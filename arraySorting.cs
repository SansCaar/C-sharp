using System;
namespace Program {
    class HelloWorld {
      static void Main(String[] args) {
          int temp;
          int[] arr = new int[5];
          Console.WriteLine("Enter values in arr");
          for(int i = 0; i < 5; i++){
              arr[i] = Convert.ToInt32(Console.ReadLine());
          }
          
          for(int i = 0; i < arr.Length; i++){
              for(int j = i+1; j<arr.Length;j++){
                  if(arr[i]< arr[j]){
                      temp = arr[i];
                      arr[i] =arr[j];
                      arr[j] = temp;
                  }
              }
          }
          
          Console.WriteLine("Sorted arr in acending order");
          for(int i = 0; i < 5; i++){
              Console.WriteLine(arr[i]);
          }
      }
    }
}
    
