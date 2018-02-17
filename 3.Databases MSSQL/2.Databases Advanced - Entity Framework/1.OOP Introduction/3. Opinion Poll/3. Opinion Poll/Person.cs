public class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Person()
    {
        this.Name = "No name";
        this.Age = 1;
    }

    public Person(int age)
    {
        this.Age = age;
        this.Name = "No name";
    }

    public Person(string name, int age)
    {

        this.name = name;
        this.age = age;
    }
}