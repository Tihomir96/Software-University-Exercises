public abstract class Monument
{
    private string name;
    public string Name
    {
        get { return this.name; }
    }

    protected Monument(string name)
    {
        this.name = name;
    }
}

