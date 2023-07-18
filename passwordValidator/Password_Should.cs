namespace passwordValidator
{
    public class Password_Should
    {
        [Theory]
        [InlineData("1234567", true)]
        [InlineData("", false)]
        public void HasMinimalLength(string password, bool expectedValidation)
        {
            var pass = new Password(password);

            var isValid = pass.Validate(password);

            isValid
                .Should()
                .Be(expectedValidation);
        }

        [Fact]
        public void ValidateCapitalLetter()
        {
            Assert.Fail();
        }

        [Fact]
        public void ValidateLowerCase()
        {
            Assert.Fail();
        }

        [Fact]
        public void ContainANumber()
        {
            Assert.Fail();
        }

        [Fact]
        public void ContainAnUnderscore()
        {
            Assert.Fail();
        }
    }
}
