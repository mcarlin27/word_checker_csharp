using Xunit;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    public int CountRepeats(string firstInput, string secondInput)
    {
      string [] secondInputArray = secondInput.Split(' ');
      int matchCount = 0;

      for(int i = 0; i < secondInputArray.Length; i++)
      {
        if (secondInputArray[i] == firstInput)
        {
          matchCount ++;
        }
        else
        {
          matchCount += 0;
        }
      }
      return matchCount;
    }
  }
}
