using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule12
{
    public class RaceGame
    {
        public delegate void GoToStartHandler();

        public delegate void StartRaceHandler();

        public delegate void MoveHandler();

        public delegate void FinishRaceHandler();

        public void Play()
        {
            SportsCar sportsCar = new SportsCar("Спортивный автомобиль", 10);
            PassengerCar passengerCar = new PassengerCar("Легковой автомобиль", 8);
            Truck truck = new Truck("Грузовик", 5);
            Bus bus = new Bus("Автобус", 7);

            GoToStartHandler sportsCarGoToStart = sportsCar.GoToStart;
            GoToStartHandler passengerCarGoToStart = passengerCar.GoToStart;
            GoToStartHandler truckGoToStart = truck.GoToStart;
            GoToStartHandler busGoToStart = bus.GoToStart;

            StartRaceHandler sportsCarStartRace = sportsCar.Move;
            StartRaceHandler passengerCarStartRace = passengerCar.Move;
            StartRaceHandler truckStartRace = truck.Move;
            StartRaceHandler busStartRace = bus.Move;

            FinishRaceHandler sportsCarFinishRace = () => Console.WriteLine($"{sportsCar.Model} пришел к финишу!");
            FinishRaceHandler passengerCarFinishRace = () => Console.WriteLine($"{passengerCar.Model} пришел к финишу!");
            FinishRaceHandler truckFinishRace = () => Console.WriteLine($"{truck.Model} пришел к финишу!");
            FinishRaceHandler busFinishRace = () => Console.WriteLine($"{bus.Model} пришел к финишу!");

            sportsCar.Finished += (sender, args) => sportsCarFinishRace();
            passengerCar.Finished += (sender, args) => passengerCarFinishRace();
            truck.Finished += (sender, args) => truckFinishRace();
            bus.Finished += (sender, args) => busFinishRace();

            sportsCarGoToStart();
            passengerCarGoToStart();
            truckGoToStart();
            busGoToStart();

            sportsCarStartRace();
            passengerCarStartRace();
            truckStartRace();
            busStartRace();
        }
    }
}
