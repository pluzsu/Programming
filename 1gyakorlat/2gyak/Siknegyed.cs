using System;

public class Siknegyed
{
    //static void Main(string[] args)
    public Siknegyed()
    {
        double x, y;
        int p = 0; 

        Console.Write("x: ");
        double.TryParse(Console.ReadLine(), out x);
        Console.Write("y: ");
        double.TryParse(Console.ReadLine(), out y);
            
        if (x>=0) {
            if (y>=0) {
                p=1;
            }
            else
            {
                p=4;
            }
        } else {
            if (y>=0)
            {
                p=2;
            }
            else
            {
                p=3;
            }
        }
        
        Console.WriteLine("Síknegyed: {0}", p);
    }
}
