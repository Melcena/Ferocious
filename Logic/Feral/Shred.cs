namespace Ferocious.Logic.Feral
{
    class Shred : Definition.IAction
    {
        public string Name()
        {
            return "Shred";
        }

        public int Priority()
        {
            return 1;
        }

        public bool ShouldUse()
        {

            return false;
        }

        public void ApplyEffect()
        {
        }
    }
}