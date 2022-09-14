using System;
namespace Program {
    class HelloWorld {
      static void Main(String[] args) {
          int greatest;
          int[] arr = new int[5];
          Console.WriteLine("Enter values in arr");
          for(int i = 0; i < 5; i++){
              arr[i] = Convert.ToInt32(Console.ReadLine());
          }
          greatest = arr[0];
          for(int i = 1;i<arr.Length;i++){
              if(arr[0] < arr[i]){
                  greatest = arr[i];
              }
          }
          Console.WriteLine("Greatest num is "+ greatest);
      }
    }
}
    
