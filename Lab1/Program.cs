namespace Lab1
{

public class Rectangle
{

    private double sideA;
    private double sideB;

    public Rectangle(double sideA, double sideB)
    {
        if (sideA <= 0 || sideB <= 0)
            throw new ArgumentException("Длины сторон не могут быть отрицательными или равны нулю.");
        this.sideA = sideA;
        this.sideB = sideB;
    }

    private double CalculateArea()
    {
        return sideA * sideB;
    }

    private double CalculatePerimeter()
    {
        return 2 * (sideA + sideB);
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите длину стороны A: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Введите длину стороны B: ");
        double sideB = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(sideA, sideB);
        Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");
        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
    }
}
}