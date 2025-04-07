using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using П23_2._1_20._01.Utils;

namespace П23_2._1_20._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool tr = true;
            while (tr)
            {
                Console.Clear();
                Console.Write("Введите номер задания: ");

                string task = Console.ReadLine();
                switch (task)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");
                            
                            Console.Write("f - ");
                            double f = Convert.ToDouble(Console.ReadLine());
                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Number1 num1 = new Number1(f, y);
                            num1.Result();
                            Thread.Sleep(1000);

                        }
                        break;
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("d - ");
                            double d = Convert.ToDouble(Console.ReadLine());
                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Number2 num2 = new Number2(d, y);
                            num2.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "3":
                        {
                            Console.Write("k - ");
                            double k = Convert.ToDouble(Console.ReadLine());

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Number3 num3 = new Number3(k, y);

                            num3.Result();

                            Console.ReadKey();
                        }
                        break;
                    case "4":
                        {
                            Console.Write("w - ");
                            double w = Convert.ToDouble(Console.ReadLine());

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Number4 num4 = new Number4(w, y);

                            num4.Result();

                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        {
                            Console.Write("a - ");
                            double a = Convert.ToDouble(Console.ReadLine());

                            Console.Write("t - ");
                            double t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Number5 num5 = new Number5(a, t, y);

                            num5.Result();

                            Console.ReadKey();
                        }
                        break;
                    case "6": 
                        {
                            Console.Write("i - ");
                            double i = Convert.ToDouble(Console.ReadLine());

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Number6 num6 = new Number6(i, y);

                            num6.Result();

                            Console.ReadKey();
                        }
                        break;
                    case "7":
                        {
                            Console.Write("m - ");
                            double m = Convert.ToDouble(Console.ReadLine());

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Number7 num7 = new Number7(m, y);

                            num7.Result();

                            Console.ReadKey();
                        }
                        break;
                    case "8":
                        {
                            Console.Write("t - ");
                            double t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Number8 num8 = new Number8(t, y);

                            num8.Result();
                            Console.ReadKey();
                        }
                        break;
                    case "9":
                        {
                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("w - ");
                            double w = Convert.ToDouble(Console.ReadLine());

                            Number9 num9 = new Number9(w, y);

                            num9.Result();
                            Console.ReadKey();
                        }
                        break;
                    case "10":
                        {
                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("t - ");
                            double t = Convert.ToDouble(Console.ReadLine());

                            Number10 num10 = new Number10(t, y);

                            num10.Result();
                            Console.ReadKey();
                        }
                        break;
                    case "11":
                        {
                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("n - ");
                            double n = Convert.ToDouble(Console.ReadLine());

                            Number11 num11 = new Number11(y, n);

                            num11.Result();
                            Console.ReadKey();
                        }
                        break;
                    case "12":
                        {
                            Console.Write("t - ");
                            double t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Number12 num12 = new Number12(t, y);

                            num12.Result();
                            Console.ReadKey();
                        }
                        break;
                    case "13":
                        {
                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("h - ");
                            double h = Convert.ToDouble(Console.ReadLine());

                            Number13 num13 = new Number13(y, h);

                            num13.Result();
                            Console.ReadKey();
                        }
                        break;
                    case "14":
                        {
                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("h - ");
                            double h = Convert.ToDouble(Console.ReadLine());

                            Number14 num14 = new Number14(y, h);

                            num14.Result();
                            Console.ReadKey();
                        }
                        break;
                    case "15":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double j = Convert.ToDouble(Console.ReadLine());
                            Number15 num15 = new Number15(y, j);
                            num15.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "16":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double t = Convert.ToDouble(Console.ReadLine());
                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("r - ");
                            double r = Convert.ToDouble(Console.ReadLine());
                            Number16 num16 = new Number16(t, y, r);
                            num16.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "17":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double j = Convert.ToDouble(Console.ReadLine());
                            Number17 num17 = new Number17(y, j);
                            num17.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "18":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double j = Convert.ToDouble(Console.ReadLine());
                            Number18 num18 = new Number18(y, j);
                            num18.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "19":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double j = Convert.ToDouble(Console.ReadLine());
                            Number19 num19 = new Number19(y, j);
                            num19.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "20":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double k = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double x = Convert.ToDouble(Console.ReadLine());
                            Number20 num20 = new Number20(y, k, x);
                            num20.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "21":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double j = Convert.ToDouble(Console.ReadLine());
                            Number21 num21 = new Number21(y, j);
                            num21.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "22":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double j = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double x = Convert.ToDouble(Console.ReadLine());
                            Number22 num22 = new Number22(y, j, x);
                            num22.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "23":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double u = Convert.ToDouble(Console.ReadLine());
                            Number23 num23 = new Number23(y, u);
                            num23.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "24":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double j = Convert.ToDouble(Console.ReadLine());
                            Number24 num24 = new Number24(y, j);
                            num24.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "25":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double j = Convert.ToDouble(Console.ReadLine());
                            Number25 num25 = new Number25(y, j);
                            num25.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "26":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double j = Convert.ToDouble(Console.ReadLine());
                            Number26 num26 = new Number26(y, j);
                            num26.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "27":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double j = Convert.ToDouble(Console.ReadLine());
                            Number27 num27 = new Number27(y, j);
                            num27.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "28":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double j = Convert.ToDouble(Console.ReadLine());
                            Number28 num28 = new Number28(y, j);
                            num28.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "29":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double j = Convert.ToDouble(Console.ReadLine());
                            Number29 num29 = new Number29(y, j);
                            num29.Result();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "30":
                        {
                            Console.Clear();
                            Console.WriteLine($"№{task}");

                            Console.Write("y - ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            Console.Write("h - ");
                            double j = Convert.ToDouble(Console.ReadLine());
                            Number30 num30 = new Number30(y, j);
                            num30.Result();
                            Thread.Sleep(1000);
                        }
                        break;


                    default: Console.WriteLine("ERROR DATA"); Thread.Sleep(1000); break;

                }
            }
        }
    }
}
