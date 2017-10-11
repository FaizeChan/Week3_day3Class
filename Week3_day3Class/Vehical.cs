﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day3Class
{
    class Vehical
    {
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;
        private float gearRatio;
        private float engineSize;
        protected double distanceTraveled;

        public int Seats
        {
            get
            { return this.seats; }
        }

        public int CarryingCapacity
        {
            get
            { return this.CarryingCapacity; }
        }

        public string Color
        {
            get { return this.Color; }
            set { this.Color = value; }
        }

        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
        }

        public Vehical()
        {
        }

        public Vehical (int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.distanceTraveled = 0.0d;
        }

        public virtual void Move()
        {
            //distanceTraveled = distanceTraveled + movementSpeed;
            distanceTraveled += movementSpeed;
        }


    }
}