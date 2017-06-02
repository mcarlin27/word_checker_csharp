using Xunit;
using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    public int CountRepeats(string firstInput, string secondInput)
    {
      string queryInput = firstInput.ToLower();
      string dataInput = secondInput.ToLower();
      // string separators = ".,/?!@#$%&;:";
      // separators.ToCharArray();
      string[] secondInputArray = dataInput.Split(' ');
      // secondInputArray.Replace(separators, "");
      int matchCount = 0;
      string match = queryInput;

      for(int i = 0; i < secondInputArray.Length; i++)
      {
        if (secondInputArray[i] == match)
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
