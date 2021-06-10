using System;
using System.Text;

namespace LifeSpot
{
    class Lambdas  
    {
        // используем protected, чтобы разрешить доступ классам - потомкам
        protected delegate void Printer();
     
        // пометим метод как virtual, чтобы можно было переопределить в классе-потомке
        public virtual void Test()
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            Print(numbers, () => { Console.WriteLine("Ура! Нашел четное число!"); }); 
        }
        
        // тоже используем protected для доступа из наследуемых классов
        protected static void Print(int[] numbers, Printer func)
        {
            foreach (var i in numbers)
            {
                if (i % 2 == 0)
                    func(); 
            }
        }
    }
    
    class SuperLambdas : Lambdas  
    {
        // переопределим метод Test() - полиморфизм в действии
        public override void Test()
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            Print(numbers, () =>
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ура! Нашел четное число!");
            }); 
        }
    }
}