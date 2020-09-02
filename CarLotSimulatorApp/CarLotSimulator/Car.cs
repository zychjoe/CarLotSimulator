using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {

        }
        public Car(
            int year,
            string model,
            string engineNoise,
            string honkNoise,
            bool isDriveable,
            string make = "whatever")
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDriveable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; } = "Vroom";
        public string HonkNoise { get; set; } = "beep!";
        public bool IsDrivable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()

        public void MakeEngineNoise()
        {
            Console.WriteLine($"{EngineNoise}");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }
    }
}
