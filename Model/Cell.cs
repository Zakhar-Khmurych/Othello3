using System.Collections;
using System.Collections.Generic;

namespace Model
{
    public class Cell
    {
        public Player Occupier { get; set; }
        public Stack<Player> History { get; set; }

        public Cell()
        {
            Occupier = null; 
            History = new Stack<Player>();
            History.Push(null);
        }

        public void MarkBy(Player player)
        {
            Occupier = player;
            History.Push(player);
        }
    }
}