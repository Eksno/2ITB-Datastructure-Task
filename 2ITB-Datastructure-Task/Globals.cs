using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITB_Datastructure_Task
{
    public static class Globals
    {
        public static string[] basicCarBrandNames = { "Ford", "Toyota", "Tesla", "Saab" };
        public static List<string> carBrandNames = new List<string>();
        public static List<CarBrand> carBrands = new List<CarBrand>();
        
        public static void addBasicCarBrands()
        {
            for (int i = 0; i < basicCarBrandNames.Length; i++)
            {
                addCarBrand(basicCarBrandNames[i]);
            }
        }

        public static void addCarBrand(string brand)
        {
            if (!carBrandNames.Contains(brand))
            {
                carBrandNames.Add(brand);
                carBrands.Add(new CarBrand());
                carBrands[carBrands.Count - 1].Initialize(brand, new Point(40, 40));//new Point(10, carBrands.Count * 40));
            }
            else
            {

            }
        
        }

        public static bool removeCarBrand(string brand)
        {
            if (carBrandNames.Contains(brand))
            {
                int index = carBrandNames.IndexOf(brand);
                carBrands.RemoveAt(index);
                carBrandNames.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
