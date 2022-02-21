using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITB_Datastructure_Task
{
    public class CarBrand : Label
    {
        public void Initialize(string initialText, Point initialLocation)
        {
            this.Text = initialText;
            this.Location = initialLocation;
        }
    }
}
