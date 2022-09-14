using System;
namespace Program {
    class HelloWorld {
      static void Main(String args[]) {
          bool prime = true;
          Console.WriteLine("Enter a number to check");
          int n = Convert.ToInt32(Console.ReadLine());
          for(int i = 2; i < n/2; i++){
              if(n % i == 0){
                  prime = false;
                  break;
              }
          }
          if(prime){
              Console.WriteLine("Prime");
          }else{
              Console.WriteLine("Not Prime");
          }
      }
    }
}
    
