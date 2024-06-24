using AutoMapper;
using GloboTicket.TicketManagment.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTicket.TicketManagment.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GloboTicket.TicketManagment.Application.Features.Events.Commands.CreateEvent;
using GloboTicket.TicketManagment.Application.Features.Events.Commands.DeleteEvent;
using GloboTicket.TicketManagment.Application.Features.Events.Commands.UpdateEvent;
using GloboTicket.TicketManagment.Application.Features.Events.Queries.GetEventDetail;
using GloboTicket.TicketManagment.Application.Features.Events.Queries.GetEventsList;
using GloboTicket.TicketManagment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagment.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();

            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            //CreateMap<Event, DeleteEventCommand>().ReverseMap();
        }
    }
}
