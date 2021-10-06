using System;
using System.Linq;
class MainClass {
  public static void Main (string[] args) {
    int evencount = 0;
    int oddcount = 0;
    int[] evennum =new int[10];
    int[] oddnum=new int[10];
    for(int count = 0; count < 10; count++)
    {
    Console.WriteLine ("Input number:");
    int numb = Convert.ToInt32(Console.ReadLine());
    if ((numb%2)==0)
    {
      evennum[evencount] =numb;
      evencount++;
    }
    else
    {
      oddnum[oddcount]=numb;
      oddcount++;
    }
    }
    int numToRemove = 0;
    evennum = evennum.Where(val => val != numToRemove).ToArray();
    oddnum = oddnum.Where(val=>val!=numToRemove).ToArray();
    Console.WriteLine("Odd Numbers in descending order:");
    Array.Reverse(oddnum);
    foreach (int i in oddnum)
    {
    Console.WriteLine(i);
    }
    Console.WriteLine("Even Numbers in ascending order:");
    Array.Sort(evennum);
    foreach (int i in evennum)
    {
      Console.WriteLine(i);
    }
    Console.WriteLine("Odd number sum: " + oddnum.Sum());
    Console.WriteLine("Even number sum: " + evennum.Sum());
  }
}