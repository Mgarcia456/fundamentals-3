// 1
// static void PrintList(List<string> MyList)
// {
// foreach(string item in MyList)
// {
// Console.WriteLine(item);
// }
// }
// List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
// PrintList(TestStringList);

// ================2nd way  my favorite way tbh
static void PrintList(List<string> MyList)
{
for(int i = 0; i < MyList.Count; i++)
{
Console.WriteLine(MyList[i]);
}
}

List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);

// ================ 3rd way 
// static void PrintList(List<string> MyList)
// {
// Console.WriteLine(String.Join(", ", MyList));
// }

// List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
// PrintList(TestStringList);

// 2
static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach (int num in IntList)
    {
        sum += num;
    }
    Console.WriteLine("The sum of the numbers in the list is: " + sum);
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
SumOfNumbers(TestIntList);

// 3 
static int FindMax(List<int> IntList)
{
    int max = IntList[0];
    foreach (int num in IntList)
    {
        if (num > max)
        {
            max = num;
        }
    }
    return max;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
int maxNum = FindMax(TestIntList2);
Console.WriteLine("The maximum number in the list is: " + maxNum);

//  4
static List<int> SquareValues(List<int> IntList)
{
    List<int> squaredList = new List<int>();
    foreach (int num in IntList)
    {
        squaredList.Add(num * num);
    }
    return squaredList;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
List<int> squaredList = SquareValues(TestIntList3);
Console.WriteLine("The squared list is: [" + string.Join(",", squaredList) + "]");

//  5
static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }
    }
    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
int[] nonNegativeArray = NonNegatives(TestIntArray);
Console.WriteLine("The non-negative array is: [" + string.Join(",", nonNegativeArray) + "]");

//  6
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach (KeyValuePair<string,string> kvp in MyDictionary)
    {
        Console.WriteLine(kvp.Key + ": " + kvp.Value);
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

//  7
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    return MyDictionary.ContainsKey(SearchTerm);
}

Console.WriteLine(FindKey(TestDict, "RealName")); 
Console.WriteLine(FindKey(TestDict, "Name"));

//  8 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    var result = new Dictionary<string,int>();
    for (int i = 0; i < Names.Count; i++)
    {
        result.Add(Names[i], Numbers[i]);
    }
    return result;
}
List<string> TestNamesList = new List<string>() {"Julie", "Harold", "James", "Monica"};
List<int> TestNumbersList = new List<int>() {6, 12, 7, 10};

Dictionary<string, int> testDict = GenerateDictionary(TestNamesList, TestNumbersList);
foreach (var item in testDict)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}