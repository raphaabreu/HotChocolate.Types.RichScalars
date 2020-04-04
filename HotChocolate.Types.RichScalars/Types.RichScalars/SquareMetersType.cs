namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `SquareMeters` scalar type represents areas measured in m^2.
    /// </summary>
    public class SquareMetersType : CustomFloatType
    {
        /// <inheritdoc />
        public SquareMetersType() : base("SquareMeters")
        {
            Description = "The `SquareMeters` scalar type represents areas measured in m^2.";
        }
    }
}