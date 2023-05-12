namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Вывести число");
                Console.WriteLine("1. в двоичном виде");
                Console.WriteLine("2. в восьмеричном виде");
                Console.WriteLine("3. в десятичном виде");
                Console.WriteLine("4. в шестнадцатиричном виде");

                int answer = Convert.ToInt32(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        Console.WriteLine(Convert.ToString(number, 2));
                        break;
                    case 2:
                        Console.WriteLine(Convert.ToString(number, 8));
                        break;
                    case 3:
                        Console.WriteLine(Convert.ToString(number));
                        break;
                    case 4:
                        Console.WriteLine(Convert.ToString(number, 16));
                        break;
                    default:
                        Console.WriteLine(Convert.ToString("Такой пункт меню отсутствует."));
                        break;
                };

            }

            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("\nНеверный формат ввода.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}