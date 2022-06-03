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
            var Haus2 = Haus1.Clone();

            child.TypeOfRoof = "neues Roof";
            Haus2.CountOfWalls = 1;
            Haus2.PrintHouse();
        }
    }
}