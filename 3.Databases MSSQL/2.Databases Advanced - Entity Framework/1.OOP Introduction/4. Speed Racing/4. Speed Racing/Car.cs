using System;
public class Car
{
    private string model;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    private double fuelAmount;

    public double FuelAmount
    {
        get { return fuelAmount; }
        set { fuelAmount = value; }
    }
    private double fuelConsumption;

    public double FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }

    private int distanceTravelled;

    public int DistanceTravelled
    {
        get { return distanceTravelled; }
        set { distanceTravelled = value; }
    }

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumption = fuelConsumption;
    }

    public bool CanCarMove(int kmToTravell)
    {
         var consumption = kmToTravell * this.FuelConsumption;
        if (this.FuelAmount - consumption > 0)
        {
            return true;
        }
        return false;
    }
    public void Drive(int kmToTravell)
    {
        if (CanCarMove(kmToTravell))
        {
            this.FuelAmount -= kmToTravell * this.FuelConsumption;
            this.DistanceTravelled += kmToTravell;
        }
        else
        {
           throw new Exception("Insufficient fuel for the drive");
        }
        
    }
}