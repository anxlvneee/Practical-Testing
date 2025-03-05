namespace ConsoleTests
{
    public class Tests
    {
        [Fact]
        public void Guess_ShouldReturnMore_WhenGuessIsLessThanNumber()
        {
            // Arrange
            var game = new GuessNumber(50);

            // Act
            var result = game.Guess(30);

            // Assert
            Assert.Equal("�i����", result);
        }

        [Fact]
        public void Guess_ShouldReturnLess_WhenGuessIsGreaterThanNumber()
        {
            // Arrange
            var game = new GuessNumber(50);

            // Act
            var result = game.Guess(80);

            // Assert
            Assert.Equal("�����", result);
        }

        [Fact]
        public void Guess_ShouldReturnCorrectMessage_WhenGuessIsEqualToNumber()
        {
            // Arrange
            var game = new GuessNumber(50);

            // Act
            var result = game.Guess(50);

            // Assert
            Assert.Contains("�i���!", result);
        }

        [Fact]
        public void Guess_ShouldHandleBoundaryValues()
        {
            // Arrange
            var gameMin = new GuessNumber(1);
            var gameMax = new GuessNumber(100);

            // Act
            var resultMin = gameMin.Guess(1);
            var resultMax = gameMax.Guess(100);

            // Assert
            Assert.Contains("�i���!", resultMin); 
            Assert.Contains("�i���!", resultMax);
        }
    }
}