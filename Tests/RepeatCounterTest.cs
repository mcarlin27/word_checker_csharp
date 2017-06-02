using Xunit;
using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounter_SingleLetterMatch_true()
    {
      //Arrange
      string firstInput = "a";
      string secondInput = "a";
      RepeatCounter instance = new RepeatCounter(firstInput, secondInput);
      Console.WriteLine(instance);

      //Act
      int matchCount = instance.CountRepeats(firstInput, secondInput);

      //Assert
      Assert.Equal(true, matchCount == 1);
    }
    [Fact]
    public void RepeatCounter_PartialMatch_false()
    {
      //Arrange
      string firstInput = "a";
      string secondInput = "am";
      RepeatCounter instance = new RepeatCounter(firstInput, secondInput);

      //Act
      int matchCount = instance.CountRepeats(firstInput, secondInput);

      //Assert
      Assert.Equal(true, matchCount == 0);
    }
    [Fact]
    public void RepeatCounter_SingleLetterMultiInputMatch_true()
    {
      //Arrange
      string firstInput = "a";
      string secondInput = "a m";
      RepeatCounter instance = new RepeatCounter(firstInput, secondInput);

      //Act
      int matchCount = instance.CountRepeats(firstInput, secondInput);

      //Assert
      Assert.Equal(true, matchCount == 1);
    }
    [Fact]
    public void RepeatCounter_SingleLetterMultiInputMultiMatch_true()
    {
      //Arrange
      string firstInput = "a";
      string secondInput = "a m a";
      RepeatCounter instance = new RepeatCounter(firstInput, secondInput);

      //Act
      int matchCount = instance.CountRepeats(firstInput, secondInput);

      //Assert
      Assert.Equal(true, matchCount == 2);
    }
    [Fact]
    public void RepeatCounter_MultiLetterMatch_true()
    {
      //Arrange
      string firstInput = "alex";
      string secondInput = "alex";
      RepeatCounter instance = new RepeatCounter(firstInput, secondInput);

      //Act
      int matchCount = instance.CountRepeats(firstInput, secondInput);

      //Assert
      Assert.Equal(true, matchCount == 1);
    }
    [Fact]
    public void RepeatCounter_MultiLetterMultiMatch_true()
    {
      //Arrange
      string firstInput = "alex";
      string secondInput = "alex m";
      RepeatCounter instance = new RepeatCounter(firstInput, secondInput);

      //Act
      int matchCount = instance.CountRepeats(firstInput, secondInput);

      //Assert
      Assert.Equal(true, matchCount == 1);
    }
    [Fact]
    public void RepeatCounter_MultiLetterMultiInputMultiMatch_true()
    {
      //Arrange
      string firstInput = "alex";
      string secondInput = "alex and alex";
      RepeatCounter instance = new RepeatCounter(firstInput, secondInput);

      //Act
      int matchCount = instance.CountRepeats(firstInput, secondInput);

      //Assert
      Assert.Equal(true, matchCount == 2);
    }
  }
}
