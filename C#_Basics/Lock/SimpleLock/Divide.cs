
internal class DivideMethod : IDivideMethod
{
    internal readonly object _locker = new object();
    static int _val1 = 1, _val2 = 1;

    int IDivideMethod.Divide()
    {
        int x = 0;
        lock (_locker)
        {
            if (_val2 != 0)
            {
                x = _val1 / _val2;
                Console.WriteLine(x);
            }
        }

        return x;
    }

}


