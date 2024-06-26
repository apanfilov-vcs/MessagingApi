using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DbUserConversations.DTOs;
using DbUserConversations.Models;

namespace DbUserConversations
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Conversation, GetConversationDto>();
            CreateMap<User, GetUserDto>();
            CreateMap<Message, GetMessageDto>();

            CreateMap<User, GetConversationUserDto>();
            CreateMap<Conversation, GetUserConversationDto>();
            CreateMap<User, GetMessageUserDto>();
            CreateMap<Conversation, GetMessageConversationDto>();
        }
    }
}