#region LICENSE

//    Definition.cs
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

namespace Ferocious.Logic
{
    internal static class Definition
    {
        internal enum EffectType
        {
            StatChange,
            NamedEffect,
            Damage,
            Healing,
            OverTime,
            EndOfEffect
        }
        internal enum StatType
        {
            None,
            CriticalStrike,
            Haste,
            Mastery,
            CriticalDamage,
            Multistrike,
            Versatility,
            Primary,
            Power,
            WeaponDamage,
            
        }
        internal struct Effect
        {
            private EffectType _effectType;
            private StatType _statType;
            private float _effectAmn;

            public Effect(EffectType effectType, float effectAmn, StatType statType = StatType.None)
            {
                _effectType = effectType;
                _statType = statType;
                _effectAmn = effectAmn;
            }
        }
        internal class Buff
        {
            private float EndTime { get; set; }
            private float Amount { get; set; }
            private EffectType Type { get; set; }
            private string Name { get; set; }
        }
        internal interface IAction
        {
            string Name();
            int Priority();
            bool ShouldUse();
            void ApplyEffect();
        }
    }
}