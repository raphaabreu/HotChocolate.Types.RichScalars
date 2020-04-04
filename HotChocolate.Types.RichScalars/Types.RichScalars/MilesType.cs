namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `Miles` scalar type represents distances measured in miles.
    /// </summary>
    public class MilesType : CustomFloatType
    {
        /// <inheritdoc />
        public MilesType() : base("Miles")
        {
            Description = "The `Miles` scalar type represents distances measured in miles.";
        }
    }
}