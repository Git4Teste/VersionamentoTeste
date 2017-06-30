	using System;

	class Menu
    {
        static void Main()
        {
            int X = 1000;

			while(X!=0){
				Console.WriteLine("1-RedPill\n2-Arvos\n3-Sqvare\n");
				X =  Convert.ToInt32(Console.ReadLine());
				if(X==1){
					Console.WriteLine("Você está no dominio da RedPill\n");
				}
				
				if(X==2){
					Console.WriteLine("Você está no dominio da Arvos\n");					
				}
				if(X==3){
					Console.WriteLine("Você está no dominio da Sqvare\n");					
				}		
			}	
        }      
    }
