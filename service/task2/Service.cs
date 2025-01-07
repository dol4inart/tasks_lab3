
using System.Diagnostics;

class ServiceTask2 : IService
{
  private Reader _reader;
  private SpaceCounter _counter;

    public ServiceTask2(Reader reader, SpaceCounter counter) {
        _reader = reader;
        _counter = counter;
    }
    
    public async Task Run()
    {
        Console.WriteLine("start async");
        var sw1 = new Stopwatch();

        sw1.Start();
        var text1 =  _reader.AsyncRead("./files/1.txt");
        var text2 =  _reader.AsyncRead("./files/2.txt");
        var text3 =  _reader.AsyncRead("./files/3.txt");
        var text4 =  _reader.AsyncRead("./files/4.txt");

        var textes = await Task.WhenAll(text1, text2, text3, text4);

        for (int i = 0; i < textes.Length; i++) {
            Console.WriteLine(_counter.Count(textes[i]));
        }

        sw1.Stop();

        Console.WriteLine($"time: {sw1.ElapsedMilliseconds} ms");

        Console.WriteLine("end async");

    }
}
