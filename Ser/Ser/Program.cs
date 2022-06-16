using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Ser
{
    internal class Program
    {

        public static List<RentedCar> Cars;

        static void Main(string[] args)
        {
            Cars = new List<RentedCar>();

            var serializer = new XmlSerializer(Cars.GetType());

            //var car = new RentedCar(new Car("Hyundai", "Sonata", "V6", "Black"), new Person("Derek", "Hale"));
            //var car2 = new RentedCar(new Car("Toyota", "Land Cruiser", "GT", "Green"), new Person("John", "McCall"));

            //Cars.Add(car);
            //Cars.Add(car2);

            //using (StreamWriter writer = new StreamWriter("cars.xml"))
            //{
            //    serializer.Serialize(writer, Cars);
            //}

            FileStream reader = new FileStream("cars.xml", FileMode.Open, FileAccess.Read, FileShare.Read);

            Cars = (List<RentedCar>)serializer.Deserialize(reader);

            foreach (var car in Cars)
            {
                Console.WriteLine(car);
            }

            string answer = Console.ReadLine();
        }
    }

    [Serializable]
    public class RentedCar
    {
        public Car CurrentCar { get; set; }
        public Person Renter { get; set; }

        public RentedCar() { }

        public RentedCar(Car car, Person renter)
        {
            CurrentCar = car;
            Renter = renter;
        }

        public override string ToString()
        {
            return $"{CurrentCar.Make}-{CurrentCar.Model}-{CurrentCar.Engine}-{CurrentCar.Color}-{Renter.FName}-{Renter.LName}";
        }
    }

    [Serializable]
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }

        public Car() { }

        public Car(string make, string model, string engine, string color)
        {
            Make = make;
            Model = model;
            Engine = engine;
            Color = color;
        }
    }

    [Serializable]
    public class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public Person() { }

        public Person(string fname, string lname)
        {
            FName = fname;
            LName = lname;
        }
    }
}
