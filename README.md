# HotChocolate.Types.RichScalars

Simple extension to the original HotChocolate Type system to make it easier to have rich schemas by using custom scalars that describe common units of length, time, speed, area, angles, etc.

To use, install package then add to your schema builder:

    services.AddGraphQL(SchemaBuilder.New()
        .AddQueryType<YourQuery>()
        .AddRichScalars(Unit.Meters, Unit.MetersPerSecond, Unit.Degrees, Unit.Seconds, Unit.SquareMeters)
        .Create());

