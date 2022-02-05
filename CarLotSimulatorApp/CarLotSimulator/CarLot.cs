using System;
using System.Collections.Generic;


namespace CarLotSimulator
{
    public class CarLot
    {
        private List<Car> Occupants = new List<Car>();
        private bool IsFull;
        public int Capacity { get; set; }

        public CarLot()
        {
            Capacity = 2;
        }


        public void ParkCar(Car parker)
        {
            if (Occupants.Count < Capacity)
            {
                Occupants.Add(parker);
                Console.WriteLine($"PARKING ATTENDANT: C'mon in, {parker.Year} {parker.Make} {parker.Model}");
            }
            else
            {
                Console.WriteLine("PARKING ATTENDANT: Sorry, we're full!");
            }
        }

        public void ReadInventory()
        {
            Console.WriteLine("PARKING ATTENDANT: Our inventory is as follows:");
            foreach (Car c in Occupants)
            {
                Console.WriteLine($"{c.Year} {c.Make} {c.Model}");
            }
            Console.WriteLine($"Since our capacity is {Capacity} we have room for {Capacity - Occupants.Count} more cars.");
        }
    }
}
