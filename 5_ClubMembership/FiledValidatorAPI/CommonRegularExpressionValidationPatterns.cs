namespace FiledValidatorAPI
{
    public static class CommonRegularExpressionValidationPatterns
    {
        public const string Email_Address_RegEx_Pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        public const string Uk_PhoneNumber_RegEx_Pattern = @"^(\+44\s?|0)7\d{9}$";

        public const string Uk_Post_Code_RegEx_Pattern = @"^([GIR]0AA|[A-Z]{1,2}\d[A-Z\d]? \d[A-Z]{2})$";

        public const string Strong_Passwprd_RegEx_Pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
    }
}
