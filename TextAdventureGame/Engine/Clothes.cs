using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAGEngine
{
    public class Clothes : Item
    {
        public string strClothType { get; set; } // casual, goingout, nightwear, business
        public string strClothBodyPart { get; set; } // upper, lower, all-body
        public string strClothGender { get; set; }
        public string strClothDescription { get; set; }

        public Clothes(int id, string name, string namePlural, string clothtype, string clothbodypart, string clothgender, string clothdesc) : base(id, name, namePlural)
        {
            strClothType = clothtype;
            strClothBodyPart= clothbodypart;
            strClothGender = clothgender;
            strClothDescription = clothdesc;
        }
    }
}
