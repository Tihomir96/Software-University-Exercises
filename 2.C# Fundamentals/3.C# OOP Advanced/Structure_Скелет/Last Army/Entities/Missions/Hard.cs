public class Hard : Mission
{
    public const double HardEnduranceRequired = 80;

    public Hard( double scoreToComplete) : base(HardEnduranceRequired,scoreToComplete)
    {
        this.Name = "Disposal of terrorists";
    }
}

