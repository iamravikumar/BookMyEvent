﻿using BookMyEvent.Services.ShoppingCart.Entities;
using System;

namespace BookMyEvent.Services.ShoppingCart.DTOs
{
    public class BasketChangeEventForPublication
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid EventId { get; set; }
        public DateTimeOffset InsertedAt { get; set; }
        public BasketChangeTypeEnum BasketChangeType { get; set; }
    }
}
