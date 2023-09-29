//Variant 6
using System;
class GetX{
    static void Main(){
        Console.WriteLine("Enter initial value of x: ");
        string sxMin = Console.ReadLine();
        Console.WriteLine("Enter the last value of x: ");
        string sxMax = Console.ReadLine();
        Console.Write("Enter increase value: ");
        string sdx = Console.ReadLine();

        double xMin = Double.Parse(sxMin);
        double xMax = Double.Parse(sxMax);
        double dx = double.Parse(sdx);
        
        double x = xMin;
        double y;
        double finalSumY = 0;
        while (x <= xMax){
            y = Math.Pow(x, 2);
            finalSumY += y;
            Console.WriteLine("x = {0}\t\t y = {1}", x, y);
            x += dx;
        }
        if (Math.Abs (x - xMax - dx) > 0.0001){
            y = Math.Pow(xMax, 2);
            finalSumY += y;
            Console.WriteLine("x = {0}\t\t y = {1}",xMax, y);
        }

        Console.WriteLine("The sum of all Y = {0}", finalSumY);

        Console.WriteLine("Do you want to continue?(y/n): ");
        string a = Console.ReadLine();
        if (a == "y"){
            GetY();
        } else if (a == "n"){
            Console.ReadKey();
        } else Console.WriteLine("Incorrect value");

    }
    static void GetY(){
        
        Console.WriteLine("\nEnter the first value of x: ");
        string sx1 = Console.ReadLine();
        Console.WriteLine("Enter the second value of x: ");
        string sx2 = Console.ReadLine();

        int x1 = Int32.Parse(sx1);
        int x2 = int.Parse(sx2);
        
        double y = Math.Sqrt((Math.Cos(2*x2) + x1/x2)/(16*x1*x2));
        
        Console.WriteLine(y);

        Console.ReadKey();
    }
}
