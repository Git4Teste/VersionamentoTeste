	using System;

	class Menu
    {
        static void Main()
        {
            int X = 9999;

			while(X!=0){
				Console.WriteLine("1-Area do quadrado\n2-Tipo do triangulo\n3-Sqvare\n");
				X =  Convert.ToInt32(Console.ReadLine());
				
				if(X==1){
					Console.WriteLine("Insira o lado do quadrado\n");
					X = Convert.ToInt32(Console.ReadLine());
					
					int area = X*X;
					
					Console.WriteLine("A área do quadrado é:{0}", +area);
				}
				
				if(X==2){
					Console.WriteLine("Digite o lado A do triangulo: ");
					//int A = 0;
					int A = Convert.ToInt32(Console.ReadLine());

					
					Console.WriteLine("Digite o lado B do triangulo: ");
					int B = Convert.ToInt32(Console.ReadLine());
					
					Console.WriteLine("Digite o valor da base do triangulo: ");
					int C = Convert.ToInt32(Console.ReadLine());
					
					
					if(A==B & B==C & C==A){
						Console.WriteLine("As medidas são de um triangulo Equilátero\n");
					}
					
					if(A!=B & B!=C & C!=A){
						Console.WriteLine("As medidas são de um triangulo Escaleno\n");
					}
					
					if(A==B & A!=C | B==C & B!= A| C==A & C!=A){						
						Console.WriteLine("As medidas são de um triangulo Isósceles\n");
					}
					
					
						

					
					
				}
				if(X==3){
					Console.WriteLine("Você está no dominio da Sqvare\n");					
				}		
			}	
        }      
    }
