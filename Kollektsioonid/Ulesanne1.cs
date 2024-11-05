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

        public static void Terveitamine()
        {
            Console.WriteLine("СДЕЛАНО ЧЕРЕЗ ЦИКЛ FOR");
            for (int i = 0; i < 18; i++)
            {
                Console.WriteLine("Привет Андрей");
            }

            Console.WriteLine("СДЕЛАНО ЧЕРЕЗ ЦИКЛ DO WHILE");
            int j = 0;
            do
            {
                Console.WriteLine("Привет Андрей");
                j++;
            } while (j < 18);

            Console.WriteLine("СДЕЛАНО ЧЕРЕЗ ЦИКЛ foreach");
            var greetings = new string[18];
            foreach (var _ in greetings)
            {
                Console.WriteLine("Привет Андрей");
            }
        }

        public void Kommi()
        {
            Console.WriteLine("Попрошайка");

            Random random = new Random();
            int number = random.Next(1, 11);

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Дай конфетку, пожалуйста {i}!");
            }

            Console.WriteLine("Торгующийся");

            int current = number;

            while (current > 0)
            {
                Console.WriteLine($"Ну дай, пожалуйста, конфетку {current}?");
                string response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    Console.WriteLine("Спасибо! Ты лучший!");
                    return;
                }
                else if (response == "no")
                {
                    Console.WriteLine("Почему? Я так хочу конфетку");
                    current--;
                }
            }

            // Прощания
            for (int i = current; i >= 0; i--)
            {
                Console.WriteLine($"Прощай, {i}!");
            }
        }

        public static void Vikto()
        {
            Random rand = new Random();

            Console.Write("Введите минимальное значение д: ");
            int lower = int.Parse(Console.ReadLine());

            Console.Write("Введите максимальное значение д: ");
            int higher = int.Parse(Console.ReadLine());

            if (lower >= higher)
            {
                Console.WriteLine("Ошибка: минимальное число должно быть меньше максимального.");
                return;
            }

            int number = rand.Next(lower + 1, higher);

            Console.WriteLine($"Загадал число между {lower} и {higher}. Попробуйте угадать!");

            int triesCount = 0;
            int userInput;

            do
            {
                Console.Write("Введите ваше число: ");
                userInput = int.Parse(Console.ReadLine());
                triesCount++;

                if (userInput == number)
                {
                    Console.WriteLine($"Правильно! Загаданное число {number}. Количество попыток: {triesCount}");
                }
                else
                {
                    Console.WriteLine(userInput < number ? "Загаданное число больше." : "Загаданное число меньше.");
                }

            } while (userInput != number);
        }
    }
}
