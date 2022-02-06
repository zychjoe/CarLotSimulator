using System;
namespace CarLotSimulator
{
    public class Car
    {
        //Props
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Default Constructor
        public Car()
        {
            CarLotModuleEight.NumberOfCars++; //For Module 8 exercise
        }

        //Costructor w/ props
        public Car(int year, string make, string model, string engine, string honk, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engine;
            HonkNoise = honk;
            IsDriveable = isDriveable;
            CarLotModuleEight.NumberOfCars++; //For Module 8 exercise

        }

        public void MakeEngineNoise(string newNoise)
        {
            Console.WriteLine(newNoise + newNoise + newNoise);
        }

        public void MakeHonkNoise(string newNoise)
        {
            Console.WriteLine(newNoise);
        }
    }
}
