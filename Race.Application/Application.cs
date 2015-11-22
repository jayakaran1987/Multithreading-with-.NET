using Race.Core;
using Race.Core.Model;
using Race.Service;
using Race.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Race.Application
{
    public class Application
    {
        IRaceService raceService = new RaceService();
        static void Main(string[] args)
        {
            ThreadStart bmw1Start = new ThreadStart(new Application().StartBMW1);
            ThreadStart bmw2Start = new ThreadStart(new Application().StartBMW2);
            ThreadStart audi1Start = new ThreadStart(new Application().StartAudi1);
            ThreadStart audi2Start = new ThreadStart(new Application().StartAudi2);
            ThreadStart mercidesStart = new ThreadStart(new Application().StartMercedes);
            ThreadStart volvoStart = new ThreadStart(new Application().StartVolvo);
            ThreadStart PeugeotStart = new ThreadStart(new Application().StartPeugeot);

            Thread[] raceThread = new Thread[7];
            raceThread[0] = new Thread(bmw1Start);
            raceThread[1] = new Thread(bmw2Start);
            raceThread[2] = new Thread(audi1Start);
            raceThread[3] = new Thread(audi2Start);
            raceThread[4] = new Thread(mercidesStart);
            raceThread[5] = new Thread(volvoStart);
            raceThread[6] = new Thread(PeugeotStart);

            Console.WriteLine("*********************************************************************** ");
            Console.WriteLine("*************************** Race Started ****************************** ");
            foreach (Thread race in raceThread)
            {
                race.Start();
            }
            
            Console.ReadLine();
        }

        public void StartBMW1()
        {
            Vehicle v = new BMW() { Name = "BMW Sport Car", DriverName = "A", Fuel = FuelType.ElectricCharging, Model = "M1", Type = VehicleType.Hybrid };
            raceService.Start(v);
            //executing in thread
            Thread.Sleep(2750);
            raceService.GetAverageSpeed(v, 50, "00:12:04.05");
        }

        public void StartBMW2()
        {
            Vehicle v = new BMW() { Name = "BMW Race Car", DriverName = "B", Fuel = FuelType.ElectricCharging, Model = "X3", Type = VehicleType.Hover };
            raceService.Start(v);
            //executing in thread
            Thread.Sleep(4000);
            raceService.GetAverageSpeed(v, 55, "00:18:04.05");
        }

        public void StartAudi1()
        {
            Vehicle v = new Audi() { Name = "Audi Sport", DriverName = "C", Fuel = FuelType.ElectricCharging, Model = "A6", Type = VehicleType.Hover };
            raceService.Start(v);
            //executing in thread
            Thread.Sleep(2500);
            raceService.GetAverageSpeed(v, 50, "00:11:05.05");
        }

        public void StartAudi2()
        {
            Vehicle v = new Audi() { Name = "Audi Normal", DriverName = "D", Fuel = FuelType.ElectricCharging, Model = "Q5", Type = VehicleType.Hover };
            raceService.Start(v);
            //executing in thread
            Thread.Sleep(3100);
            raceService.GetAverageSpeed(v, 55, "00:17:04.05");
        }

        public void StartMercedes()
        {
            Vehicle v = new Mercedes() { Name = "Benz - Mercedes", DriverName = "E", Fuel = FuelType.Petrol, Model = "E220" };
            raceService.Start(v);
            //executing in thread
            Thread.Sleep(2000);
            raceService.GetAverageSpeed(v, 51, "00:11:04.05");
        }

        public void StartVolvo()
        {
            Vehicle v = new Volvo() { Name = "Volvo Normal", DriverName = "F", Fuel = FuelType.Petrol, Model = "V4" };
            raceService.Start(v);
            //executing in thread
            Thread.Sleep(3400);
            raceService.GetAverageSpeed(v, 70, "00:22:04.05");
        }

        public void StartPeugeot()
        {
            Vehicle v = new Peugeot() { Name = "Peugeot Sport", DriverName = "H", Fuel = FuelType.Petrol, Model = "P6", };
            raceService.Start(v);
            //executing in thread
            Thread.Sleep(4500);
            raceService.GetAverageSpeed(v, 60, "00:20:04.05");
        }
    }
}
