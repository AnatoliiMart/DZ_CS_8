namespace DZ_CS_8
{
    internal struct NumericSystems
    {
        int number;
        public NumericSystems(int  number)
        {
            this.number = number;
        }

        
        public void ToBinary()
        {
            string? str = Convert.ToString(number, 2);
            Console.WriteLine("Number in BINARY:\t" + str);
        }
        public void ToOctal()
        {
            string? str = Convert.ToString(number, 8);
            Console.WriteLine("Number in OCTAL:\t" + str);
        }
        public void ToHex()
        {
            string? str = Convert.ToString(number, 16);
            Console.WriteLine("Number in HEX:\t\t" + str);
        }
    }
}
