using System.Text.RegularExpressions;

namespace FiledValidatorAPI
{
    // delegate a method that checks not empty or null form field
    public delegate bool RequiredValidDel(string fieldVal);

    // reference a method that checks a string length between min and max
    public delegate bool StringLengthValidDel(string fieldVal, int min, int max);

    // reference a method that validate a date
    public delegate bool DateValidDel(string fieldVal, out DateTime validDatTime);

    // reference a method that checks a string with a regex pattern
    public delegate bool PatternMatchValidDel(string fieldVal, string pattern);

    // reference a method that validates a text field value against another text field value
    public delegate bool CompareFieldsValidDel(string fieldVal, string fieldValCompare);

    public class CommonFieldValidatorFunctions
    {
        private static RequiredValidDel _requiredValidDel = null;
        private static StringLengthValidDel _stringLengthValidDel = null;
        private static DateValidDel _dateValidDel = null;
        private static PatternMatchValidDel _patternMatchValidDel = null;
        private static CompareFieldsValidDel _compareFieldValidDel = null;

        public static RequiredValidDel RequiredFieldValidDel
        {
            get
            {
                if (_requiredValidDel == null)
                    _requiredValidDel = new RequiredValidDel(RequiredFieldValid);

                return _requiredValidDel;
            }
        }

        public static StringLengthValidDel StringLenghtFieldValid
        {
            get
            {
                if (_stringLengthValidDel == null)
                    _stringLengthValidDel = new StringLengthValidDel(StringFieldLengthValid);

                return _stringLengthValidDel;
            }
        }

        public static DateValidDel DateFieldValidDel
        {
            get
            {
                if (_dateValidDel == null)
                    _dateValidDel = new DateValidDel(DateFieldValid);

                return _dateValidDel;
            }
        }

        public static PatternMatchValidDel PatternMatchValidDel
        {
            get
            {
                if (_patternMatchValidDel == null)
                    _patternMatchValidDel = new PatternMatchValidDel(FieldPatternValid);

                return _patternMatchValidDel;
            }
        }

        public static CompareFieldsValidDel FieldsCompareValidDel
        {
            get
            {
                if (_compareFieldValidDel == null)
                    _compareFieldValidDel = new CompareFieldsValidDel(FieldComparisonValid);

                return _compareFieldValidDel;
            }
        }

        private static bool RequiredFieldValid(string fieldVal)
        {
            if(!string.IsNullOrEmpty(fieldVal))
                return true;

            return false;
        }

        private static bool StringFieldLengthValid(string fieldVal, int min, int max)
        {
            if(fieldVal.Length >= min && fieldVal.Length <= max)
                return true;

            return false;
        }

        private static bool DateFieldValid(string dateTime, out DateTime validDatTime)
        {
            return DateTime.TryParse(dateTime, out validDatTime);
        }

        private static bool FieldPatternValid(string fieldVal, string regularExpressionPattern) 
        { 
            Regex regex = new Regex(regularExpressionPattern);
            
            return regex.IsMatch(fieldVal);
        }

        private static bool FieldComparisonValid(string field1, string field2) 
        { 
            return field1.Equals(field2);
        }

    }
}
