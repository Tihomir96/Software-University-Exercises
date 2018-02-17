using AutoMapper;
using Instagraph.DataProcessor.ExportDto;
using Instagraph.Models;

namespace Instagraph.App
{
    public class InstagraphProfile : Profile
    {
        public InstagraphProfile()
        {
            CreateMap<Post, UncommentedPostDto>()
                .ForMember(x => x.Picture, pp => pp.MapFrom(p => p.Picture.Path))
                .ForMember(x => x.User, u => u.MapFrom(p => p.User.Username));

            CreateMap<User, PopularUserDto>()
                .ForMember(x => x.Follower, f => f.MapFrom(u => u.Followers.Count));
        }
    }
}
