using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        Location loc = null;
        public Snake()
        {
            loc = new Location(0, 0);
        }
        public Location getLoc()
        {
            return loc;
        }

        public void testKeys(ConsoleKeyInfo key)
        {
            
            
            if (key != null && key.Key == ConsoleKey.DownArrow)
            {
                loc = new Location(loc.loc[0], loc.loc[1] + 1);
            }
            else if (key != null && key.Key == ConsoleKey.UpArrow)
            {
                loc = new Location(loc.loc[0], loc.loc[1] - 1);
            }
            else if (key != null && key.Key == ConsoleKey.LeftArrow)
            {
                loc = new Location(loc.loc[0]-1, loc.loc[1]);
            }
            else if (key != null && key.Key == ConsoleKey.RightArrow)
            {
                loc = new Location(loc.loc[0]+1, loc.loc[1]);
            }

        }
    }
}
