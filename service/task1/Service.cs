using System.Diagnostics;

class ServiceTask1 : IService {
    private readonly Reader _reader;
    private readonly SpaceCounter _counter;

    public ServiceTask1(Reader reader, SpaceCounter counter) {
        _reader = reader;
        _counter = counter;
    }

    public async Task Run() {
        Console.WriteLine("start async");
        var sw1 = new Stopwatch();

        sw1.Start();
        string text1 = await _reader.AsyncRead("./files/1.txt");
        int spaces = _counter.Count(text1);
        Console.WriteLine(spaces);

        string text2 = await _reader.AsyncRead("./files/2.txt");
        spaces = _counter.Count(text2);
        Console.WriteLine(spaces);

        string text3 = await _reader.AsyncRead("./files/3.txt");
        spaces = _counter.Count(text3);
        Console.WriteLine(spaces);

        string text4 = await _reader.AsyncRead("./files/4.txt");
        spaces = _counter.Count(text4);
        Console.WriteLine(spaces);

        sw1.Stop();

        Console.WriteLine($"time: {sw1.ElapsedMilliseconds} ms");

        Console.WriteLine("end async");
  }
}
