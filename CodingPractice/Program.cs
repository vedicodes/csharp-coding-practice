LognestSubString.Run();

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
        for (int i = 0; i < 10000; i++)
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
        foreach (var subNum in uniqueNumbers)
        {
            isSubset = lst2.Count(num2 => num2 == subNum) >= lst1.Count(num1 => num1 == subNum);
            if (!isSubset)
                break;
        }
        return isSubset;
    }
}

class Author
{
    public long Id { get; set; } = Random.Shared.NextInt64();
    public string name { get; set; }
    public string bookTitle { get; set; }
}

class AuthorBookSold
{
    public long Id { get; set; } = Random.Shared.NextInt64();
    public string bookTitle { get; set; }
    public string store { get; set; }
    public long copiesSold { get; set; }
}

class MostSoldAuthor
{
    public static void Run()
    {
        var authors = new List<Author>
        {
            new Author
            {
                name = "Amish",
                bookTitle = "Immortals of Meluha"
            },
            new Author
            {
                name = "Amish",
                bookTitle = "The Secret of the Nagas"
            },
            new Author
            {
                name = "Amish",
                bookTitle = "The Oath of the Vayuputras"
            },
            new Author
            {
                name = "Ashwin Sanghi",
                bookTitle = "The Rozabal Line"
            },
            new Author
            {
                name = "Ashwin Sanghi",
                bookTitle = "Chanakya''s Chant"
            },
            new Author
            {
                name = "Ashwin Sanghi",
                bookTitle = "The Krishna Key"
            },
            new Author
            {
                name = "Arundhati Roy",
                bookTitle = "The God of Small Things"
            },
            new Author
            {
                name = "Arundhati Roy",
                bookTitle = "The Ministry of Utmost Happiness"
            }
        };

        var booksSold = new List<AuthorBookSold>
        {
            new AuthorBookSold 
            {
                bookTitle = "Immortals of Meluha", store = "Amazon", copiesSold = 30000
            },
            new AuthorBookSold 
            {
                bookTitle = "Immortals of Meluha", store = "Flipkart", copiesSold = 10000
            },
            new AuthorBookSold 
            {
                bookTitle = "Immortals of Meluha", store = "Kindle", copiesSold = 10000
            },
            new AuthorBookSold 
            {
                bookTitle = "The Secret of the Nagas", store = "Amazon", copiesSold = 25000
            },
            new AuthorBookSold 
            {
                bookTitle = "The Secret of the Nagas", store = "Flipkart", copiesSold = 15000
            },
            new AuthorBookSold 
            {
                bookTitle = "The Secret of the Nagas", store = "Kindle", copiesSold = 10000
            },
            new AuthorBookSold 
            {
                bookTitle = "The Oath of the Vayuputras", store = "Amazon", copiesSold = 20000
            },
            new AuthorBookSold 
            {
                bookTitle = "The Oath of the Vayuputras", store = "Flipkart", copiesSold = 5000
            },
            new AuthorBookSold 
            {
                bookTitle = "The Oath of the Vayuputras", store = "Kindle", copiesSold = 5000
            },
            new AuthorBookSold 
            {
                bookTitle = "The Rozabal Line", store = "Amazon", copiesSold = 30000
            },
            new AuthorBookSold 
            {
                bookTitle = "The Rozabal Line", store = "Flipkart", copiesSold = 20000
            },
            new AuthorBookSold 
            {
                bookTitle = "Chanakya''s Chant", store = "Amazon", copiesSold = 20000
            },
            new AuthorBookSold 
            {
                bookTitle = "Chanakya''s Chant", store = "Flipkart", copiesSold = 20000
            },
            new AuthorBookSold 
            {
                bookTitle = "The Krishna Key", store = "Amazon", copiesSold = 30000
            },
            new AuthorBookSold 
            {
                bookTitle = "The Krishna Key", store = "Flipkart", copiesSold = 30000
            },
            new AuthorBookSold 
            {
                bookTitle = "The God of Small Things", store = "Amazon", copiesSold = 25000
            },
            new AuthorBookSold 
            {
                bookTitle = "The God of Small Things", store = "Kindle", copiesSold = 5000
            },
            new AuthorBookSold 
            {
                bookTitle = "The Ministry of Utmost Happiness", store = "Amazon", copiesSold = 15000
            },
            new AuthorBookSold 
            {
                bookTitle = "The Ministry of Utmost Happiness", store = "Kindle", copiesSold = 4000
            },
        };

        var result = authors.Join(booksSold, author => author.bookTitle, book => book.bookTitle, (author, book) => new 
        {
            author,
            book
        }).GroupBy(authorBook => authorBook.author.name).Select(data => new 
        {
            authorName = data.Key,
            soldCopies = data.Sum(bookData => bookData.book.copiesSold),
        }).OrderByDescending(authorGroup => authorGroup.soldCopies)
        .Select(result => result.authorName)
        .FirstOrDefault();

        Console.WriteLine(result);
    }
}

class LognestSubString
{
    public static void Run()
    {
        var inputStr = "aavvcccaa";
        var uniqueSquenceStr = new List<char> { inputStr.First() };
        for(int i = 1; i < inputStr.Length; i++)
        {
            if (uniqueSquenceStr.Last() != inputStr[i])
                uniqueSquenceStr.Add(inputStr[i]);
        }
        Console.WriteLine(string.Join("", uniqueSquenceStr));

        var outputStr = "";
        var windowLst = new List<char> { inputStr.First() };
        for(int i = 1; i < inputStr.Length; i++)
        {
            if (windowLst.Contains(inputStr[i]))
            {
                windowLst.Clear();
            }
            windowLst.Add(inputStr[i]);
            if (windowLst.Count >= outputStr.Length)
            {
                outputStr = string.Join("", windowLst);
            }
        }

        Console.WriteLine(outputStr);
    }
}

public interface ITesting1
{
    int Add();
}

public interface ITesting2
{
    int Add();
}

class Addition : ITesting1, ITesting2
{
    int ITesting1.Add()
    {
        return 1;
    }
    int ITesting2.Add()
    {
        return 2;
    }
}

class Example
{
    public static void Run()
    {
        ITesting1 testing1 = new Addition();
        Console.WriteLine(testing1.Add());
        ITesting2 testing2 = new Addition();
        Console.WriteLine(testing2.Add());
    }
}

class RemoveDuplicate
{
    public static void Run()
    {
        var inputStr = "aacAxTyAssDwADFGtRFGH@$^&*346@#$%dfgh".ToUpperInvariant();
        var result = new List<char>();
        for(int i = 0; i < inputStr.Length; i++)
        {
            var isNotInserted = true;
            foreach(var insertedChar in result)
            {
                isNotInserted = char.ToLowerInvariant(insertedChar) != char.ToLowerInvariant(inputStr[i]);
                if (!isNotInserted)
                    break;
            }
            if(isNotInserted)
            {
                result.Add(inputStr[i]);
            }
        }
        Console.WriteLine(string.Join("", result));
    }
}

sealed class SingletonBusiness
{
    private SingletonBusiness()
    {

    }

    private static SingletonBusiness _business { get; set;}

    public static SingletonBusiness business
    {
        get
        {
            if (_business == null)
            {
                _business = new SingletonBusiness();
            }
            return _business;
        }
    }
}

static class TestingStatic
{
    static TestingStatic()
    {

    }
    static void Run()
    {
        Console.WriteLine("Static Class");
    }
}

class TestingShadowBase
{
    public void Run()
    {
        Console.WriteLine("TestingShadowBase Run Method.");
    }
}

class TestingShadowDerived : TestingShadowBase
{
    public new void Run()
    {
        base.Run();
        Console.WriteLine("TestingShadowDerived Run Method.");
    }
}

public class TestingCode
{
    
    public void TestingOverloading(string str1)
    {
        Console.WriteLine("{0}", str1);
    }

    public bool TestingOverloading(string str1, string str2)
    {
        Console.WriteLine("{0}, {1}", str1, str2);
        return true;
    }

    public int TestingOverloading(int num1)
    {
        Console.WriteLine("{0}", num1);
        return num1;
    }
    
    /*
    Note: In method overloading the return type of the method doesn't matter only the parameters matter.
    */

    public delegate void Callback(string message);

    public static void HelloWorldMsg(string msg)
    {
        Console.WriteLine("Hello, World From {0}", msg);
    }

    public void HelloIamMsg(string name)
    {
        Console.WriteLine("Hello, I'm {0}", name);
    }

    public static void Run()
    {
        Callback callback = HelloWorldMsg;
        var testCode = new TestingCode();
        callback += testCode.HelloIamMsg;
        callback("The Developer!");
    }
}

public delegate void Notify();

public class EventNotification
{
    public event Notify ProcessCompleted;

    public void Run()
    {
        Console.WriteLine("Process Started");
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0}", i + 1);
        }
        OnProcessCompleted();
    }

    public void OnProcessCompleted()
    {
        ProcessCompleted?.Invoke();
    }
}

public class EventNotificationSub
{
    public static void Run()
    {
        var eventNoti = new EventNotification();
        eventNoti.ProcessCompleted += OnProcessCompleted;
        eventNoti.Run();
    }

    public static void OnProcessCompleted()
    {
        Console.WriteLine("Process Completed!");
    }
}