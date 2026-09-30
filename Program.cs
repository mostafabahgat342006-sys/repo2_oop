namespace c__oop_ass2;

internal class Program
{
    static void Main(string[] args)
    {
        /*

             Q1)
                 a- class -> reference type , accept null , support inheritance
                    struct -> value type , not accept null , not support inheritance 


                 b- Classes are more suitable for large applications 
                    because they support inheritance, polymorphism, encapsulation,
                    and complex relationships.



             Q2) 

                 a- shipment
                 b- ExpressShipment
                 c- TrackingCode is inherited by ExpressShipment.
                 d- Inheritance avoids code duplication, improves code reuse, easier to maintain.

         */

    
            DeliveryCenter center = new DeliveryCenter();

            Console.Write("Enter Center Name: ");
            center.CenterName = Console.ReadLine();

            Console.WriteLine("\nEnter Standard Shipment Data:");

            Console.Write("Tracking Code: ");
            string trackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("Street: ");
            string street = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber = int.Parse(Console.ReadLine());



            DeliveryAddress destination =
                new DeliveryAddress(city, street, buildingNumber);

            StandardShipment standard = new StandardShipment(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination
            );


            Console.WriteLine("\nEnter Express Shipment Data:");

            Console.Write("Tracking Code: ");
            string expressTrackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string expressDescription = Console.ReadLine();

            Console.Write("Weight: ");
            decimal expressWeight = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal expressDeliveryFee = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string expressCity = Console.ReadLine();

            Console.Write("Street: ");
            string expressStreet = Console.ReadLine();

            Console.Write("Building Number: ");
            int expressBuildingNumber = int.Parse(Console.ReadLine());

            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress expressDestination =
                new DeliveryAddress(
                    expressCity,
                    expressStreet,
                    expressBuildingNumber
                );

            ExpressShipment express = new ExpressShipment(
                expressTrackingCode,
                expressDescription,
                expressWeight,
                expressDeliveryFee,
                expressDestination,
                extraFee
            );




            Console.WriteLine("\nEnter International Shipment Data:");

            Console.Write("Tracking Code: ");
            string internationalTrackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string internationalDescription = Console.ReadLine();

            Console.Write("Weight: ");
            decimal internationalWeight = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal internationalDeliveryFee = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string internationalCity = Console.ReadLine();

            Console.Write("Street: ");
            string internationalStreet = Console.ReadLine();

            Console.Write("Building Number: ");
            int internationalBuildingNumber = int.Parse(Console.ReadLine());

            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine();

            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress internationalDestination =
                new DeliveryAddress(
                    internationalCity,
                    internationalStreet,
                    internationalBuildingNumber
                );

            InternationalShipment international = new InternationalShipment(
                internationalTrackingCode,
                internationalDescription,
                internationalWeight,
                internationalDeliveryFee,
                internationalDestination,
                destinationCountry,
                customsFee
            );


            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);


            Console.WriteLine("\nAll Shipments:");
            center.PrintAllShipments();


            Console.Write("\nEnter Tracking Code to search: ");
            string searchCode = Console.ReadLine();

            Shipment found = center[searchCode];

            if (found != null)
            {
                found.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }


            Console.Write("\nEnter Tracking Code to remove: ");
            string removeCode = Console.ReadLine();

            bool removed = center.RemoveShipment(removeCode);

            if (removed)
            {
                Console.WriteLine("Shipment removed successfully.");
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }


            Console.WriteLine("\nRemaining Shipments now:");
            center.PrintAllShipments();
        }
    }








