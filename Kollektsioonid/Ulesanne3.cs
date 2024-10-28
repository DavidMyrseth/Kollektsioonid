namespace Kollektsioonid
{
    public class Ulesanne3
    {
        public static void Execute()
        {
            // Запрос данных у пользователя: вес, рост, возраст, пол, уровень активности
            Console.WriteLine("Sisestage oma kaal kl:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisestage oma pikkus cm:");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisestage oma vanus:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisestage oma sugu (M/N):");
            char gender = Console.ReadLine().ToUpper()[0];

            Console.WriteLine("Valige oma aktiivsuse tase (1 - istuv, 2 - mitteaktiivne, 3 - mõõdukalt aktiivne, 4 - aktiivne, 5 - väga aktiivne):");
            int activityChoice = int.Parse(Console.ReadLine());

            // Присваиваем значение коэффициента активности
            double activityMultiplier = activityChoice switch
            {
                1 => 1.2,
                2 => 1.375,
                3 => 1.55,
                4 => 1.725,
                5 => 1.9,
                _ => 1.2
            };

            // Рассчитываем базовый обмен веществ (BMR) по формуле Харриса-Бенедикта
            double bmr = gender == 'M'
                ? 66 + (13.7 * weight) + (5 * height) - (6.8 * age)
                : 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);

            // Учитываем активность для расчета суточной нормы калорий
            double dailyCalories = bmr * activityMultiplier;

            // Выводим расчет
            Console.WriteLine($"Teie päevane kalorikogus: {dailyCalories:F2} kaloreid.");
        }
    }
}