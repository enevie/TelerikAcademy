using System;

    class Quadratic
    {
        static void Main()
        {
            while (true)
            {
            Console.WriteLine("enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("enter c: ");
            double c = double.Parse(Console.ReadLine());

            double desk = Math.Pow(b,2)- (4 * a * c);
    
            if(desk==0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine("x1=x2= : " +x1);
            }
            else if (desk > 0)
            {
                double x1 = (-b + Math.Sqrt(desk)) / (2*a);
                double x2 = (-b - Math.Sqrt(desk)) / (2*a);
                Console.WriteLine("x1: {0,-3}, x2: {1}", x1,x2);
            }
            else
            {
                Console.WriteLine("D<0, no real roots");
            }
            Console.ReadLine();
            Console.Clear();
        }

    }
}


