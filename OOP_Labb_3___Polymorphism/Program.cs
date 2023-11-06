namespace OOP_Labb_3___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rektangel = new Rectangle();
            //Geometry rektangel1 = new Rectangle();


            Square fyrkant = new Square();
            //Geometry fyrkant1 = new Square();

            Circle cirkel = new Circle();
            //Geometry cirkel1 = new Circle();

            Console.WriteLine("Area Cirkel : {0:0.00}", cirkel.Area());
            Console.WriteLine("Area Fyrkant : {0:0.00}", fyrkant.Area());
            Console.WriteLine("Area Rektangel : {0:0.00} ", rektangel.Area());
            //Console.WriteLine("Area Rektangel1 : {0:0.00} ", rektangel1.Area());
            //Console.WriteLine("Area Cirkel1 : {0:0.00} ", cirkel1.Area());
            //Console.WriteLine("Area Fyrkant1 : {0:0.00} ", fyrkant1.Area());

            
        }
    }
}