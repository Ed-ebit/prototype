namespace prototype
{
    public class House : IClone<House> { 
        public int CountOfWalls;

        public int CountOfWindows;
        public string TypeOfRoof;


        public House(int CountOfWindows, int CountOfWalls, string TypeOfRoof)
        {
            this.CountOfWindows = CountOfWindows;
            this.CountOfWalls = CountOfWalls;
            this.TypeOfRoof = TypeOfRoof;
        }

        public void PrintHouse()
        {
            Console.WriteLine("Fenster: " + this.CountOfWindows + " Wände: " + this.CountOfWalls + " Dach: " + this.TypeOfRoof);
        }

        public House Clone()
        {
            return new House(this.CountOfWindows, this.CountOfWalls, this.TypeOfRoof);
        }
    }
}
