﻿using BookMyEvent.Services.EventCatalog.DbContexts;
using BookMyEvent.Services.EventCatalog.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyEvent.Services.EventCatalog.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly EventCatalogDbContext _eventCatalogDbContext;

        public EventRepository(EventCatalogDbContext eventCatalogDbContext)
        {
            _eventCatalogDbContext = eventCatalogDbContext;
        }

        public async Task<IEnumerable<Event>> GetEvents(Guid categoryId)
        {
            return await _eventCatalogDbContext.Events
                .Include(x => x.Category)
                .Where(x => (x.CategoryId == categoryId || categoryId == Guid.Empty))
                .Include(x => x.Venue)
                .ToListAsync();
        }

        public async Task<Event> GetEventById(Guid eventId)
        {
            return await _eventCatalogDbContext.Events
                .Include(x => x.Category)
                .Include(x => x.Venue)
                .Where(x => x.EventId == eventId).FirstOrDefaultAsync();
        }

        //public async Task<bool> SaveChanges()
        //{
        //    return (await _eventCatalogDbContext.SaveChangesAsync() > 0);
        //}

    }
}
