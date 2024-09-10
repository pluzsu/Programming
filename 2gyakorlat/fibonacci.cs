using System;

public class Fibonacci {
    static void Main(string[] args) {
        int n;
        int f = 0;

        Console.Write("n: ");
        int.TryParse(Console.ReadLine(), out n);
// n ellenőrzése

        if (n == 1 || n == 2) {
            f = 1;
        }
        else {
            // Fibonacci számok: 1 1 2 3 5 8 13 21 ...
            // i == 2
            int fibIMinus2 = 0;
            int fibIMinus1 = 1;
            int fibI = 1;
            int i = 3;

            while (i <= n) {
                fibIMinus2 = fibIMinus1;
                fibIMinus1 = fibI;
                fibI = fibIMinus1 + fibIMinus2;
                i = i + 1;
            }

            f = fibI;
        }
// csak az n- írjuk ki - Hova tegyük, hogy mindet kiírjuk?
        Console.WriteLine("Az {0}. Fibonacci szám: {1}", n, f);

    }
}
