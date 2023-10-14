using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceWork05
{
    public class Program
    {
        /// <summary>
      
        /// Реализовать несколько методов или классов с методами и вызвать один метод из другого. 
        /// В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.
      
        /// </summary>
        
        static void exampleMethod(int[] arr, int index)
        {
            try
            {
                if(index < 0 || index > arr.Length)
                {
                    throw new IndexOutOfRangeException("Индекс находится за пределами массива");
                }
                int element = arr[index];
                Console.WriteLine("Элемент массива: {0}", element);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Произошла ошибка: " + e.Message);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            exampleMethod(arr, 5);
            exampleMethod(arr, 10); //я не понял, но прикиньте, он мне выдал "Индекс находился вне границ массива" - хотя я писал, чтобы он вывел мне: "Индекс находится за пределами массива".
            //попробуйте изменить на 11, а не на 10, будет так, как я и хотел. Это как? не пон... Прикольная фишка, по идее
        }
    }
}
