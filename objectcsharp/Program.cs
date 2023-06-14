internal class Program
{
    private static void Main(string[] args)
    {
        vip vipp = new vip();
        normal normp = new normal();
        int person;

        Console.WriteLine("Enter the number of persons: ");
        person = int.Parse(Console.ReadLine());

        if (person > 100 && person <= 500)
        {
            vipp.info();
        }
        else
        {
            normp.info();
        }
    }
}
public class details
{
    public int id;
    public string fullname;
    public int chirno;
}

public class vip : details
{
    public int vtno;
    public void info()
    {
        
        Console.WriteLine("welcome big man you are most valuable");
    }
}
public class normal : details
{
    public int ntno;
    public void info()
    {
        Console.WriteLine("welcome here a gain");
    }
}