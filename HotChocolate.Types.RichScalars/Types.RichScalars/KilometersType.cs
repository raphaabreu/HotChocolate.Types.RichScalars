namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `Kilometers` scalar type represents distances measured in kilometers.
    /// </summary>
    public class KilometersType : CustomFloatType
    {
        /// <inheritdoc />
        public KilometersType() : base("Kilometers")
        {
            Description = "The `Kilometers` scalar type represents distances measured in kilometers.";
        }
    }
}