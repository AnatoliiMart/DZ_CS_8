
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_CS_8
{
    internal struct RGBConvert
    {
        int r, g, b;
        public RGBConvert(int r, int g, int b) 
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
        public void ToHEX()
        {
            string? hex = Convert.ToString(r, 16) + Convert.ToString(g, 16) + Convert.ToString(b, 16);
            Console.WriteLine("To HEX:\t #" + hex);
           
        }
        public void ToCMYK()
        {
            int R = r / 255;
            int G = g / 255;
            int B = b / 255;
            int max = Math.Max(Math.Max(R, G), B);
           
            int K = 1 - max;
            int C = (1 - R - K) / (1 - K);
            int M = (1 - G - K) / (1 - K);
            int Y = (1 - B - K) / (1 - K);
            string? CYMK = Convert.ToString(C) + Convert.ToString(M) + Convert.ToString(Y) + Convert.ToString(K);
            Console.WriteLine("To CMYK: " + CYMK);


        }
    }
}
