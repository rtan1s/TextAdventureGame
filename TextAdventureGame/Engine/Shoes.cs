using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAGEngine
{
    public class Shoes : Item
    {
        public string strShoeGender { get; set; }
        public string strShoeType { get; set; }
        public string strShoeDescription { get; set; }

        public Shoes(int id, string name, string namePlural, string shoetype, string shoegender, string shoedesc) : base(id, name, namePlural)
        {
            strShoeType = shoetype;
            strShoeGender = shoegender;
            strShoeDescription = shoedesc;
        }
    }
}
