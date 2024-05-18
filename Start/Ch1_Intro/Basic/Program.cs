// Example file for C# Applied Data Structures by Joe Marini
// Basic data structures

string s1 = "Hello world";
char[] c1 = new char[] { 'f', 'a', 'm', 'i', 'l', 'y' };
// TODO: strings are collections of characters, and are immutable
Console.WriteLine(s1);
char[] c2 = new char[] { 'F', 'i', 'z', 'z', 'y', ' ', 'B', 'u', 'z', 'z' };
string s2 = s1;

string s3 = new string(c2);
Console.WriteLine(s3);
Console.WriteLine(s2);
Console.WriteLine(s1);
char[] c5= {'a', 'b'};
string s4 = new string(c5);
Console.WriteLine(c5);
// TODO: Be careful with string references


// TODO: Arrays are contiguous storage of the same variable type
int[] nums = new int[5];
int[] nums2 = {1, 2, 3, 4, 5};

// TODO: implicitly typed array
var a= new[] {"abc","def"};


// TODO: multiple type array
object[] obs = {"ABC", 1,2,3,true,false};

// TODO: Tuples are lightweight data structures that group multiple data elements
(string, int,bool) t1 = ("abc", 15, false);
Console.WriteLine($"{t1.Item1}, {t1.Item2}");
