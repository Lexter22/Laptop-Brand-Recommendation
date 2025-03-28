using System;

namespace DataBusiness
{
    public class LaptopProcess
    {
        public static List<string> LaptopBrands = new List<string>();
        public static string brand;
        // Business logic for recommending a brand
        public static string RecommendBrand(int use)
        {
            List<string> RecommendedBrands = new List<string>();

            switch (use)
            {
                case 1:
                    if (LaptopBrands.Contains("DELL")) RecommendedBrands.Add("DELL");
                    if (LaptopBrands.Contains("APPLE")) RecommendedBrands.Add("APPLE");
                    if (LaptopBrands.Contains("HP")) RecommendedBrands.Add("HP");
                    if (LaptopBrands.Contains("HUAWEI")) RecommendedBrands.Add("HUAWEI");
                    break;
                case 2:
                    if (LaptopBrands.Contains("ASUS")) RecommendedBrands.Add("ASUS");
                    if (LaptopBrands.Contains("MSI")) RecommendedBrands.Add("MSI");
                    if (LaptopBrands.Contains("ACER")) RecommendedBrands.Add("ACER");
                    break;
                case 3:
                    if (LaptopBrands.Contains("LENOVO")) RecommendedBrands.Add("LENOVO");
                    if (LaptopBrands.Contains("SAMSUNG")) RecommendedBrands.Add("SAMSUNG");
                    if (LaptopBrands.Contains("MICROSOFT")) RecommendedBrands.Add("MICROSOFT");
                    break;
                default:
                    return "Please read and try again";
            }

            if (RecommendedBrands.Count > 0)
            {
                return $"Recommended brands: {String.Join(",", RecommendedBrands)}";
            }
            else
            {
                return "No recommended brands";
            }
        }

        // Data logic for adding a brand
        public static string AddBrand(string brand)
        {
            if (!LaptopBrands.Contains(brand))
            {
                LaptopBrands.Add(brand);
                return $"{brand} added";
            }
            else
            {
                return $"{brand} already exists";
            }
        }

        // Data logic for removing a brand
        public static string RemoveBrand(string brand)
        {
            if (LaptopBrands.Contains(brand))
            {
                LaptopBrands.Remove(brand);
                return $"{brand} removed";
            }
            else
            {
                return $"{brand} does not exist";
            }
        }
    }
}
