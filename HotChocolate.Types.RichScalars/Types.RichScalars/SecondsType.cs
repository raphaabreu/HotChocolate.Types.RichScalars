using System;

namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `Seconds` scalar type represents a period of time represented as the total number of seconds.
    /// </summary>
    public class SecondsType : CustomTimeSpanType
    {
        /// <inheritdoc />
        public SecondsType() : base("Seconds")
        {
            Description =
                "The `Seconds` scalar type represents a period of time represented as the total number of seconds.";
        }

        protected override double ConvertToDouble(TimeSpan value)
        {
            return value.TotalSeconds;
        }

        protected override TimeSpan ConvertToTimeSpan(double value)
        {
            return TimeSpan.FromSeconds(value);
        }
    }
}
