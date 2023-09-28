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
        while (x <= xMax){
            y = Math.Pow(x, 2);
            Console.WriteLine("x = {0}\t\t y = {1}", x, y);
            x += dx;
        }
        if (Math.Abs (x - xMax - dx) > 0.0001){
            y = Math.Pow(xMax, 2);
            Console.WriteLine("x = {0}\t\t y = {1}",xMax, y);
        }
        Console.ReadKey();
    }
}