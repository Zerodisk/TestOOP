using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOOP.Ording;
using TestOOP.Ording.Supplier;
using TestOOP.Interfaces;
using TestOOP.Patterns.Strategy;
//using TestOOP.Patterns.Observer;
using TestOOP.Patterns.Observer2;
using TestOOP.Patterns.Decorator;
using TestOOP.Patterns.Singleton;
using TestOOP.Patterns.State;

namespace TestOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            TestVirtual testVirtual = new TestVirtual();
            Console.WriteLine(testVirtual.resultA);         //using method from overrride
            Console.WriteLine(testVirtual.resultB);         //using method from base class

            Console.WriteLine(testVirtual.add(1,2));        //using method from overrride
            Console.WriteLine(testVirtual.substract(9,1));  //using method from base class
            Console.WriteLine();
            //======================================================================================

            SealMethod sealMethod = new SealMethod();
            Console.WriteLine(sealMethod.add(1, 1));
            Console.WriteLine(sealMethod.substract(2, 2));
            Console.WriteLine(sealMethod.multipy(2, 2));
            Console.WriteLine();
            //======================================================================================

            ProtectBase protectBase = new ProtectBase();
            TestProtected testProtected = new TestProtected();
            // below will have complier error as "add" method can only be used inside TestProtected 
            //Console.WriteLine(TestProtected.add(4, 5));
            Console.WriteLine();
            //======================================================================================

            // below will have compier error - abstract can't be instantiate
            //AbstractBase ab = new AbstractBase();
            TestAbstract testAb = new TestAbstract();
            Console.WriteLine(testAb.add(3, 8));
            Console.WriteLine();
            //======================================================================================

            Console.WriteLine("---- test order system ----");
            Order order = new Order { Id = 1, FirstName = "Tan", Email = "tan@email.com", Price = 10.50M };
            OrderingFactory factory = new OrderingFactory();
            IOrderProcess orderA = factory.GetOrderSupplier("A");
            orderA.MakeOrder(order);

            Console.WriteLine("");

            IOrderProcess orderB = factory.GetOrderSupplier("B");
            orderB.MakeOrder(order);

            Console.WriteLine("");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("");
            Console.WriteLine(Multi10000(1,1));
            Console.WriteLine();
            //======================================================================================
            IStore store = new Document();
            ICompress compress = new Document();
            store.Read();
            store.Write();
            compress.Compress();
            compress.Decompress();

            using (SimpleClass simple = new SimpleClass())
            {
                Console.WriteLine(simple.returnA());
            }
            Console.WriteLine();
            //======================================================================================

            
            Duck d1 = new DecoyDuck();
            d1.Display();
            d1.PerformFly();
            d1.PerformQuack();
            Duck d2 = new RubberDuck();
            d2.Display();
            d2.PerformFly();
            d2.PerformQuack();
            Console.WriteLine();
            //======================================================================================

            /*
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currDisplay = new CurrentConditionsDisplay(weatherData);
            ForecastDisplay foreDisplay = new ForecastDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            */

            Console.WriteLine();
            //======================================================================================

            WeatherTracker provider = new WeatherTracker();

            CurrentConditionsDisplay currDisplay = new CurrentConditionsDisplay(provider);
            ForecastDisplay foreDisplay = new ForecastDisplay(provider);

            provider.UpdateWeather(new WeatherData(80, 65, 30.4f));

            Console.WriteLine();
            //======================================================================================
            BeverageBase beverage = new Decaf();
            Console.WriteLine(beverage.Description
                + " $" + beverage.cost());

            BeverageBase beverage2 = new DarkRoast();
            beverage2 = new Milk(beverage2);
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.Description
                + " $" + beverage2.cost());


            Console.WriteLine();
            //======================================================================================
            Console.WriteLine(Singleton.Instant.getTest());
            Console.WriteLine(Singleton.Instant.getTest());
            Console.WriteLine(Singleton.Instant.getTest());


            Console.WriteLine();
            //======================================================================================
            Booking booking = new Booking { BookingId = 1, SupplierCode = "GTA", FirstName = "Tan", LastName = "Tang", TotalAmount = (decimal)299.99 };
            ProcessBooking bookingProcess = new ProcessBooking(booking);
            bookingProcess.Initial();
            Console.WriteLine("  Booking State = {0}, Status = {1}",  booking.State.ToString(), booking.Status);

            bookingProcess.PreAuthorisation();
            Console.WriteLine("  Booking State = {0}, Status = {1}", booking.State.ToString(), booking.Status);

            bookingProcess.MakeBooking();
            Console.WriteLine("  Booking State = {0}, Status = {1}", booking.State.ToString(), booking.Status);

            bookingProcess.MakePayment();
            Console.WriteLine("  Booking State = {0}, Status = {1}", booking.State.ToString(), booking.Status);

            bookingProcess.FinaliseBooking();
            Console.WriteLine("  Booking State = {0}, Status = {1}", booking.State.ToString(), booking.Status);


            Console.Read();
        }

        static int Multi10000(int a, int b)
        {
            int result = 0;
            int oldA = 0;
            int oldB = 0;
            bool check = true;
            while (result <= 10000)
            {
                if (check)
                {
                    oldA = a;
                    a = a + 1;
                }
                else {
                    oldB = b;
                    b = b + 1;
                }

                check = !check;
                result = a * b;
            }
            return oldA * oldB;
        }
    }

    class a
    {
        public virtual int add(int a, int b)
        {
            return a + b;
        }
    }
    class b : a
    {
        public  override int add(int a, int b)
        {
            return a + b + 1;
        }

    }
    class c : b
    {
        public override int add(int a, int b)
        {
            return a + b + 2;
        }
    }




    class TryOverrideSealMethod : SealMethod 
    {
        public override int add(int a, int b)
        {
            return a + b + 10;
        }

        // below will give complier error
        /*
        public override int multipy(int a, int b)
        {

        }
        */

    }
}
