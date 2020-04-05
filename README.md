# HotChocolate.Types.RichScalars

Simple extension to the original HotChocolate Type system to make it easier to have rich schemas by using custom scalars that describe common units of length, time, speed, area, angles, etc.

[Nuget package](https://www.nuget.org/packages/HotChocolate.Types.RichScalars).

To use, install package using ``dotnet add package HotChocolate.Types.RichScalars`` then add to your schema builder:

    services.AddGraphQL(SchemaBuilder.New()
        .AddQueryType<YourQuery>()
        .AddRichScalars(Unit.Meters, Unit.MetersPerSecond, Unit.Degrees, Unit.Seconds, Unit.SquareMeters)
        .Create());

Rich units available as GraphQL Custom Scalars:

* Seconds
* Hours
* Days
* Degrees
* Radians
* Meters
* MetersPerSecond
* SquareMeters
* Kilometers
* KilometersPerHour
* SquareKilometers
* Miles
* MilesPerHour
* SquareMiles
