using AutoMapper;
using GenertelPoc.Common.ViewModels.Home;
using GenertelPoc.Domain.BusinessObject;

namespace GenertelPoc.Common.Mappings
{
    public class ViewModelMapping : Profile
    {
        public ViewModelMapping()
        {
            CreateMap<FirstPageViewModel, Person>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName.Value))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.Age.Value));
            CreateMap<SecondPageViewModel, Person>()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email.Value));
        }
    }
}
