using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        List<object> collection = new List<object>(); // Здесь нужно заполнить коллекцию элементами

        Thread thread = new Thread(() =>
        {
            foreach (var item in collection)
            {
                // Вызываем метод ToString() для каждого элемента и выводим результат на экран
                Console.WriteLine(item.ToString());
            }
        });

        thread.Start();
        thread.Join(); // Ждем завершения потока

        Console.WriteLine("Главный поток завершил выполнение.");
    }
}
