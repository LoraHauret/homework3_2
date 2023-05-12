namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                passport p = new passport("123456780", "Александр", "Македонский", "Батькович", 21, 4, 2023, 23, 4, 2023);
                //passport p = new passport("123456780", "some name", "some sirname", "some family name", 21, 4, 2023, 23, 2023, 4);
                p.Print();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    internal class passport
    {
        string number;
        string name;
        string surname;
        string familyName;
        DateTime dateBirth;
        DateTime dateGiven;
        //public passport() { }
        public passport(string anumber, string aname, string asurname, string afamilyName, int bDay, int bMonth, int bYear, int gDay, int gMonth, int gYear)
        {
            if (string.IsNullOrEmpty(anumber) == true || anumber.Length > 9 || anumber.Length < 9)
            {

                throw new NotFiniteNumberException("Неверно указан номер паспорта");
            }

            this.number = anumber;

            this.name = aname;
            this.surname = asurname;
            this.familyName = afamilyName;
            try
            {
                dateBirth = new DateTime(bYear, bMonth, bDay);
                dateGiven = new DateTime(gYear, gMonth, gDay);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Неверно введена дата.");
                throw e;
            }

        }
        public void Print()
        {
            Console.WriteLine("Номер паспорта: {0}", number);
            Console.WriteLine("Фамилия: {0}", surname);
            Console.WriteLine("Имя: {0}", name);
            Console.WriteLine("Отчество: {0}", familyName);
            Console.WriteLine("Дата рождения: {0}", dateBirth.ToShortDateString());
            Console.WriteLine("Дата выдачи: {0}", dateGiven.ToShortDateString());
        }
    }
}