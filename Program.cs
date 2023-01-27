internal class Program
{
    public static bool CompareObject(string string1, string string2)
    {
        if(string1.Equals(string2)) return true;
        return false;
    }

    public static bool CompareObject(int int1, int int2)
    {
        if(int1 == int2) return true;
        return false;
    }

    public static bool CompareObject(double double1, double double2)
    {
        if(double1 == double2) return true;
        return false;
    }

    public static bool CompareObject<T>(T obj1, T obj2)
    {
        return obj1.Equals(obj2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(CompareObject("Mateus", "Mateus"));
        Console.WriteLine(CompareObject("Mateus", "Matheus")); //Meu nome NAO TEM H!!!!!
        Console.WriteLine(CompareObject(1, 1));
        Console.WriteLine(CompareObject(1, 0));
        Console.WriteLine(CompareObject(3.14, 3.14));
        Console.WriteLine(CompareObject(3.14, 3.15));
        Console.WriteLine(CompareObject('M', 'M'));
        Console.WriteLine(CompareObject('M', 'N'));
    }
}