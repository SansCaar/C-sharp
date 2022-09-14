using System;
namespace Program {
    class HelloWorld {
      static void Main(String[] args) {
          int n  = Convert.ToInt32(Console.ReadLine());
          int f=1;
          Console.WriteLine("The factors are:");
          for(int i = 2; i<=n;i++){
              f=f*i;
          }
          Console.WriteLine("Factorial number "+f);
      }
    }
}
    
