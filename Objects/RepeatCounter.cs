using Xunit;
using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _firstInput;
    private string _secondInput;

    public RepeatCounter(string firstInput, string secondInput)
    {
      _firstInput = firstInput;
      _secondInput = secondInput;
    }
    public string GetFirstInput()
    {
      return _firstInput;
    }
    public void SetFirstInput(string firstInput)
    {
      _firstInput = firstInput;
    }
    public string GetSecondInput()
    {
      return _secondInput;
    }
    public void SetSecondInput(string secondInput)
    {
      _secondInput = secondInput;
    }
    public int CountRepeats(string firstInput, string secondInput)
    {
      string[] secondInputArray = secondInput.Split(' ');
      int matchCount = 0;
      string match = firstInput;

      for(int i = 0; i < secondInputArray.Length; i++)
      {
        if (secondInputArray[i] == match)
        {
          Console.WriteLine(secondInputArray[i]);
          matchCount ++;
        }
        else
        {
          Console.WriteLine(secondInputArray[i]);
          matchCount += 0;
        }
      }
      return matchCount;
    }
  }
}
