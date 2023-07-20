namespace passwordValidator
{
    public class Password_Should
    {
        [Theory]
        [InlineData("123A4567", true)]
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
            var passwordStringWithCapitalLetter = "password";

            var password = new Password(passwordStringWithCapitalLetter);

            password.IsValid
                .Should()
                .BeFalse();
        }

        //[Fact]
        //public void ValidateLowerCase()
        //{
        //    Assert.Fail();
        //}

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
