namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// "The `Meters` scalar type represents distances measured in meters.
    /// </summary>
    public class MetersType : CustomFloatType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetersType"/> class.
        /// </summary>
        public MetersType() : base("Meters")
        {
            Description = "The `Meters` scalar type represents distances measured in meters.";
        }
    }
}