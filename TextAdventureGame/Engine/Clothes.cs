using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAGEngine
{
    public class Clothes : Item
    {
        public int intClothID { get; set; }
        public string strClothName { get; set; }
        public string strClothType { get; set; } // casual, goingout, nightwear, business
        public string strClothBodyPart { get; set; } // upper, lower, all-body
        public string strClothGender { get; set; }
        public string strClothDescription { get; set; }
    }
}
