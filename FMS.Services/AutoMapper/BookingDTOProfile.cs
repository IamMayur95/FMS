using AutoMapper;
using FMS.Entities.DTOs;
using FMS.Entities.Models;

namespace FMS.Services.AutoMapper
{
    public class BookingDTOProfile : Profile
    {
        public BookingDTOProfile()
        {
            CreateMap<StatusType, StatusTypeDTO>();
            CreateMap<StatusTypeDTO, StatusType>();

            CreateMap<BuildingDetail, BuildingDetailDTO>();
            CreateMap<BuildingDetailDTO, BuildingDetail>();

            CreateMap<DeskDetail, DeskDetailDTO>();
            CreateMap<DeskDetailDTO, DeskDetail>();

            CreateMap<FloorDetail, FloorDetailDTO>();
            CreateMap<FloorDetailDTO, FloorDetail>();

            CreateMap<LocationDetail, LocationDetailDTO>();
            CreateMap<LocationDetailDTO, FloorDetail>();

            CreateMap<WingDetail, WingDetailDTO>();
            CreateMap<WingDetailDTO, WingDetail>();

            CreateMap<BookingDetail, BookingDetailDTO>();
            CreateMap<BookingDetailDTO, BookingDetail>();

            CreateMap<StatusType, StatusTypeDTO>();
            CreateMap<StatusTypeDTO, StatusType>();

            CreateMap<UserPreference, UserPreferencesDTO>();
            CreateMap<UserPreferencesDTO, UserPreference>();

            CreateMap<UserPermissionGroup, UserPermissionGroupDTO>();
            CreateMap<UserPermissionGroupDTO, UserPermissionGroup>();

            CreateMap<PermissionGroup, PermissionGroupDTO>();
            CreateMap<PermissionGroupDTO, PermissionGroup>();

            CreateMap<AdminConfiguration, AdminConfigurationDTO>();
            CreateMap<AdminConfigurationDTO, AdminConfiguration>();

            CreateMap<DeskAllocateDetail, DeskAllocateDetailDTO>();
            CreateMap<DeskAllocateDetailDTO, DeskAllocateDetail>();

            CreateMap<PhotoType, PhotoTypeDTO>();
            CreateMap<PhotoTypeDTO, PhotoType>();

            CreateMap<PhotoDetails, PhotoDetailsDTO>();
            CreateMap<PhotoDetailsDTO, PhotoDetails>();
        }
    }
}
