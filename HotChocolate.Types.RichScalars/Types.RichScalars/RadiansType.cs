namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `Radians` scalar type represents an angle in radians.
    /// </summary>
    public class RadiansType : CustomFloatType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadiansType"/> class.
        /// </summary>
        public RadiansType() : base("Radians")
        {
            Description = "The `Radians` scalar type represents an angle in radians.";
        }
    }
}