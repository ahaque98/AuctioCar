﻿using AuctionService.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.Entities
{
    public class Auction
    {
        [Key]
        public Guid Id { get; set; }
        public int ReservePrice { get; set; } = 0;
        public string Seller { get; set; } //username from Claim (Auth)
        public string Winner { get; set; } 
        public int SoldAmount { get; set; }
        public int CurrentHighBid { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime AuctionEnd { get; set; }
        public Status Status { get; set; } = Status.Live; 
        public Item Item { get; set; }  
    }
}
