using System;

class Program
{
    static string CalculateGrade(int totalScore)
    {
        if (totalScore >= 70)
            return "5 (отлично)";
        else if (totalScore >= 40)
            return "4 (хорошо)";
        else if (totalScore >= 20)
            return "3 (удовлетворительно)";
        else
            return "2 (неудовлетворительно)";
    }

    static void Main(string[] args)
    {
        int[] maxScores = { 10, 50, 30, 10 };
        int totalScore = 0;

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Введите баллы за задание {i + 1}: ");
            string input = Console.ReadLine();

            int score;
            if (!int.TryParse(input, out score))
            {
                Console.WriteLine($"Ошибка: Некорректный ввод для задания {i + 1}. Введите целое число.");
                Console.ReadLine();
                return;
            }

            if (score < 0 || score > maxScores[i])
            {
                Console.WriteLine($"Ошибка: Некорректный ввод для задания {i + 1}. Баллы должны быть целым числом от 0 до {maxScores[i]}");
                Console.ReadLine();
                return;
            }

            totalScore += score;
        }

        Console.WriteLine($"Общая сумма баллов: {totalScore}");
        Console.WriteLine($"Оценка по 5-бальной шкале: {CalculateGrade(totalScore)}");
        Console.ReadLine();
    }
}
