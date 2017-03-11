using System;
namespace jokenpo
{
	public class Jokenpo
	{
		Jogador j1;
		Jogador j2;

		public Jokenpo()
		{
			this.j1 = new Jogador();
			this.j1.SetNome("A");

			this.j2 = new Jogador();
			this.j2.SetNome("B");
		}

		public Jogador GetJogador1()
		{
			return this.j1;
		}
		public Jogador GetJogador2()
		{
			return this.j2;
		}

		public Jogador QuemGanhou()
		{
			Jogador ganhador = null;
			int escolhaDoJogador1 = j1.GetEscolha();
			int escolhaDoJogador2 = j2.GetEscolha();
			if (escolhaDoJogador1 == 1 && escolhaDoJogador2 == 0)
			{
				ganhador = this.j1;
			}
			else
			{
				ganhador = this.j2;
			}
			return ganhador;
		}
	}
}
