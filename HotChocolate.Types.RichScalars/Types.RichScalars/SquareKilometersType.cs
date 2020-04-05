namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `SquareKilometers` scalar type represents areas measured in km^2.
    /// </summary>
    public class SquareKilometersType : CustomFloatType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SquareKilometersType"/> class.
        /// </summary>
        public SquareKilometersType() : base("SquareKilometers")
        {
            Description = "The `SquareKilometers` scalar type represents areas measured in km^2.";
        }
    }
}