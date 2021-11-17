using System;
class Program
{
  static void Mostrar(string[,] mostrar)
  {   
      Console.WriteLine("   --------------TABULEIRO--------------");
      Console.WriteLine();
      Console.Write("           {0}    |   {1}    |   {2}   \n", mostrar[0,0],mostrar[0,1],mostrar[0,2]);
      Console.Write("        ________|________|_______\n");
      Console.Write("           {0}    |   {1}    |   {2}   \n", mostrar[1,0],mostrar[1,1],mostrar[1,2]);
      Console.Write("        ________|________|_______\n");
      Console.Write("           {0}    |   {1}    |   {2}   \n", mostrar[2,0],mostrar[2,1],mostrar[2,2]);
      Console.WriteLine(); 
  }
  static void jogada_da_pessoa(string jogada, string[,] tabuleiro)
  {
	if(jogada == "1")
	{
		if(tabuleiro[0,0] != "X" && tabuleiro[0,0] != "#")
			tabuleiro[0,0] = "X";
	}
	else if(jogada == "2")
	{
		if(tabuleiro[0,1] != "X" && tabuleiro[0,1] != "#")
			tabuleiro[0,1] = "X";
	}
	else if(jogada == "3")
	{
		if(tabuleiro[0,2] != "X" && tabuleiro[0,2] != "#")
			tabuleiro[0,2] = "X";
	}
	else if(jogada == "4")
	{
		if(tabuleiro[1,0] != "X" && tabuleiro[1,0] != "#")
			tabuleiro[1,0] = "X";
	}
	else if(jogada == "5")
	{
		if(tabuleiro[1,1] != "X" && tabuleiro[1,1] != "#")
			tabuleiro[1,1] = "X";
	}
	else if(jogada == "6")
	{
		if(tabuleiro[1,2] != "X" && tabuleiro[1,2] != "#")
			tabuleiro[1,2] = "X";
	}
	else if(jogada == "7")
	{
		if(tabuleiro[2,0] != "X" && tabuleiro[2,0] != "#")
			tabuleiro[2,0] = "X";
	}
	else if(jogada == "8")
	{
		if(tabuleiro[2,1] != "X" && tabuleiro[2,1] != "#")
			tabuleiro[2,1] = "X";
	}
	else if(jogada == "9")
	{
		if(tabuleiro[2,2] != "X" && tabuleiro[2,2] != "#")
			tabuleiro[2,2] = "X";
	}
  }
  static void jogada_da_maquina(string jogada, string[,] tabuleiro, int controle)
  {
	if(tabuleiro[0,0] != "X" &&  tabuleiro[0,0] != "#")
	{
		tabuleiro[0,0] = "#";
	}
	else if(tabuleiro[0,1] != "X" &&  tabuleiro[0,1] != "#")
	{
		tabuleiro[0,1] = "#";
	}
	else if(tabuleiro[0,2] != "X" &&  tabuleiro[0,2] != "#")
	{
		tabuleiro[0,2] = "#";
	}
	else if(tabuleiro[1,0] != "X" &&  tabuleiro[1,0] != "#")
	{
		tabuleiro[1,0] = "#";
	}
	else if(tabuleiro[1,1] != "X" &&  tabuleiro[1,1] != "#")
	{
		tabuleiro[1,1] = "#";
	}
	else if(tabuleiro[1,2] != "X" &&  tabuleiro[1,2] != "#")
	{
		tabuleiro[1,2] = "#";
	}
	else if(tabuleiro[2,0] != "X" &&  tabuleiro[2,0] != "#")
	{
		tabuleiro[2,0] = "#";
	}
	else if(tabuleiro[2,1] != "X" &&  tabuleiro[2,1] != "#")
	{
		tabuleiro[2,1] = "#";
	}
	else if(tabuleiro[2,2] != "X" &&  tabuleiro[2,2] != "#")
	{
		tabuleiro[2,2] = "#";
	}
  }
  static int Defesa(string[,] tabuleiro)
  {
	int valor=0;
	if(tabuleiro[0,0] == "X" && tabuleiro [0,1] == "X" && tabuleiro [0,2] == "1" || tabuleiro[0,1] == "X" && tabuleiro [0,2] == "X" && tabuleiro [0,0] == "3"|| tabuleiro[0,0] == "X" && tabuleiro [0,2] == "X" && tabuleiro [0,1] == "2")
	{
		if(tabuleiro[0,0] == "X" && tabuleiro [0,1] == "X")
		{
			tabuleiro[0,2] = "#";
		}
		else if(tabuleiro[0,1] == "X" && tabuleiro [0,2] == "X")
		{
				tabuleiro[0,0] = "#";
		}
		else if(tabuleiro[0,0] == "X" && tabuleiro [0,2] == "X")
		{
			tabuleiro[0,1] = "#";
		}
	}  
	else if(tabuleiro[1,0] == "X" && tabuleiro [1,1] == "X" && tabuleiro [1,2] == "6"|| tabuleiro[1,1] == "X" && tabuleiro [1,2] == "X" && tabuleiro [1,0] == "4"|| tabuleiro[1,0] == "X" && tabuleiro [1,2] == "X" && tabuleiro [1,1] == "5")
	{
		if(tabuleiro[1,0] == "X" && tabuleiro [1,1] == "X")
		{
			tabuleiro[1,2] = "#";
		}
		else if(tabuleiro[1,1] == "X" && tabuleiro [1,2] == "X")
		{
			tabuleiro[1,0] = "#";
		}
		else if(tabuleiro[1,0] == "X" && tabuleiro [1,2] == "X")
		{
			tabuleiro[1,1] = "#";
		}	
	}
	else if(tabuleiro[2,0] == "X" && tabuleiro [2,1] == "X" && tabuleiro [2,2] == "9"|| tabuleiro[2,1] == "X" && tabuleiro [2,2] == "X" && tabuleiro [2,0] == "7"|| tabuleiro[2,0] == "X" && tabuleiro [2,2] == "X" && tabuleiro [2,1] == "8")
	{
		if(tabuleiro[2,0] == "X" && tabuleiro [2,1] == "X")
		{
			tabuleiro[2,2] = "#";
		}
		else if(tabuleiro[2,1] == "X" && tabuleiro [2,2] == "X")
		{	
			tabuleiro[2,0] = "#";
		}
		else if(tabuleiro[2,0] == "X" && tabuleiro [2,2] == "X")
		{
			tabuleiro[2,1] = "#";
		}
	}   
	else if(tabuleiro[0,0] == "X" && tabuleiro [1,0] == "X" && tabuleiro [2,0] == "7" || tabuleiro[1,0] == "X" && tabuleiro [2,0] == "X" && tabuleiro [0,0] == "1" || tabuleiro[0,0] == "X" && tabuleiro [2,0] == "X" && tabuleiro [1,0] == "4")
	{
		if(tabuleiro[0,0] == "X" && tabuleiro [1,0] == "X")
		{
			tabuleiro[2,0] = "#";
		}
		else if(tabuleiro[1,0] == "X" && tabuleiro [2,0] == "X")
		{
			tabuleiro[0,0] = "#";
		}
		else if(tabuleiro[0,0] == "X" && tabuleiro [2,0] == "X")
		{
			tabuleiro[1,0] = "#";
		}
	}
	else if(tabuleiro[0,1] == "X" && tabuleiro [1,1] == "X" && tabuleiro [2,1] == "8" || tabuleiro[1,1] == "X" && tabuleiro [2,1] == "X" && tabuleiro [0,1] == "2"|| tabuleiro[0,1] == "X" && tabuleiro [2,1] == "X" && tabuleiro [1,1] == "5")
	{
		if(tabuleiro[0,1] == "X" && tabuleiro [1,1] == "X")
		{
			tabuleiro[2,1] = "#";
		}
		else if(tabuleiro[1,1] == "X" && tabuleiro [2,1] == "X")
		{
			tabuleiro[0,1] = "#";
		}
		else if(tabuleiro[0,1] == "X" && tabuleiro [2,1] == "X")
		{
			tabuleiro[1,1] = "#";
		}
	}
	else if(tabuleiro[0,2] == "X" && tabuleiro [1,2] == "X" && tabuleiro [2,2] == "9"|| tabuleiro[1,2] == "X" && tabuleiro [2,2] == "X" && tabuleiro [0,2] == "3"|| tabuleiro[0,2] == "X" && tabuleiro [2,2] == "X" && tabuleiro [1,2] == "6")
	{
		if(tabuleiro[0,2] == "X" && tabuleiro [1,2] == "X")
		{
			tabuleiro[2,2] = "#";
		}
		else if(tabuleiro[1,2] == "X" && tabuleiro [2,2] == "X")
		{
			tabuleiro[0,2] = "#";
		}
		else if(tabuleiro[0,2] == "X" && tabuleiro [2,2] == "X")
		{
			tabuleiro[1,2] = "#";
			
		}
	}    
	else if(tabuleiro[0,0] == "X" && tabuleiro [1,1] == "X" && tabuleiro [2,2] == "9"|| tabuleiro[1,1] == "X" && tabuleiro [2,2] == "X" && tabuleiro [0,0] == "1"|| tabuleiro[0,0] == "X" && tabuleiro [2,2] == "X" && tabuleiro [1,1] == "5")
	{
		if(tabuleiro[0,0] == "X" && tabuleiro [1,1] == "X")
		{
			tabuleiro[2,2] = "#";
			
		}
		else if(tabuleiro[1,1] == "X" && tabuleiro [2,2] == "X")
		{
			tabuleiro[0,0] = "#";
			
		}
		else if(tabuleiro[0,0] == "X" && tabuleiro [2,2] == "X")
		{
			tabuleiro[1,1] = "#";
			
		}
	}
	else if(tabuleiro[0,2] == "X" && tabuleiro [1,1] == "X" && tabuleiro [2,0] == "7"|| tabuleiro[1,1] == "X" && tabuleiro [2,0] == "X" && tabuleiro [0,2] == "3"|| tabuleiro[0,2] == "X" && tabuleiro [2,0] == "X" && tabuleiro [1,1] == "5")
	{
		if(tabuleiro[0,2] == "X" && tabuleiro [1,1] == "X")
		{
			tabuleiro[2,0] = "#";
			
		}
		else if(tabuleiro[1,1] == "X" && tabuleiro [2,0] == "X")
		{
			tabuleiro[0,2] = "#";
			
		}
		else if(tabuleiro[0,2] == "X" && tabuleiro [2,0] == "X")
		{
			tabuleiro[1,1] = "#";
			
		}
	}
	else
	{
		return(1);

	}
	return(valor);
  }
  static int Ataque(string[,] tabuleiro)
  {
	int valor=0;
	if(tabuleiro[0,0] == "#" && tabuleiro [0,1] == "#" && tabuleiro [0,2] == "3" || tabuleiro[0,1] == "#" && tabuleiro [0,2] == "#" && tabuleiro [0,0] == "1" || tabuleiro[0,0] == "#" && tabuleiro [0,2] == "#" && tabuleiro [0,1] == "2")
	{
		if(tabuleiro[0,0] == "#" && tabuleiro [0,1] == "#")
		{
			tabuleiro[0,2] = "#";
			
		}
		else if(tabuleiro[0,1] == "#" && tabuleiro [0,2] == "#")
		{
			tabuleiro[0,0] = "#";
			
		}
		else if(tabuleiro[0,0] == "#" && tabuleiro [0,2] == "#")
		{
			tabuleiro[0,1] = "#";
			
		}
	}
	else if(tabuleiro[1,0] == "#" && tabuleiro [1,1] == "#" && tabuleiro [1,2] == "6"|| tabuleiro[1,1] == "#" && tabuleiro [1,2] == "#" && tabuleiro [1,0] == "4"|| tabuleiro[1,0] == "#" && tabuleiro [1,2] == "#" && tabuleiro [1,1] == "5")
	
	{
		if(tabuleiro[1,0] == "#" && tabuleiro [1,1] == "#")
		{
			tabuleiro[1,2] = "#";
			
		}
		else if(tabuleiro[1,1] == "#" && tabuleiro [1,2] == "#")
		{
			tabuleiro[1,0] = "#";
			
		}
		else if(tabuleiro[1,0] == "#" && tabuleiro [1,2] == "#")
		{
			tabuleiro[1,1] = "#";
			
		}
	} 
	else if(tabuleiro[2,0] == "#" && tabuleiro [2,1] == "#" && tabuleiro [2,2] == "9"|| tabuleiro[2,1] == "#" && tabuleiro [2,2] == "#" && tabuleiro [2,0] == "7"|| tabuleiro[2,0] == "#" && tabuleiro [2,2] == "#" && tabuleiro [2,1] == "8")
	{
		if(tabuleiro[2,0] == "#" && tabuleiro [2,1] == "#")
		{
			tabuleiro[2,2] = "#";
			
		}
		else if(tabuleiro[2,1] == "#" && tabuleiro [2,2] == "#")
		{
			tabuleiro[2,0] = "#";
			
		}
		else if(tabuleiro[2,0] == "#" && tabuleiro [2,2] == "#")
		{
			tabuleiro[2,1] = "#";
			
		}
	}    
	else if(tabuleiro[0,0] == "#" && tabuleiro [1,0] == "#" && tabuleiro [2,0] == "7" || tabuleiro[1,0] == "#" && tabuleiro [2,0] == "#" && tabuleiro [0,0] == "1" || tabuleiro[0,0] == "#" && tabuleiro [2,0] == "#" && tabuleiro [1,0] == "4")
	{
		if(tabuleiro[0,0] == "#" && tabuleiro [1,0] == "#")
		{
			tabuleiro[2,0] = "#";
			
		}
		else if(tabuleiro[1,0] == "#" && tabuleiro [2,0] == "#")
		{
			tabuleiro[0,0] = "#";
			
		}
		else if(tabuleiro[0,0] == "#" && tabuleiro [2,0] == "#")
		{
			tabuleiro[1,0] = "#";
			
		}
	} 
	else if(tabuleiro[0,1] == "#" && tabuleiro [1,1] == "#" && tabuleiro [2,1] == "8" || tabuleiro[1,1] == "#" && tabuleiro [2,1] == "#" && tabuleiro [0,1] == "2"|| tabuleiro[0,1] == "#" && tabuleiro [2,1] == "#" && tabuleiro [1,1] == "5")
	{
		if(tabuleiro[0,1] == "#" && tabuleiro [1,1] == "#")
		{
			tabuleiro[2,1] = "#";
			
		}
		else if(tabuleiro[1,1] == "#" && tabuleiro [2,1] == "#")
		{
			tabuleiro[0,1] = "#";
			
		}
		else if(tabuleiro[0,1] == "#" && tabuleiro [2,1] == "#")
		{
			tabuleiro[1,1] = "#";
			
		}
	}
	else if(tabuleiro[0,2] == "#" && tabuleiro [1,2] == "#" && tabuleiro [2,2] == "9"|| tabuleiro[1,2] == "#" && tabuleiro [2,2] == "#" && tabuleiro [0,2] == "3"|| tabuleiro[0,2] == "#" && tabuleiro [2,2] == "#" && tabuleiro [1,2] == "6")
	{
		if(tabuleiro[0,2] == "#" && tabuleiro [1,2] == "#")
		{
			tabuleiro[2,2] = "#";
			
		}
		else if(tabuleiro[1,2] == "#" && tabuleiro [2,2] == "#")
		{
			tabuleiro[0,2] = "#";
			
		}
		else if(tabuleiro[0,2] == "#" && tabuleiro [2,2] == "#")
		{
			tabuleiro[1,2] = "#";
			
		}
	}     
	else if(tabuleiro[0,0] == "#" && tabuleiro [1,1] == "#" && tabuleiro [2,2] == "9"|| tabuleiro[1,1] == "#" && tabuleiro [2,2] == "#" && tabuleiro [0,0] == "1"|| tabuleiro[0,0] == "#" && tabuleiro [2,2] == "#" && tabuleiro [1,1] == "5")
	{
		if(tabuleiro[0,0] == "#" && tabuleiro [1,1] == "#")
		{
			tabuleiro[2,2] = "#";
			
		}
		else if(tabuleiro[1,1] == "#" && tabuleiro [2,2] == "#")
		{
			tabuleiro[0,0] = "#";
			
		}
		else if(tabuleiro[0,0] == "#" && tabuleiro [2,2] == "#")
		{
			tabuleiro[1,1] = "#";
			
		}
	}
	else if(tabuleiro[0,2] == "#" && tabuleiro [1,1] == "#" && tabuleiro [2,0] == "7"|| tabuleiro[1,1] == "#" && tabuleiro [2,0] == "#" && tabuleiro [0,2] == "3"|| tabuleiro[0,2] == "#" && tabuleiro [2,0] == "#" && tabuleiro [1,1] == "5")
	{
		if(tabuleiro[0,2] == "#" && tabuleiro [1,1] == "#")
		{
			tabuleiro[2,0] = "#";
			
		}
		else if(tabuleiro[1,1] == "#" && tabuleiro [2,0] == "#")
		{
			tabuleiro[0,2] = "#";
			
		}
		else if(tabuleiro[0,2] == "#" && tabuleiro [2,0] == "#")
		{
			tabuleiro[1,1] = "#";
			
		}
	}
	else{
		return(2);
	}
	return(valor);
  }
  static int Vitoria(string[,] tabuleiro)
  {
	    if(tabuleiro[0,0] == tabuleiro [0,1] && tabuleiro[0,1] == tabuleiro [0,2])
		{
			return 1;
		}
		else if(tabuleiro[1,0] == tabuleiro [1,1] && tabuleiro[1,1] == tabuleiro [1,2])
		{
			return 1;
		}
		else if(tabuleiro[2,0] == tabuleiro [2,1] && tabuleiro[2,1] == tabuleiro [2,2])
		{
			return 1;
		}   
		else if(tabuleiro[0,0] == tabuleiro [1,0] && tabuleiro[1,0] == tabuleiro [2,0])
		{
			return 1;
		}
		else if(tabuleiro[0,1] == tabuleiro [1,1] && tabuleiro[1,1] == tabuleiro [2,1])
		{
			return 1;
		}
		else if(tabuleiro[0,2] == tabuleiro [1,2] && tabuleiro[1,2] == tabuleiro [2,2])
		{
			return 1;
		}
		else if(tabuleiro[0,0] == tabuleiro [1,1] && tabuleiro[1,1] == tabuleiro [2,2])
		{
			return 1;
		}
		else if(tabuleiro[0,2] == tabuleiro [1,1] && tabuleiro[1,1] == tabuleiro [2,0])
		{
			return 1;
		}
		else if (tabuleiro[0,0] != "1" && tabuleiro[0,1] != "2" && tabuleiro[0,2] != "3" && tabuleiro[1,0] != "4" && tabuleiro[1,1] != "5" && tabuleiro[1,2] != "6" && tabuleiro[2,0] != "7" && tabuleiro[2,1] != "8" && tabuleiro[2,2] != "9")
		{
			return -1;
		}
		else
		{
			return 0;
		}
  }
  static void Main()
  { 
	int turno = 0;
    string[,] tabuleiro = new string [3,3] {{"1","2","3"},{"4","5","6"},{"7","8","9"}};
    Console.ForegroundColor=ConsoleColor.Red;
    Console.Clear();
    Console.WriteLine("    ------------------------------------");
    Console.WriteLine("    |  BEM VINDO AO SEU JOGO DA VELHA!  |");
    Console.WriteLine("    ------------------------------------");
    Console.WriteLine();
    Console.Write("  - Você sempre será o" );
    Console.ForegroundColor=ConsoleColor.Blue;
    Console.Write(" (X)");
    Console.ForegroundColor=ConsoleColor.Red;
    Console.WriteLine("!");
    Console.WriteLine();
    Console.WriteLine("  - E você sempre começara fazendo a jogada!  ");
    string resp = " ";
	int controle = 0;
	int ganhou = 0;
    while(resp.ToUpper() != "NÃO")
    {
	  while(ganhou != 1 && ganhou != -1)
	  {
		Console.WriteLine();
		Mostrar(tabuleiro);
		Console.WriteLine("  - Primeiro scolha o numero em que deseja jogar ");
		Console.Write("  - (A maquina ira jogar em seguida):  ");
		string jogada = Console.ReadLine();
		jogada_da_pessoa(jogada, tabuleiro);
		Console.Clear();
		if(controle == 0)
		{
			controle = Defesa(tabuleiro);
		}
		if(controle == 1)
		{
			controle = Ataque(tabuleiro);
		}
		if(controle == 2)
		{
			jogada_da_maquina(jogada, tabuleiro, controle); 
		}
		controle = 0;
	  	ganhou = Vitoria(tabuleiro);
		turno++;
	  }
	  ganhou = 0;
	  if((tabuleiro[0,0] == "X" && tabuleiro [0,1] == "X" && tabuleiro [0,2] == "X") || (tabuleiro[1,0] == "X" && tabuleiro [1,1] == "X" && tabuleiro [1,2] == "X") || (tabuleiro[2,0] == "X" && tabuleiro [2,1] == "X" && tabuleiro [2,2] == "X") || (tabuleiro[0,0] == "X" && tabuleiro [1,0] == "X" && tabuleiro [2,0] == "X") || (tabuleiro[0,1] == "X" && tabuleiro [1,1] == "X" && tabuleiro [2,1] == "X") || (tabuleiro[0,2] == "X" && tabuleiro [1,2] == "X" && tabuleiro [2,2] == "X") || (tabuleiro[0,0] == "X" && tabuleiro [1,1] == "X" && tabuleiro [2,2] == "X") || (tabuleiro[0,2] == "X" && tabuleiro [1,1] == "X" && tabuleiro [2,0] == "X"))
	  {
		  Console.WriteLine(" - PARABÉNS VOCÊ JOGA MUITO!!");
	  }
	  else if((tabuleiro[0,0] == "#" && tabuleiro [0,1] == "#" && tabuleiro [0,2] == "#") || (tabuleiro[1,0] == "#" && tabuleiro [1,1] == "#" && tabuleiro [1,2] == "#") || (tabuleiro[2,0] == "#" && tabuleiro [2,1] == "#" && tabuleiro [2,2] == "#") || (tabuleiro[0,0] == "#" && tabuleiro [1,0] == "#" && tabuleiro [2,0] == "#") || (tabuleiro[0,1] == "#" && tabuleiro [1,1] == "#" && tabuleiro [2,1] == "#") || (tabuleiro[0,2] == "#" && tabuleiro [1,2] == "#" && tabuleiro [2,2] == "#") || (tabuleiro[0,0] == "#" && tabuleiro [1,1] == "#" && tabuleiro [2,2] == "#") || (tabuleiro[0,2] == "#" && tabuleiro [1,1] == "#" && tabuleiro [2,0] == "#"))
	  {
		  Console.WriteLine(" - JOGOU NADA AMIGO");
	  }
	  else
	  {
		  Console.WriteLine(" - OLHA SÓ! O JOGO EMPATOU!");
	  }
	  Console.WriteLine();
	  Mostrar(tabuleiro);
	  Console.Write(" - Quer jogar de novo? Sim ou Não? ");
	  resp = Console.ReadLine();
	  tabuleiro = new string [3,3] {{"1","2","3"},{"4","5","6"},{"7","8","9"}};
	  Console.Clear();
    }
	Console.WriteLine(" - Programa Finalizado!");
  }
}
