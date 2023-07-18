namespace passwordValidator
{
    public class Validator_Should
    {
        [Theory]
        [InlineData("1234567", true)]
        [InlineData("", false)]
        public void ValidateLength(string password, bool expectedValidation)
        {
            var validator = new PasswordValidator();

            var isValid = validator.Validate(password);

            isValid
                .Should()
                .Be(expectedValidation);
        }
    }
}
