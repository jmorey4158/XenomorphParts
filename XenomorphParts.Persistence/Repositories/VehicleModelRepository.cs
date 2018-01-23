using System;
using System.Collections.Generic;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.DTO;
using XenomorphParts.Exceptions;

namespace XenomorphParts.Persistence.Repositories
{
    public class VehicleModelRepository : IVehicleModelRepository
    {
        private static readonly VehicleModelDto _model = new VehicleModelDto()
        {
            ManufacturerId = 382092098,
            Id = 129870977,
            Name = "Extremus ZXL - Mark 5",
            Description = "Freem Duplication Drive Type 3; Henkly Panning Thermal disapator.",
            BeginYear = 2345,
            EndYear = 2356
        };

        private static readonly VehicleModelDto _model2 = new VehicleModelDto()
        {
            ManufacturerId = 382092098,
            Id = 129870979,
            Name = "Extremus ZXK - Mark 6",
            Description = "Freem Duplication Drive Type 4; Henkly Panning Phased Thermal disapator.",
            BeginYear = 2357,
            EndYear = 2361
        };


        public IVehicleModelDto GetById(long id)
        {
            switch (id)
            {
                case 129870977:
                    return _model;

                case 129870979:
                    return _model2;

                default:
                    throw new VehicleModelNotFoundException($"Vehicle Model {id} not found.");
            }
        }

        public List<IVehicleModelDto> GetByManufacturerId(long maker)
        {
            if (maker == 382092098)
                return new List<IVehicleModelDto>()
                {
                    _model,
                    _model2
                };
            else
                throw new VehicleModelNotFoundException($"Vehicle Model for Manufacturer {maker} not found.");
        }

        public List<IVehicleModelDto> GetByName(string name)
        {
            switch (name)
            {
                case "Extremus ZXL - Mark 5":
                    return new List<IVehicleModelDto>() { _model };

                case "Extremus ZXK - Mark 6":
                    return new List<IVehicleModelDto>() { _model2 };

                default:
                    throw new VehicleModelNotFoundException($"Vehicle Model {name} not found.");
            }
        }

        public List<IVehicleModelDto> GetByYear(int year)
        {
            if (year >= 2345 && year <= 2356)
                return new List<IVehicleModelDto>() { _model };
            else if (year >= 2357 && year <= 2361)
                return new List<IVehicleModelDto>() { _model2 };
            else
                throw new VehicleModelNotFoundException($"Vehicle Model for year {year} not found.");
        }
    }
}
