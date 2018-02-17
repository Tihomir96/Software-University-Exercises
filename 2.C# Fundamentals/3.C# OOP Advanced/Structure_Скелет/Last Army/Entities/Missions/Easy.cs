public class Easy:Mission,IMission
{
    public const double EasyEnduranceRequired = 20;

    public Easy( double scoreToComplete) : base(EasyEnduranceRequired,scoreToComplete)
    {
        this.Name = "Suppression of civil rebellion";
    }
}

