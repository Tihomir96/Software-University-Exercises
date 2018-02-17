public interface IAmmunition
{
    string Name { get; }

    double Weight { get; }

    double WearLevel { get; }

    int Number { get; set; }
    // int Number { get; set; }

    void DecreaseWearLevel(double wearAmount);
}
