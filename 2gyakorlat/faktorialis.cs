using System; 
public class Faktorialis {
  static void Main(string[] args) {
    public Faktorialis() {
        int x;
        int i = 1;
        int fakt = 1;

        Console.Write("x: ");
        int.TryParse(Console.ReadLine(), out x);

        if (x < 0 || x > 14) {
            Console.WriteLine("0 <= n <= 14");
        } else {
            while (i <= x) {
              fakt = fakt * i;
              i = i + 1;
           }
        
        Console.WriteLine("{0} faktoriális = {1}", x, fakt);
       }
   }
 }
