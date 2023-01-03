using System;
namespace abc
{
class HelloWorld
{
    static void Main()
    {
        int[][] n = new int[3][];
        n[0] = new int[]{3,4,5,6};
        n[1] = new int[]{3};
        n[2] = new int[]{3,4,5}

        int[][] numbers = new int[][] {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6, 7 },
            new int[] { 8, 9 }
        };
        // int sum = 0;

        for(int i = 0; i<numbers.Length; i++){
            for(int j = 0;j<numbers[i].Length; j++){
                // sum = sum + numbers[i][j];
                Console.Write(numbers[i][j]);
            }
            Console.WriteLine();
        }
        // for(subarr in numbers2){
        //     for(el in subarr){
        //         Console.WriteLine(el);
        //     }
        // }
    }
}
}