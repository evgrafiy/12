// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Жду 3 числа:");
            Console.WriteLine("Введите первое число: ");
    int num_A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
    int num_B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
    int num_C = Convert.ToInt32(Console.ReadLine());

            int max = num_A;

            if (num_A > max)
            {
                max = num_A;
            }

            if (num_C > max)
            {
                max = num_C;
            }

            Console.WriteLine("Самое большое из чисел -> " + max);
