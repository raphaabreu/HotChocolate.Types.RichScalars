using System;
using HotChocolate.Types.RichScalars;

namespace HotChocolate
{
    public static class RichScalarsSchemaBuilderExtensions
    {
        /// <summary>
        /// Add rich scalars to the schema builder.
        /// </summary>
        /// <param name="builder">The schema builder.</param>
        /// <param name="units">The rich scalars to add.</param>
        /// <returns>The schema builder.</returns>
        public static ISchemaBuilder AddRichScalars(this ISchemaBuilder builder, params Unit[] units)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            foreach (var unit in units)
            {
                switch (unit)
                {
                    case Unit.Seconds:
                        builder.AddType(typeof(SecondsType));
                        break;

                    case Unit.Hours:
                        builder.AddType(typeof(HoursType));
                        break;

                    case Unit.Days:
                        builder.AddType(typeof(DaysType));
                        break;

                    case Unit.Degrees:
                        builder.AddType(typeof(DegreesType));
                        break;

                    case Unit.Radians:
                        builder.AddType(typeof(RadiansType));
                        break;

                    case Unit.Meters:
                        builder.AddType(typeof(MetersType));
                        break;

                    case Unit.MetersPerSecond:
                        builder.AddType(typeof(MetersPerSecondType));
                        break;

                    case Unit.SquareMeters:
                        builder.AddType(typeof(SquareMetersType));
                        break;

                    case Unit.Kilometers:
                        builder.AddType(typeof(KilometersType));
                        break;

                    case Unit.KilometersPerHour:
                        builder.AddType(typeof(KilometersPerHourType));
                        break;

                    case Unit.SquareKilometers:
                        builder.AddType(typeof(SquareKilometersType));
                        break;

                    case Unit.Miles:
                        builder.AddType(typeof(MilesType));
                        break;

                    case Unit.MilesPerHour:
                        builder.AddType(typeof(MilesPerHourType));
                        break;

                    case Unit.SquareMiles:
                        builder.AddType(typeof(SquareMilesType));
                        break;

                    default:
                        break;
                }
            }

            return builder;
        }
    }
}
