namespace Kollektsioonid
{
    public class Ulesanne4
    {
        // Создаем словарь для хранения пар "город-область"
        private static Dictionary<string, string> counties = new Dictionary<string, string>()
        {
            {"Tallinn", "Harjumaa"},
            {"Tartu", "Tartumaa"},
            {"Pärnu", "Pärnumaa"}
        };

        public static void Execute()
        {
            while (true)
            {
                // Меню пользователя
                Console.WriteLine("\nValige suvand:");                     // Выберите опцию:
                Console.WriteLine("1: Otsi piirkond linna järgi");            // 1: Найти область по городу
                Console.WriteLine("2: otsi linn piirkonna järgi");             // 2: Найти город по области"
                Console.WriteLine("3: Lisage sõnaraamatusse linn ja piirkond"); // 3: Добавить город и область в словарь
                Console.WriteLine("4: Teadmiste test");                        // 4: Тест знаний
                Console.WriteLine("5: Lõpeta");                              // 5: Выйти

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1) FindCountyByCity();
                else if (choice == 2) FindCityByCounty();
                else if (choice == 3) AddCityAndCounty();
                else if (choice == 4) TestKnowledge();
                else break;
            }
        }

        private static void FindCountyByCity()
        {
            // Поиск области по названию города
            Console.WriteLine("Sisesta linna nimi:"); // Введите название города:
            string city = Console.ReadLine();

            if (counties.ContainsKey(city))
                Console.WriteLine($"Piirkond: {counties[city]}");
            else
                Console.WriteLine("Linna ei leitud.");
        }

        private static void FindCityByCounty()
        {
            // Поиск города по названию области
            Console.WriteLine("Sisestage piirkonna nimi:"); // Введите название области:
            string county = Console.ReadLine();

            foreach (var pair in counties)
            {
                if (pair.Value.Equals(county, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Piirkond: {pair.Key}");
                    return;
                }
            }

            Console.WriteLine("Linna ei leitud.");
        }

        private static void AddCityAndCounty()
        {
            // Добавление новой пары "город-область"
            Console.WriteLine("Sisesta linna nimi:");
            string city = Console.ReadLine();

            Console.WriteLine("Sisestage piirkonna nimi:"); 
            string county = Console.ReadLine();

            counties[city] = county;
            Console.WriteLine("Linn ja piirkond lisatud");
        }

        private static void TestKnowledge()
        {
            // Тестирование знаний пользователя
            Random random = new Random();
            int correctAnswers = 0;

            foreach (var pair in counties)
            {
                Console.WriteLine($"Mis on linna piirkonna nimi? {pair.Key}?");
                string answer = Console.ReadLine();

                if (answer.Equals(pair.Value, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Õige!");
                    correctAnswers++;
                }
                else
                    Console.WriteLine($"Vale. Õige vastus: {pair.Value}");
            }

            double score = (double)correctAnswers / counties.Count * 100;
            Console.WriteLine($"Sinu tulemus: {score}% õiged vastused.");
        }
    }
}