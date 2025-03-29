using DataBusiness;
namespace Laptop_Brand_Recommendation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] processes = { "1 - Add Brand", "2 - Display Brands", "3 - Recommend Brand", "4 - Remove Brand", "5 - Exit" };
            Boolean loop = true;

            // ui logic
            while (loop)
            {
                Formatter();
                DisplayMenu(processes);
                int ProcessChoice = Convert.ToInt16(Console.ReadLine());

                switch (ProcessChoice)
                {
                    case 1:
                        Console.Write("Enter brand: ");
                        string brand = GetUserInput();
                        Console.WriteLine("What type? ");
                        Console.WriteLine("1 - Productivity 2 - Gaming 3 - Basic Browsing");
                        int use = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(LaptopProcess.AddBrand(brand,use));
                        break;
                    case 2:
                        DisplayBrands(DataBusiness.LaptopProcess.LaptopBrands);
                        break;
                    case 3:
                        Console.WriteLine("For what use do you want your computer?\n1 - Productivity 2 - Gaming 3 - Basic Browsing");
                        int type = Convert.ToInt16(Console.ReadLine());
                        Formatter();
                        
                        if (DataBusiness.LaptopProcess.RecommendBrand(type).Count > 0)
                        {
                            Console.WriteLine($"Recommended brands: {String.Join(",",LaptopProcess.RecommendedBrands)}");
                        }
                        else
                        {
                            Console.WriteLine("No recommended brands");
                        }
                            break;
                    case 4:
                        Console.Write("Enter brand: ");
                        string Remove = GetUserInput();
                        Console.WriteLine(DataBusiness.LaptopProcess.RemoveBrand(Remove.ToUpper()));
                        break;
                    case 5:
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
        }
        public static void DisplayBrands(List<string> LaptopBrands) // ui logic
        {
            Formatter();
            Console.WriteLine("Brands");
            Formatter();
            foreach (string brand in LaptopBrands)
            {
                Console.Write($"{brand} | ");
            }
            Console.WriteLine();
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
