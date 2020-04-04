namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `KilometersPerHour` scalar type represents speeds measured in km/h.
    /// </summary>
    public class KilometersPerHourType : CustomFloatType
    {
        /// <inheritdoc />
        public KilometersPerHourType() : base("KilometersPerHour")
        {
            Description = "The `KilometersPerHour` scalar type represents speeds measured in km/h.";
        }
    }
}