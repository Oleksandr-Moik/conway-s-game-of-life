using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_life
{
    class LifeRule
    {
        private string name;
        private int typeRule;
        private bool[] creationRules;
        private bool[] survivalRules;

        public LifeRule() { }

        public LifeRule(string name, int type, bool[] creation, bool[] survival)
        {
            this.name = name;
            this.typeRule = type;

        }


    }
}
