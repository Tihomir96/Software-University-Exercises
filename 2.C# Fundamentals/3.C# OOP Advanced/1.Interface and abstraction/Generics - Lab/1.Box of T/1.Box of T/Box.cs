using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Box<T>
{
    private List<T> data;

    public Box()
    {
        this.data= new List<T>();
    }
    public void Add(T element)
    {
        this.data.Add(element);
    }

    public string Remove()
    {
        var rem = this.data.LastOrDefault();
        this.data.Remove(rem);
        return rem.ToString();        
    }

    public int Count => this.data.Count;


}

