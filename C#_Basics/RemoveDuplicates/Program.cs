using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

Dictionary<string, int> RemoveDuplicate(/*List<List<string>> resultList*/)
{

    var finalList = new Dictionary<string, int>();
    //var finalList = Array.Empty<T>();

    Dictionary<string, int> first = new Dictionary<string, int>()
                {
                    {"cheese", 1},
                    {"cakes", 2},
                    {"milk", 3},
                    {"cheese", 3},
                };
    Dictionary<string, int> second = new Dictionary<string, int>()
                {
                    {"cheese", 5},
                    {"milk", 0},
                    {"cake", 4},
                };
    var results =
        (from x in first
         join y in second on x.Key equals y.Key
         where x.Value - y.Value > 0
         select new { x.Key, Value = x.Value - y.Value })
        .ToDictionary(p => p.Key, p => p.Value);



    var uniqueValues = second.GroupBy(pair => pair.Value)
                         .Select(group => group.First())
                         .ToDictionary(pair => pair.Key, pair => pair.Value);

    //var newDict = new Dictionary<string, int>();
    //finalList.Add(results);
    return uniqueValues;
    //    foreach (var singleList in resultList)
    //    {
    //        var s1 = singleList.ToString();
    //        var t = s1.Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
    //        Dictionary<string, string> dictionary =
    //                t.Select(item => item.Split('-')).ToDictionary(s => s[0], s => s[-]);
    //        var list = dictionary.Keys.ToList();
    //        finalList.Add(list);
    //    }
    //    return finalList;

}
Dictionary<string, int> dictionary = new Dictionary<string, int> 
    { 
                    { "cheese", 5},
                    {"milk", 0},
                    {"cake", 4},
                };
Dictionary <TKey, TValue> AddIfKeyUnique<TKey, TValue>( Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
{
    if (!dictionary.ContainsKey(key))
    {
        dictionary.Add(key, value);
    }
    return dictionary;
}
//var resultList = new List<List<string>>();
//resultList.Add(new List<string>{ "Index_SPXINDEX-450trend", "Index_1-5_trend"});
//resultList.Add(new List<string> { "Index_1-15_trend", "Index_1-30_trend" });

//Console.WriteLine( string.Join(", ", RemoveDuplicate(/*resultList*/)));
//Console.WriteLine(string.Join(", ", AddIfKeyUnique(dictionary, string key, int); // jak to wypełnić ?? 

var ret = "Index_SPXINDEX-5_trend" +
                "Index_SPXINDEX-15_trend" +
                "Index_1-5_trend" +
                "Index_1-30_trend" +
                "Index_2-5_trend" +
                "Index_2-15_trend" +
                "Index_3-450_trend" +
                "Index_3-60_trend" ;
int k = 2;

var itemsList = ret.Split(" ").Select(item =>
    {
        var parts = item.Split('-');
        Console.WriteLine(string.Join(", ", parts));
        return new { Key = parts[0], Value = parts[1] };
    }).ToList();

    var dict = new Dictionary<string, string>();
    foreach (var line in itemsList)
    {
        dict.Add(line.Key, line.Value);
        Console.WriteLine(line);
    }


var finalList = new List<List<string>>();
var partlist = new List<string>();

foreach (var singleList in resultList)
{
    return singleList
        .Select((x, i) => new { Index = i, Value = x })
        .GroupBy(x => x.Index / 1)
        .Select(x => x.Select(v => v.Value).ToList())
        .ToList();
}
return finalList;

public List<List<char>> RemoveDuplicate(List<List<string>> resultList)
{
    var finalList = new List<List<char>>();
    var partlist = new Dictionary<string, string>();

    foreach (var singleList in resultList)
    {
        foreach (var item in singleList)
        {
            var singleListSplit = item.Split(" ");
            var singleDict = singleListSplit.Distinct().ToDictionary(s => s.Split("-")[0], s => s.Split("-")[1]);
            Console.WriteLine(string.Join(", ", singleDict));
            partlist.Append(singleDict);
        }
        foreach (k for k, v in)

                // TO DO przerobić kazda  z list na dictionary i zostawić tyle te, które mają niepowtarzające się klucze;

                //var sd = singleDict.ToString();
                //var sl =  sd.ToList();
                //finalList.Add(sl);
            }
    return finalList;






//Dictionary<string, int> first = new Dictionary<string, int>()
//            {
//                {"cheese", 1},
//                {"cakes", 2},
//                {"milk", 3},
//            };
//Dictionary<string, int> second = new Dictionary<string, int>()
//            {
//                {"cheese", 0},
//                {"cakes", 1},
//                {"milk", 4},
//            };
//var results =
//    (from x in first
//     join y in second on x.Key equals y.Key
//     where x.Value - y.Value > 0
//     select new { x.Key, Value = x.Value - y.Value })
//    .ToDictionary(p => p.Key, p => p.Value);
//finalList.Add(results);
//return finalList;
