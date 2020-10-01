using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Drawing;

namespace Projektarbete
{
    class World
    {
        //Klassmedlemmar:
        public char[,] Map { get; protected set; } //kartans rutnät. Protected set innebär att bara denna klass och underklasser har tillgång till att direkt tilldela denna egenskap ett värde.
        public int Width { get; protected set; } //Så att man kan använda sig av width och height senare.
        public int Height { get; protected set; }
        public List<Entities> ListOfItemsAndEnemies { get; protected set; }
        public World(int height, int width) //Konstruktor för att generera världen.
        {
            Map = new char[height, width]; 
            Width = Map.GetLength(1); 
            Height = Map.GetLength(0);
            ListOfItemsAndEnemies = new List<Entities>();

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (i == 0 || i == Height - 1)
                        Map[i, j] = '#';
                    else if (j == 0 || j == Width - 1) //Enbart för att det ska bli mindre plottrigt. Annars kan man kombinera båda if-satserna
                        Map[i, j] = '#';
                    else
                        Map[i, j] = '.';
                }

            }
            
        }
        //Metoder
        public void GeneratePositions(int numberOfEntities) //Bestämmer punkter för objekt och fiender.
        {
            Random r = new Random();
            int x;
            int y;
            Point p;
            
            while (true)
            {
                x = r.Next(1, Width);
                y = r.Next(1, Height);
                if (Map[y,x] == '.')
                {
                    Map[y, x] = '@'; //placeholder. för att ha någonting i kodandets stund.
                    p = new Point(x, y);
                    Entities entity = new Enemy(); //När det finns en konstruktor för Enemy måste detta fixas. Samma gäller för Item nedan.

                    if (numberOfEntities > 5)
                        entity = new Item();
                    
                    entity.position = p;
                    ListOfItemsAndEnemies.Add(entity);
                    numberOfEntities--;
                }
                if (numberOfEntities < 1)
                    break;

                //Instansierar en placeholder för items
                //x = r.Next(1, Width);
                //y = r.Next(1, Height);
                //if (Map[y, x] == '.')
                //{

                //    Map[y, x] = 'A'; //placeholder. för att ha någonting i kodandets stund.
                //    p = new Point(x, y);
                //    Positions.Add(p);
                //}
            }
            
        }

        public void PrintWorld()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(Map[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
