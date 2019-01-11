﻿using Pinzhi.Platform.Dto;
using Pinzhi.Platform.Model;
using AutoMapper;
using Pinzhi.Platform.Dto.Project;

namespace Pinzhi.Platform.WebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SetPlatformInput, PlatformInfo>();
            CreateMap<SetMenuInput, MenuInfo>();
            CreateMap<SetRoleInput, RoleInfo>();
            CreateMap<SetUserInput, UserInfo>();
            CreateMap<SetApiInput, ApiInfo>();
            CreateMap<SetAppInfoInput, AppInfo>();
            CreateMap<SetAppProjectInfoInput, AppNamespaceInfo>();
            CreateMap<SetAppConfigInfoInput, AppConfigInfo>()
                .ForMember(destination => destination.CreateTime, option => option.Ignore())
                .ForMember(destination => destination.LastTime, option => option.Ignore())
                .ForMember(destination => destination.Version, option => option.Ignore());
            CreateMap<SetProjectInput, ProjectInfo>();
        }
    }
}
