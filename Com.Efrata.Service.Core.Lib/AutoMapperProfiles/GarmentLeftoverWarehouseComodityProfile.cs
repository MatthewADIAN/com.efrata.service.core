﻿using AutoMapper;
using Com.Ambassador.Service.Core.Lib.Models;
using Com.Ambassador.Service.Core.Lib.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Core.Lib.AutoMapperProfiles
{
    public class GarmentLeftoverWarehouseComodityProfile : Profile
    {
        public GarmentLeftoverWarehouseComodityProfile()
        {
            CreateMap<GarmentLeftoverWarehouseComodityModel, GarmentLeftoverWarehouseComodityViewModel>()
                .ReverseMap();
        }
    }
}
