using System.Diagnostics.Metrics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
//528
var options = new JsonWriterOptions { Indented = true };
using (var stream = File.Create("MyFile.json"))
using (var writer = new Utf8JsonWriter(stream, options))
{
    writer.WriteStartObject();
    // nazwa i wartość własności określone w jednym wywołaniu
    writer.WriteString("FirstName", "Dylan");
    writer.WriteString("LastName", "Lockwood");
    // nazwa i wartość własności określone w oddzielnych wywołaniach
    writer.WritePropertyName("Age");
    writer.WriteNumberValue(46);
    writer.WriteCommentValue("To jest (niestandardowy) komentarz.");
    writer.WriteEndObject();
}
//using var json = File.OpenRead(jsonPath);
//using JsonDocument document = JsonDocument.Parse(json);
//var options = new JsonWriterOptions { Indented = true };
//using (var outputStream = File.Create("NewFile.json"))
//using (var writer = new Utf8JsonWriter(outputStream, options))
//{
//    writer.WriteStartArray();
//    foreach (var person in document.RootElement.EnumerateArray())
//    {
//        int friendCount = person.GetProperty("Friends").GetArrayLength();
//        if (friendCount >= 2)
//            person.WriteTo(writer);
//    }
//}

// siec str 694 | HttpClient
//Uri
class UriAdress
{
    public void UriInfo()
    {
        Uri info = new Uri("http://www.domain.com:80/info/");
        Uri page = new Uri("http://www.domain.com/info/page.html");
        Console.WriteLine(info.Host); // www.domain.com
        Console.WriteLine(info.Port); // 80
        Console.WriteLine(page.Port); // 80 (Uri zna domyślny port dla HTTP)
        Console.WriteLine(info.IsBaseOf(page)); // True
        Uri relative = info.MakeRelativeUri(page);
        Console.WriteLine(relative.IsAbsoluteUri); // False
        Console.WriteLine(relative.ToString()); // page.html
        Uri u = new Uri("page.html", UriKind.Relative);
    }
}
class ClassWebClient
{
    //Metody przeznaczone do pobierania wymieniono poniżej:

    //public void DownloadFile(string adres, string nazwaPliku);
    //public string DownloadString(string adres);
    //public byte[] DownloadData(string adres);
    //public Stream OpenRead(stri
    //ng adres);
    public void DownloadFile()
    {
        WebClient wc = new WebClient { Proxy = null };
        wc.DownloadFile("http://www.albahari.com/nutshell/code.aspx", "code.htm");

        //WebClient oferuje asynchroniczne wersje jej długo wykonywanych metod
        //await wc.DownloadFileTaskAsync("http://oreilly.com", "webpage.htm");

    }


}
class CheckWebRequestWebResponse
{
    public async Task CheckWbRequest()
    {
        WebRequest req = WebRequest.Create
                        ("http://www.albahari.com/nutshell/code.html");
        req.Proxy = null;
        using (WebResponse res = req.GetResponse())
        using (Stream rs = res.GetResponseStream())
        using (FileStream fs = File.Create("code.html"))
            rs.CopyTo(fs);

        // w wariancie działającym asynchronicznie
        //WebRequest req = WebRequest.Create
        //("http://www.albahari.com/nutshell/code.html");
        req.Proxy = null;
        using (WebResponse res = await req.GetResponseAsync())
        using (Stream rs = res.GetResponseStream())
        using (FileStream fs = File.Create("code.html"))
            await rs.CopyToAsync(fs);

        /* Najprostszym sposobem użycia HttpClient jest utworzenie egzemplarza, a następnie wywołanie
         jednej z jego metod Get*(), przekazując jej adres URI:*/
        string html = await new HttpClient().GetStringAsync("http://linqpad.net");

        var client = new HttpClient();
        var task1 = client.GetStringAsync("http://www.linqpad.net");
        var task2 = client.GetStringAsync("http://www.albahari.com");
        Console.WriteLine(await task1);
        Console.WriteLine(await task2);
    }
    //GetAsync() i komunikaty odpowiedzi 705
    public async Task HttpClientHandlerExample()
    {
        //var handler = new HttpClientHandler { UseProxy = false };
        //var client = new HttpClient(handler);

        var client = new HttpClient();
        // metoda GetAsync() akceptuje również CancellationToken
        HttpResponseMessage response = await client.GetAsync("http://...");
        response.EnsureSuccessStatusCode();

        string html = await response.Content.ReadAsStringAsync();
        //HttpContent ma metodę CopyToAsync() pozwalającą na zapis
        using (var fileStream = File.Create("linqpad.html"))
            await response.Content.CopyToAsync(fileStream);


    }


}
}