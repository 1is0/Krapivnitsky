using System;
using System.Runtime.InteropServices;

namespace lab4._2
{
    class Program
    {
        [DllImport("math.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int sum(int a, int b);
        [DllImport("math.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int mult(int a, int b);
        [DllImport("math.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int div(int a, int b);
        [DllImport("math.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int sub(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a + b = {sum(a, b)}\na - b = {sub(a, b)}\na * b = {mult(a, b)}\na \\ b = {div(a, b)}");
        }
    }
}
