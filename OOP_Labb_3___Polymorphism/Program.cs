namespace OOP_Labb_3___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry rektangel1 = new Rectangle();

            Geometry fyrkant1 = new Square();

            Geometry cirkel1 = new Circle();

            Console.WriteLine("Area Rektangel1 : {0:0.00} ", rektangel1.Area());
            Console.WriteLine("Area Cirkel1 : {0:0.00} ", cirkel1.Area());
            Console.WriteLine("Area Fyrkant1 : {0:0.00} ", fyrkant1.Area());

            
        }
    }
}