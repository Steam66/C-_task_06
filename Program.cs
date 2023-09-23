namespace Задача_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите температуру: ");
            int t= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите в каких единицах отобразить:");
            Console.WriteLine("1. По Цельсию (° C);");
            Console.WriteLine("2. По Фаренгейту (° F).");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice != 1 || choice != 2)
            {
                switch (choice)
                {
                    case 1:
                        double C = (t - 32) / 1.8;
                        Console.WriteLine(C + " °C");
                        break;
                    case 2:
                        int F = (t * 9) / 5 + 32;
                        Console.WriteLine(F + " °F");
                        break;
                }
            }
            else Console.WriteLine("Нет такого варианта!!!");
        }
    }
}