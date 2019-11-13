using System;

namespace ChessProj
{
    class Program
    {

        static void Main()
        {
            int row1;
            char colum1;
            int row2;
            char colum2;
            while (true)
            {
                try
                {
                    Console.WriteLine("Colums 1");
                    colum1 = char.Parse(Console.ReadLine());
                    Console.WriteLine("Rows 1");
                    row1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Colums 2");
                    colum2 = char.Parse(Console.ReadLine());
                    Console.WriteLine("Rows 2");
                    row2 = int.Parse(Console.ReadLine());

                    Cell cell1 = new Cell(colum1, row1);
                    Cell cell2 = new Cell(colum2, row2);
                    cell1.WhiteOrBlack();
                    cell2.WhiteOrBlack();
                    cell1.IsHorizontal(row1, row2);
                    cell1.IsVertical(colum1, colum2);
                    cell1.IsDiagonal(row1, colum1, row2, colum2);

                    break;
                }
                catch (MyOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
