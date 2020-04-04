namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `Radians` scalar type represents an angle in radians.
    /// </summary>
    public class RadiansType : CustomFloatType
    {
        /// <inheritdoc />
        public RadiansType() : base("Radians")
        {
            Description = "The `Radians` scalar type represents an angle in radians.";
        }
    }
}