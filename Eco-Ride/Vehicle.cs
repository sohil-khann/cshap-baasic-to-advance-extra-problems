using System;
public class Vehicle
{
    private string Vehicle_id { get; set; }
    private string Model { get; set; }
    private byte Battery_percentage { get; set; }
    private bool Maintenance_Status { get; set; }
    private int Rental_Price { get; set; }
    public Vehicle(string vehicle_id, string model)
    {
        Vehicle_id = vehicle_id;
        Model = model;

        

    }
    public bool GetMaintenanceStatus()
    {
        return Maintenance_Status;
    }
    public void SetMaintenanceStatus(bool status)
    {
        Maintenance_Status = status;
    }
    public int GetRentalPrice()
    {
        return Rental_Price;
    }
    public void SetRentalPrice(int price)
    {

        Rental_Price = price;
    }
    public void SetBatteryPercentage(byte percentage)
    {
        if(percentage <=100 && percentage>=0)
        {
            Battery_percentage = percentage;

        }
        else
        {
            Console.WriteLine("Invalid Battery Percentage");
        }
    }

    //public override string ToString()
    //{
    //    return $"";
    //}
}