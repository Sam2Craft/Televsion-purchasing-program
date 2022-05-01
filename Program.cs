using System;
namespace TVLABEXTRA
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your TV Shopping Program!");
            CreateSamsungTV();
            CreatePortableTV();

        }


        static void CreateSamsungTV(){
            //television constructor
            Television samsungTV = new Television("Samsung", 32);

            //using the ToString method to write out the details of the TV
            Console.WriteLine("Samsung TV: " + samsungTV.ToString()); 

            //buy the TV
            Console.WriteLine("Let's buy the TV.");
            samsungTV.BuyTV();

            //ask the user how many payments they'd like to make when purchasing the TV
            Console.WriteLine("How many payments would you like to make?");
            int userInput = int.Parse(Console.ReadLine());
            //set number of payments with the User's input
            samsungTV.SetNumPayments(userInput);

           //using the ToString method to write out the details of the TV
            Console.WriteLine(samsungTV.ToString());

            //return the TV
            Console.WriteLine("Turns out you didn't like the TV that much. Let's return it.");
            samsungTV.ReturnTV();
            
            //using the ToString method to write out the details of the TV
            Console.WriteLine(samsungTV.ToString());
        }

         static public void CreatePortableTV(){
         Television Portable = new Television("Sharp", 19);
            //using the ToString method to write out the details of the TV
            Console.WriteLine("Sharp TV: " + Portable.ToString()); 
            Portable.DecreasePrice();
            System.Console.WriteLine($"The TV went on sale for {Portable.price}! This is a steal! Let's buy it!");
            //buy the TV
            Portable.BuyTV();
            //ask the user how many payments they'd like to make when purchasing the TV
            Console.WriteLine("How many payments would you like to make?");
            int userInput = int.Parse(Console.ReadLine());
            //set number of payments with the User's input
            Portable.SetNumPayments(userInput);

            //using the ToString method to write out the details of the TV
            Console.WriteLine(Portable.ToString());

    
            
            
        }
    }
}
