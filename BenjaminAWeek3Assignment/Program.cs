namespace Week3Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in the speed limit"); //Program asks for speed limit of the street/road.

            int limit = Convert.ToInt32(Console.ReadLine()); //Input speed limit of street or road.
            
            Console.WriteLine("Speed Limit: " + limit + "mph"); // Program states speed limit of street/road.

            Car a = new Car(); //Car one for speed test

            Car b = new Car(); //Car one for speed test

            Car c = new Car(); //Car one for speed test

            Console.WriteLine("Enter the speed of the first car: "); //Program asks for speed of first car.

            a.speed = Convert.ToInt32(Console.ReadLine()); //Input speed for driver one.

            Console.WriteLine("Enter the speed of the second car: "); //Program asks for speed of second car.

            b.speed = Convert.ToInt32(Console.ReadLine()); //Input speed for driver two.

            Console.WriteLine("Enter the speed of the third car: "); //Program asks for speed of third car.

            c.speed = Convert.ToInt32(Console.ReadLine()); //Input speed for driver three.

            Console.WriteLine("Enter the make of the first car: "); //Program asks make for first car.

            a.make = Console.ReadLine(); //Input make for driver one.

            Console.WriteLine("Enter the make of the second car: "); //Program asks make for second car.

            b.make = Console.ReadLine(); //Input make for driver two.

            Console.WriteLine("Enter the make of the third car: "); //Program asks make for third car.

            c.make = Console.ReadLine(); //Input make for driver three.

            Console.WriteLine("Enter the model of the first car: "); //Program asks model for first car.

            a.model = Console.ReadLine(); //Input model for driver one.

            Console.WriteLine("Enter the model of the second car: "); //Program asks model for second car.

            b.model = Console.ReadLine(); //Input model for driver two.

            Console.WriteLine("Enter the model of the third car: "); //Program asks model for third car.

            c.model = Console.ReadLine(); //Input model for driver three.

            string totalA = a.make + " " + a.model + " " + a.speed;
            string totalB = b.make + " " + b.model + " " + b.speed;
            string totalC = c.make + " " + c.model + " " + c.speed;

            //Car A

            if (a.speed <= limit)
            {
                Console.WriteLine(totalA + "mph: OK "); //Program states car one is obeying the law.
            }
            else if (a.speed > limit)
            {
                int over = a.speed - limit;
                int demerits = over / 5;
                if (demerits > 10)
               

                    Console.WriteLine(totalA +  "mph" + demerits +  "<LICENSE SUSPENDED>"); //Program states car one getting their license suspended.

                else if (demerits < 9 && demerits > 0)

                    Console.WriteLine(totalA + "mph" + demerits + " demerits "); //Program states car one is going too fast.
            }
            
            //Car B
            if (b.speed <= limit)
            {
                Console.WriteLine(totalB + "mph : OK "); //Program states car two is obeying the law.
            }
            else if (b.speed > limit)
            {
                int over = b.speed - limit;
                int demerits = over / 5;
                    if (demerits > 10)
                       
                        Console.WriteLine(totalB + "mph: " + demerits + " <LICENSE SUSPENDED>"); //Program states car two is getting their license suspended
                else if (demerits < 9 && demerits > 0)

                        Console.WriteLine(totalB + "mph: " + demerits + " demerits "); //Program states car two is going too fast.
            }
            //Car C
            if (c.speed <= limit)
            {
                Console.WriteLine(totalC + "mph : OK "); //Program states car three is obeying the law.
            }
            else if (c.speed > limit)
            {
                int over = c.speed - limit;
                int demerits = over / 5;
                    if (demerits > 10)

                        Console.WriteLine(totalC + "mph: " + demerits + " demerits <LICENSE SUSPENDED>"); //Program states car three getting their license suspended.

                    else if (demerits < 9 && demerits > 0)

                        Console.WriteLine(totalC + "mph: " + demerits + " demerits "); //Program states car three is going too fast.
            }

        }    
            public class Car
            {

            public int speed;
            public string make;
            public string model;
            
            }
    }
}