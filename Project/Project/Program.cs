
Console.WriteLine("Hi have a nice day!");
//TestOne();
TestTwo();

/// <summary>
/// test 1
/// </summary>
void TestOne()
{

    Console.WriteLine("Test 1: ");

    int size;

    Console.Write("Enter the number of elements in the array: ");
    size = Convert.ToInt32(Console.ReadLine());


    int[] arr = new int[size];
    int[] EvenNumber = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Enter the "+ i +"th element: ");
        arr[i] = Convert.ToInt32(Console.In.ReadLine());
    }
    SortArray(arr);
    Console.WriteLine("Result is: ");
    foreach (int i in arr)
    {
        Console.Write(i +" ");
    }
    Console.ReadKey();

}
void SortArray(int[] arr)
{
    int temp = 0;
    List<int> lstEvens = new List<int>();
    List<int> lstOdds = new List<int>();

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            lstEvens.Add(arr[i]);
        }
        else
        {
            lstOdds.Add(arr[i]);
        }
    }

    int[] arrEvens = lstEvens.ToArray();
    int[] arrOdds = lstOdds.ToArray();

    for (int i = 0; i < arrEvens.Length; i++)
    {
        for (int j = i + 1; j < arrEvens.Length; j++)
        {

            if (arrEvens[j] > arrEvens[i])
            {
                temp = arrEvens[i];
                arrEvens[i] = arrEvens[j];
                arrEvens[j] = temp;
            }
        }
    }

    for (int i = 0; i < arrOdds.Length; i++)
    {
        for (int j = i + 1; j < arrOdds.Length; j++)
        {
            if (arrOdds[j] < arrOdds[i])
            {
                temp = arrOdds[i];
                arrOdds[i] = arrOdds[j];
                arrOdds[j] = temp;
            }
        }
    }
    Array.Resize(ref arr, ( arrOdds.Length + arrEvens.Length));
    arrOdds.CopyTo(arr, 0);
    arrEvens.CopyTo(arr, arrOdds.Length);
    
}

/// <summary>
/// test 2
/// </summary>

void TestTwo()
{
    Console.WriteLine("Test 2: ");

    string str = string.Empty;
    Console.WriteLine("Press string: ");
    str = Convert.ToString(Console.ReadLine());

    string reverse = string.Empty;
    for (int i = str.Length - 1; i >= 0; i--)
    {
        reverse += str[i];
    }
    if(reverse == str)
    {
        Console.WriteLine(str + " is Palindrome");
    }
    else
    {
        Console.WriteLine(str + " is not Palindrome");
    }
}