using System;

namespace DataBusiness
{
    public class LaptopProcess
    {
        public static List<string> LaptopBrands = new List<string>();
        public static List<string> Productivity = new List<string>();
        public static List<string> Gaming = new List<string>();
        public static List<string> BasicBrowsing = new List<string>();
        public static List<string> RecommendedBrands = new List<string>();
        // Business logic for recommending a brand
        public static List<string> RecommendBrand(int use)
        {
            switch (use)
            {
                case 1:
                    RecommendedBrands = Productivity;
                    break;
                case 2:
                    RecommendedBrands = Gaming;
                    break;
                case 3:
                    RecommendedBrands = BasicBrowsing;
                    break;
                default:
                    return RecommendedBrands;
            }

            return RecommendedBrands;
          
        }

        // Data logic for adding a brand
        public static string AddBrand(string brand,int use)
        {
            switch (use)
            {
                case (int)Actions.Productivtity:        
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
                case 2:
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
                case 3:
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
                return $"{brand} removed from Productivity!";
            }
            else if (Gaming.Contains(brand))
            {
                LaptopBrands.Remove(brand);
                Gaming.Remove(brand);
                return $"{brand} removed from Gaming!";
            }
            else if (BasicBrowsing.Contains(brand))
            {
                LaptopBrands.Remove(brand);
                BasicBrowsing.Remove(brand);
                return $"{brand} removed from Basic Browsing!";
            }
            else
            {
                return $"{brand} does not exist";
            }       
        }
       
    }
}
