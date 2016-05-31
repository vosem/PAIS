using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Application
{
    class Program
    {
        public class Point
        {
            public int X, Y;
            public Point(int x, int y)
            {
             this.X = x;
             this.Y = y;
            }
            public Point()
            { }
        }
        static void Main(string[] args)
        {
            solution();
        }
        static void solution()
        {
            //получаем входные данные
            Point p1, p2, p3, p4, p;
            p1 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            p2 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            p3 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            p4 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
             //проверяем отрезки на пересечение
            if (areCrossing(p1, p2, p3, p4))
            {
                int a1, b1, c1, a2, b2, c2;
                LineEquation(p1, p2);
                a1 = A; b1 = B; c1 = C;
                LineEquation(p3, p4);
                a2 = A; b2 = B; c2 = C;
                p = CrossingPoint(a1, b1, c1, a2, b2, c2);
                Console.WriteLine("Отрезки пересекаются" + "\n" + "в точке(" + Convert.ToString(p.X) + "," + Convert.ToString(p.Y) + ")");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Отрезки" + "\n" + "не пересекаются!");
            Console.ReadKey();
        }

        //построение уравнения прямой
        static int A, B, C; //коэффициенты уравнения прямой вида: Ax+By+C=0
        static void LineEquation(Point p1, Point p2)
        {
            int A, B, C; //коэффициенты уравнения прямой вида: Ax+By+C=0
            A = p2.Y - p1.Y;
            B = p1.X - p2.X;
            C = -p1.X * (p2.Y - p1.Y) + p1.Y * (p2.X - p1.X);
        } 
        //поиск точки пересечения
        static Point CrossingPoint(int a1, int b1, int c1, int a2, int b2, int c2)
        {
            Point pt = new Point();
            double d = (double)(a1 * b2 - b1 * a2);
            double dx = (double)(-c1 * b2 + b1 * c2);
            double dy = (double)(-a1 * c2 + c1 * a2);
            pt.X = (int)(dx / d);
            pt.Y = (int)(dy / d);
            return pt;
        }
        static int vector_mult(int ax, int ay, int bx, int by) //векторное произведение
        {
            return ax * by - bx * ay;
        }
        static bool areCrossing(Point p1, Point p2, Point p3, Point p4)//проверка пересечения
        {
            int v1 = vector_mult(p4.X - p3.X, p4.Y - p3.Y, p1.X - p3.X, p1.Y - p3.Y);
            int v2 = vector_mult(p4.X - p3.X, p4.Y - p3.Y, p2.X - p3.X, p2.Y - p3.Y);
            int v3 = vector_mult(p2.X - p1.X, p2.Y - p1.Y, p3.X - p1.X, p3.Y - p1.Y);
            int v4 = vector_mult(p2.X - p1.X, p2.Y - p1.Y, p4.X - p1.X, p4.Y - p1.Y);
            if ((v1 * v2) < 0 && (v3 * v4) < 0)
                return true;
            return false;
        }

    }
}
