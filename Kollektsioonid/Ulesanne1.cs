namespace Kollektsioonid
{
    public class Ulesanne1
    {
        public static void Execute()
        {
            // Ввод строки чисел
            Console.WriteLine("Sisestage tühikutega eraldatud numbrite loend:");
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray(); // Преобразует каждую строку в целое число. В массив целых чисел 

            // Если в списке только одно число, вывести его же
            if (input.Length == 1)
            {
                Console.WriteLine(input[0]);
                return;
            }

            // Результат будет хранить сумму соседей для каждого элемента
            int[] result = new int[input.Length]; // Массив целых чисел размер которого равен длине массива

            for (int i = 0; i < input.Length; i++)
            {
                // Сосед слева (если i = 0, берется последний элемент списка)
                int leftNeighbor = input[(i - 1 + input.Length) % input.Length];
                // Сосед справа (если i = последний индекс, берется первый элемент списка)
                int rightNeighbor = input[(i + 1) % input.Length];
                // Сумма соседей
                result[i] = leftNeighbor + rightNeighbor;
            }

            // Вывод результата в строку
            Console.WriteLine(string.Join(" ", result));
        }
    }
}