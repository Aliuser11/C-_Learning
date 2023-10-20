//Kolekcje od str336
//Interfejsy IEnumerable i IEnumerator
using NUnit.Framework.Internal;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

string s = "Cześć";
IEnumerator rator = s.GetEnumerator();
while (rator.MoveNext())
{
    char c = (char)rator.Current;
    Console.Write(c + "."); // wynik: C.z.e.ś.ć.
}
public class MyCollection : IEnumerable
{
    int[] data = { 1, 2, 3 };
    public IEnumerator GetEnumerator()
    {
        foreach (int i in data)
            yield return i;
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
/*sposobem napisania metody GetEnumerator jest napisanie klasy bezpośrednio implementującej interfejs IEnumerator*/
namespace Numerable
{
    public class MyIntList : IEnumerable
    {
        int[] data = { 1, 2, 3 };
        public IEnumerator GetEnumerator() => new Enumerator(this);
        class Enumerator : IEnumerator // definicja wewnętrznej klasy
        { // dla enumeratora
            MyIntList collection;
            int currentIndex = -1;
            public Enumerator(MyIntList items) => this.collection = items;
            public object Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new InvalidOperationException("Enumeracja nie została rozpoczęta!");
                    if (currentIndex == collection.data.Length)
                        throw new InvalidOperationException("Za końcem listy!");
                    return collection.data[currentIndex];
                }
            }
            public bool MoveNext()
            {
                if (currentIndex >= collection.data.Length - 1) return false;
                return ++currentIndex < collection.data.Length;
            }
            public void Reset() => currentIndex = -1;
        }
    }
    public interface ICollection<T> : IEnumerable<T>, IEnumerable
    {
        int Count { get; }
        bool Contains(T item);
        void CopyTo(T[] array, int arrayIndex);
        bool IsSynchronized { get; }
        object SyncRoot { get; }
        void CopyTo(Array array, int index);
        bool IsReadOnly { get; }

        void Add(T item);
        bool Remove(T item);
        void Clear();
    }

    //IList<T> to standardowy interfejs kolekcji indeksowanych pozycyjnie.
    public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
    {
        T this[int index] { get; set; }
        int IndexOf(T item);
        //IndexOf wykonują przeszukiwanie liniowe listy i zwracają wartość -1, jeśli nie znajdą szukanego elementu
        void Insert(int index, T item);
        void RemoveAt(int index);
    }
    //Interfejsy IReadOnlyCollection<T> i IReadOnlyList<T>
    public interface IReadOnlyCollection<out T> : IEnumerable<T>, IEnumerable
    {
        int Count { get; }
    }
    public interface IReadOnlyList<out T> : IReadOnlyCollection<T>,
    IEnumerable<T>, IEnumerable
    {
        T this[int index] { get; }
    }
}

//Listy, kolejki, stosy i zbiory  str  3 5 4 
namespace ListyKolejkiStosyZbiory
{

}