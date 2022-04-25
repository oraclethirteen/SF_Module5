using System;

namespace SF_Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* (I)
            (string Name, string[] Dishes) User;

            User.Dishes = new string[5];

            Console.WriteLine("Введите ваше имя");

            User.Name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Назовите 5 ваших любимых блюд");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Блюдо №{0}: ", i + 1);
                User.Dishes[i] = Console.ReadLine();
            }
            */

            /* (II)
            static string ShowColor()
            {
                var color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }

                return color;
            }

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }

            Console.WriteLine();
            Console.WriteLine("Ваши любимые цвета:");

            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }

            Console.ReadKey();
            */

            /* (III) [5.1.6]
            static int[] GetArrayFromConsole()
            {
                var result = new int[5];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }

                int num = 0;

                for (int k = 0; k < result.Length; k++)
                {   
                    for (int j = k + 1; j < result.Length; j++)
                    {
                        if (result[j] < result[k])
                        {
                            num = result[j];
                            result[j] = result[k];
                            result[k] = num;
                        }
                    }
                }

                Console.WriteLine();

                foreach (var chr in result)
                {
                    Console.WriteLine(chr);
                }

                return result;
            }

            GetArrayFromConsole();
            */

            /* (IV) [5.2.2 - 5.2.3, 5.2.7]
            static string ShowColor(string username, int userage)
            {
                Console.WriteLine("{0}, {1} лет \nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);

                var color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }

                return color;
            }

            static void ShowColors(string username, params string[] favcolors)
            {
                Console.WriteLine("{0}, ваши любимые цвета:", username);

                foreach (var color in favcolors)
                {
                    Console.WriteLine(color);
                }
            }

            var (name, age) = ("Andrew", 23);

            Console.WriteLine("My name: {0}", name);
            Console.WriteLine("My age: {0}", age);

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name: {0}", name);
            Console.WriteLine("Your age: {0}", age);

            Console.WriteLine();

            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name, age);
            }

            Console.WriteLine();

            ShowColors(name, favcolors);

            Console.ReadKey();
            */

            /* (V) [5.2.8]
            static int[] GetArrayFromConsole()
            {
                var result = new int[5];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }

                return result;
            }

            static int[] SortArray(int[] result)
            {
                int num = 0;

                for (int k = 0; k < result.Length; k++)
                {
                    for (int j = k + 1; j < result.Length; j++)
                    {
                        if (result[j] < result[k])
                        {
                            num = result[j];
                            result[j] = result[k];
                            result[k] = num;
                        }
                    }
                }

                return result;
            }
            */

            /* (VI) [5.2.14 - 5.2.15, 5.2.17 - 5.2.18]
            static int[] GetArrayFromConsole(int num = 5)
            {
                var result = new int[num];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }

                return result;
            }

            static int[] SortArray(int[] result)
            {
                int num = 0;

                for (int k = 0; k < result.Length; k++)
                {
                    for (int j = k + 1; j < result.Length; j++)
                    {
                        if (result[j] < result[k])
                        {
                            num = result[j];
                            result[j] = result[k];
                            result[k] = num;
                        }
                    }
                }

                return result;
            }

            var array = GetArrayFromConsole();

            var sortedarray = SortArray(array);

            static void ShowArray(int[] arr, bool IsSort = false)
            {
                var nums = arr;

                if (IsSort)
                {
                    nums = SortArray(arr);
                }

                foreach (var num in nums)
                {
                    Console.WriteLine(num);
                }
            }

            Console.WriteLine();

            ShowArray(array);

            Console.WriteLine();

            var ar = GetArrayFromConsole(10);
            ShowArray(ar, true);
            */

            /* (VII) [5.3.1]
            var someAge = 23;
            Console.WriteLine(someAge);

            ChangeAge(someAge);
            Console.WriteLine(someAge);

            Console.ReadKey();

            static void ChangeAge(int age)
            {
                Console.WriteLine("Введите возраст:");
                age = Convert.ToInt32(Console.ReadLine());
            }
            */

            /* (VIII) [5.3.3]
            var someName = "Евгения";
            Console.WriteLine(someName);

            GetName(ref someName);

            Console.WriteLine(someName);

            Console.ReadKey();

            static void GetName(ref string name)
            {
                Console.WriteLine("Введите имя:");
                name = Console.ReadLine();
            }
            */

            /* (IX) [5.3.8]
            static int[] GetArrayFromConsole(ref int num)
            {
                var result = new int[num];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }

                return result;
            }

            var sz = 6;

            GetArrayFromConsole(ref sz);
            */

            /* (X) [5.3.13]
            static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
            {
                sorteddesc = SortArrayDesc(array);
                sortedasc = SortArrayAsc(array);
            }

            static int[] SortArrayDesc(int[] result)
            {
                int num = 0;

                for (int k = 0; k < result.Length; k++)
                {
                    for (int j = k + 1; j < result.Length; j++)
                    {
                        if (result[j] > result[k])
                        {
                            num = result[j];
                            result[j] = result[k];
                            result[k] = num;
                        }
                    }
                }

                return result;
            }

            static int[] SortArrayAsc(int[] result)
            {
                int num = 0;

                for (int k = 0; k < result.Length; k++)
                {
                    for (int j = k + 1; j < result.Length; j++)
                    {
                        if (result[j] < result[k])
                        {
                            num = result[j];
                            result[j] = result[k];
                            result[k] = num;
                        }
                    }
                }

                return result;
            }
            */

            /* (XI) [5.5.4]
            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);

            Console.ReadKey();
            */

            /* (XII)
            static decimal Factorial(int x)
            {
                if (x == 0)
                {
                    return 1;
                }
                else
                {
                    return x * Factorial(x - 1);
                }
            }

            Console.WriteLine(Factorial(20));
            */

            /* (XIII) [5.5.8]
            Console.WriteLine(PowerUp(2, 3));
            */
        }

        /* (XI) [5.5.4]
        static void Echo(string saidword, int deep)
        {
            var modif = saidword;

            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
        */

            /* (XIII) [5.5.8]
            private static int PowerUp(int N, byte pow)
            {
                if (pow == 0)
                {
                    return 1;
                }
                else
                {
                    if (pow == 1)
                    {
                        return N;
                    }
                    else
                    {
                        return N * PowerUp(N, --pow);
                    }

                }

            }
            */
        }
    }