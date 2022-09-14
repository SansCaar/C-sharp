using System;
namespace Program {
    class HelloWorld {
      static void Main(String[] args) {
          int n  = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("The factors are:");
          for(int i = 1; i<=n;i++){
              if(n % i == 0){
                  Console.WriteLine(i);
              }
          }
      }
    }
}
    
