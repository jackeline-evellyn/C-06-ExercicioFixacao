using System;

namespace _3_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] xy = Console.ReadLine().Split(' ');     
            int x = int.Parse(xy[0]);
            int y = int.Parse(xy[1]);

            double[,] mat = new double[x, y];

            for(int i=0; i<x; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j=0; j < y; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine();

            int numero = int.Parse(Console.ReadLine());
           
            for(int i =0; i < x; i++)
            {
                for(int j=0; j<y; j++)
                {
                    if (numero == mat[i, j]) {
                        Console.WriteLine("Position: " + i + "," + j);
                        if (j>0)
                            Console.WriteLine("Left : " + mat[i,j-1]);
                        if (i> 0)
                            Console.WriteLine("Up: "+mat[i-1,j]);
                        if (j+1 < x)
                            Console.WriteLine("Right: " + mat[i,j+1]);
                        if(i+1 <y)
                            Console.WriteLine("Down: " + mat[i+1,j]);
                     }
                }
            }
        }
    }
}
