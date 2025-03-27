using System;

abstract class Shape{
    
    public abstract double CalculateArea();
    
    public void Display(double area){
        Console.Write($"\n\nThe area of your selected shape is {area:f2}");
    }

}

class Circle: Shape{

    public override double CalculateArea(){
        
        Console.Write("\nEnter the diameter of the Circle: ");
        double diameter = Convert.ToDouble(Console.ReadLine());
        
        double area = 3.14159265359 * ((diameter/2) * (diameter/2));
        
        return area;
    }
    
}

class Rectangle: Shape{
    
    public override double CalculateArea(){
        
        Console.Write("\nEnter the length of the Rectangle: ");
        double l = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the width of the Rectangle: ");
        double w = Convert.ToDouble(Console.ReadLine());
        
        double area = l*w;
        
        return area;
    }
    
}

class Triangle: Shape{

    public override double CalculateArea(){
        
        Console.Write("\nEnter the base of the Rectangle: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the height of the Rectangle: ");
        double h = Convert.ToDouble(Console.ReadLine());
        
        double area = (b*h)/2;
        
        return area;
    }
    
}

class Program{
    
    public static void Main() {
        
        char choice = 'y';
        
        do{
            Console.Write("\n1. Circle\n2. Rectangle\n3. Triangle\n\n");
          
            Console.Write("Choose the Shape you want to get the area: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            double area = 0;
            
            if(num == 1){
                Circle obj = new Circle();
                area = obj.CalculateArea();
                obj.Display(area);
            }
            else if(num == 2){
                Rectangle obj = new Rectangle();
                area = obj.CalculateArea();
                obj.Display(area);
            }
            else if(num == 3){
                Triangle obj = new Triangle();
                area = obj.CalculateArea();
                obj.Display(area);
            }
            else{
                Console.WriteLine("Invalid input, please try again.");
            } 
            
            Console.Write("\n\nEnter 'y' if you want to do another area computation otherwise enter any other keys: ");
            choice = Convert.ToChar(Console.ReadLine());
            
      } while(choice == 'y' || choice == 'Y');
      
    }
}