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


// TODO: implicitly typed array


// TODO: multiple type array


// TODO: Tuples are lightweight data structures that group multiple data elements

