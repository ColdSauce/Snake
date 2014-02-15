using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Location
    {
        private int[] locationArray = null;

        public int[] loc
        {
            get{

                // to keep the class immutable
                int[] copyOfArray = new int[locationArray.Length];
                Array.Copy(locationArray, copyOfArray,locationArray.Length);
                return copyOfArray;
            }
        }



        public Location(int row, int col)
        {
            locationArray = new int[] { row, col };

        }
        public static void printAtLocation(String text, Location loc)
        {
            int row = loc.locationArray[0];
            int col = loc.locationArray[1];
            Console.Clear();
            for (int j = 0; j < col; j++)
            {
                Console.WriteLine();
            }
            for (int i = 0; i < row; i++)
            {
                Console.Write(" ");

            }
            Console.Write(text);
        }
    }
}
