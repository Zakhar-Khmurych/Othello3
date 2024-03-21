using System;
using Model;

namespace ConsoleHandler
{
    public class ConsoleWriter
    {
        public void BroadcastGame(Grid grid)
        {
            //Console.Clear();
            for (int i = 0; i < grid.Cells.GetLength(0); i++)
            {
                for (int j = 0; j < grid.Cells.GetLength(1); j++)
                {
                    Console.Write(GetCellState(grid.Cells[i, j]));
                    Console.Write("\t");
                }

                Console.WriteLine();
                //
            }
            Console.WriteLine("===========================================================");
        }
        private string GetCellState(Cell cell)
        {
            if (cell.Occupier != null)
            {
                return cell.Occupier.Name.Substring(0, 1); 
            }
            else
            {
                return ".";
            }
        }
    }
}