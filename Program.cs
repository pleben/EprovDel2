using System;
using System.Collections.Generic;

namespace E_Prov_Del2
{
    class Program
    {

        
        static void Main(string[] args)
        {





            List<Car> Bilar = new List<Car>();
           











            
            string answer;
            bool loopa = false;
            int resultat;
            int antalSomSkaByggas;


            while (loopa == false)
            {
                Console.WriteLine("Hur många bilar ska skapas?");
                answer = Console.ReadLine();
                
                bool rättSvar = int.TryParse(answer, out resultat);
                if (resultat == 0)
                {
                    rättSvar = false;
                }
                if (rättSvar == false)
                {
                    Console.WriteLine("Please enter a number over 0!");

                }
                if (rättSvar == true)
                {

                    antalSomSkaByggas = resultat;
                    loopa = true;
                }

            }

            
            ContrabandCar OndBil()
            {
                return new ContrabandCar(1, 1, false);
            }
            ContrabandCar OndBil1()
            {
                return new ContrabandCar(2, 2, false);
            }
            ContrabandCar OndBil2()
            {
                return new ContrabandCar(3, 3, false);
            }
            ContrabandCar OndBil3()
            {
                return new ContrabandCar(4, 4, false);
            }
            ClearCar BraBil()
            {
                return new ClearCar(1, 0, false);
            }
            ClearCar BraBil1()
            {
                return new ClearCar(2, 0, false);
            }
            ClearCar BraBil2()
            {
                return new ClearCar(3, 0, false);
            }







            Console.WriteLine("*Bilar byggs*");


            Console.ReadLine();





            



           

        }
    }
}
