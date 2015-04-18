using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferocious.Logic;
using static Ferocious.Logic.Definition;

namespace Ferocious.Logic.Feral
{
    class Rake : IAction
    {
        public string Name()
        {
            return "Rake";
        }

        public int Priority()
        {
            if (StatObject.Buffs.ContainsKey("Prowl") || StatObject.Buffs.ContainsKey("Shadowmeld"))
                return 100; //Highest priority ALWAYS. Note how this is not incarnation.

            return 2;
        }

        public bool ShouldUse()
        {
            return false;
        }

        public void ApplyEffect()
        {

            //CombatLog.Log.Add();
        }
    }
}
