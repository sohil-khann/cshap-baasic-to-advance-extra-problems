using System;
public class  ElectricCar : Vehicle
{
    //private field
    int seatingCapacity;
    public ElectricCar(string vehicle_id, string model, int capacity) : base(vehicle_id, model)
    {
        seatingCapacity = capacity;
    }
    public int GetSeatingCapacity()
    {
        return seatingCapacity;
    }

    //overriding the abstract method from Vehicle class
    public override int calculate_trip_cost(int distance)
    {

        int base_rate = 5; // Base rate per kilometer
        double cost_per_km = 0.5; // Cost per kilometer
        return (base_rate + cost_per_km) * distance;
    }

}