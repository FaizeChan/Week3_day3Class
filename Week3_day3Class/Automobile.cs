using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day3Class
{
    class Automobile : Vehical
    {
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;


        public int NumberOfWheels
        {
            get { return this.NumberOfWheels; }
        }

        public Automobile (int numberOfWheels, float wheelSize, int numberOfDoors, int seats, int carryingCapacity, string color, double movementSpeed)
        {
            //these fields are in the Automobile class
            this.numberOfWheels = numberOfWheels;
            this.numberOfDoors = numberOfDoors;
            this.wheelSize = wheelSize;
            //these fields are in the Vehicle class
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

        }
    }
}
