namespace passwordValidator
{
    public class Validator_Should
    {
        [Fact]
        public void MarkAsCorrectAPasswordWithMoreThan6Characters()
        {
            var validator = new PasswordValidator();

            var isValid = validator.Validate("1234567");

            isValid
                .Should()
                .BeTrue();
        }
    }
}
