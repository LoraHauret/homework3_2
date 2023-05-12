using System.Text;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string[][] numberArr = new string[10][];
            numberArr[0] = new string[] { "0", "ZERO", "" };
            numberArr[1] = new string[] { "1", "ONE", "ОДИН", "РАЗ", "ЕДИНИЦА" };
            numberArr[2] = new string[] { "2", "TWO", "ДВА" };
            numberArr[3] = new string[] { "3", "THREE", "ТРИ" };
            numberArr[4] = new string[] { "4", "FOUR", "ЧЕТЫРЕ" };
            numberArr[5] = new string[] { "5", "FIVE", "ПЯТЬ" };
            numberArr[6] = new string[] { "6", "SIX", "ШЕСТЬ" };
            numberArr[7] = new string[] { "7", "SEVEN", "СЕМЬ" };
            numberArr[8] = new string[] { "8", "EIGHT", "ВОСЕМЬ" };
            numberArr[9] = new string[] { "9", "NINE", "ДЕВЯТЬ" };

            Console.Write("Введите число буквами: ");
            string userNumber = Console.ReadLine().Trim();

            userNumber = userNumber.ToUpper();
            bool isFound = false;
            try
            {
                for (int i = 0; i < numberArr.Length; i++)
                {
                    for (int j = 1; j < numberArr[i].Length; j++)
                    {
                        if (userNumber.Equals(numberArr[i][j]))
                        {
                            Console.Write("\nЧисловое представление: {0}\n\n\n", numberArr[i][0]);
                            isFound = true;
                            return;
                        }
                    }
                }

                if (isFound == false)
                    throw new Exception("Число не найдено");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}