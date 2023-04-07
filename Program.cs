using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Введите число M: ");
    int M = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());
    int sum = 0;

    for (int i = M; i <= N; i++) {
      sum += i;
    }

    Console.WriteLine("Сумма натуральных чисел от {0} до {1} равна {2}.", M, N, sum);
  }
}

