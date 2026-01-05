using System;
public abstract class Vehicle


{
    //abstract method to calculate trip cost
    public abstract int calculate_trip_cost(int distance);
    //private fields
    private string Vehicle_id { get; set; }
    private string Model { get; set; }
    private byte Battery_percentage { get; set; }
    private bool Maintenance_Status { get; set; }
    private int Rental_Price { get; set; }
    public Vehicle(string vehicle_id, string model)
    {
        Vehicle_id = vehicle_id;
        Model = model;



    }//getter and setter methods
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
    {//validation for battery percentage
        if (percentage <=100 && percentage>=0)
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