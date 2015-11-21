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
    public class Program
    {
        IRaceService raceService = new RaceService();
        static void Main(string[] args)
        {
            ThreadStart bmw1Start = new ThreadStart(new Program().StartBMW1);
            ThreadStart bmw2Start = new ThreadStart(new Program().StartBMW2);
            ThreadStart audi1Start = new ThreadStart(new Program().StartAudi1);
            ThreadStart audi2Start = new ThreadStart(new Program().StartAudi2);
            ThreadStart mercidesStart = new ThreadStart(new Program().StartMercedes);
            ThreadStart volvoStart = new ThreadStart(new Program().StartVolvo);
            ThreadStart PeugeotStart = new ThreadStart(new Program().StartPeugeot);

            Thread[] raceThread = new Thread[7];
            raceThread[0] = new Thread(bmw1Start);
            raceThread[1] = new Thread(bmw2Start);
            raceThread[2] = new Thread(audi1Start);
            raceThread[3] = new Thread(audi2Start);
            raceThread[4] = new Thread(mercidesStart);
            raceThread[5] = new Thread(volvoStart);
            raceThread[6] = new Thread(PeugeotStart);

            foreach (Thread race in raceThread)
            {
                race.Start();
            }

            Console.ReadLine();
        }

        public void StartBMW1()
        {
            Vehicle v = new BMW() { Name = "BMW - 1", DriverName = "A", Fuel = FuelType.Diesel, Model = "530", Type = VehicleType.Hybrid };
            raceService.Start(v);
            //executing in thread
            Thread.Sleep(1000);
            raceService.GetAverageSpeed(v, 50, "00:02:04.05");
        }

        public void StartBMW2()
        {
            Vehicle v = new BMW() { Name = "BMW - 2", DriverName = "B", Fuel = FuelType.ElectricCharging, Model = "560", Type = VehicleType.Hover };
            raceService.Start(v);
            //executing in thread
            Thread.Sleep(500);
            raceService.GetAverageSpeed(v, 40, "00:20:04.05");
        }

        public void StartAudi1()
        {
            Vehicle v = new Audi() { Name = "Audi - 2", DriverName = "C", Fuel = FuelType.ElectricCharging, Model = "A6", Type = VehicleType.Hover };
            raceService.Start(v);
            //executing in thread
            Thread.Sleep(500);
            raceService.GetAverageSpeed(v, 40, "00:20:04.05");
        }

        public void StartAudi2()
        {
            Vehicle v = new Audi() { Name = "Audi - 2", DriverName = "D", Fuel = FuelType.ElectricCharging, Model = "A5", Type = VehicleType.Hover };
            raceService.Start(v);
            //executing in thread
            Thread.Sleep(500);
            raceService.GetAverageSpeed(v, 60, "00:20:04.05");
        }

        public void StartMercedes()
        {
            Vehicle v = new Mercedes() { Name = "Mercedes - 1", DriverName = "E", Fuel = FuelType.ElectricCharging, Model = "C320" };
            raceService.Start(v);
            //executing in thread
            Thread.Sleep(500);
            raceService.GetAverageSpeed(v, 90, "00:12:04.05");
        }

        public void StartVolvo()
        {
            Vehicle v = new Volvo() { Name = "Volvo - 1", DriverName = "F", Fuel = FuelType.ElectricCharging, Model = "V4" };
            raceService.Start(v);
            //executing in thread
            Thread.Sleep(500);
            raceService.GetAverageSpeed(v, 80, "00:12:04.05");
        }

        public void StartPeugeot()
        {
            Vehicle v = new Peugeot() { Name = "Peugeot - 1", DriverName = "H", Fuel = FuelType.ElectricCharging, Model = "P 1", };
            raceService.Start(v);
            //executing in thread
            Thread.Sleep(500);
            raceService.GetAverageSpeed(v, 60, "00:18:04.05");
        }
    }
}
