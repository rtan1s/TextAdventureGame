using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAGEngine
{
    public class Item
    {
        public int intID { get; set; }
        public string strName { get; set; }
        public string NamePlural { get; set; }

        public Item(int id, string name, string namePlural) {
            intID = id;
            strName = name;
            NamePlural = namePlural;
        }
    }
}
