using System;
using System.Threading;
using System.Threading.Tasks;

namespace MicroOndas.Core
{
    public class Microondas
    {
        private int _tempo;
        private int _potencia;
        private CancellationTokenSource _cts;

        public void DefinirTempo(int tempo)
        {
            _tempo = tempo;
        }

        public void DefinirPotencia(int potencia)
        {
            _potencia = potencia;
        }

        public void IniciarAquecimento(Action<string> atualizarVisor)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            Task.Run(() =>
            {
                int segundosRestantes = _tempo;

                while (segundosRestantes > 0 && !token.IsCancellationRequested)
                {
                    string tempoFormatado = TimeSpan.FromSeconds(segundosRestantes).ToString(@"mm\:ss");

                    atualizarVisor?.Invoke(tempoFormatado);
                    Thread.Sleep(1000);
                    segundosRestantes--;
                }

                if (!token.IsCancellationRequested)
                {
                    atualizarVisor?.Invoke("Aquecido!");
                    Console.Beep(); 
                }
            }, token);
        }

        public void CancelarAquecimento()
        {
            _cts?.Cancel();
        }

        public void SelecionarProgramaRapido(string nomePrograma, Action<string> atualizarVisor)
        {
            switch (nomePrograma)
            {
                case "Pipoca":
                    DefinirTempo(30);
                    DefinirPotencia(8);
                    break;
                case "Refeição":
                    DefinirTempo(60);
                    DefinirPotencia(10);
                    break;
                default:
                    atualizarVisor?.Invoke("Programa não encontrado");
                    return;
            }

            IniciarAquecimento(atualizarVisor);
        }
    }
}
