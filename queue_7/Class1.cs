using System;
using System.Collections;

class person
{
    public string name;
    public int age;
    public ArrayList c = new ArrayList();
    public Queue<ArrayList> a = new Queue<ArrayList>();
    public void Tostring()
    {
        c.Add(name);
        c.Add((int)age);
        a.Enqueue(c);
        Console.WriteLine("name  age");
        foreach (ArrayList item in a)
        {
            foreach (var v in item)
            {
                Console.Write(v + " ");
            }
        }

    }

}
