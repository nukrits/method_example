//ითვლის ოთხკუთხედის ფართობს, თუ კი კონსოლში მივაწოდებთ გვერდის სიგრძეებს..
/*  
int a, b, c;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = a * b;
Console.WriteLine(c);
Console.WriteLine("============="); */

// ითვლის სტრინგ ტიპის სფეისების რაოდენობას

/*
using System.Threading.Channels;

class program
{
    static int countphrase (string phraseTocount)
    {
        return phraseTocount.Count();
    }
    static void Main(string[] args)
    {
        Console.Write("Enter the phrase =>");
        string phrase = Console.ReadLine();


        int p = countphrase(phrase);
        Console.WriteLine(p);
    }


}
*/

//ითვლის კონსოლში გადაწოდებული რიცხვის ციფრთა ჯამს

/*
public class SumExample
{
    public static void Main(string[] args)
    {
        int n, sum = 0, m;
        Console.Write("Enter a number: ");
        n = int.Parse(Console.ReadLine());
        while (n > 0)
        {
            m = n % 10;
            sum = sum + m;
            n = n / 10;
        }
        Console.Write("Sum is= " + sum);
        Console.ReadLine();
    }
} 

*/
//მასივიდან კონსოლში გამოაქვს მაქსიმალური მნიშნელობა

/*

int[] anArray = { 1, 5, 2, 7,25,125 };
int m = anArray.Max();

Console.WriteLine(m);

*/

//შემთხვევით დაგენერირებული რიცხვი აფასებს სტუდენტის შეფასებას (A,B,C,D,E)
/*
Console.WriteLine("One random integers between 0 and 100:");
for (int ctr = 0; ctr <= 0; ctr++)
{
    var t = (new Random()).Next(0, 101);
    Console.WriteLine(t);


    string value;


    if (t <= 50)
    {
        value = "Failed";
    }
    else if (t < 61 && t > 50)
    {
        value = "E";

    }
    else if (t < 71 && t > 60)
    {
        value = "F";
    }
    else if (t > 70 && t < 81)
    {
        value = "C";

    }
    else if (t > 80 && t < 91)
    {
        value = "B";

    }
    else if (t > 90 && t <= 100)
    {
        value = "A";

    }
    else
    {
        value = "eror";
    }

    Console.WriteLine(value);


} */