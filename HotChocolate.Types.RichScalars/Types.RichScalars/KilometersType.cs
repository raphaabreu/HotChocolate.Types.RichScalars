namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `Kilometers` scalar type represents distances measured in kilometers.
    /// </summary>
    public class KilometersType : CustomFloatType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KilometersType"/> class.
        /// </summary>
        public KilometersType() : base("Kilometers")
        {
            Description = "The `Kilometers` scalar type represents distances measured in kilometers.";
        }
    }
}