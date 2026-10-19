namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            #region part01 assignment05

            #region q1
            //a) Both variables refer to the same object in memory
            //b) No. It only copies the reference to the existing object
            //c) Copying an object creates a new object in memory but copying its reference makes two variables point to the same object

            #endregion

            #region q2
            //a) A Shallow Copy creates a new object but shares references to nested objects with the original
            //b) A Deep Copy creates a new object and independent copies of its nested objects
            //c) Their references are copied so both objects refer to the same object
            //d) Independent copies of object so changes to one do not affect the other
            //e)When copying a shipment that contains a delivery address,
            //  Deep Copy is safer because changing the copied shipment's address will not affect the original shipment
            #endregion

            #region q3

            //a) A static field belongs to the class and is shared by all objects but instance field belongs to each object
            //b) A static method belongs to the class and can be called without creating an object ,no it cannot directly access instance members
            //c) A static constructor initializes the class's static data. It runs automatically only once, before the class is first used
            //d) A static class contains only static members, No you cannot create an object from a static class

            #endregion

            #region q4
            //a)An Extension Method allows us to add new method-like functionality to an existing type without modifying its original code or inheriting from it
            //b) this
            //c) It must be declared in static class
            //d) No It cannot directly access private members because it is not actually part of the original class
            #endregion

            #region q5

            //a) A Partial Class allows a single class to be divided into multiple parts
            //b) To organize code and improve readability
            //d) is a method whose declaration and implementation can be written in different parts of a partial class
            //e) If the partial method is optional, the compiler removes its declaration and calls. Otherwise, a compilation error occurs


            #endregion

            #endregion

            #region part02
            Shipment sh01 = standardShipment;
            Shipment sh02 = sh01;
            Console.WriteLine("Original Shipment : " + sh01.TrackingCode);
            Console.WriteLine("Assigned Shipment : " + sh02.TrackingCode);
            Console.WriteLine(ReferenceEquals(sh01, sh02));

            Shipment shallow = standardShipment.ShallowCopy();
            
            Console.WriteLine("Original Shipment : " + sh01.Destination.City);
            Console.WriteLine("copied : " + shallow.Destination.City);

            shallow.Destination.City = "qina";

            Console.WriteLine("Original Shipment : " + sh01.Destination.City);
            Console.WriteLine("copied : " + shallow.Destination.City);

            Console.WriteLine("Same DeliveryAddress Object : " +ReferenceEquals(sh01.Destination, shallow.Destination));

            Shipment deep= standardShipment.DeepCopy();

            Console.WriteLine("Original Shipment : " + sh01.Destination.City);
            Console.WriteLine("copied : " + deep.Destination.City);
            shallow.Destination.City = "alex";
            Console.WriteLine("Original Shipment : " + sh01.Destination.City);
            Console.WriteLine("copied : " + deep.Destination.City);

            Console.WriteLine("Same DeliveryAddress Object : " + ReferenceEquals(sh01.Destination, deep.Destination));

            Console.WriteLine(standardShipment.GetSummary());
            Console.WriteLine(expressShipment.GetSummary());
            Console.WriteLine(internationalShipment.GetSummary());

            Console.WriteLine(standardShipment.TrackingCode + " Is Delivered : " + standardShipment.IsDelivered());

            Console.WriteLine(internationalShipment.TrackingCode + " Is Delivered : " +internationalShipment.IsDelivered());

            standardShipment.UpdateTrackingStatus("Out For Delivery");

            DeliveryUtilities.PrintSystemTitle();
            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Total Shipments Created : " +Shipment.GetTotalShipmentsCreated());

            standardShipment.UpdateTrackingStatus("Delivered");


            #endregion




        }
    }
}
 