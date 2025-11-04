byte a = 1;
short b = 2;
int c = 3;
float d = 4.4f;
double e = 3.55;
char f = 'A';
bool g = true;

int num = 42;
string numStr = num.ToString();

string piStr = "3.14";
double piDouble = double.Parse(piStr);

Console.WriteLine($"Byte: {a}");
Console.WriteLine($"Short: {b}");
Console.WriteLine($"Int: {c}");
Console.WriteLine($"Float: {d}");
Console.WriteLine($"Double: {e}");
Console.WriteLine($"Char: {f}");
Console.WriteLine($"Bool: {g}");
Console.WriteLine($"Converted int to str: {numStr}");
Console.WriteLine($"Converted str to double: {piDouble}");