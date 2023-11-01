namespace OOP_Labb_3___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rektangel = new Rectangle();
            Square fyrkant = new Square();
            Circle cirkel = new Circle();

            Console.WriteLine("Area Cirkel : {0:0.00}", cirkel.Area());
            Console.WriteLine("Area Fyrkant : {0:0.00}", fyrkant.Area());
            Console.WriteLine("Area Rektangel : {0:0.00} ", rektangel.Area());

        }
    }
}