using System;

namespace jokenpo
{
	class App
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Jokenpo!");
			Jokenpo jogo = new Jokenpo();

			Jogador j1 = jogo.GetJogador1();
			Jogador j2 = jogo.GetJogador2();

			j1.EscolherTesoura();
			j2.EscolherPedra();

			Jogador ganhador = jogo.QuemGanhou();
			String nomeDoGanhador = ganhador.GetNome();
				
			Console.WriteLine("o ganhador é:");
			Console.WriteLine(nomeDoGanhador);
		}
	}
}
