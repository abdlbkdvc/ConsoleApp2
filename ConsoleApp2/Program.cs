using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==================== TODO-1 (Personal Information) ====================
            Console.Write("What's your name? ");
            string name_1 = Console.ReadLine();

            Console.Write("Which city are you from? ");
            string city = Console.ReadLine();
            string Department = "Computer Engineering";
            string Year = "2";

            Console.WriteLine($"Name : {name_1}\n" +
                $"City: {city}\n" +
                $"Department: {Department}\n" +
                $"Year: {Year}");

            Console.WriteLine("C# is fun");
            Console.WriteLine($"Hello {name_1} from {city}, welcome to C#!\n");


            // ==================== TODO-2 (Simple Calculator) ====================
            Console.Write("Can you give me a number ? ");
            int number_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Give me an operator (+, -, *, /): ");
            string operator_1 = Console.ReadLine();

            Console.Write("Can you give me a number ? ");
            int number_2 = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            if (operator_1 == "+")
            {
                sum = number_1 + number_2;
            }
            else if (operator_1 == "-")
            {
                sum = number_1 - number_2;
            }
            else if (operator_1 == "*")
            {
                sum = number_1 * number_2;
            }
            else if (operator_1 == "/")
            {
                if (number_2 != 0)
                {
                    sum = number_1 / number_2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero!");
                }
            }

            Console.WriteLine($"Result: {sum}\n");


            // ==================== TODO-3 (Exams Check) ====================
            Console.Write("What's your name? ");
            string student_name = Console.ReadLine();

            Console.Write("What's your midterm score ? ");
            int midterm_score = Convert.ToInt32(Console.ReadLine());

            Console.Write("What's your final score ? ");
            int final_score = Convert.ToInt32(Console.ReadLine());

            // Tamsayı bölme hatasını önlemek için 0.4 ve 0.6 kullanıldı
            double pass_check = (midterm_score * 0.4) + (final_score * 0.6);

            if (pass_check < 50)
            {
                Console.WriteLine("FAILED");
            }
            else if (pass_check >= 50 && pass_check < 100)
            {
                Console.WriteLine("PASSED");
            }
            else
            {
                Console.WriteLine("Perfect Final!");
            }
            Console.WriteLine();


            // ==================== TODO-4 (DIGIT Numbers) ====================
            Console.Write("Enter a 3-digit number: ");
            int number_3 = Convert.ToInt32(Console.ReadLine());

            string new_v_of_number = Math.Abs(number_3).ToString();

            if (new_v_of_number.Length == 3)
            {
                Console.WriteLine("Its three digits.");

                char hundreds = new_v_of_number[0];
                char tens = new_v_of_number[1];
                char ones = new_v_of_number[2];

                Console.WriteLine($"Hundreds: {hundreds}\nTens: {tens}\nOnes: {ones}");
            }
            else
            {
                Console.WriteLine("Its not three digits.");
            }
        }
    }
}