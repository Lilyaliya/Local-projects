using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Made by Lyn: https://www.sololearn.com/Profile/15088011/?ref=app
//If you do not know what a Hamming code is, I advise you to read this article here (it is in Russian): https://m.habr.com/ru/post/140611/. The Hamming code action algorithm is described in detail here, with examples
namespace SoloLearn
{
    class Program
    {
        static void hamming(char[] chars, out string num)//метод преобразует двоичную строку в код хемминга
        {
            int ch = 0; int k = 0;
            num = new string(chars);
            char[] chars2 = num.ToCharArray();
            do
            {
                for (int i = (int)Math.Pow(2, k) - 1; i < num.Length; i += 2 * (int)Math.Pow(2, k))//считаем количество единичных бит с позиции n,через n бит n бит
                {
                    for (int j = 0; j < Math.Pow(2, k); j++)
                    {
                        if (i + j >= num.Length)
                            break;

                        if (chars[i + j] == '1')
                            ch++;

                    }

                }

                if (ch % 2 != 0)//если количество единичных бит нечетно,то контрольный бит n равен 1,иначе 0
                    chars2[(int)Math.Pow(2, k) - 1] = '1';
                else chars2[(int)Math.Pow(2, k) - 1] = '0';
                num = new string(chars2);
                ch = 0;
                k++;
            } while (Math.Pow(2, k) < num.Length);
        }

        static string codenum(int a)//вычисляет двоичное представление символа
        {
            string str = null;
            while (a > 0)
            {
                if (a % 2 == 1)
                    str = "1" + str;
                else str = "0" + str;
                a = a >> 1;
            }
            int t = str.Length;
            while (t < 8)
            {
                str = "0" + str;
                t++;
            }
            return str;
        }

        static int convert(string str)//переводит двоичное представление символа в кодовое
        {
            int record = 0;
            char[] chars1 = str.ToCharArray();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (chars1[i] == '1')
                    record = record + (int)Math.Pow(2, str.Length - 1 - i);
            }
            return record;
        }

        static string concentrate(string prcode)//убираем контрольные биты
        {
            string score = null; int k = 0;
            for (int i = 0; i < prcode.Length; i++)
            {
                if (i == (int)Math.Pow(2, k) - 1)
                {
                    k++;
                    continue;
                }
                score = score + prcode[i];
            }
            return score;
        }

        static int index(string prcode, string code, char[] chars)
        {
            int k = 0; int schet = 0;


            while (Math.Pow(2, k) < prcode.Length)
            {
                chars[(int)Math.Pow(2, k) - 1] = '0';//обнуляем контрольные биты
                k++;
            }
            k = 0;
            code = new string(chars);//code-строка представляет собой строку с обнуленными контрольными битами с ошибкой

            hamming(chars, out code);//определяем значения контрольных бит

            while (Math.Pow(2, k) < code.Length)//ищем расхождения в битах и складываем индексы
            {
                if (prcode[(int)Math.Pow(2, k) - 1] != code[(int)Math.Pow(2, k) - 1])
                    schet += (int)Math.Pow(2, k);
                k++;
            }
            //сумма индексов расхожих бит равняется индексу ошибочного бита
            return schet;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("\ufeff");
            Console.WriteLine("Введите строку(не используйте иной алфавит,кроме английского)");
            Console.WriteLine("Enter a string (do not use a alphabet other than English)");

            string s = Console.ReadLine();//enter the message
            Console.WriteLine("Ваша строка");
            Console.WriteLine("Your line\n\n {0}", s);
            int a; int k = 0;
            string num = null;
            string sox = null;
            char[] chars = new char[] { };
            foreach (char c in s)
            {
                a = (int)c;//кодовое значение символа

                num = codenum(a);//двоичное представление символа

                while (Math.Pow(2, k) < num.Length)//добавление контрольных бит
                {
                    num = num.Insert((int)Math.Pow(2, k) - 1, "0");
                    k++;
                }
                k = 0;
                chars = num.ToCharArray();


                hamming(chars, out num);//изменение контрольных бит
                sox = sox + num;//хеммингова двоичная строка


            }

            Random rnd = new Random();
            int pos; int b;
            int[] codnum = new int[] { 0, 1, 3, 7, 15 };
            string code = null;
            string score = null;
            int schet = 0;
            int record;

            pos = rnd.Next(0, sox.Length);//выбирается индекс бита,который будет ошибочным
            while (Array.IndexOf(codnum, pos % num.Length) != -1)
            {
                pos = rnd.Next(0, sox.Length);
            }

            chars = sox.ToCharArray();
            if (chars[pos] == '1')
                chars[pos] = '0';
            else chars[pos] = '1';//делаем ошибку
            sox = new string(chars);
            string s2 = null;
            Console.WriteLine();
            foreach (char c in s)
            {
                score = sox.Substring(k * num.Length, num.Length);
                score = concentrate(score);
                b = convert(score);
                s2 = s2 + (char)b;
                k++;
            }
            Console.WriteLine("Переданное сообщение");
            Console.WriteLine("Transmitted message\n");
            Console.WriteLine(s2);//выводим сообщение с ошибкой
            Console.WriteLine("\nУпс, ваше сообщение передалось с ошибкой");
            Console.WriteLine("Oops, your message was transmitted with an error");
            Console.WriteLine("\nПрименяем код Хэмминга...");
            Console.WriteLine("Apply the Hamming code...");
            k = 0;
            b = 0;
            string prcode;
            do
            {
                code = sox.Substring(b * num.Length, num.Length);//двоичный код символа,в котором мы допустим ошибку
                chars = code.ToCharArray();
                prcode = new string(chars);
                schet = index(prcode, code, chars);//вычисление суммы индексов расхожих бит
                b++;
            } while (schet == 0);

            chars = prcode.ToCharArray();
            if (chars[schet - 1] == '1')
                chars[schet - 1] = '0';
            else chars[schet - 1] = '1';
            prcode = new string(chars);//исправляем ошибку

            score = concentrate(prcode);//убираю контрольные биты

            record = convert(score);

            chars = s2.ToCharArray();
            chars[b - 1] = (char)record;
            s2 = new string(chars);
            Console.WriteLine("\nВаше сообщение (исправленное)");
            Console.WriteLine("Your message (corrected)\n");
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
