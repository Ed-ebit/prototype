namespace prototype
{
    public class Krototype : ICloneable { 
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

        public object Clone()
        {
            if (TypeOfRoof == "Satteldach")
            {
                throw new Exception("Ich kann Satteldaecher nicht klonen.");

            }

            return new Krototype(this.CountOfWindows, this.CountOfWalls, this.TypeOfRoof, (Krototype)this.child?.Clone());
        }
    }
}
