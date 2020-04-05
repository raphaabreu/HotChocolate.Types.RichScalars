namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `KilometersPerHour` scalar type represents speeds measured in km/h.
    /// </summary>
    public class KilometersPerHourType : CustomFloatType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KilometersPerHourType"/> class.
        /// </summary>
        public KilometersPerHourType() : base("KilometersPerHour")
        {
            Description = "The `KilometersPerHour` scalar type represents speeds measured in km/h.";
        }
    }
}