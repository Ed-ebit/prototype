namespace prototype
{
    public class Krototype //: IClone<Krototype>
    {
        public int CountOfWalls;

        public int CountOfWindows;
        public string TypeOfRoof;
        private Krototype child;


        public Krototype(int CountOfWindows, int CountOfWalls, string TypeOfRoof, Krototype child)
        {
            this.CountOfWindows = CountOfWindows;
            this.CountOfWalls = CountOfWalls;
            this.TypeOfRoof = TypeOfRoof;
            this.child = child;
        }

        public void PrintHouse()
        {
            Console.WriteLine("Fenster: " + this.CountOfWindows + " Wände: " + this.CountOfWalls + " Dach: " + child.TypeOfRoof);
        }

        public Krototype Clone()
        {
            return new Krototype(this.CountOfWindows, this.CountOfWalls, this.TypeOfRoof, this.child?.Clone());
        }
    }
}
