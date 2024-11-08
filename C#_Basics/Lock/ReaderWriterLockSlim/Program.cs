/*ReaderWriterLockSlim*/

using LockSlim;
using SlimLock;

internal class Program
{
    private static void Main(string[] args)
    {
        IInterface _methods = new Methods();

        new Thread(_methods.Read).Start();
        new Thread(_methods.Read).Start();
        new Thread(_methods.Read).Start();
        new Thread(_methods.Write).Start("First");
        new Thread(_methods.WriteWhenDoesNotExist).Start("Second");
    }
}