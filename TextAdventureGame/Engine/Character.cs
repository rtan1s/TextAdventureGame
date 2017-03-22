using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAGEngine
{
    public class Character
    {
        public int intCharID { get; set; }
        public string strCharName { get; set; }
        public string strCharGender { get; set; }
        public int intCharAge { get; set; }
        public string strCharRace { get; set; }
        public string strCharAppearance { get; set; }
        public string strCharBackground { get; set; }
        public int intCharMoney { get; set; }
        public int intCharLevel { get; set; }
        public int intCharExpPoints { get; set; }
        public int intCharEnergy { get; set; }
        public int intCharKnowledge { get; set; }
        public int intCharCunning { get; set; }
        public int intCharSelfDefense { get; set; }
        public int intCharAttack { get; set; }

        public Character(int id, string name, string gender, int age, string race, string appear, string background, int money, int level, int exppts, int energy, int knwldg, int cunning, int slfdefence, int attck)
        {
            intCharID = id;
            strCharName = name;
            strCharGender = gender;
            intCharAge = age;
            strCharRace = race;
            strCharAppearance = appear;
            strCharBackground = background;
            intCharMoney = money;
            intCharLevel = level;
            intCharExpPoints = exppts;
            intCharEnergy = energy;
            intCharKnowledge = knwldg;
            intCharCunning = cunning;
            intCharSelfDefense = slfdefence;
            intCharAttack = attck;
        }
    }
}
