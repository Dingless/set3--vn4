using System;

public class Program
{

    public static void Main(string[] args)
    {
        double basen = 5.0; //  basen av triangeln
        double höjden = 3.0; //  höjden av triangeln

        double area = RightTriangleArea(basen, höjden); // Anropar metoden RightTriangleArea med basen och höjden som parametrar och ger resultatet till variabeln area

        Console.WriteLine("Arean av triangeln är: " + area); // Skriver ut resultatet av arean till konsolen
    }

    // Metod som tar två flyttal som parametrar och ger arean av en rätvinklig triangel
    public static double RightTriangleArea(double b, double h)
    {
        return (b * h) / 2; // get till arean av den rätvinkliga triangeln
    }
}