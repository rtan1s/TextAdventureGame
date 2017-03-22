using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAGEngine
{
    public class MPlayer : Character
    {
        public int intMPCLikeness { get; set; }

        public MPlayer(int id, string name, string gender, int age, string race, string appear, string background, int money, int level, int exppts, int energy, int knwldg, int cunning, int slfdefence, int attck, int likeness) : base(id, name, gender, age, race, appear, background, money, level, exppts, energy, knwldg, cunning, slfdefence, attck)
        {
            intMPCLikeness = likeness;
        }
    }
        
}

