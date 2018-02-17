public class Medium : Mission
{
    public const double MediumEnduranceRequired = 50;
    public Medium( double scoreToComplete) : base(MediumEnduranceRequired, scoreToComplete)
    {
        this.Name = "Capturing dangerous criminals";
    }
}

