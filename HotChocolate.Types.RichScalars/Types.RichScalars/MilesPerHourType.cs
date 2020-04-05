namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `MilesPerHour` scalar type represents speeds measured in mi/h.
    /// </summary>
    public class MilesPerHourType : CustomFloatType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MilesPerHourType"/> class.
        /// </summary>
        public MilesPerHourType() : base("MilesPerHour")
        {
            Description = "The `MilesPerHour` scalar type represents speeds measured in mi/h.";
        }
    }
}