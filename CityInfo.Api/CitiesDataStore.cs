using CityInfo.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            // init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with the park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "blah",
                            Description = "more blah"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "blah",
                            Description = "more blah"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the unfinished Cathedral",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "blah",
                            Description = "more blah"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "blah",
                            Description = "more blah"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Salt Lake City",
                    Description = "The one with the Mormons",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "blah",
                            Description = "more blah"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "blah",
                            Description = "more blah"
                        }
                    }
                }
            };
        }
    }
}
