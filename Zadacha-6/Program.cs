// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

 Console.WriteLine("Жду число: ");
    int num_A = Convert.ToInt32(Console.ReadLine());
            if (num_A % 2 == 1)
            {
                Console.WriteLine("Число " + num_A + " является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число " + num_A + " является: ЧЁТНЫМ");
            }