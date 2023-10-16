Console.WriteLine("Please Enter the size of array");
int arraysize = int.Parse(Console.ReadLine());
int[] array = new int[arraysize];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Please enter Words for array elements");
    string a = (Console.ReadLine());
}

Console.WriteLine("please Enter size of array for second array");
int arraysiz2 = int.Parse(Console.ReadLine());

int[] array2 = new int[arraysiz2];
for (int i = 0; i < array2.Length; i++)
{
    Console.WriteLine("Please enter for second array element");
    string b = (Console.ReadLine());
}


int combinedarray = combinedarray (array, array2);
