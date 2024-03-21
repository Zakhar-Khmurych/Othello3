using System.Collections.Generic;

namespace Model
{
    public interface IRules
    {
        
        bool HasAvailableMoves(); 
        List<Cell> AvailableMoves(Player whose_turn);
    }
}