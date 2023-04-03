
using System.Numerics;

namespace DZ_CS_8
{ 

    internal struct StructVector
    {
        int x = 0;
        int y = 0;
        int z = 0;
        public StructVector(int  x, int y, int z)
        {
            this.x = x; 
            this.y = y;
            this.z = z;
        }
        public static StructVector operator +(StructVector vector, StructVector vector1)
        {
            StructVector tmp = new StructVector();
            tmp.x = vector.x + vector1.x;
            tmp.y = vector.y + vector1.y;
            tmp.z = vector.z + vector1.z;

            return tmp;
        }
        public static StructVector operator -(StructVector vector, StructVector vector1)
        {
            StructVector tmp = new StructVector();
            tmp.x = vector.x - vector1.x;
            tmp.y = vector.y - vector1.y;
            tmp.z = vector.z - vector1.z;

            return tmp;
        }
        public static StructVector operator *(StructVector vector, int Value)
        {
            StructVector tmp = new StructVector();
            tmp.x = vector.x * Value;
            tmp.y = vector.y * Value;
            tmp.z = vector.z * Value;


            return tmp;
        }


        public override string ToString()
        {
            return $"X:\t{x}\nY:\t{y}\nZ:\t{z}\n";
        }
    }
}
