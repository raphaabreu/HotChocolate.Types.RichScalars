namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `MetersPerSecond` scalar type represents speeds measured in m/s.
    /// </summary>
    public class MetersPerSecondType : CustomFloatType
    {
        /// <inheritdoc />
        public MetersPerSecondType() : base("MetersPerSecond")
        {
            Description = "The `MetersPerSecond` scalar type represents speeds measured in m/s.";
        }
    }
}