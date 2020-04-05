namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `Degrees` scalar type represents an angle in degrees.
    /// </summary>
    public class DegreesType : CustomFloatType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DegreesType"/> class.
        /// </summary>
        public DegreesType() : base("Degrees")
        {
            Description = "The `Degrees` scalar type represents an angle in degrees.";
        }
    }
}