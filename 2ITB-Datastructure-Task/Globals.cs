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
                carBrandNames.Add(basicCarBrandNames[i]);

                carBrands.Add(new CarBrand());
                carBrands[i].Initialize();
                carBrands[i].Text = carBrandNames[i];
                carBrands[i].Location = new Point(10, i * 40);
            }
        }

        public static void addCarBrand(string brand)
        {
            if (!carBrandNames.Contains(brand))
            {
                carBrandNames.Add(brand);
                carBrands.Add(new CarBrand());
                carBrands[-1].Initialize();
                carBrands[-1].Text = carBrandNames[-1];
                //carBrands[carBrandNames.Length()];
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
