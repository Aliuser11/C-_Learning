using LockSlim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlimLock
{
    public class Methods : IInterface
    {
        static ReaderWriterLockSlim _rw = new ReaderWriterLockSlim();
        static List<int> _items = new List<int>();
        static Random _rand = new Random();

        void IInterface.Read()
        {
            while (true)
            {
                _rw.EnterReadLock();
                foreach (int i in _items) Thread.Sleep(10);
                _rw.ExitReadLock();
            }
        }

        void IInterface.Write(object threadID)
        {
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Liczba współbieżnych czytników: " + _rw.CurrentReadCount);
                    int newNumber = GetRandNum(100);
                    _rw.EnterWriteLock();
                    _items.Add(newNumber);
                    _rw.ExitWriteLock();
                    Console.WriteLine("Wątek " + threadID + " dodał " + newNumber);
                    Thread.Sleep(100);
                }
            }
        }
        void IInterface.WriteWhenDoesNotExist(object threadID)
        {
            for (int i = 0; i < 10; i++)
            {
                int newNumber = GetRandNum(100);
                _rw.EnterUpgradeableReadLock();
                if (!_items.Contains(newNumber))
                {
                    _rw.EnterWriteLock();
                    _items.Add(newNumber);
                    _rw.ExitWriteLock();
                    Console.WriteLine("Wątek " + threadID + " dodał " + newNumber);
                }
                _rw.ExitUpgradeableReadLock();
                Thread.Sleep(100);
            }
        }

        int GetRandNum(int max)
        {
            lock (_rand) return _rand.Next(max);
        }
    }
}
