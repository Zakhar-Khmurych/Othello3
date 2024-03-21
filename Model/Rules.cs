using System;
using System.Collections.Generic;

namespace Model
{
    public class RuleSet : IRules
    {
        public Grid CurrentGrid;

        public RuleSet(int x, int y)
        {
            CurrentGrid = new Grid(x, y);
        }
        
        public bool HasAvailableMoves()
        {
            foreach (var cell in CurrentGrid.Cells)
            {
                if (cell.Occupier == null)
                {
                    return true;
                }
            }
            Console.WriteLine("it is over!");
            return false;
        }
        
        public List<Cell> AvailableMoves(Player whose_turn)
        {
            List<Cell> available = new List<Cell>();
            
            for (int i = 0; i < CurrentGrid.Cells.GetLength(0); i++)
            {
                for (int j = 0; j < CurrentGrid.Cells.GetLength(1); j++)
                {
                    if (CurrentGrid.Cells[i, j].Occupier == null)
                    {
                        for (int di = -1; di <= 1; di++)
                        {
                            for (int dj = -1; dj <= 1; dj++)
                            {
                                if (i + di < 0 || i + di >= CurrentGrid.Cells.GetLength(0) ||
                                    j + dj < 0 || j + dj >= CurrentGrid.Cells.GetLength(1))
                                    continue;
                                
                                if (CurrentGrid.Cells[i + di, j + dj].Occupier != null &&
                                    CurrentGrid.Cells[i + di, j + dj].Occupier != whose_turn)
                                {
                                    int ni = i + di;
                                    int nj = j + dj;
                                    while (ni >= 0 && ni < CurrentGrid.Cells.GetLength(0) &&
                                           nj >= 0 && nj < CurrentGrid.Cells.GetLength(1) &&
                                           CurrentGrid.Cells[ni, nj].Occupier != whose_turn)
                                    {
                                        ni += di;
                                        nj += dj;
                                    }
                                    if (ni >= 0 && ni < CurrentGrid.Cells.GetLength(0) &&
                                        nj >= 0 && nj < CurrentGrid.Cells.GetLength(1) &&
                                        CurrentGrid.Cells[ni, nj].Occupier == whose_turn)
                                    {
                                        available.Add(CurrentGrid.Cells[i, j]);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return available;
        }
    }
}