using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks.Dataflow;


namespace BussLinjen
{
    class Simulation
    {
        public void Start()
        {
            Console.WriteLine("Simulator is starting.");

            int bX = 4;
            int bY = 2;
            int dX = 1;
            int dY = 0;
           
            string[,] grid =         // Skriver ut gridden på ett osofistikerat sätt
            {
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". " },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". " },
                {"H5",". ",". ",". ",". ","H1",". ",". ",". ","H2",". ",". " },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". " },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". " },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". " },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". " },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". " },
                {"H4",". ",". ",". ",". ",". ",". ",". ",". ","H3 ",". ",". "},
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". " },
                {".",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". "  },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". " },
                {". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". " }
            };


            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            Buss aBuss = new Buss(10);                        // Listor och Klasser -- Inget funkar.

            Station astation = new Station();

            Passenger aPassenger = new Passenger(1, 5);

           // astation.StationPassengers.Add(aPassenger);

            List<string> Hplts = new List<string>();       

            string Hpl1 = grid[4, 2];
            string Hpl2 = grid[9, 2];
            string Hpl3 = grid[9, 8];
            string Hpl4 = grid[0, 8];
            string Hpl5 = grid[0, 2];
            Hplts.Add(Hpl1);
            Hplts.Add(Hpl2);
            Hplts.Add(Hpl3);
            Hplts.Add(Hpl4);
            Hplts.Add(Hpl5);
           
            // Loop för att skriva ut grid[] med ReadKey(). Samt addera / remova från listor
           
            
            while (true) 
            {
                if (bX == 4 && bY == 2 || bX == 0 && bY == 2)   // Logik för att ändra riktning på bussen
                {
                    dY = 0;
                    dX = 1;
                }
                if (bX == 9 && bY == 2)
                {
                    dY = 1;
                    dX = 0;
                }
                if (bX == 9 && bY == 8)
                {
                    dY = 0;
                    dX = -1;
                }
                if (bX == 0 && bY == 8)
                {
                    dY = -1;
                    dX = 0;
                }

                Console.Clear();                                   
                for (int y = 0; y < grid.GetLength(0); y++)
                {
                    for (int x = 0; x < grid.GetLength(1); x++)
                    {
                        if (bX == x && bY == y)
                        {
                          
                            Console.Write("B ");
                            if (Hpl2 == "B ")
                            {
                                aBuss.BussCurrentPassenger.Add(aPassenger);
                                astation.StationPassengers.Remove(aPassenger);
                            }

                        }
                        else
                        Console.Write(grid[y, x]);
                       }
                    Console.WriteLine();
                }
                Console.ReadKey();
                            bY += dY;
                            bX += dX;
            }
           


            Console.Write(grid);

            int rowss = grid.GetLength(0);
            int colss = grid.GetLength(1);

            while (true)
            {
                for (int y = 0; y < rows; y++)
                {
                    for (int x = 0; x < cols; x++)
                    {
                            Console.Write(grid[0,1]);
                    }
                    Console.WriteLine();
                }
                Console.Clear();
            }
        }
    }
}
