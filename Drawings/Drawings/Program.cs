using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Numerics;
using System.IO;

namespace Drawings
{
    class Program
    {

        static void Convertic(BigInteger bob, string way)
        {

            bob /= 17;

            string bytes = null;
            while (bob > 0)
            {
                bytes = bob % 2 + bytes;
                bob >>= 1;
            }
            if (bytes.Length < 1802)
                bytes = new string('0', 1802 - bytes.Length) + bytes;

            Bitmap b = new Bitmap(106, 17);

            //using (Graphics g = Graphics.FromImage(b)) {  g.Clear(Color.White); }
            string[] li = new string[17];
            for (int i = 0; i <1802; i++)
            {
                li[i % 17]= bytes[1801-i]+li[i%17];
            }
            for (int y = 0; y < 17; y++)
                for (int x = 0; x < 106; x++)
                {
                    int pix = Convert.ToInt32(li[y][x].ToString()) * 255;
                    b.SetPixel(105 - x, 16 - y, Color.FromArgb(pix,pix,pix));
                }
            b.Save(@way);
            DrawImage(b);

        }


        public class CieLab
        {
            public double L { get; set; }
            public double A { get; set; }
            public double B { get; set; }

            public static double DeltaE(CieLab l1, CieLab l2)
            {
                return Math.Pow(l1.L - l2.L, 2) + Math.Pow(l1.A - l2.A, 2) + Math.Pow(l1.B - l2.B, 2);
            }

            public static CieLab Combine(CieLab l1, CieLab l2, double amount)
            {
                var l = l1.L * amount + l2.L * (1 - amount);
                var a = l1.A * amount + l2.A * (1 - amount);
                var b = l1.B * amount + l2.B * (1 - amount);

                return new CieLab { L = l, A = a, B = b };
            }
        }

        public static CieLab RGBtoLab(int red, int green, int blue)
        {
            var rLinear = red / 255.0;
            var gLinear = green / 255.0;
            var bLinear = blue / 255.0;

            double r = rLinear > 0.04045 ? Math.Pow((rLinear + 0.055) / (1 + 0.055), 2.2) : (rLinear / 12.92);
            double g = gLinear > 0.04045 ? Math.Pow((gLinear + 0.055) / (1 + 0.055), 2.2) : (gLinear / 12.92);
            double b = bLinear > 0.04045 ? Math.Pow((bLinear + 0.055) / (1 + 0.055), 2.2) : (bLinear / 12.92);

            var x = r * 0.4124 + g * 0.3576 + b * 0.1805;
            var y = r * 0.2126 + g * 0.7152 + b * 0.0722;
            var z = r * 0.0193 + g * 0.1192 + b * 0.9505;

            Func<double, double> Fxyz = t => ((t > 0.008856) ? Math.Pow(t, (1.0 / 3.0)) : (7.787 * t + 16.0 / 116.0));

            return new CieLab
            {
                L = 116.0 * Fxyz(y / 1.0) - 16,
                A = 500.0 * (Fxyz(x / 0.9505) - Fxyz(y / 1.0)),
                B = 200.0 * (Fxyz(y / 1.0) - Fxyz(z / 1.0890))
            };
        }

        class ConsolePixel
        {
            public char Char { get; set; }

            public ConsoleColor Forecolor { get; set; }
            public ConsoleColor Backcolor { get; set; }
            public CieLab Lab { get; set; }
        }

        static List<ConsolePixel> pixels;

        private static void ComputeColors()
        {
            pixels = new List<ConsolePixel>();

           // char[] chars = { '█', '▓', '▒', '░' };

            int[] rs = { 0, 0, 0, 0, 128, 128, 128, 192, 128, 0, 0, 0, 255, 255, 255, 255 };
            int[] gs = { 0, 0, 128, 128, 0, 0, 128, 192, 128, 0, 255, 255, 0, 0, 255, 255 };
            int[] bs = { 0, 128, 0, 128, 0, 128, 0, 192, 128, 255, 0, 255, 0, 255, 0, 255 };

            for (int i = 0; i < 16; i++)
                for (int j = i + 1; j < 16; j++)
                {
                    var l1 = RGBtoLab(rs[i], gs[i], bs[i]);
                    var l2 = RGBtoLab(rs[j], gs[j], bs[j]);

                    for (int k = 0; k < 4; k++)
                    {
                        var l = CieLab.Combine(l1, l2, (4 - k) / 4.0);

                        pixels.Add(new ConsolePixel
                        {
                            Char = '█',
                            Forecolor = (ConsoleColor)i,
                            Backcolor = (ConsoleColor)j,
                            Lab = l
                        });
                    }
                }
        }

       
        public static void Conversion(Bitmap srch)
        {
            int width = srch.Width; int height = srch.Height; string byteSet = null;
      
                for (int x = width-1; x >=0; x--)
                    for (int y = 0; y <height; y++)
                    {
                        var any = srch.GetPixel(x, y);
                   // Console.WriteLine("{0} {1} {2}", any.R, any.G, any.B);
                        if (any.R < 127 && any.G <127 && any.B < 127)
                            byteSet += "0";
                        else byteSet += "1";
                    }
            BigInteger first = new BigInteger(2);
           
            for (int i = byteSet.Length - 1; i >= 0; i--)
                firs2 = BigInteger.Add(firs2, Convert.ToInt32(byteSet[i].ToString()) * BigInteger.Pow(first, byteSet.Length-i-1));
            firs2 *= 17;
        }
        public static void DrawImage(Bitmap source)
        {
            // int width = Console.WindowWidth - 1;
            //int height = (int)(width * source.Height / 2.0 / source.Width);
            int width = source.Width; int height = source.Height; 
            
            using (var bmp = new Bitmap(source, width, height))
            {
                var unit = GraphicsUnit.Pixel;

              

                using (var src = bmp.Clone(bmp.GetBounds(ref unit), PixelFormat.Format24bppRgb))
                {
                    var bits = src.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, src.PixelFormat);
                    byte[] data = new byte[bits.Stride * bits.Height];

                    Marshal.Copy(bits.Scan0, data, 0, data.Length);

                    for (int j = 0; j < height; j++)
                    {
                        StringBuilder builder = new StringBuilder();
                        var fore = ConsoleColor.White;
                        var back = ConsoleColor.Black;

                        for (int i = 0; i < width; i++)
                        {
                            int idx = j * bits.Stride + i * 3;
                            var pixel = DrawPixel(data[idx + 2], data[idx + 1], data[idx + 0]);

                            if (pixel.Forecolor != fore || pixel.Backcolor != back)
                            {
                                Console.ForegroundColor = fore;
                                Console.BackgroundColor = back;
                                Console.Write(builder);

                                builder.Clear();
                            }

                            fore = pixel.Forecolor;
                            back = pixel.Backcolor;
                            builder.Append(pixel.Char);
                        }

                        Console.ForegroundColor = fore;
                        Console.BackgroundColor = back;
                        Console.WriteLine(builder);
                    }
                  

                    Console.ResetColor();
                }
            }
        }

        private static ConsolePixel DrawPixel(int r, int g, int b)
        {
            var l = RGBtoLab(r, g, b);

            double diff = double.MaxValue;
            var pixel = pixels[0];

            foreach (var item in pixels)
            {
                var delta = CieLab.DeltaE(l, item.Lab);
                if (delta < diff)
                {
                    diff = delta;
                    pixel = item;
                }
            }

            return pixel;
        }

        public static BigInteger firs2 = new BigInteger(0);
        static void Main()
        {
            
                ComputeColors();
            Console.WriteLine("Изображение в k? [y] [n]");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("Укажите путь к картинке 106x17");
                string way = Console.ReadLine();
               //way = @"C:\1.png";
                Bitmap image = new Bitmap(@way, true);
                Conversion(image);
                DrawImage(image);
                Console.WriteLine(firs2.ToString());
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Введите число k");

                Stream inputStream = Console.OpenStandardInput(1024);
                byte[] bytes = new byte[1024];
                int outputLength = inputStream.Read(bytes, 0, 1024);
                char[] chars = Encoding.UTF7.GetChars(bytes, 0, outputLength);
                string chislo = new string(chars);
                BigInteger bob = BigInteger.Parse(chislo);
                Console.WriteLine("Создайте пустой файл изображения и укажите к нему путь для сохранения");
                string w = Console.ReadLine();
                Convertic(bob, w);
                Console.ReadLine();
            }
            
        }
    }
}
