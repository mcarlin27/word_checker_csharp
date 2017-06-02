using Xunit;
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
      RepeatCounter instance = new RepeatCounter();

      //Act
      int matchCount = instance.CountRepeats(firstInput, secondInput);

      //Assert
      Assert.Equal(true, matchCount == 1);
    }
  }
}
