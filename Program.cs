// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
// либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. 

Console.Clear();
Console.Write("Введите слова(символы) строки через пробел: ");
string row = Console.ReadLine()!;
//далее создаем массив из подстрок, разделенных пробелами и удаляем пустые (только с пробелами) подстроки
string[] Row = row.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine(String.Join(" ", Row));

string[] RowLength3 = Array.FindAll(Row, person => person.Length <= 3);
foreach (var person in RowLength3) Console.WriteLine(person);