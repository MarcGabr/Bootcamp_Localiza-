using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciei");
            double valor, auxNotas;
            int auxDinheiro, i;
            int[] reais = new int[6] {100,50,20,10,5,2};
            double[] moedas = new double[6] {1,0.50,0.25,0.10,0.05,0.01};

            valor = Convert.ToDouble(Console.ReadLine());
            i = 0;
            auxNotas = valor/100;
            
            Console.WriteLine("NOTAS:");
            do{
                auxDinheiro = (int)Math.Floor((auxNotas / reais[i]));
                if(auxDinheiro != 0){
                    
                    auxNotas = Math.Round(auxNotas - (reais[i] * auxDinheiro), 2);
                }
                Console.WriteLine("{0} nota(s) de R$ {1}.00", auxDinheiro, reais[i]);
                i++;

            }while(i < 6);
            i = 0;   
            Console.WriteLine("MOEDAS:");
            do{
                auxDinheiro = (int)Math.Floor((auxNotas / moedas[i]));
                if(auxDinheiro != 0){
                    auxNotas = Math.Round(auxNotas - (moedas[i] * auxDinheiro), 2);
                }
                switch (i){
                    case 0: 
                        Console.WriteLine("{0} moeda(s) de R$ 1.00", auxDinheiro); break;
                    case 1: 
                        Console.WriteLine("{0} moeda(s) de R$ 0.50", auxDinheiro); break;
                    case 2: 
                        Console.WriteLine("{0} moeda(s) de R$ 0.25", auxDinheiro); break;
                    case 3: 
                        Console.WriteLine("{0} moeda(s) de R$ 0.10", auxDinheiro); break;
                    case 4: 
                        Console.WriteLine("{0} moeda(s) de R$ 0.05", auxDinheiro); break;
                    case 5: 
                        Console.WriteLine("{0} moeda(s) de R$ 0.01", auxDinheiro); break;
                }
                i++;

            }while(i < 6);       
        
        }
    }
}
