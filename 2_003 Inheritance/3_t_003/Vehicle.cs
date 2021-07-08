using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_t_003
{
    class Vehicle
    {
        public int price;
        public int speed;
        public int year;

        public virtual void Show()
        {
            Console.WriteLine(price);
            Console.WriteLine(speed);
            Console.WriteLine(year);

        }
    }
    class Plane : Vehicle
    {
        int Passenger { get; set; }
        public Plane(int price, int speed, int year, int Passenger)
        {
            base.price = price;
            base.speed = speed;
            base.year = year;
            this.Passenger = Passenger;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine(Passenger);
        }
    }
    class Car : Vehicle
    {
        public Car()
        {
            price = 5000;
            speed = 120;
            year = 2007;
        }

    }
    class Ship : Vehicle
    {
        int Passenger { get; set; }
        public Ship()
        {
            price = 160000;
            speed = 42;
            year = 2011;
            Passenger = 50;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine(Passenger);
        }

    }
        
        

}
