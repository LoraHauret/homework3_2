namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логическое выражение. \nИспользуйте целые числа и операторы <, >, <=, >=, ==, !=. ");
            string userExpression = Console.ReadLine();
            if (string.IsNullOrEmpty(userExpression))
                throw new ArgumentNullException("Введена пустая строка.");

            string[] operators = { "<", ">", "<=", ">=", "==", "!=" };

            Boolean operatorExists = false;

            int operatorIndex = 0;
            int operatorLength = 0;
            foreach (var el in operators)
            {
                if (userExpression.Contains(el))
                {
                    operatorExists = true;
                    operatorIndex = userExpression.IndexOf(el, 0);
                    operatorLength = el.Length;
                    break;
                }
            }

            if (!operatorExists)
                throw new Exception("В выражении отсутствует оператор");

            int leftOperand = Convert.ToInt32(userExpression.Substring(0, operatorIndex).Trim());

            int rightOperand = Convert.ToInt32(userExpression.Substring(operatorIndex + operatorLength).Trim());

            string op = userExpression.Substring(operatorIndex, operatorLength);

            Console.Write(leftOperand + op + rightOperand + " = ");
            bool result;
            switch (op)
            {
                case "<":
                    result = leftOperand < rightOperand;
                    break;
                case ">":
                    result = leftOperand > rightOperand;
                    break;
                case "<=":
                    result = leftOperand <= rightOperand;
                    break;
                case "==":
                    result = leftOperand == rightOperand;
                    break;
                case ">=":
                    result = leftOperand >= rightOperand;
                    break;
                case "!=":
                    result = leftOperand != rightOperand;
                    break;
                default:
                    throw new Exception("Что-то пошло не так.");
            }
            Console.WriteLine(result);


        }
    }
}