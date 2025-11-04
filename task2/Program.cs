class Circle
{
    const double PI = 3.14;

    static void Main (string [] args)
    {
        PI = 2.123; // This line will return a compilation error because the value of a constant cannot be changed.
    }
}