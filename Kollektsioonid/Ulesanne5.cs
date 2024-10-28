namespace Kollektsioonid
{
    public class Ulesanne5
    {
        public static void Execute()
        {
            // Пример задачи на словари: создаем словарь с товарами и их количеством на складе
            Dictionary<string, int> inventory = new Dictionary<string, int>()
            {
                {"Õunad", 100},
                {"Banaanid", 50},
                {"Apelsinid", 75}
            };

            // Запрашиваем у пользователя товар и выводим его наличие
            Console.WriteLine("Saadavuse kontrollimiseks sisestage toote nimi:");
            string product = Console.ReadLine();

            if (inventory.ContainsKey(product))
                Console.WriteLine($"Laos {product}: {inventory[product]} asju");
            else
                Console.WriteLine($"{product} otsas.");
        }
    }
}