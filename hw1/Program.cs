// Напишите программу,которая принимает два числа и выдаёт, какое число большее,а какое меньшее.
// пример 5и7.2и10.-9и-3

using System;

namespace hw1{

    class Programs {

        static void Main() {
            
            int fn,sn;                                      //задаём переменные 
            Console.WriteLine("Enter first number:");
            fn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            sn = Convert.ToInt32(Console.ReadLine());
                                                            //описываем условия сравнения
            if(fn == sn)
                Console.WriteLine(" Numbers equal ");
            if(fn < sn)
                Console.WriteLine(" The second number is greater than the first ");
            if(fn > sn)
                Console.WriteLine(" The first number is greater that the second ");
                
            



        }
    }
}
