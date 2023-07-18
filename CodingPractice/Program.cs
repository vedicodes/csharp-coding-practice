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