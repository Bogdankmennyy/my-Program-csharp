/*
Завдання 1
//Користувач вводить з клавіатури число від 1 до 100.
//Якщо число кратне 3 (ділиться на 3 без залишку), потрібно
//вивести слово Fizz. Якщо число кратне 5, потрібно вивести
//слово Buzz. Якщо число кратне 3 і 5, потрібно вивести Fizz
//Buzz. Якщо число не кратне ні 3, ані 5, потрібно вивести
//тільки число.
//Якщо користувач ввів значення не в діапазоні від 1
//до 100, потрібно вивести повідомлення про помилку.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть число від 1 до 100: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number >= 1 && number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Число не входить до діапазону від 1 до 100");
            }
        }
        else
        {
            Console.WriteLine("Некоректний ввід");
        }
    }
}
*/





/*
//Завдання 2
//Користувач вводить з клавіатури два числа. Перше
//число — це значення, друге число — відсоток, який необхідно підрахувати. Наприклад, ми ввели з клавіатури
//90 і 10. Потрібно вивести на екран 10 відсотків від 90.
//Результат: 9.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть число:");
        double number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть відсоток:");
        double percent = Convert.ToDouble(Console.ReadLine());

        double result = number * percent / 100;
        Console.WriteLine($"{percent}% від {number} дорівнює {result}.");
    }
}
*/




/*
//Завдання 3
//Користувач вводить з клавіатури чотири цифри. Необхідно створити число, яке містить ці цифри. Наприклад, якщо з клавіатури введено 1, 5, 7, 8 тоді потрібно
//сформувати число 1578.
using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Введіть чотири цифри:");

        // Зчитуємо чотири цифри з консолі
        int digit1 = Console.Read() - '0';
        int digit2 = Console.Read() - '0';
        int digit3 = Console.Read() - '0';
        int digit4 = Console.Read() - '0';

        // Формуємо число з цих цифр
        int number = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

        Console.WriteLine("Ваше число: " + number);
    }
}
*/

/*
//Завдання 4
//Користувач вводить шестизначне число. Потім, користувач вводить номери розрядів для заміни цифр.
//Наприклад, якщо користувач ввів 1 і 6 — це означає, що
//треба поміняти місцями першу та шосту цифри.
//Число 723895 має перетворитися на 523897.
//Якщо користувач ввів не шестизначне число, потрібно
//вивести повідомлення про помилку.

using System;

class Program {
    static void Main() {
        Console.Write("Введіть шестизначне число: ");
        string numberInput = Console.ReadLine();

        if (numberInput.Length != 6) {
            Console.WriteLine("Помилка: введене число не є шестизначним.");
            return;
        }

        Console.Write("Введіть номери розрядів для заміни цифр (через пробіл): ");
        string positionsInput = Console.ReadLine();
        string[] positions = positionsInput.Split();

        if (positions.Length != 2) {
            Console.WriteLine("Помилка: необхідно ввести рівно 2 номери розрядів для заміни цифр.");
            return;
        }

        int pos1, pos2;
        if (!int.TryParse(positions[0], out pos1) || !int.TryParse(positions[1], out pos2)) {
            Console.WriteLine("Помилка: номери розрядів мають бути цілими числами.");
            return;
        }

        if (pos1 < 1 || pos1 > 6 || pos2 < 1 || pos2 > 6) {
            Console.WriteLine("Помилка: номери розрядів мають бути від 1 до 6.");
            return;
        }

        // Конвертуємо рядок в масив цифр
        int[] digits = new int[6];
        for (int i = 0; i < 6; i++) {
            digits[i] = int.Parse(numberInput[i].ToString());
        }

        // Поміняти місцями дві цифри
        int temp = digits[pos1-1];
        digits[pos1-1] = digits[pos2-1];
        digits[pos2-1] = temp;

        // Вивести результат
        Console.Write("Результат: ");
        for (int i = 0; i < 6; i++) {
            Console.Write(digits[i]);
        }
    }
}
*/


/*
//Завдання 5
//Користувач вводить з клавіатури два числа. Потрібно показати усі парні числа у вказаному діапазоні. Якщо
//межі діапазону вказані неправильно, потрібно провести
//нормалізацію кордонів. Наприклад, користувач ввів 20 і
//11. Потрібна нормалізація, після якої початок діапазону
//дорівнюватиме 11, а кінець дорівнюватиме 20.
using System;

class Program {
    static void Main() {
        Console.WriteLine("Введіть два цілих числа через пробіл:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        // перевіряємо, чи введено рівно 2 числа
        if (numbers.Length != 2) {
            Console.WriteLine("Потрібно ввести два числа!");
            return;
        }

        // перетворюємо введені дані у цілі числа
        int num1 = int.Parse(numbers[0]);
        int num2 = int.Parse(numbers[1]);

        // нормалізуємо межі діапазону
        int start = Math.Min(num1, num2);
        int end = Math.Max(num1, num2);

        // виводимо всі парні числа в діапазоні
        for (int i = start; i <= end; i++) {
            if (i % 2 == 0) {
                Console.WriteLine(i);
            }
        }
    }
}
*/




/*Завдання 6
Створити базовий клас «Музичний інструмент» і похідні
класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель». За
допомогою конструктора, встановити назву до кожного
музичного інструменту і його характеристики.
Реалізуйте для кожного з класів методи:
■ Sound — видає звук музичного інструменту (пишемо
текстом у консоль);
■ Show — відображає назву музичного інструменту;
■ Desc — відображає опис музичного інструменту;
■ History — відображає історію створення музичного
інструменту.
using System;

class MusicalInstrument
{
    protected string name;
    protected string characteristics;

    public MusicalInstrument(string name, string characteristics)
    {
        this.name = name;
        this.characteristics = characteristics;
    }

    public virtual void Sound()
    {
        Console.WriteLine("This instrument makes a sound.");
    }

    public void Show()
    {
        Console.WriteLine("Musical instrument name: " + name);
    }

    public void Desc()
    {
        Console.WriteLine("Musical instrument description: " + characteristics);
    }

    public virtual void History()
    {
        Console.WriteLine("This instrument has a long history.");
    }
}

class Violin : MusicalInstrument
{
    public Violin(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("The violin makes a beautiful, soothing sound.");
    }

    public override void History()
    {
        Console.WriteLine("The violin has a rich history dating back to the 16th century.");
    }
}

class Trombone : MusicalInstrument
{
    public Trombone(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("The trombone has a bold, brassy sound.");
    }

    public override void History()
    {
        Console.WriteLine("The trombone was first developed in the mid-15th century and has been an important part of orchestras ever since.");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("The ukulele has a bright, cheerful sound.");
    }

    public override void History()
    {
        Console.WriteLine("The ukulele originated in Hawaii in the late 19th century and has become a popular instrument worldwide.");
    }
}

class Cello : MusicalInstrument
{
    public Cello(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("The cello has a rich, warm sound.");
    }

    public override void History()
    {
        Console.WriteLine("The cello evolved from the viola da gamba in the 17th century and has been a staple of classical music ever since.");
    }
}
*/



