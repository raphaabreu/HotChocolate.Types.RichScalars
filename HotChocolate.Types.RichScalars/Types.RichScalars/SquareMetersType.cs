namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `SquareMeters` scalar type represents areas measured in m^2.
    /// </summary>
    public class SquareMetersType : CustomFloatType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SquareMetersType"/> class.
        /// </summary>
        public SquareMetersType() : base("SquareMeters")
        {
            Description = "The `SquareMeters` scalar type represents areas measured in m^2.";
        }
    }
}