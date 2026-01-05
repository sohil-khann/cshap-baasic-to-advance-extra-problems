
using System;
public class  ElectricScooter : Vehicle
{

    int max_speed_limit;
    public ElectricScooter(string vehicle_id, string model, int speed_limit) : base(vehicle_id, model)
    {
        max_speed_limit = speed_limit;
    }
    public int GetMaxSpeedLimit()
    {
        return max_speed_limit;
    }
    public override int calculate_trip_cost(int distance)
    {
        int cost_per_km = GetRentalPrice();
        return cost_per_km * distance;
    }

}