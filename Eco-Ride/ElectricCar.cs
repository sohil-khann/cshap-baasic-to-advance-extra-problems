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
    public override int calculate_trip_cost(int distance)
    {
        int cost_per_km = GetRentalPrice();
        return cost_per_km * distance;
    }

}