namespace passwordValidator
{
    public class Password_Should
    {
        [Theory]
        [InlineData("123456Aa_", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void ValidateMinimalLength(string passwordString, bool expectedValidation)
        {
            var password = new Password(passwordString);

            password.IsValid
                .Should()
                .Be(expectedValidation);
        }

        [Fact]
        public void ValidateContainACapitalLetter()
        {
            AssertValidationShouldFail("without_captial_letters_1");
        }

        [Fact]
        public void ValidateContainLowerCase()
        {
            AssertValidationShouldFail("CAPITAL_LETTERS_1");
        }

        [Fact]
        public void ValidateContainANumber()
        {
            AssertValidationShouldFail("Without_Numbers");
        }

        [Fact]
        public void ValidateContainAnUnderscore()
        {
            AssertValidationShouldFail("1Password");
        }

        private void AssertValidationShouldFail(string passwordString)
        {
            var password = new Password(passwordString);

            password.IsValid
                .Should()
                .BeFalse();
        }
    }
}
