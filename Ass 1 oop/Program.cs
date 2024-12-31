namespace Ass_1_oop
{


   
    internal class Program
    {

        static double CalculateDistance(Point p1, Point p2)
        {
            double deltaX = p2.X - p1.X;
            double deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }


        static void Main(string[] args)
        {
           
            
            
            Console.Write("Enter the X  of the first point: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the Y  of the first point: ");
            double y1 = double.Parse(Console.ReadLine());
            // طلب إدخال النقطة الثانية من المستخدم
            Console.Write("Enter the X  of the second point: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the Y  of the second point: ");
            double y2 = double.Parse(Console.ReadLine());


            Point po1 = new Point(x1, y1); 
            Point po2 = new Point(x2, y2);

            double distance = CalculateDistance(po1, po2);
            Console.WriteLine($"The distance between the two points is: {distance}");

        }
    }
}