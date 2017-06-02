using Xunit;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    public int CountRepeats(string firstInput, string secondInput)
    {
      int matchCount = 0;
      if (firstInput == secondInput)
      {
        matchCount += 1;
      }
      else
      {
        matchCount = 0;
      }
      return matchCount;
    }
  }
}
