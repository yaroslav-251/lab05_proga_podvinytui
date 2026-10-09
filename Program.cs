// Console.WriteLine("Обратный отсчет");
// int countdown = 5;
// while (countdown >= 1)
// {
//     Console.WriteLine(countdown);
//     countdown--;
// }
// Console.WriteLine("пуск");
// Console.WriteLine();
// Console.WriteLine("Сумма чисел от 1 до 10");
// int number = 1;
// int sum = 0;
// while (number <= 10)
// {
//     sum += number;
//     number++;
// }
// Console.WriteLine($"Сумма: {sum}");

// Console.WriteLine();
// Console.WriteLine("Бесконечный цикл");
// int i = 1;
// while (i <= 5)
// {
//     Console.WriteLine($"Значение i: {i}");
//     i++;
// }

// Console.WriteLine();
// Console.WriteLine("валидация через while");
// bool isValid = false;
// int enteredAge = 0;

// while (!isValid)
// {
//     Console.WriteLine("Введите ваш возраст (целое число): ");
//     string input = Console.ReadLine();
//     isValid = int.TryParse(input, out enteredAge);
//     if (!isValid)
//     {
//         Console.WriteLine("Это не похоже на целое число. Попробуйте еще раз.");
//     }
// }
// Console.WriteLine($"принято! Ваш возраст: {enteredAge}");
// Console.WriteLine();
// Console.WriteLine("меню (без выхода, один проход)");
// string menuChoice;
// do
// {
//     Console.WriteLine("1 - показать дату");
//     Console.WriteLine("2 - Показать приветствие");
//     Console.WriteLine("0 - выход");
//     Console.WriteLine("Выберите пункт: ");
//     menuChoice = Console.ReadLine();
//     switch (menuChoice)
//     {
//         case "1":
//             Console.WriteLine($"Сегодня: {DateTime.Now:dd.MM.yyyy}");
//             break;
//         case "2":
//             Console.WriteLine("Здравствуйте! Рады видеть вас снова.");
//             break;
//         case "0":
//             Console.WriteLine("До свидания");
//             break;
//         default:
//             Console.WriteLine("Такого пункта нет, попробуйте снова.");
//             break;
//     }
// }
// while (menuChoice != "0");
// Console.WriteLine("Прямой счёт");
// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine();
// Console.WriteLine("Обртный отсчет");
// for (int i = 5; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine();
// Console.WriteLine("Четные числа от 0 до 20");
// for (int i = 0; i <= 20; i += 2)
// {
//     Console.WriteLine($"{i}");
// }
// Console.WriteLine("foreach по строке");
// string word = "Программирование";
// foreach (char letter in word)
// {
//     Console.Write($"{letter} ");
// }
// Console.WriteLine();
// Console.WriteLine("Считаем гласные");
// string sentence = "курс алгоритмизации и программмирования";
// string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
// int vowelCount = 0;
// foreach (char letter in sentence)
// {
//     if (vowels.Contains(letter))
//     {
//         vowelCount++;
//     }
// }
// Console.WriteLine($"гласных букв в предложении: {vowelCount}");
Console.WriteLine("Таблица умножения 1-9");
for (int row = 1; row <= 9; row++)
{
    for (int col = 1; col <= 9; col++)
    {
        Console.WriteLine($"{row * col}");
    }
    Console.WriteLine();
}
Console.WriteLine("треугольник");
for (int row = 1; row <= 5; row++)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("break прерывает только внутренний цикл");
for (int row = 1; row <= 3; row++)
{
    Console.WriteLine($"Внешняя итерация: {row}");
    for (int col = 1; col <= 5; col++)
    {
        if (col == 3)
        {
            break;
        }
        Console.WriteLine($"Внутренняя итерация: {col}");
    }
}