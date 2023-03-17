// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
// либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. 

void ArrayElements3Simbol(string[] Row) // метод записи в массив элементов с длиной <=3 и вывода в консоль
{
    string[] RowLength3 = Array.FindAll(Row, person => person.Length <= 3);
    Console.WriteLine("Массив из строк с длиной меньше или равно 3 символам: " + String.Join(" ", RowLength3));
}

void Main()      // метод ввода элементов строки и записи в массив этих элементов
{
    Console.Clear();
    Console.Write("Введите слова(символы) строки через пробел: ");
    string row = Console.ReadLine()!;
    // создаем массив из подстрок, разделенных пробелами и удаляем пустые (только с пробелами) подстроки
    string[] Row = row.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    ArrayElements3Simbol(Row);
}

Main();