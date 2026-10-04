namespace DeliverySystem.SmartDeliveryManagementSystem;

public class DeliveryHelper
{
    public static void PrintShipment(Shipment shipment)
    {
        if (shipment == null)
        {
            return;
        }
        shipment.PrintShipment();
    }
}
