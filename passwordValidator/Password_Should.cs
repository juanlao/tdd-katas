namespace passwordValidator
{
    public class Password_Should
    {
        [Theory]
        [InlineData("123456Aa", true)]
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
        public void ValidateDoNotContainACapitalLetter()
        {
            var passwordStringWithoutCapitalLetter = "password";

            var password = new Password(passwordStringWithoutCapitalLetter);

            password.IsValid
                .Should()
                .BeFalse();
        }

        [Fact]
        public void ValidateLowerCase()
        {
            var passwordStringWithoutLowerLetter = "PASSWORD";

            var password = new Password(passwordStringWithoutLowerLetter);

            password.IsValid
                .Should()
                .BeFalse();
        }

        [Fact]
        public void ValidateDoNotContainANumber()
        {
            var notcontainingANumber = "Password";

            var password = new Password(notcontainingANumber);

            password.IsValid
                .Should()
                .BeFalse();
        }

        //[Fact]
        //public void ContainAnUnderscore()
        //{
        //    Assert.Fail();
        //}
    }
}
