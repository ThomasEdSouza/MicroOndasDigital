using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroOndas.Core
{
    public class Microondas
    {
        private int _tempoSegundos;
        private int _potencia;
        private char _caractere;
        private CancellationTokenSource _cts;
        private bool _pausado;
        private bool _emAquecimento;

        public event Action<string> OnAtualizarAquecimento;
        public event Action<string> OnFinalizarAquecimento;

        public bool EmAquecimento => _emAquecimento;
        public bool Pausado => _pausado;

        public Microondas()
        {
            Resetar();
        }

        public void Iniciar(int? tempo = null, int? potencia = null, char caractere = '.')
        {

            if (!tempo.HasValue && !potencia.HasValue)
            {
                tempo = 30;
                potencia = 10;
            }

            if (!tempo.HasValue)
                throw new ArgumentException("O tempo precisa ser informado.");

            if (tempo < 1 || tempo > 120)
                throw new ArgumentException("O tempo tem que ser entre 1 segundo e 2 Minutos.");

            if (potencia.HasValue && (potencia < 1 || potencia > 10))
                throw new ArgumentException("a potencia tem que estar entre 1 e 10");


            _tempoSegundos = tempo.Value;
            _potencia = potencia ?? 10;
            _caractere = caractere;
            _pausado = false;

            if (_emAquecimento && !_pausado)
            {
                _tempoSegundos = Math.Min(_tempoSegundos + 30, 120);
                return;
            }

            _emAquecimento = true;
            _cts = new CancellationTokenSource();

            Task.Run(() => Aquecer(_cts.Token));
        }
            private async Task Aquecer(CancellationToken token)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < _tempoSegundos; i++)
            {
                if (token.IsCancellationRequested || _pausado)
                    return;

                for (int j = 0; j < _potencia; j++)
                {
                    sb.Append(_caractere);
                }

                OnAtualizarAquecimento?.Invoke(sb.ToString());

                await Task.Delay(1000, token);
            }

            _emAquecimento = false;
            OnFinalizarAquecimento?.Invoke(sb.ToString() + "\nAquecimento concluído.");
        }

        public void PausarOuCancelar()
        {
            if (_emAquecimento && !_pausado)
            {
                _pausado = true;
                _cts.Cancel();
            }
            else if (_pausado)
            {
                Resetar();
            }
            else
            {
                Resetar();
            }
        }

        public void Retomar()
        {
            if (_pausado)
            {
                _pausado = false;
                _cts = new CancellationTokenSource();
                Task.Run(() => Aquecer(_cts.Token));
            }
        }

        public void Resetar()
        {
            _tempoSegundos = 0;
            _potencia = 10;
            _caractere = '.';
            _emAquecimento = false;
            _pausado = false;

            _cts?.Cancel();

        }
  }
}
