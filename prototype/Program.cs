// See https://aka.ms/new-console-template for more information

namespace prototype
{
    class Program
    {

        public static void Main()
        {
            Krototype child = new Krototype(0,0, "SuperCooles Roof", null);
            Krototype Haus1 = new Krototype(3, 4, "Spitzdach",child);
            Haus1.PrintHouse();
            var Haus2 = (Krototype)Haus1.Clone();

            child.TypeOfRoof = "neues Roof";
            Haus2.CountOfWalls = 1;
            Haus2.PrintHouse();

            var Haus3 = Clone(Haus1);

            Haus1.CountOfWindows = 5; Haus3.PrintHouse();

        }


        private static T Clone<T>(T objectToClone)where T : ICloneable
        {
            return (T)objectToClone.Clone();
        }
    }
}