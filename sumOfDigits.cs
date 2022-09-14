using System;
namespace Program {
    class HelloWorld {
      static void Main(String[] args) {
          int n  = Convert.ToInt32(Console.ReadLine());
          int sum = 0;
          while(n > 0){
              int r = n % 10;
              sum = sum + r;
              n /= 10;
          }
          Console.WriteLine("Sum of digits is "+sum);
      }
    }
    
}
    
