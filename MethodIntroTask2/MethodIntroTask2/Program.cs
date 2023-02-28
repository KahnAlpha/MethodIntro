int biggest(params int[] arr)
{   int max = arr[0]; 
    for(int i=1;i<arr.Length;i++)
    {
        if (arr[i]>max)
        { max = arr[i]; }   
    }
    return max;
}
Console.WriteLine("biggest number among given is:") ;
Console.WriteLine(biggest(50,80,56,45,81,25,-55,45,87)); 