// See https://aka.ms/new-console-template for more information
// Repozytorium do prac domowych: APBD-Cw1-s29792
namespace zajecia1;
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");

        for (var i = 0; i < 20; i++)
        {
            Console.WriteLine(i);
        }

        List<char> letters = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

        letters.ForEach(letter => Console.WriteLine(letter));
        
        // 2. Typy
        int myInt = 2;
        float myFloat = 3.14f;
        double myDouble = 3.14;
        decimal myDecimal = 3.14M;
        
        char myChar = 'a';
        bool myBool = true;
        
        long myLong = 9223372036854775807;
        short myShort = 32767;
        
        // Reference type
        string myString = "Hello, World!";
        String myString2 = "Hello, World!";
        
        int[] myIntArray = { 1, 2, 3, 4, 5 };
        int[,] my2DArray = new int[2, 2];
        my2DArray[0,0] = 1;
        
        // IEnumerable<>;
        // ICollection<>;
        List<int> myIntArr3 = new List<int>();
        myIntArr3.Add(1);
        myIntArr3.Remove(1);
        //myIntArr3.RemoveAt(0);
        
        HashSet<int> mySet = new HashSet<int>();
        mySet.Add(1);
        
        Dictionary<int, string> myDict = new Dictionary<int, string>();
        myDict.Add(1, "one");
        
        // 2.1 var keyword
        var myStr = "Hello";
        var myList = new List<string>();
        
        // 2.2 typy anonimowe oraz tuple
        var myAnonym = new { FirstName = "John", LastName = "Doe" };
        Console.WriteLine(myAnonym.FirstName);
        
        var myTuple = (fName: "John", lastName: "Doe");

        (int, int) MyMethod()
        {
            return (1, 1);
        }
        
        // 3. Decyzja
        if (true)
        {
            
        }
        else if(false)
        {
            
        }
        else
        {
            
        }

        var myVar = "myStr";
        switch (myVar)
        {
            case "str": break;
            case "str2": break;
            case "str3": break;
            default: break;
        }

        var myValue = myVar switch
        {
            "str" => "to jest str",
            "str2" => "to jest str2",
            _ => "to jest ?" // znak _ to default w tego typu switchu
        };
        
        // 4. Pętle
        for(int i = 0; i < 10; i++)
        {}

        while (false)
        {
            
        }

        do
        {

        } while (false);
        
        foreach (var number in myList)
        {
        }
        
        // 5. Null
        int? myNullable = null;
        // int myNonNullable2 = null; // error
        
        // string myNullableStr = null; // warning
        string? myNullableStr2 = null;
        
        if(myNullable != null) {}
        if(myNullableStr2 is not null) {}
        
        var str = myNullable?.ToString();
        // var myIntNotNull = myNullable is null ? 20 : myNullable;
        var myIntNotNull = myNullable ?? 20;
        myNullable ??= 20;
        
        // 6. Input
        var inputStr = Console.ReadLine();
        
        // 7. Klasy
        var rect2 = new Rectangle2(20, 30);
        Console.WriteLine(rect2.GetHeight());
        
        var rect = new Rectangle(20,30);
        
        // 7.1 Exceptions
        try
        {
            throw new MyCustomException("My ERROR");
        }
        catch (MyCustomException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        // 8. Zpis oraz odczyt pliku
        var lines = File.ReadAllLines("./test.txt");
        File.WriteAllLines("./test.txt", lines);
    }
}