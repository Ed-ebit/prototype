using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    public class Schloss
    {
        public int CountOfDiener;
        public int CountOfWalls;
        public int CountOfWindows;
        public string TypeOfRoof;


        public Schloss(int CountOfWindows,int CountOfWalls, string TypeOfRoof, int CountOfDiener)
        {
            this.CountOfWindows = CountOfWindows;
            this.CountOfWalls = CountOfWalls;
            this.CountOfDiener = CountOfDiener;
            this.TypeOfRoof = TypeOfRoof;
        }

        public void PrintSchloss()
        {
            Console.WriteLine("Fenster: " + this.CountOfWindows + " Wände: " + this.CountOfWalls + " Dach: " + this.TypeOfRoof + "Diener: " + this.CountOfDiener);
        }

        public object Clone()
        {
            return new Schloss(this.CountOfWindows, this.CountOfDiener, this.TypeOfRoof, this.CountOfDiener);
        }
    }
}

