using System;

class Shape{
    public virtual void DisplayInfo ()  {
        Console.Write ("This is a shape");
    }
}

interface IDisplay{
    void Display ();
}

class Circle:Shape, IDisplay{
    public double radius{ get;set; }
    public override void DisplayInfo (){
        Console.WriteLine ($"This is a circle with a radius of {radius}.");
    }
    public void Display (){
        Console.WriteLine ("Circle displayed.");
    }
    private double getArea(){
        return Math.PI * Math.Pow(radius, 2);
    }
    public void showArea(){
        Console.Write($"The area of the circle is {String.Format("{0:0.00}", getArea())}.\n");
    }
}

class Rectangle : Shape, IDisplay{
    public double width { get;set; }
    public double length { get;set; }
    public override void DisplayInfo(){
        Console.WriteLine($"This is a rectangle with a length of {length} and width of {width}.");
    }
    public void Display(){
        Console.WriteLine("Rectangle displayed.");
    }
    private double getArea(){
        return width * length;
    }
    public void showArea(){
        Console.Write($"The area of the rectangle is {String.Format("{0:0.00}", getArea())}.\n");
    }
}

class Triangle : Shape, IDisplay{
    public double height { get;set; }
    public double side { get;set; }
    public override void DisplayInfo(){
        Console.WriteLine($"This is a triangle with a side of {side} and the height that displayed towards this side is {height}");
    }
    public void Display(){
        Console.Write("Triangle displayed.");
    }
    private double getArea(){
        return 0.5 * side * height;
    }
    public void showArea(){
        Console.Write($"The area of the triangle is {String.Format("{0:0.00}", getArea())}.\n");
    }
}

class Square : Shape, IDisplay{
    public double width { get;set; }
    public double height { get;set; }
    public override void DisplayInfo(){
        Console.WriteLine($"This is a square with a height of {height} and width of {width}.");
    }
    public void Display(){
        Console.WriteLine("Square displayed.");
    }
    private double getArea(){
        return width * height;
    }
    public void showArea(){
        Console.Write($"The area of the square is {String.Format("{0:0.00}", getArea())}.\n");
    }
}

class Program{
    static void Main(){
        Console.Write("Enter the radius of a circle: ");
        double r = Convert.ToDouble(Console.ReadLine());
        
        Circle circle = new Circle{radius = r};
        circle.DisplayInfo();
        circle.showArea();
        circle.Display();
        
        Console.Write("\n");
        
        Console.Write("Enter the width of a rectangle: ");
        double w = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the length of the rectangle: ");
        double l = Convert.ToDouble(Console.ReadLine());
        
        Rectangle rectangle = new Rectangle{width = w, length = l};
        rectangle.DisplayInfo();
        rectangle.showArea();
        rectangle.Display();
        
        Console.Write("\n");
        
        Console.Write("Enter the length of a side of a triangle: ");
        double s = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the width of the height that displayed towards that side: ");
        double h = Convert.ToDouble(Console.ReadLine());
        
        Triangle triangle = new Triangle{side = s, height = h};
        triangle.DisplayInfo();
        triangle.showArea();
        triangle.Display();
        
        Console.Write("\n\n");
        
        Console.Write("Enter the width of a square: ");
        w = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the height of the square: ");
        h = Convert.ToDouble(Console.ReadLine());
        
        Square square = new Square{width = w, height = h};
        square.DisplayInfo();
        square.showArea();
        square.Display();
        
        Console.Write("\n");
    }
}

