using CityInfo.API.Models;

namespace CityInfo.API
{
    
    public class CitiesDataStore
    {
        public List<CityDto> Cities{ get; set; }
        public static CitiesDataStore Current { get; } =new CitiesDataStore();      

        public CitiesDataStore( )
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visisted urban park in the US."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscrapper located in Midtown Manhattan."
                        },
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedram that was never really finished.",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Antwerp Name",
                            Description = "Antwerp Description"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Antwerp Name",
                            Description = "Antwerp Description"
                        },
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Eiffel Tour",
                            Description = "Eiffel Tour Description"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "The Louvre",
                            Description = "The Louvre Description"
                        },
                    }
                }
            };
        }

    }
}
