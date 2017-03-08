using System;
namespace jokenpo
{
	public class Jogador
	{
		String nome;
		int escolha;

		public Jogador()
		{
			this.escolha = -1;
			this.nome = "";
		}

		public void SetNome(string nome)
		{
			this.nome = nome;
		}

		public String GetNome()
		{
			return "jogador "+this.nome;
		}

		public void EscolherPedra()
		{
			this.escolha = 0;
		}

		public void EscolherTesoura()
		{
			this.escolha = 2;
		}

		public int GetEscolha()
		{
			return this.escolha;
		}
	}
}