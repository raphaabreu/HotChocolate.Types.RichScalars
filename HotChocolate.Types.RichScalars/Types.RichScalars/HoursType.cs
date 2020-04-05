using System;

namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `Hours` scalar type represents a period of time represented as the total number of hours.
    /// </summary>
    public class HoursType : CustomTimeSpanType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HoursType"/> class.
        /// </summary>
        public HoursType() : base("Hours")
        {
            Description =
                "The `Hours` scalar type represents a period of time represented as the total number of hours.";
        }

        protected override double ConvertToDouble(TimeSpan value)
        {
            return value.TotalHours;
        }

        protected override TimeSpan ConvertToTimeSpan(double value)
        {
            return TimeSpan.FromHours(value);
        }
    }
}