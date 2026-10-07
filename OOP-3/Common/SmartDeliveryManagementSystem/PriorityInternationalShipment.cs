namespace DeliverySystem.SmartDeliveryManagementSystem;

internal class PriorityInternationalShipment : InternationalShipment
{
    public sealed override void GenerateCustomsReport()
    {
        base.GenerateCustomsReport();
    }
}

//class SpecialShipment : PriorityInternationalShipment
//{

//    // public override void GenerateCustomsReport()
//    // {
//    // }
// cannot override a sealed method
//}
