
using System;
public class  ElectricScooter : Vehicle
{
    //private field
    int max_speed_limit;
    public ElectricScooter(string vehicle_id, string model, int speed_limit) : base(vehicle_id, model)
    {
        max_speed_limit = speed_limit;
    }
    public int GetMaxSpeedLimit()
    {
        return max_speed_limit;
    }
    //overriding the abstract method from Vehicle class
    public override double calculate_trip_cost(int distance)
    {
        
        int base_rate = 1; // Base rate per kilometer
        double cost_per_min=0.15; // Cost per minute
        return (base_rate+cost_per_min)* distance;
    }

}