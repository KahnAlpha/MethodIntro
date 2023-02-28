void search(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            Console.WriteLine(number + " exists in array given");
            break;
        }
        else if (i == array.Length - 1)
        {
            Console.WriteLine(number + " no match for element you entered");
        }
    }
}


int[] array()
{
    Console.Write("enter the number of elements in array: ");
    int numbersofelements = int.Parse(Console.ReadLine());

    int[] arr = new int[numbersofelements];

    Console.WriteLine("enter the elements of array");
    for (int i = 0; i < numbersofelements; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }

    return arr;
}


int enternumber()
{
    Console.Write("Enter the number you're searching for search: ");
    return int.Parse(Console.ReadLine());
}


int[] arr = array();
int N = enternumber();
search(arr, N);
