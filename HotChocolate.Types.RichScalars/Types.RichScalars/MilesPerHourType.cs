namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `MilesPerHour` scalar type represents speeds measured in mi/h.
    /// </summary>
    public class MilesPerHourType : CustomFloatType
    {
        /// <inheritdoc />
        public MilesPerHourType() : base("MilesPerHour")
        {
            Description = "The `MilesPerHour` scalar type represents speeds measured in mi/h.";
        }
    }
}