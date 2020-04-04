namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `Degrees` scalar type represents an angle in degrees.
    /// </summary>
    public class DegreesType : CustomFloatType
    {
        /// <inheritdoc />
        public DegreesType() : base("Degrees")
        {
            Description = "The `Degrees` scalar type represents an angle in degrees.";
        }
    }
}