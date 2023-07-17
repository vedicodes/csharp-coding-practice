Console.WriteLine(MultiSubset.IsMultiSubset(new List<int> { 1, 1, 2, 4, 4 }, new List<int> { 1, 2, 2, 3, 4, 3, 4, 1 }));

class AsyncPractice
{
    public static async Task<int> SomeTaskAsync()
    {
        Console.WriteLine("Task Start");
        await Task.Delay(1000);
        Console.WriteLine("Task Finish");
        return 1;
    }

    public static async Task<int> RunAsync()
    {
        Console.WriteLine("Practice Application Running");
        var someTask = SomeTaskAsync();
        for(int i = 0; i < 10000; i++)
        {
            Console.Write("{0}", i);
        }
        await someTask;
        Console.WriteLine("Practice Application Complete");
        return 1;
    }
}

class MultiSubset
{
    public static bool IsMultiSubset(IList<int> lst1, IList<int> lst2)
	{
		if (lst2.Count < lst1.Count)
			return false;
		var uniqueNumbers = new HashSet<int>(lst1);
		var isSubset = false;
		foreach(var subNum in uniqueNumbers)
		{
			isSubset = lst2.Count(num2 => num2 == subNum) >= lst1.Count(num1 => num1 == subNum);
			if (!isSubset)
				break;
		}
		return isSubset;
	}
}