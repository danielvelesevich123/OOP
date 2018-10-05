using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab2
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            //1.a
            System.SByte sByte = 1;
            System.Int16 int16 = 1;
            System.Int32 int32 = 1;
            System.Int64 int64 = 1;
            System.Byte Byte = 1;
            System.UInt16 uint16 = 1;
            System.UInt32 uint32 = 1;
            System.UInt64 uint64 = 1;
            System.Char Char = 'q';
            System.Boolean Bool = true;
            System.Single Float = 12.5f;
            System.Double Double = 12.5;
            System.Decimal Decimal = 124532426;
            System.String String = "asdfdsg";
            System.Object Object = "Danik";

            //1.b
            int16 = sByte;
            int64 = int32;
            uint16 = Byte;
            uint64 = uint32;
            Double = Float;

            sByte = (sbyte) int32;
            int32 = (int) int64;
            Byte = (byte) int64;
            Float = (float) Double;
            int64 = (long) Decimal;

            //1.c
            object boxingInt32 = int32;
            int unboxingInt32 = (int) boxingInt32;

            //1.d
            var arrInt32 = new[] {2, 5, 4, 6};
            Console.Write(arrInt32.GetType());
            Console.WriteLine();

            //1.e
            int? nullableType = null;
            nullableType = 5;


            //2.a
            string String1 = "Danik";
            string String2 = "DANIK";
            Console.WriteLine("{0} {2} {1}\n", String, String2, String == String2 ? "==" : "!=");

            //2.b
            String Str1 = "str1";
            String Str2 = "str2";
            String Str3 = "str3";
            String Str4 = "str4";

            Console.WriteLine("{0}\n", String.Concat(Str1, Str2, Str3));
            Str2 = String.Copy(Str1);
            Console.WriteLine("{0}\n", Str2);
            Console.WriteLine("{0}\n", Str3.Substring(2));
            Console.WriteLine("{2} {1} {0}\n", Str4.Split(' ')[0], Str4.Split(' ')[1], Str4.Split(' ')[2]);
            Console.WriteLine("{0}\n", Str4.Insert(2, Str1));
            Console.WriteLine("{0}\n", Str4.Remove(2, Str1.Length - 1));

            //2.c
            String Empty = "";
            String Null = null;
            Console.WriteLine("{0}\t{1}\n", Empty.Length, Empty == Null);

            //2.d
            StringBuilder NewString = new StringBuilder("My Group ", 50);
            Console.WriteLine("{0}\n", NewString.Remove(1, 2));
            Console.WriteLine("{0}\n", NewString.Remove(0, 1));
            Console.WriteLine("{0}\n", NewString.Insert(0, "Fourth "));
            Console.WriteLine("{0}\n", NewString.Insert(NewString.Length, "is the best"));


            //3.a
            int[,] Matrix = new int[,] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            //3.b
            string[] massivOfString = new string[] {"str1", "str2", "str3", "str4", "str5"};

            for (int i = 0; i < massivOfString.Length; i++)
                Console.Write(massivOfString[i]);
            Console.WriteLine("Sentence.Length = " + massivOfString.Length);
            Console.WriteLine("\nWrite position and substitution");

            int position = Int32.Parse(Console.ReadLine());
            massivOfString[position] = Console.ReadLine();
            for (int i = 0; i < massivOfString.Length; i++)
                Console.Write(massivOfString[i]);
            Console.WriteLine();

            //3.c
            float[][] FloatArray = new float[3][];
            FloatArray[0] = new float[2];
            FloatArray[1] = new float[3];
            FloatArray[2] = new float[4];
            Console.WriteLine("Write float numbers");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < FloatArray[i].Length; j++)
                {
                    Console.Write("FloatArray[{0}][{1}] ", i, j);
                    FloatArray[i][j] = Convert.ToSingle(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < FloatArray[i].Length; j++)
                {
                    Console.Write(FloatArray[i][j] + " ");
                }

                Console.WriteLine();
            }

            //3.d
            var VarArray = new[] {1, 2, 3};
            var VarString = "VarString";
            Console.WriteLine("------------------------");

            //4.a
            (int DefaultInt, string DefaultString, char DefaultChar, string DefaultString2, ulong DefaultUlong) Default = (1, "qq ", 'q', "qqqqq ", 1000000);

            //4.b
            Console.WriteLine($"{Default}");

            //4.c
            Console.WriteLine(Default.DefaultInt + " " + Default.DefaultChar + " " + Default.DefaultString2);

            //4.d
            var (First, Second, Third, Fourth, Fifth) = (Default.DefaultInt, Default.DefaultString, Default.DefaultChar,
                Default.DefaultString2, Default.DefaultUlong);

            //4.e
            var Type_1 = (a: 13, b: 'A');
            var Type_2 = (c: 13, d: 'A');
            Console.WriteLine("Кортежи {0} и {1} - {2}", Type_1, Type_2,
                Object.Equals(Type_1, Type_2) ? "равны\n" : "не равны\n");

            Console.WriteLine("------------------------");

            //5
            

            Console.WriteLine("your massiv:");
            int[] yourMassiv = new int[4];
            for (int i = 0; i < yourMassiv.Length; i++)
            {
                Console.WriteLine("yourMassiv[{0}]", i);
                yourMassiv[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("your string:");
            string yourString = Console.ReadLine();
            Console.WriteLine(MainFunction(yourMassiv, yourString));
            Console.ReadKey(true);

            (int, int, int, char) MainFunction(int[] arr, string str)
            {
                return (arr.Max(), arr.Min(), arr.Sum(), str.First());
            }
        }

    }
}