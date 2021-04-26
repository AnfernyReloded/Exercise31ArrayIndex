using System;


namespace Ex31_1._1
{
    using System;

    
  
    
    class Program
    {
        
        static double[] arr1 = { 2, 8, 0, 24, 51 };
        
        public static double value_Finder(int er)
        {
            return arr1[er];
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter an index of the array: ");
                string userinput = Console.ReadLine();


                int passnum;

                if (!int.TryParse(userinput, out passnum) || passnum < 0 || passnum > 4) 
                {
                    Console.WriteLine("That is NOT a valid index ");
                    continue;
                }

                double output = value_Finder(passnum);
                Console.WriteLine("The value at index " + passnum + " is " + output);

                Console.WriteLine("Would you like to continue Y or N?");
                string user_choice = Console.ReadLine().ToLower();

                if (user_choice == "n")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}


