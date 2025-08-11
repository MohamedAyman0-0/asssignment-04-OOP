#region part01 
#region Q1
public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Add(int a, int b, int c) => a + b + c;

    public double Add(double a, double b) => a + b;
}
#endregion
#region Q2
public class Rectangle
{
    public int Width { get; }
    public int Height { get; }


    public Rectangle()
    {
        Width = 0;
        Height = 0;
    }


    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }


    public Rectangle(int side)
    {
        Width = side;
        Height = side;
    }
}
#endregion
#region Q3 
public class ComplexNumber
{
    public double Real { get; }
    public double Imaginary { get; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }


    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }


    public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    }

    public override string ToString() => $"{Real} + {Imaginary}i";
}

#endregion
#region Q4.a
public class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee is working");
    }
}
#endregion
#region Q4.b
public class Manager : Employee
{
    public override void Work()
    {
        base.Work();
        Console.WriteLine("Manager is managing");
    }
}
#endregion
#region Q5.a
public class BaseClass
{
    public virtual void DisplayMessage()
    {
        Console.WriteLine("Message from BaseClass");
    }
}
#endregion
#region Q5.b
public class DerivedClass1 : BaseClass
{
    public override void DisplayMessage()
    {
        Console.WriteLine("Message from DerivedClass1");
    }
}
#endregion
#region q5.c
public class DerivedClass2 : BaseClass
{
    public new void DisplayMessage()
    {
        Console.WriteLine("Message from DerivedClass2 (hidden)");
    }
}
#endregion
#endregion
#region part2 
#region Q1
public class Duration
{
    public int Hours { get; }
    public int Minutes { get; }
    public int Seconds { get; }

    public Duration(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
}
#endregion
#region Q2
public class d
{
    public int Hours { get; }
    public int Minutes { get; }
    public int Seconds { get; }

    public d (int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public override string ToString()
    {
        return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
    }

    public override bool Equals(object obj)
    {
        if (obj is not Duration other) return false;

        return Hours == other.Hours
            && Minutes == other.Minutes
            && Seconds == other.Seconds;
    }

    public override int GetHashCode()
    {
        
        return HashCode.Combine(Hours, Minutes, Seconds);
    }
}

#endregion
#region Q3

#endregion
#region Q4

#endregion
#region

#endregion
#endregion