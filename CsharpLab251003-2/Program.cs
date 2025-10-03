// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

public class Testing
{
    public double h;
    public double r;
   
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter height of cylinder");
        double h = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter radius of cylinder");
        double r = Convert.ToDouble(Console.ReadLine());

        double face = Math.Round(r * r * Math.PI,2);
        Console.WriteLine($"Base area is {face}cm^2");

        Calculate t1 = new Calculate();
        double volume = Math.Round(t1.compute(h, r),2);
        Console.WriteLine($"Volume of the cylinder = {volume}cm^3");
        Console.WriteLine($"Volume of the cylinder = {volume/1000000}m^3");

        Console.WriteLine("The fibonacci sequence is a series that takes the last two numbers and adds them");
        Console.WriteLine("Which term would you like to see?");
        int term = Convert.ToInt32(Console.ReadLine());
        Fib f1 = new Fib(term);
        Fib.compute(f1.N);
        }
}

public class Calculate
{
    public double compute(double height, double radius)
    {
        double v = height * (radius * radius * Math.PI);
        return v;
    }
}

public class Fib
{
    public int N;
    
    public Fib(int n)
    {
        N = n;
    }

    public static Fib operator ++(Fib f)
    {
        return new Fib(f.N + 1);
    }

    public static Fib operator +(Fib f, int m)
    {
        return new Fib(f.N + m);
    }

    public static void compute(int term)
    {
        int curValue = 1;
        int preValue = 0;
        Console.WriteLine("\n");
        Console.WriteLine(curValue);
        for (int i = term; i > 0; i--)
        {
            int nextValue = curValue + preValue;
            preValue = curValue;
            curValue = nextValue;
            Console.WriteLine(curValue);
        }
    }
}

