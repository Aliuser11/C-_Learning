
internal class Program
{
    private static int Main(string[] args)
    {
        IDivideMethod _method = new DivideMethod();
        var x = _method.Divide();
        return x;
    }

}