using System;
namespace Program {
    class HelloWorld {
      static void Main(String[] args) {
          int[] arr = new int[5];
          Console.WriteLine("Enter values in arr");
          for(int i = 0; i < 5; i++){
              arr[i] = Convert.ToInt32(Console.ReadLine());
          }
          Console.WriteLine("Enter num to search");
          int search = Convert.ToInt32(Console.ReadLine());
          for(int i = 0;i<arr.Length;i++){
              if(arr[i] == search){
                  Console.WriteLine("The element "+search+" is at "+(i+1)+" position");
                  break;
              }
          }
          
      }
    }
}
    
