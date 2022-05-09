using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - done

            //Create 3 classes called Car , Truck , & SUV - done 

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common. - done
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company - done 
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size - done 
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. - done
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            //SUV Class instanciation 

            SUV envoyGMC = new SUV();
            envoyGMC.RowCount = 3;
            envoyGMC.OffRoadCapable = "No";
            envoyGMC.Name = "GMC";
            envoyGMC.Model = "Envoy";
            envoyGMC.Hood = "It has a hood";
            envoyGMC.SteeringWheel = "steering wheel";
            envoyGMC.MilesPerGallon = 14;
            envoyGMC.Bluetooth = "Yes, it does!";

            Console.WriteLine("Today, we're discussing the " + envoyGMC.Name + " " + envoyGMC.Model);
            Console.ReadKey();
            Console.WriteLine( envoyGMC.Hood + ", " + envoyGMC.RowCount + " rows of seats, and you're asking if it has bluetooth? " + envoyGMC.Bluetooth);
            Console.ReadKey();

            Truck toyotaTundra = new Truck();
            toyotaTundra.WeightCapacity = 15000;
            toyotaTundra.WheelCount = 4;
            toyotaTundra.Name = "Toyota";
            toyotaTundra.Model = "Tundra";
            toyotaTundra.Hood = "This also has a hood, ";
            toyotaTundra.SteeringWheel = "steering wheel";
            toyotaTundra.MilesPerGallon = 8;
            toyotaTundra.Bluetooth = "The bluetooth isn't as smooth, but still works";

            Console.WriteLine("Next, we have the " + toyotaTundra.Name + " " + toyotaTundra.Model);
            Console.WriteLine(toyotaTundra.Hood + toyotaTundra.WheelCount + " wheels, and a " + toyotaTundra.SteeringWheel);
            Console.WriteLine("It only has " + toyotaTundra.MilesPerGallon + " miles on the gallon. " + toyotaTundra.Bluetooth);
            Console.WriteLine("BUT it can hold like " + toyotaTundra.WeightCapacity + " lbs no problem");
            Console.ReadKey();

            Car hondaCivic= new Car();
            hondaCivic.Sedan = "This model comes in a sedan, 4 door version ";
            hondaCivic.Coupe = "buttt is also avaiable as a 2 door model, your choice!";
            hondaCivic.Name = "Honda";
            hondaCivic.Model = "Civic";
            hondaCivic.Hood = "Small hood, but a ";
            hondaCivic.SteeringWheel = "smooothhhhhh steering wheel";
            hondaCivic.MilesPerGallon = 25;
            hondaCivic.Bluetooth = "bluetooth on this runs perfectly, with NO delays or interuptions - EVER";

            Console.WriteLine("Last but not least! We have the " + hondaCivic.Name + " " + hondaCivic.Model);
            Console.WriteLine(hondaCivic.Sedan + hondaCivic.Coupe);
            Console.WriteLine(hondaCivic.Hood + hondaCivic.SteeringWheel);
            Console.WriteLine("Running on a generous " + hondaCivic.MilesPerGallon + " MPG - this will be easy on your wallet");
            Console.WriteLine("Also, the " + hondaCivic.Bluetooth);


        }
    }
}
