using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.CarFactory
{
    interface ICarFactory
    {
        Car GetCar(string carType);
    }
    interface IColor
    {
        string Color { get; set; }
    }
    interface ICilindrata
    {
        int Cilindrata { get; set; }
    }
    class CarFactory : ICarFactory
    {
        public Car GetCar(string carType)
        {
            switch (carType)
            {
                case "1":
                    return new Coupe();
                default:
                case "2":
                    return new Suv();
            }
        }
    }
    abstract class Car
    {
        public string Name => this.GetType().Name;
    }
    class Coupe : Car
    {

    }
    class Suv : Car, IColor, ICilindrata
    {
        public string Color { get; set; }
        public int Cilindrata { get; set; }
    }
}
