namespace LockSlim
{
    public interface IInterface
    {
        void Read();
        void WriteWhenDoesNotExist(object threadID);
        void Write(object threadID);
    }
}
