using System;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            FizzBuzz(1,1000);
          
        }
        static void print_num(int start, int finish)
        {
             for(int i=start;i<=finish;i=i+1){
                Console.WriteLine(i);
            }
            
        }

        static void print_35(int start, int finish)
        {
             for(int i=start;i<=finish;i=i+1){
                 if (i%3==0 && i%5==0)
                 {
                     continue;
                 }
                 else if (i%3==0 || i%5==0){
                    Console.WriteLine(i);
                 }
                
            }
            
        }

         static void FizzBuzz(int start, int finish)
        {
             for(int i=start;i<=finish;i=i+1){
                 string result;
                if (i%3==0 && i%5==0){
                     Console.WriteLine("FizzBuzz");
                }
                 else if (i%3==0)
                 {
                    Console.WriteLine("Fizz");
                 }
                 else if (i%5==0){
                   Console.WriteLine("Fizz");
                 }
             
            }
            
        }
        

        





    }
}
