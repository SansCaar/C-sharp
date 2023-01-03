using System;
namespace abc
{
struct student {
    public int s_id;
    public String s_name;
    public String address;
}
class HelloWorld
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter the number of Students.");
        int n = Convert.ToInt32(Console.ReadLine());
        student[] arr = new student[n];
        for(int i= 0; i<n; i++) {
            arr[i].s_id = i;
            Console.WriteLine("Enter the name for index"+i+":");
            arr[i].s_name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the address for index"+i+":");
            arr[i].address = Convert.ToString(Console.ReadLine());
        }
        Console.WriteLine("Enter Search address");
        String searchAddress = Convert.ToString(Console.ReadLine());
        for( int i = 0; i<n; i++) {
            if(arr[i].address == searchAddress) {
                Console.WriteLine("ID:"+ arr[i].s_id);
                Console.WriteLine("Name:"+ arr[i].s_name);
                Console.WriteLine("Address:"+ arr[i].address);
            }
        }

    }
}
}