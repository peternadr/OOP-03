namespace DeliverySystem.SmartDeliveryManagementSystem;

static public class DeliveryHelper
{
    public static void PrintShipment(Shipment shipment)
    {
        if (shipment == null)
        {
            return;
        }
        shipment.PrintShipment();
        Console.WriteLine("------------------------------");
    }
}
