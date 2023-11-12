//1
static IEnumerable<IEnumerable<T>> CartesianProduct<T>
    (this IEnumerable<IEnumerable<T>> sequences)
{
    IEnumerable<IEnumerable<T>> emptyProduct =
      new[] { Enumerable.Empty<T>() };
    return sequences.Aggregate(
      emptyProduct,
      (accumulator, sequence) =>
        from accseq in accumulator
        from item in sequence
        select accseq.Concat(new[] { item }));
}

public class Programy
{
    static void Main(string[] args)
    {
        //2
        IEnumerable<IEnumerable<T>> CartesianProduct<T>(IEnumerable<IEnumerable<T>> sequences, IEnumerable<T>? localSequence)
        {
            IEnumerable<IEnumerable<T>> result = new[] { Enumerable.Empty<T>() };
            foreach (var sequence in sequences)
            {
                var localSequence = sequence;
                result = result.SelectMany(
                  _ => localSequence,
                  (seq, item) => seq.Concat(new[] { item })
                );
            }
            return result;
        }
        var sequences = new[] {
                new object[] { "black", "white", "red" },
                new object[] { 30, 32, 34, 36, 38 },
                new object[] { 28, 30, 32, 34 }};
        var result = CartesianProduct(sequences, localSequence);
    }
}


//3
static IEnumerable<IEnumerable<T>> CartesianProduct<T>(IEnumerable<IEnumerable<T>> sequences)
{
    IEnumerable<IEnumerable<T>> emptyProduct = new[] { Enumerable.Empty<T>() };
    return sequences.Aggregate(emptyProduct,
        (accumulator, sequence) =>
            from acc in accumulator
            from item in sequence
            select acc.Concat(new[] { item }));
}
//var sequences = new[] {
//                new object[] { "black", "white", "red" },
//                new object[] { 30, 32, 34, 36, 38 },
//                new object[] { 28, 30, 32, 34 }};

var sequences = new[] {

                new object[] { 1, -1 } };

var result = CartesianProduct(sequences);
foreach (var item in result)
{
    Console.WriteLine(string.Join(", ", item));
}

//4
static IEnumerable<T[]> CartesianProduct<T>(IList<T> items, int repeat)
{
    var total = (int)Math.Pow(items.Count, repeat);
    var res = new T[repeat];
    for (var i = 0; i != total; i++)
    {
        var n = i;
        for (var j = repeat - 1; j >= 0; j--)
        {
            res[j] = items[n % items.Count];
            n /= items.Count;
        }
        yield return res;
    }
}
foreach (var arr in CartesianProduct(new[] { 1, -1 }, 3))
{
    Console.WriteLine(string.Join(", ", arr));
}