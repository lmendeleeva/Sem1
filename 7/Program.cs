//Напишите программу, кот. на вход принимает трехзначное число 
//и на выходе показывает послежнюю цифру этого числа.

Console.Clear();
Console.WriteLine("Первый метод");
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
if (num<100 || num > 999){
    Console.WriteLine("Введено неправильное число");
    
}
else {int otvet = num % 10;
Console.WriteLine($"третья цифра: {otvet}");

Console.WriteLine("---------------------------------");
}

Console.WriteLine("Второй метод");
string number = Console.ReadLine();
if (number.Length > 3 || number.Length < 3) Console.WriteLine("Неправильно");
else { Console.WriteLine($"третья цифра: {number[2]}");
}

