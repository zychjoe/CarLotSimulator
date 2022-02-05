using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Today I'm parking Uptown. I found a CarLot at 89th and 10th.
            CarLot EightyNinthAndTenth = new CarLot();

            //We're going to park three cars.
            //(Named and modeled after three real world cars I once owned.)
            Car TheExecutive = new Car();
            TheExecutive.Year = 1998;
            TheExecutive.Make = "Lincoln";
            TheExecutive.Model = "Towncar";
            TheExecutive.EngineNoise = "Ruggaruggarugga";
            TheExecutive.HonkNoise = "MIIuuuuuuh";
            TheExecutive.IsDriveable = false; //That tree popped outta nowhere!

            //Now to park the Executive.
            EightyNinthAndTenth.ParkCar(TheExecutive);

            Car SilverSnake = new Car(2010, "Saturn", "S4", "zzzzzzz", "HEEH", true);

            //And we'll park the Silver Snake.
            EightyNinthAndTenth.ParkCar(SilverSnake);

            //Now the CarLot is full!
            EightyNinthAndTenth.ReadInventory();

            Car Cherry = new Car()
            {
                Year = 2013,
                Make = "Ford",
                Model = "Fiesta",
                EngineNoise = "chigchigchig",
                HonkNoise = "BIP",
                IsDriveable = true
            };

            //If I try to park Cherry, the attendant will tell me the lot is full.
            EightyNinthAndTenth.ParkCar(Cherry);

            //So I get mad...
            Console.WriteLine("ME: What?! You've got room for atleast 3 more cars in there!");

            //And convince him to change his mind.
            Console.WriteLine("PARKING ATTENDANT: Yeah, I guess...");
            EightyNinthAndTenth.Capacity = 5;
            EightyNinthAndTenth.ParkCar(Cherry);

            //So I Drive Cherry in - 
            Console.WriteLine($"CHERRY (THE CAR): ");
            Cherry.MakeEngineNoise("Putter");

            //And give a friendly honk - 
            Cherry.MakeHonkNoise("TOOT TOOT");

            //And ask for some more information -
            Console.WriteLine("ME: What cars do you have in here now?");

            //Which I am kindly given.
            EightyNinthAndTenth.ReadInventory();

        }
    }
}
