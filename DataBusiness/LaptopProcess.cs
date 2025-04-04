using System;

namespace DataBusiness
{
    public class LaptopProcess
    {
        public static List<string> LaptopBrands = new List<string>(); // this is to store every brands
        public static List<string> Productivity = new List<string>();
        public static List<string> Gaming = new List<string>();
        public static List<string> BasicBrowsing = new List<string>();
        public static List<string> RecommendedBrands = new List<string>();
        // Business logic for recommending a brand
        public static List<string> RecommendBrand(int use)
        {
            switch (use)
            {
                case (int)ProcessActions.Productivity:
                    RecommendedBrands = Productivity;
                    break;
                case (int)ProcessActions.Gaming:
                    RecommendedBrands = Gaming;
                    break;
                case (int)ProcessActions.BasicBrowsing:
                    RecommendedBrands = BasicBrowsing;
                    break;
                default:
                    return RecommendedBrands;
            }

            return RecommendedBrands;
          
        }

        // Data logic for adding a brand

        /* In Adding and Removing a brand,other than calling the specific list
            * I included the LaptopBrands list which is the general so that
            * it gets updated too */
        public static string AddBrand(string brand,int use)
        {
            switch (use)
            {
                case (int)ProcessActions.Productivity:        
                    if(!Productivity.Contains(brand))
                    {
                        LaptopBrands.Add(brand);
                        Productivity.Add(brand);
                        return $"{brand} added to Productivity!";
                    }
                    else
                    {
                        return $"{brand} already exists";
                    }
                case (int)ProcessActions.Gaming:
                    if (!Gaming.Contains(brand))
                    {
                        LaptopBrands.Add(brand);
                        Gaming.Add(brand);
                        return $"{brand} added to Gaming!";
                    }
                    else
                    {
                        return $"{brand} already exists";
                    }
                case (int)ProcessActions.BasicBrowsing:
                    if (!BasicBrowsing.Contains(brand))
                    {
                        LaptopBrands.Add(brand);
                        BasicBrowsing.Add(brand);
                        return $"{brand} added to Basic Browsing!";
                    }
                    else
                    {
                        return $"{brand} already exists";
                    }
                default:
                    return "Invalid choice";
            }
            
        }

        // Data logic for removing a brand
        public static string RemoveBrand(string brand)
        {
           
            if (Productivity.Contains(brand))
            {
                LaptopBrands.Remove(brand);
                Productivity.Remove(brand);
                return $"{brand} removed!";
            }
            else if (Gaming.Contains(brand))
            {
                LaptopBrands.Remove(brand);
                Gaming.Remove(brand);
                return $"{brand} removed!";
            }
            else if (BasicBrowsing.Contains(brand))
            {
                LaptopBrands.Remove(brand);
                BasicBrowsing.Remove(brand);
                return $"{brand} removed1";
            }
            else
            {
                return $"{brand} does not exist";
            }       
        }
       
    }
}
