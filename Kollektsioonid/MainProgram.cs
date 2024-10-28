using System.Text;

namespace Kollektsioonid
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Основной цикл программы, который позволяет пользователю выбирать задание
            while (true)
            {
                Console.WriteLine("\nVäljumiseks valige viide (1-5) või 0:");
                int choice;
                // Проверяем, является ли ввод числом
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Palun sisestage arv vahemikus 0 kuni 5");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Ulesanne1.Execute();
                        break;
                    case 2:
                        Ulesanne2.Execute();
                        break;
                    case 3:
                        Ulesanne3.Execute();
                        break;
                    case 4:
                        Ulesanne4.Execute();
                        break;
                    case 5:
                        Ulesanne5.Execute();
                        break;
                    case 0:
                        Console.WriteLine("Programmist väljumine...");
                        return; // Завершаем выполнение программы
                    default:
                        Console.WriteLine("Vale valik. Proovi uuesti");
                        break;
                }
            }
        }
    }
}