using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 12, 14, 17, 20 };
        int sum = SumArrayValue(numbers, 2);
        Console.WriteLine(sum);
    }

    static int SumArrayValue(int[] inArray, int index)
    {
        int sum = 0;
        int ourNumber = inArray[index];
        string numberAsString = ourNumber.ToString();
        
        for (int i = 0; i < numberAsString.Length; i++)
        {
            char digitChar = numberAsString[i];

            if (char.IsDigit(digitChar))
            {
                int digit = int.Parse(digitChar.ToString());
                sum += digit;
            }
        }

        return sum;
        //int sum = 0;
        //if (index >= 0 && index < inArray.Length)
        //{
        //    int ourNumber = inArray[index];
        //    return inArray[index];
        //}
        //else
        //{
        //    // You might want to handle the case when the index is out of bounds.
        //    Console.WriteLine("Index is out of bounds.");
        //    return 0;
        //}
    }
}


