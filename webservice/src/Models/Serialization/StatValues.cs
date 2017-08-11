using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FGOData.Models.Serialization
{
    public class StatValues
    {
        public int Lvl { get; set; }
        public int HP { get; set; }
        public int Atk { get; set; }

        public StatValues(int lvl, int hp, int atk)
        {
            Lvl = lvl;
            HP = hp;
            Atk = atk;
        }
    }
}