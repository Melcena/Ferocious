#region LICENSE

//    Logic.cs
//    Copyright 2015 Melcena
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

#endregion

using System.Collections.Generic;
using System.Security.Claims;
using static Ferocious.Logic.Definition;

namespace Ferocious.Logic
{
    internal static class CombatLog
    {
        private static int _comboPoints;
        private static SortedList<float, Effect> Log { get; }
        public static float Energy { get; set; }

        public static int ComboPoints
        {
            get { return _comboPoints; }
            set
            {
                _comboPoints = value;
                if (_comboPoints > 5)
                    _comboPoints = 5;
                else if (_comboPoints < 0)
                    _comboPoints = 0;
            }
        }



        static void CombatLogStart()
        {
            StatObject.Buffs = new Dictionary<string, Buff>();
            //var effect = new Effect();
            Log.Add(0.0f, new Effect(EffectType.Damage, 0));
            while (true)
            {
                
            }


        }
    }
    internal static class StatObject
    {
        internal static Dictionary<string, Buff> Buffs { get; set; }
        internal static int Agility { get; set; }
        internal static int CritialStrike { get; set; }
        internal static int Haste { get; set; }
        internal static int Mastery { get; set; }
        internal static int Multistrike { get; set; }
        internal static int Versatility { get; set; }
    }
}