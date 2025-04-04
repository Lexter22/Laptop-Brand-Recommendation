using DataBusiness;
namespace Laptop_Brand_Recommendation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] processes = { "0 - Add Brand", "1 - Display Brands", "2 - Recommend Brand", "3 - Remove Brand", "4 - Exit" };
            Boolean loop = true;

            // ui logic
            while (loop)
            {
                Formatter();
                DisplayMenu(processes);
                int ProcessChoice = Convert.ToInt16(Console.ReadLine());

                switch (ProcessChoice)
                {
                    // dito me nag start gumamit ng enums, from 1 starting point ginawa ko yung default which is yung by 0
                    case (int)Actions.AddBrand:
                        Console.Write("Enter brand: ");
                        string brand = GetUserInput();
                        Console.WriteLine("What type? ");
                        Console.WriteLine("1 - Productivity 2 - Gaming 3 - Basic Browsing");
                        int use = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(LaptopProcess.AddBrand(brand,use));
                        break;
                    case (int)Actions.DisplayBrands:
                        DisplayBrands(DataBusiness.LaptopProcess.LaptopBrands);
                        break;
                    case (int)Actions.RecommendBrand:
                        Console.WriteLine("For what use do you want your computer?\n1 - Productivity 2 - Gaming 3 - Basic Browsing");
                        int type = Convert.ToInt16(Console.ReadLine());
                        Formatter();
                        
                        if (DataBusiness.LaptopProcess.RecommendBrand(type).Count > 0) // this returns if may marerecommend
                        {
                            Console.WriteLine($"Recommended brands: {String.Join(",",LaptopProcess.RecommendedBrands)}");
                        }
                        else
                        {
                            Console.WriteLine("No recommended brands");
                        }
                            break;
                    case (int)Actions.RemoveBrand:
                        Console.Write("Enter brand: ");
                        string Remove = GetUserInput();
                        Console.WriteLine(DataBusiness.LaptopProcess.RemoveBrand(Remove.ToUpper()));
                        break;
                    case (int)Actions.Exit:
                        Console.WriteLine("Thank you for using!");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
        // Menu
        static void DisplayMenu(string[] processes) // ui logic
        {
            Console.WriteLine("Welcome to Laptop Brand Recommendations!\n" +
                               "Choose process");
            foreach (string process in processes)
            {
                Console.WriteLine(process);
            }
        }// display all brands
        public static void DisplayBrands(List<string> LaptopBrands) // ui logic
        {
            Formatter();
            Console.WriteLine("Brands");
            Formatter();
            if(LaptopProcess.LaptopBrands.Count == 0)
            {
                Console.WriteLine("No brands available");
                return;
            }
            else
            {
                foreach (string brand in LaptopBrands)
                {
                    Console.Write($"{brand} | ");
                }
                Console.WriteLine();
            }
        // formatter method para sa lines
        }
        static void Formatter()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }
        public static string GetUserInput()
        {
            return Console.ReadLine().ToUpper();
        }
    }
}
