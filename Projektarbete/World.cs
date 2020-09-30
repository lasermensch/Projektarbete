using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Drawing;

namespace Projektarbete
{
    public class World
    {
        //Klassmedlemmar:
        public char[,] Map { get; protected set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public List<Point> Positions { get; protected set; }
        public World()
        {
            Map = new char[30, 30];
            Width = Map.GetLength(0);
            Height = Map.GetLength(1);
            Positions = new List<Point>();

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (i == 0 || i == Height - 1)
                        Map[i, j] = '#';
                    else if (j == 0 || j == Width - 1)
                        Map[i, j] = '#';
                    else
                        Map[i, j] = '.';
                }

            }
            
        }
        public void GenerateEnemies()
        {

        }
    }
}
