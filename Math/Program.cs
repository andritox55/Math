namespace AreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //referens för Parentclass
            Geometri Ref;
            
            //Referens som pekar mot alla klasser
            Ref = new Rektangel();
            Console.WriteLine($"Area Rektangel: {Ref.Area()}");

            Ref = new Fyrkant();
            Console.WriteLine($"Area Fyrkan: {Ref.Area()}");

            Ref = new Cirkel();
            Console.WriteLine($"Area Cirkel: {Ref.Area()}");

            Ref = new Parallellogram();
            Console.WriteLine($"Area Parallellogram: {Ref.Area()}");

            Ref = new Ellips();
            Console.WriteLine($"Area Ellips: {Ref.Area()}");
        }
    }
}