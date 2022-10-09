
using PallindromeChall;

string word = "abcdcba";
string notPalStr = "abcdef";
int number = 1234321;
int notPalInt = 123456;

string palWord = "stack Cats";
string notPalWord = "Stack Dogs";
double palDouble = 12.321;
double notPalDouble = 12.123;

bool checkString = PallindromeCheckLogic.IsAPallindrome(word);
bool checknotPalStr = PallindromeCheckLogic.IsAPallindrome(notPalStr);
bool checkInt = PallindromeCheckLogic.IsAPallindrome(number);
bool checknotPalInt = PallindromeCheckLogic.IsAPallindrome(notPalInt);
bool checkpalWord = PallindromeCheckLogic.IsAPallindrome(palWord);
bool checknotPalWord = PallindromeCheckLogic.IsAPallindrome(notPalWord);
bool checkpalDouble = PallindromeCheckLogic.IsAPallindrome(palDouble);
bool checknotPalDouble = PallindromeCheckLogic.IsAPallindrome(notPalDouble);

Console.WriteLine($"abcdcba is a Pallindrome: {checkString}");
Console.WriteLine($"abcdef is a Pallindrome: {checknotPalStr}");
Console.WriteLine($"1234321 is a Pallindrome: {checkInt}");
Console.WriteLine($"123456 is a Pallindrome: {checknotPalInt}");
Console.WriteLine($"stack Cats is a Pallindrome: {checkpalWord}");
Console.WriteLine($"Stack Dogs is a Pallindrome: {checknotPalWord}");
Console.WriteLine($"12.321 is a Pallindrome: {checkpalDouble}");
Console.WriteLine($"12.123 is a Pallindrome: {checknotPalDouble}");