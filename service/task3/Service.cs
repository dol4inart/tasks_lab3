
using System.Diagnostics;

class ServiceTask3 : IService {

  private SpaceCounter _counter;

    public ServiceTask3(SpaceCounter counter) {
        _counter = counter;
    }

    public async Task Run()
    {
        var sw1 = new Stopwatch();

        sw1.Start();

        Console.WriteLine(await CountSpacesInFile("./files/1.txt"));
        Console.WriteLine(await CountSpacesInFile("./files/2.txt"));
        Console.WriteLine(await CountSpacesInFile("./files/3.txt"));
        Console.WriteLine(await CountSpacesInFile("./files/4.txt"));

        sw1.Stop();

        Console.WriteLine($"time: {sw1.ElapsedMilliseconds} ms"); 
    }

    public async Task<int> CountSpacesInFile(string path) {
      int spaces = 0;
      using (StreamReader reader = new StreamReader(path))
      {
            string? line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                spaces += _counter.Count(line);
            }
      }
      return spaces;
    }
}
