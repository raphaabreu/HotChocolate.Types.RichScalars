namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `MetersPerSecond` scalar type represents speeds measured in m/s.
    /// </summary>
    public class MetersPerSecondType : CustomFloatType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetersPerSecondType"/> class.
        /// </summary>
        public MetersPerSecondType() : base("MetersPerSecond")
        {
            Description = "The `MetersPerSecond` scalar type represents speeds measured in m/s.";
        }
    }
}