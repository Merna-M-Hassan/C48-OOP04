namespace Assignment_8_C__OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1) a)
            //What is Abstraction in Object-Oriented Programming?

            /*
             * Abstraction: hiding complex implementation details and showing only the essential features of an object.
             * Showing only what's necessary and hiding how it's done.
             * Focusing on what an object does, not how it does it
             */
            #endregion

            #region Q1) b)
            //Why is abstraction considered one of the four pillars of OOP?

            /*
             * Because it simplifies complexity by focusing on what the object does (what the object does), not the complex how it does.
             * Also provides a blueprint for other pillars. Enables encapsulation (defines "what" and encapsulation defines "how"), polymorphism (provides the common interface for different implementations), and inheritance (provides the blueprint for class hierarchies).
             * It is the starting point for all OOP design.
             */
            #endregion

            #region Q2) a)
            // What is the difference between an Abstract Class and an Interface?

            /*
             * Abstract class: can have fields, can have constructors, can use public, private, and protected access modifiers, class can inherite one class only.
             * Serves as a base for other classes and can not be instantiated.
             * Use abstract class when classes are related and share code.
             * 
             * Inferface: can not have fields, can not have constructors, can only use public access modifier, class can implement mutiple interfaces.
             * A contract that classes must follow. It contains only method signatures (without implementation).
             */
            #endregion

            #region Q2) b)
            //When would you choose an Interface instead of an Abstract Class?

            /*
             *Use interface when unrelated classses need to implement the same behavior. Also, if a multiple behaviors is need to be implemented.
             */
            #endregion

            #region Q2) c)
            //Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?

            /*
             * No, a class can not inherit from multiple abstract classes. Yes, can implement multiple interface, because interface supports multiple implementation.
             */
            #endregion

            #region Q8)
            Console.WriteLine("Delivery Center");
            Console.WriteLine("===========================================");
            Console.WriteLine();

            // Create addresses
            DeliveryAddress addr1 = new DeliveryAddress("Cairo", "Tahrir Street", 15);
            DeliveryAddress addr2 = new DeliveryAddress("Alexandria", "Corniche", 20);
            DeliveryAddress addr3 = new DeliveryAddress("Giza", "Pyramids Street", 10);

            // a. Create one StandardShipment.
            StandardShipment standard = new StandardShipment("SH001", "Laptop", 3, 80, addr1);

            // b. Create one ExpressShipment.
            ExpressShipment express = new ExpressShipment("SH002", "Mobile Phone", 2, 60, addr2, 30);

            // c. Create one InternationalShipment.
            InternationalShipment international = new InternationalShipment("SH003", "Television", 8, 120, addr3, "Germany", 100);

            // d. Add all shipments to the DeliveryCenter.
            DeliveryCenter center = new DeliveryCenter("Main Center");
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            // e. Print all shipment details.
            Console.WriteLine("Standard Shipment");
            Console.WriteLine("---");
            Console.WriteLine($"Tracking Code : {standard.TrackingCode}");
            Console.WriteLine($"Description  : {standard.Description}");
            Console.WriteLine($"Estimated Cost: {standard.EstimatedCost} EGP");
            Console.WriteLine();

            Console.WriteLine("Express Shipment");
            Console.WriteLine("---");
            Console.WriteLine($"Tracking Code : {express.TrackingCode}");
            Console.WriteLine($"Extra Fee    : {express.ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {express.EstimatedCost} EGP");
            Console.WriteLine();

            Console.WriteLine("International Shipment");
            Console.WriteLine("---");
            Console.WriteLine($"Tracking Code    : {international.TrackingCode}");
            Console.WriteLine($"Destination Country   : {international.DestinationCountry}");
            Console.WriteLine($"Estimated Cost    : {international.EstimatedCost} EGP");
            Console.WriteLine();

            // f. Print the tracking status of every shipment.
            Console.WriteLine("Tracking Status");
            Console.WriteLine("---");
            Console.WriteLine(standard.GetTrackingStatus());
            Console.WriteLine(express.GetTrackingStatus());
            Console.WriteLine(international.GetTrackingStatus());
            Console.WriteLine();

            // g. Print the insurance cost of every shipment.
            Console.WriteLine("Insurance");
            Console.WriteLine("---");
            Console.WriteLine($"Standard Shipment Insurance : {standard.CalculateInsurance()} EGP");
            Console.WriteLine($"Express Shipment Insurance : {express.CalculateInsurance()} EGP");
            Console.WriteLine($"International Shipment Insurance : {international.CalculateInsurance()} EGP");
            Console.WriteLine();

            // h. Store the shipment objects in an ITrackable[] array and print their tracking statuses.
            ITrackable[] trackables = new ITrackable[]
            {
                standard,
                express,
                international
            };

            // i. Store the shipment objects in an IInsurable[] array and print their insurance values.
            IInsurable[] insurables = new IInsurable[]
            {
                standard,
                express,
                international
            };

            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
            #endregion
        }
    }
}
