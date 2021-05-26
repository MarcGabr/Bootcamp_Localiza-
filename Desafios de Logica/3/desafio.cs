using System; 

class minhaClasse {

    static void Main(string[] args) { 

		    int diaInicio,  horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int diaTermino, horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split();
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
			minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
			segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[4]);
    
            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
			minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);
			segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[4]);
			
            int transformaSegundosInicio = segundoMomentoInicio + minutoMomentoInicio * 60 + 
				horaMomentoInicio * 3600 + diaInicio * 86400;
            int transformaSegundosTermino = segundoMomentoTerminio + minutoMomentoTermino * 60 + 
				horaMomentoTermino * 3600 + diaTermino * 86400;
		
            int somaTotalSegundos = transformaSegundosTermino - 
				transformaSegundosInicio;   
		
			int W = somaTotalSegundos/86400;
			somaTotalSegundos = somaTotalSegundos - 86400 * W;
            int X = somaTotalSegundos/3600;
			somaTotalSegundos = somaTotalSegundos - 3600 * X;
            int Y = somaTotalSegundos/60;
			int Z = somaTotalSegundos - 60 * Y;
          

      Console.WriteLine("{0} dia(s)", W);
			Console.WriteLine("{0} hora(s)", X);
			Console.WriteLine("{0} minuto(s)", Y);
			Console.WriteLine("{0} segundo(s)", Z);


    }

}