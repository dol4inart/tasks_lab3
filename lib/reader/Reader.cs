class Reader {
  public Reader() {
    
  }

  public async Task<string> AsyncRead(string path) {
    string text;
      using (StreamReader reader = new StreamReader(path))
    {
       text = await reader.ReadToEndAsync();
    } 

    return text;
  }


  public string SyncRead(string path) {
    string text;
    try { 
      using (StreamReader reader = new StreamReader(path))
    {
       text = reader.ReadToEnd();
    } 
    } 
    catch (Exception ex) { 
      Console.WriteLine(ex.Message); 
      return "";
    }

    return text;
  }
}
