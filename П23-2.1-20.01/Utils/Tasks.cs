using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace П23_2._1_20._01.Utils
{
    public class Tasks
    {
    }

    public class Number1
    {
        public double F { get; set; }
        public double Y { get; set; }


        public Number1(double f, double y)
        {
            F = f;
            Y = y;
        }

        public void Result()
        {
            double G = (Math.Pow(Math.E, 2 * Y) + Math.Sin(F)) / (Math.Log(3.8 * Y + F));
            Console.WriteLine($"G = {G}");
        }

    }

    public class Number2
    {
        public double D { get; set; }
        public double Y { get; set; }

        public Number2(double d, double y)
        {
            D = d;
            Y = y;
        }

        public void Result()
        {
            double F = Math.Log(D) + (3.5 * Math.Pow(D, 2) + 1) / (Math.Cos(2 * Y));
            Console.WriteLine($"F = {F}");
        }
    }

    public class Number3
    {
        public double K { get; set; }
        public double Y { get; set; }

        public Number3(double k, double y)
        {
            K = k;
            Y = y;
        }

        public void Result() 
        {
            double U = (Math.Log(K - Y) + Math.Pow(Y, 4)) / (Math.Pow(Math.E, Y) + 2.355 * Math.Pow(K, 2));
            Console.WriteLine(U);
        }
    }
    public class Number4
    {
        public double W { get; set; }
        public double Y { get; set; }

        public Number4(double w, double y)
        {
            W = w;
            Y = y;
        }

        public void Result()
        {
            double G = (9.33 * Math.Pow(W, 3) + Math.Sqrt(W)) / (Math.Log(Y + 3.5) + Math.Sqrt(Y));
            Console.WriteLine($"G = {G}");
        }
    }
    public class Number5
    {
        public double A { get; set; }
        public double T { get; set; }
        public double Y { get; set; }

        public Number5(double a, double t, double y)
        {
            A = a;
            T = t;
            Y = y;

        }

        public void Result()
        {
            double D = (7.8 * Math.Pow(A, 2) + 3.52 * T) / (Math.Log(A + 2 * Y) + Math.Pow(Math.E, Y));
            Console.WriteLine($"D = {D}");
        }
    }
    public class Number6
    {
        public double I { get; set; }
        public double Y { get; set; }

        public Number6(double i, double y)
        {
            I = i;
            Y = y;

        }

        public void Result()
        {
            double L = (0.81* Math.Cos(I)) / (Math.Log(Y + 2 * Math.Pow(I, 3)));
            Console.WriteLine($"L = {L}");
        }
    }

    public class Number7
    {
        public double M { get; set; }
        public double Y { get; set; }

        public Number7(double m, double y)
        {
            M = m;
            Y = y;
        }

        public void Result() 
        {
            double N = (Math.Pow(M, 2) + 2.8 * M + 0.355) /  (Math.Cos(2 * Y) + 3.6);
            Console.WriteLine($"N = {N}");
        }
    }
    public class Number8
    {
        public double T { get; set; }
        public double Y { get; set; }

        public Number8(double t, double y)
        {
            T = t;
            Y = y;
        }

        public void Result()
        {
            double res = (2.37 * Math.Sin(T + 1)) / (Math.Sqrt(4 * Math.Pow(Y, 2) - 0.1 * Y + 5));
            Console.WriteLine($"T = {res}");
        }
    }

    public class Number9
    {
        

        public double Y { get; set; }
        public double W { get; set; }
        
        public Number9(double y, double w)
                {
                    Y = y;
                    W = w;
                }

        public void Result()
        {
            double res = (Math.Pow(Y + 2 * W, 3)) / (Math.Log(Y + 0.75));
            Console.WriteLine($"V = {res}");
        }
    }
    public class Number10
    {


        public double T { get; set; }
        public double Y { get; set; }

        public Number10(double t, double y)
        {
            T = t;
            Y = y;
        }

        public void Result()
        {
            double res = (2 * T + Y * Math.Cos(T)) / (Math.Sqrt(Y + 4.831));
            Console.WriteLine($"Z = {res}");
        }
    }

    public class Number11
    {
        public double Y { get; set; }
        public double N { get; set; }

        public Number11(double y, double n)
        {
            Y = y;
            N = n;
        }

        public void Result()
        {
            double res = Math.Pow(Y, 2) + (0.5 * N + 4.8) / (Math.Sin(Y));
            Console.WriteLine($"Z = {res}");
        }
    }

    public class Number12
    {
        public double T { get; set; }
        public double Y { get; set; }

        public Number12(double t, double y)
        {
            T = t;
            Y = y;
        }

        public void Result()
        {
            double res = (Math.Sin(Math.Pow(2 * T + 1, 2) + 0.3) / Math.Log(T + Y));
            Console.WriteLine($"R = {res}");
        }
    }

    public class Number13
    {
        public double Y { get; set; }
        public double H { get; set; }

        public Number13(double y, double h)
        {
            Y = y;
            H = h;
        }

        public void Result()
        {
            double res = (Math.Sin(2 * Y + H) + Math.Pow(H, 2)) / (Math.Pow(Math.E, H) + Y);
            Console.WriteLine($"A = {res}");
        }

    }

    public class Number14
    {
        public double Y { get; set; }
        public double H { get; set; }

        public Number14(double y, double h)
        {
            Y = y;
            H = h;
        }

        public void Result()
        {
            double res = (Math.Pow(Math.E, Y + 2.5) + 7.1 * Math.Pow(H, 3)) / (Math.Log(Math.Sqrt(Y + 0.04 * H)));
            Console.WriteLine($"P - {res}");
        }
    }

    public class Number15
    {
        public double Y { get; set; }
        public double J { get; set; }

        public Number15(double y, double j)
        {
            Y = y;
            J = j;
        }

        public void Result()
        {
            double res = (2 * Math.Sin(0.354 * Y + 1)) / (Math.Log(Y + 2 * J));
            Console.WriteLine($"F - {res}");
        }
    }

    public class Number16
    {
        public double T { get; set; }
        public double R { get; set; }
        public double Y { get; set; }

        public Number16(double t, double r, double y)
        {
            T = t;
            R = r;
            Y = y;
        }

        public void Result()
        {
            double res = (4 * Math.Pow(T, 4) + Math.Log(R)) / (Math.Pow(Math.E, Y + R) + 7.2 * Math.Sin(R));
            Console.WriteLine($"W - {res}");
        }
    }

    public class Number17
    {
        public double Y { get; set; }
        public double N { get; set; }

        public Number17(double y, double n)
        {
            Y = y;
            N = n;
        }

        public void Result()
        {
            double res = (Y*Y - 0.8*Y+Math.Sqrt(Y)) / (23.1 * (N * N) + Math.Cos(N));
            Console.WriteLine($"H - {res}");
        }
    }

    public class Number18
    {
        public double Y { get; set; }
        public double K { get; set; }

        public Number18(double y, double k)
        {
            Y = y;
            K = k;
        }

        public void Result()
        {
            double res = (Math.Sqrt(Math.Pow(Math.Sin(Y),2) + Y + 6.835)) / (Math.Log(Y + K) + 3 * (Y * Y));
            Console.WriteLine($"R - {res}");
        }
    }

    public class Number19
    {
        public double Y { get; set; }
        public double Q { get; set; }

        public Number19(double y, double q)
        {
            Y = y;
            Q = q;
        }

        public void Result()
        {
            double res = (Math.Log(0.7*Y+2*Q))/(Math.Sqrt(3*(Y*Y)+0.5*Y+4));
            Console.WriteLine($"P - {res}");
        }
    }

    public class Number20
    {
        public double K { get; set; }
        public double Y { get; set; }
        public double X { get; set; }

        public Number20(double k, double y, double x)
        {
            K = k;
            Y = y;
            X = x;
        }

        public void Result()
        {
            double res = Math.Pow(Math.E, K + Y) + Math.Tan(X * Math.Sqrt(Y));
            Console.WriteLine($"U - {res}");
        }

    }

    public class Number21
    {


        public double Y { get; set; }
        public double H { get; set; }
        public Number21(double y, double h)
        {
            Y = y;
            H = h;
        }

        public void Result()
        {
            double res = Math.Pow(Math.E, Y + 5.5) + 9.1 * Math.Pow(H, 3);
            Console.WriteLine($"P - {res}");
        }
    }

    public class Number22
    {


        public double U { get; set; }
        public double Y { get; set; }
        public double X { get; set; }
        public Number22(double u, double y, double x)
        {
            U = u;
            Y = y;
            X = x;
        }

        public void Result()
        {
            double res = Math.Sin(2 * U) * Math.Log(2 * (Y * Y) + Math.Sqrt(X));
            Console.WriteLine($"P - {res}");
        }
    }

    public class Number23
    {


        public double Y { get; set; }
        public double F { get; set; }
        public Number23(double y, double f)
        {
            Y = y;
            F = f;
        }

        public void Result()
        {
            double res = Math.Pow(Math.E, Y + 5.5) + 9.1 * Math.Pow(F, 3);
            Console.WriteLine($"P - {res}");
        }
    }

    public class Number24
    {


        public double Y { get; set; }
        public double H { get; set; }
        public Number24(double y, double h)
        {
            Y = y;
            H = h;
        }

        public void Result()
        {
            double res = Math.Pow(Math.E, Y + 5.5) + 9.1 * Math.Pow(H, 3);
            Console.WriteLine($"P - {res}");
        }
    }

    public class Number25
    {


        public double Y { get; set; }
        public double H { get; set; }
        public Number25(double y, double h)
        {
            Y = y;
            H = h;
        }

        public void Result()
        {
            double res = Math.Pow(Math.E, Y + 5.5) + 9.1 * Math.Pow(H, 3);
            Console.WriteLine($"P - {res}");
        }
    }

    public class Number26
    {


        public double Y { get; set; }
        public double H { get; set; }
        public Number26(double y, double h)
        {
            Y = y;
            H = h;
        }

        public void Result()
        {
            double res = Math.Pow(Math.E, Y + 5.5) + 9.1 * Math.Pow(H, 3);
            Console.WriteLine($"P - {res}");
        }
    }

    public class Number27
    {


        public double Y { get; set; }
        public double H { get; set; }
        public Number27(double y, double h)
        {
            Y = y;
            H = h;
        }

        public void Result()
        {
            double res = Math.Pow(Math.E, Y + 5.5) + 9.1 * Math.Pow(H, 3);
            Console.WriteLine($"P - {res}");
        }
    }

    public class Number28
    {


        public double Y { get; set; }
        public double H { get; set; }
        public Number28(double y, double h)
        {
            Y = y;
            H = h;
        }

        public void Result()
        {
            double res = Math.Pow(Math.E, Y + 5.5) + 9.1 * Math.Pow(H, 3);
            Console.WriteLine($"P - {res}");
        }
    }

    public class Number29
    {


        public double Y { get; set; }
        public double H { get; set; }
        public Number29(double y, double h)
        {
            Y = y;
            H = h;
        }

        public void Result()
        {
            double res = Math.Pow(Math.E, Y + 5.5) + 9.1 * Math.Pow(H, 3);
            Console.WriteLine($"P - {res}");
        }
    }

    public class Number30
    {


        public double Y { get; set; }
        public double H { get; set; }
        public Number30(double y, double h)
        {
            Y = y;
            H = h;
        }

        public void Result()
        {
            double res = Math.Pow(Math.E, Y + 5.5) + 9.1 * Math.Pow(H, 3);
            Console.WriteLine($"P - {res}");
        }
    }

}
