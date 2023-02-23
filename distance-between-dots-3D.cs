/* 

Условие задачи:
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */ 

/* при выполнении задания использовался топик https://ru.stackoverflow.com/questions/927564/Расстояние-между-двумя-точками-на-плоскости-и-в-пространстве */

public class Point3D
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}

public static class GeomertyMath
{
    public static double Distance(Point3D p1, Point3D p2)
    {
        return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) 
                         + (p1.Y - p2.Y) * (p1.Y - p2.Y) 
                         + (p1.Z - p2.Z) * (p1.Z - p2.Z));
    }
}

public interface IReaderWriter
{
    Point3D Read3DPoint();
    string ReadLine();
    void WriteLine(string line);
}

public class ConsoleReaderWriter : IReaderWriter
{    public Point3D Read3DPoint()
    {
        Console.Write("Введите координату x: ");
        var x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату y: ");
        var y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату z: ");
        var z = Convert.ToDouble(Console.ReadLine());
        return new Point3D(x, y, z);
    }

    public void WriteLine(string line)
    {
        Console.WriteLine(line);
    }
    public string ReadLine()
    {
        return Console.ReadLine();
    }
}

public class MainScenario
{
    private readonly IReaderWriter _readerWriter;

    public MainScenario(IReaderWriter readerWriter)
    {
        _readerWriter = readerWriter;
    }

    public void Start()
    {
        _readerWriter.WriteLine("Расстояние между двумя точками в Эвклидовом пространстве по заданным координатам");

        Read3DScenario();
        break;

        private void Read3DScenario()
    {
        _readerWriter.WriteLine("Введите первую точку:");
        var p1 = _readerWriter.Read3DPoint();
        _readerWriter.WriteLine("Введите вторую точку:");
        var p2 = _readerWriter.Read3DPoint();
        var distance = GeomertyMath.Distance(p1, p2);
        _readerWriter.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
    }

}  
