using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
        // AbstractProductA
        abstract class Car
        {
            public abstract void Info();
        }
        // ConcreteProductA1
        class Ford : Car
        {
            public override void Info()
            {
                Console.WriteLine("Ford");
            }
        }
        //ConcreteProductA2
        class Toyota : Car
        {
            public override void Info()
            {
                Console.WriteLine("Toyota");
            }
        }
        class Mersedez : Car
        {
            public override void Info()
            {
                Console.WriteLine("Mersedez");
            }
        }
        // AbstractProductB
        class Engine
        {
            public virtual void GetPower()
            {
            }
        }
        // ConcreteProductB1
        class FordEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Ford Engine 4.4");
            }
        }
        //ConcreteProductB2
        class ToyotaEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Toyota Engine 3.2");
            }
        }
        class MersedezEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Mercedez Engine 5.5");
            }
        }
        // AbstractFactory
        interface ICarFactory
        {
            Car CreateCar();
            Engine CreateEngine();
        }
        // ConcreteFactory1
        class FordFactory : ICarFactory
        {
            // from CarFactory
            Car ICarFactory.CreateCar()
            {
                return new Ford();
            }
            Engine ICarFactory.CreateEngine()
            {
                return new FordEngine();
            }
        }
        // ConcreteFactory2
        class ToyotaFactory : ICarFactory
        {
            // from CarFactory
            Car ICarFactory.CreateCar()
            {
                return new Toyota();
            }
            Engine ICarFactory.CreateEngine()
            {
                return new ToyotaEngine();
            }
        }
        class MercedezFactory: ICarFactory
        {
            Car ICarFactory.CreateCar()
            {
                return new Mersedez();
            }
            Engine ICarFactory.CreateEngine()
            {
                return new MersedezEngine();
            }
        }
    }
