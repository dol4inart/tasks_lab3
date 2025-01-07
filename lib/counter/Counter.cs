class SpaceCounter {
  public SpaceCounter() {

  }
  
  public int Count(string text) {
    int count = 0;
    for (int i = 0; i < text.Length; i++) {
      if (text[i] == ' ') {
        count++;
      }
    }
    return count;
  } 
}
