namespace Model
{
    public class Grid
    {
        public Cell[,] Cells;

        public Grid(int rows, int columns)
        {
            Cells = new Cell[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Cells[i, j] = new Cell();
                }
            }
        }

    }
}