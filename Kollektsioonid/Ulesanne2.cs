namespace Kollektsioonid
{
    public class Ulesanne2
    {
        public static void Execute()
        {
            // Создаем массив случайных чисел
            Random random = new Random();
            int[] numbers = Enumerable.Range(0, 20).Select(_ => random.Next(1, 101)).ToArray();

            Console.WriteLine("Juhuslikud numbrid: " + string.Join(" ", numbers));

            // Отбираем четные числа и затем нечетные
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();
            var oddNumbers = numbers.Where(n => n % 2 != 0).ToArray();

            // Выводим сначала четные, затем нечетные
            Console.WriteLine("Paarisarvud: " + string.Join(" ", evenNumbers));
            Console.WriteLine("Paaritud numbrid: " + string.Join(" ", oddNumbers));
        }
    }
}