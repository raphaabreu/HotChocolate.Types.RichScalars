namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// "The `Meters` scalar type represents distances measured in meters.
    /// </summary>
    public class MetersType : CustomFloatType
    {
        /// <inheritdoc />
        public MetersType() : base("Meters")
        {
            Description = "The `Meters` scalar type represents distances measured in meters.";
        }
    }
}