namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `SquareMiles` scalar type represents areas measured in mi^2.
    /// </summary>
    public class SquareMilesType : CustomFloatType
    {
        /// <inheritdoc />
        public SquareMilesType() : base("SquareMiles")
        {
            Description = "The `SquareMiles` scalar type represents areas measured in mi^2.";
        }
    }
}