//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
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