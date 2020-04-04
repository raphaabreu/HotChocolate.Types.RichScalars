using System;

namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `Days` scalar type represents a period of time represented as the total number of days.
    /// </summary>
    public class DaysType : CustomTimeSpanType
    {
        /// <inheritdoc />
        public DaysType() : base("Days")
        {
            Description =
                "The `Days` scalar type represents a period of time represented as the total number of days.";
        }

        protected override double ConvertToDouble(TimeSpan value)
        {
            return value.TotalDays;
        }

        protected override TimeSpan ConvertToTimeSpan(double value)
        {
            return TimeSpan.FromDays(value);
        }
    }
}