using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService.RequestHelpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //source //destination //adding item properties to auction dto
            CreateMap<Auction, AuctionDto>().IncludeMembers(member => member.Item);

            //source //destination 
            CreateMap<Item, AuctionDto>();

            CreateMap<CreateAuctionDto, Auction>().ForMember(destination => destination.Item, o => o.MapFrom(s => s));

            CreateMap<AuctionDto, Item>();
        }
    }
}
