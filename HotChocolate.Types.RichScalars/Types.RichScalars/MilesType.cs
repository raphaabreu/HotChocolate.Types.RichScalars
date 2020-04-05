namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The `Miles` scalar type represents distances measured in miles.
    /// </summary>
    public class MilesType : CustomFloatType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MilesType"/> class.
        /// </summary>
        public MilesType() : base("Miles")
        {
            Description = "The `Miles` scalar type represents distances measured in miles.";
        }
    }
}