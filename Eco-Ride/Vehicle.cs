using System;
public class Vehicle
{
    public string Vehicle_id { get; set; }
    public string Model { get; set; }
    public byte Battery_percentage { get; set; }
    public Vehicle(string vehicle_id, string model, int battery_percentage)
    {
        Vehicle_id = vehicle_id;
        Model = model;
        Battery_percentage = battery_percentage;
       
    }
    //public override string ToString()
    //{
    //    return $"";
    //}
}