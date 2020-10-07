using System;
using System.Collections.Generic;
using System.Text;

namespace BussLinjen
{
    class Passenger
    {
        static Random r = new Random();

        public int SpawnBStation { get; set; }
        public int HeadingBStation { get; set; }

        public Passenger(int spawnBStation, int headingBStation)
        {
            SpawnBStation = spawnBStation;
            HeadingBStation = headingBStation;
        }
        public void Spawn()
        {
            int spawnstation = r.Next(1, 6);
            SpawnBStation = spawnstation;
        }
        public void GenerateDestination()
        {
            int destination = r.Next(1, 6);
            HeadingBStation = destination;
        }

    }

}
