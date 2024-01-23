using FileHelpers;

namespace sentiment
{
    [DelimitedRecord(",")]
    [IgnoreFirst(1)]
    internal class Feedback
    {
        [FieldOrder(1)]
        [FieldNullValue(0)]
        public int ID;

        [FieldOrder(2)]
        public string StartDate;

        [FieldOrder(3)]
        public string EndDate;

        [FieldOrder(4)]
        [FieldOptional]
        [FieldTrim(TrimMode.Both)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldConverter(typeof(MyStringConverter))]
        public string tweet_text;

        [FieldOrder(5)]
        [FieldOptional]
        public string Sentiment;

        [FieldOrder(6)]
        [FieldOptional]
        [FieldNullValue(0.0)]
        public double Score;
    }

    public class MyStringConverter : ConverterBase
    {
        public override string FieldToString(object from)
        {
            string output = base.FieldToString(from);
            // remove any line breaks before outputting
            output = output.Replace("\n", "");
            output = output.Replace("\r", "");
            return output;
        }

        public override object StringToField(string from)
        {
            return from;
        }
    }
}
