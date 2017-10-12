using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day3Class
{
    class Program
    {
        static void Main(string[] args)
        {

            //Vehical baseVehical = new Vehical(4, 2000, "Green", 55.0d);

            //baseVehical.Move();
            //baseVehical.Move();
            //Console.WriteLine(baseVehical.DistanceTraveled);

            Automobile herbie = new Automobile(4, 13, 2, 4, 1500, "white", 88.0d);
            herbie.Move();
            herbie.Move();
            Console.WriteLine("Automobile " + herbie.GetDistanceTraveled());

            Boat boaty = new Boat(2, 500, "Red", 80.0d, .9d);
            boaty.Move();
            boaty.Move();
            Console.WriteLine("Boat Distance " + boaty.GetDistanceTraveled());

            Aircraft Wings = new Aircraft(70, 100000, "Red", 600.0d);
            Wings.Move();
            Wings.Move();
            Console.WriteLine("Aircraft " + Wings.GetDistanceTraveled());
        }
    }
}
