using System;

namespace GitEnjoy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class IntManager{
        public static int Sum(int[] array){
            int j;
            for(int i = 0; i < array.Length; i++){
                j += array[i];
            }
            return j;
        }
    }
}
