using System;
using System.Collections.Generic;
using System.Text;

namespace ChessProj
{
    class Cell
    {
        char colum;
        int row;
        public Cell(char colum, int row)
        {
            if ((colum < 'a' || colum > 'h') || (row > 8) || (row < 1))
            {
                throw new MyOutOfRangeException("Exception");
            }
            this.colum = colum;
            this.row = row;

        }
        public void WhiteOrBlack() 
        {          
                if ((Convert.ToInt32(colum) + row) % 2 == 0)
                {
                    Console.WriteLine("Black");
                }
                else
                    Console.WriteLine("White ");       
        }
        public void IsVertical(char colum, char colum2)
        {
            if (Convert.ToInt32(colum) == Convert.ToInt32(colum2))
            {
                Console.WriteLine("Vertical");                
            }           
        }
        public void IsHorizontal(int row,int row2)
        {
            if (row == row2)
            {
                Console.WriteLine("Horizontal");
            }
        }
        public void IsDiagonal(int row, char colum, int row2, char colum2)
        {
            int letterDif = Convert.ToInt32(colum) - Convert.ToInt32(colum2);
            int numberDif = row - row2;
            if (Math.Abs(letterDif)  == Math.Abs(numberDif))
            {
                Console.WriteLine("Diagonal");
            }
        }
    }
}
