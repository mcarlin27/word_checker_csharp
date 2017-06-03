using System;
using System.Collections.Generic;

namespace WordCounter.Objects
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
      Console.WriteLine(secondInputArray);
      // secondInputArray.Replace(separators, "");
      int matchCount = 0;

      for(int i = 0; i < secondInputArray.Length; i++)
      {
        if (secondInputArray[i] == queryInput)
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
