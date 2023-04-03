namespace DZ_CS_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
       static void Ex1()
        {
            StructVector vector  = new StructVector(4, 4, 4);
            StructVector vector1 = new StructVector(1, 1, 1);

            Console.WriteLine("Addition of vectors");
            StructVector vector2 = vector1 + vector;
            Console.WriteLine(vector2.ToString());

            Console.WriteLine("Substraction of vectors");
            vector2 = vector1 - vector;
            Console.WriteLine(vector2.ToString());

            Console.WriteLine("Multiplication vector on integer value");
            vector2 = vector2 * 5;
            Console.WriteLine(vector2.ToString());
        }
        static void Ex2()
        {
            Console.WriteLine("Enter the number for converting:");
            int number = Convert.ToInt32(Console.ReadLine());

            NumericSystems numericSystems = new(number);

            numericSystems.ToBinary();
            numericSystems.ToOctal();
            numericSystems.ToHex();
        }
        void Ex3()
        {
            RGBConvert rGBConvert = new RGBConvert(255, 255, 255);
            rGBConvert.ToHEX();
            rGBConvert.ToCMYK();
        }
    }
}