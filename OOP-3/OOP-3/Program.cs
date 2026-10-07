using DeliverySystem;
using DeliverySystem.SmartDeliveryManagementSystem;
namespace OOP_3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions

            #region Question 01
            // a)  What is the difference between Method Overloading and Method Overriding?
            // Method Overloading is a feature that allows a class to have multiple methods with the same name but different parameters (different type, number, or order of parameters). It is resolved at compile time (static polymorphism).
            // Method Overriding is a feature that allows a child class to provide a specific implementation of a method that is already defined in its parent class. It is resolved at runtime (dynamic polymorphism).


            //b)  What is the difference between Static Binding and Dynamic Binding?
            // Static Binding occurs at compile time, where the method to be called is determined based on the reference type. It is associated with method overloading
            // Dynamic Binding occurs at runtime, where the method to be called is determined based on the actual object type. It is associated with method overriding.

            #endregion

            #region Sealed Classes 
            //a)  What is the purpose of the sealed keyword when applied to a class?
            //The sealed keyword prevents a class from being inherited by another class

            //b)  What is the difference between a sealed class and a sealed method?
            // A sealed class cannot be inherited, while a sealed method can be overridden in a derived class but cannot be further overridden in any subclass of that derived class

            //c)  Can a sealed method be overridden? Why?
            // No, a sealed method cannot be overridden becaus it is marked as final in the inheritance hierarchy preventing any further overriding in subclasses

            #endregion

            #endregion

            #region Main() Checklist

            #region creat DeliveryCenter
            // Create a DeliveryCenter object with a driver name.
            Console.WriteLine("Enter Driver Name: ");
            string driverName = Console.ReadLine()!;

            // Create a DeliveryCenter object with the driver name.
            DeliveryCenter deliveryCenter = new DeliveryCenter(driverName);
            #endregion

            #region Creat StanderdShipment
            bool flag = false;

            //Read the tracking code from the user.
            Console.Write("Tracking Code: ");
            string trackingCode = Console.ReadLine();

            //Read the description from the user.
            Console.Write("Description: ");
            string description = Console.ReadLine();

            // Get weight from user
            decimal weight;
            do
            {
                Console.Write("Enter Valid Weight: ");
                flag = decimal.TryParse(Console.ReadLine(), out weight);
            }
            while (!flag || weight <= 0);

            // Get DeliveryFee from user
            decimal deliveryFee;
            do
            {
                Console.Write("Enter Valid Delivery Fee: ");
                flag = decimal.TryParse(Console.ReadLine(), out deliveryFee);
            }
            while (!flag || deliveryFee <= 0);

            //Create one StandardShipment.
            StandardShipment standardShipment = new StandardShipment(
                trackingCode,
                description,
                weight,
                deliveryFee
                );

            Console.WriteLine();

            // Add StandardShipment
            if (deliveryCenter.AddShipment(standardShipment))
            {
                Console.WriteLine("Shipment Add Successfully ");

            }
            Console.WriteLine("--------------------------");
            #endregion

            #region Creat ExpressShipment

            //Read the tracking code from the user.
            Console.Write("Tracking Code: ");
            string ExpressTrackingCode = Console.ReadLine();

            //Read the description from the user.
            Console.Write("Description: ");
            string ExpressDescription = Console.ReadLine();

            // Get weight from user
            decimal ExpressWeight;
            do
            {
                Console.Write("Enter Valid Weight: ");
                flag = decimal.TryParse(Console.ReadLine(), out ExpressWeight);
            }
            while (!flag || ExpressWeight <= 0);

            // Get DeliveryFee from user
            decimal ExpressDeliveryFee;
            do
            {
                Console.Write("Enter Valid Delivery Fee: ");
                flag = decimal.TryParse(Console.ReadLine(), out ExpressDeliveryFee);
            }
            while (!flag || ExpressDeliveryFee <= 0);

            // Get extraFee from user
            decimal ExpressExtraFee;
            do
            {
                Console.Write("Enter Valid Extra Fee: ");
                flag = decimal.TryParse(Console.ReadLine(), out ExpressExtraFee);
            }
            while (!flag || ExpressExtraFee < 0);


            //Create one ExpressShipment.
            ExpressShipment expressShipment = new ExpressShipment(
                ExpressTrackingCode,
                ExpressDescription,
                ExpressWeight,
                ExpressDeliveryFee,
                ExpressExtraFee
                );

            Console.WriteLine();

            // Add ExpressShipment
            if (deliveryCenter.AddShipment(expressShipment))
            {
                Console.WriteLine("Shipment Add Successfully ");

            }
            Console.WriteLine("--------------------------");

            #endregion

            #region Creat InternationlShipment

            //Read the tracking code from the user.
            Console.Write("Tracking Code: ");
            string InternationlTrackingCode = Console.ReadLine();

            //Read the description from the user.
            Console.Write("Description: ");
            string InternationlDescription = Console.ReadLine();

            // Get weight from user
            decimal InternationlWeight;
            do
            {
                Console.Write("Enter Valid Weight: ");
                flag = decimal.TryParse(Console.ReadLine(), out InternationlWeight);
            }
            while (!flag || InternationlWeight <= 0);

            // Get DeliveryFee from user
            decimal InternationlDeliveryFee;
            do
            {
                Console.Write("Enter Valid Delivery Fee: ");
                flag = decimal.TryParse(Console.ReadLine(), out InternationlDeliveryFee);
            }
            while (!flag || InternationlDeliveryFee <= 0);

            // Get customsFee from user
            decimal customsFee;
            do
            {
                Console.Write("Enter Valid customs Fee: ");
                flag = decimal.TryParse(Console.ReadLine(), out customsFee);
            }
            while (!flag || customsFee < 0);

            //Read destinationCountry from user
            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine();

            //Create one ExpressShipment.
            InternationalShipment internationlShipment = new InternationalShipment(
                InternationlTrackingCode,
                InternationlDescription,
                InternationlWeight,
                InternationlDeliveryFee,
                destinationCountry,
                customsFee
                );

            Console.WriteLine();

            // Add ExpressShipment
            if (deliveryCenter.AddShipment(internationlShipment))
            {
                Console.WriteLine("Shipment Add Successfully ");

            }
            Console.WriteLine("--------------------------");

            #endregion

            #region print All Shipments

            Console.WriteLine();
            Console.WriteLine("print all shipments with delivery center: ");

            // Print all shipments in the delivery center.
            deliveryCenter.printAll();

            Console.WriteLine();
            #endregion

            #region print shipment with deliveryHelper

            Console.WriteLine();
            Console.WriteLine("print shipments using DeliveryHelper: ");
            
            // Print all shipments using DeliveryHelper.
            DeliveryHelper.PrintShipment(standardShipment);
            DeliveryHelper.PrintShipment(expressShipment);
            DeliveryHelper.PrintShipment(internationlShipment);

            Console.WriteLine();

            #endregion

            #region Test UpdateWeight().
            // Test the UpdateWeight() first overload method with one parameter.
            standardShipment.UpdateWeight(10);
            Console.WriteLine($"Updated Weight: {standardShipment.Weight}");

            Console.WriteLine();

            // Test the UpdateWeight() second overload method with two parameters.
            standardShipment.UpdateWeight(10, 5);
            Console.WriteLine($"Updated Weight: {standardShipment.Weight}");

            Console.WriteLine("-------------------------");

            #endregion

            #region Shipment With Mixed types

            Console.WriteLine();
            Console.WriteLine("print all shipments using polymorphism: ");

            // Create an array of Shipment objects with mixed types.
            Shipment[] shipments = new Shipment[3];
            shipments[0] = standardShipment;
            shipments[1] = expressShipment;
            shipments[2] = internationlShipment;

            // Print all shipments using polymorphism.
            for (int i = 0; i < shipments.Length; i++)
            {
                shipments[i].PrintShipment();
                Console.WriteLine("---------------------------");
            }

            #endregion



            #endregion
        }
    }
}
