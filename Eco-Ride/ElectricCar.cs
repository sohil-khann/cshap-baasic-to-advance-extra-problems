using System;
public class  ElectricCar : Vehicle
{
    int seatingCapacity;
    public ElectricCar(string vehicle_id, string model, int capacity) : base(vehicle_id, model)
    {
        seatingCapacity = capacity;
    }
    public int GetSeatingCapacity()
    {
        return seatingCapacity;
    }
}