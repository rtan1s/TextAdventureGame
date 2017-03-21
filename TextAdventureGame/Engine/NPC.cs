using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAGEngine
{
    public class NPC : Character
    {
        public int intNPCID { get; set; }
        public string strNPCFirstName { get; set; }
        public string strNPCLastName { get; set; }
        public string strNPCGender { get; set; }
        public int intNPCAge { get; set; }
        public string strNPCRace { get; set; }
        public string strNPCAppearance { get; set; }
        public string strNPCStory { get; set; }
    }
}
