namespace passwordValidator
{
    public class Password_Should
    {
        [Theory]
        [InlineData("123456Aa", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void HasMinimalLength(string passwordString, bool expectedValidation)
        {
            var password = new Password(passwordString);

            password.IsValid
                .Should()
                .Be(expectedValidation);
        }

        [Fact]
        public void DoNotContainACapitalLetter()
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

        //[Fact]
        //public void ContainANumber()
        //{
        //    Assert.Fail();
        //}

        //[Fact]
        //public void ContainAnUnderscore()
        //{
        //    Assert.Fail();
        //}
    }
}
