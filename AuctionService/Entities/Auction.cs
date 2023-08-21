namespace AuctionService.Entities
{
    public class Auction
    {
        public Guid Key { get; set; }
        public int ReservePrice { get; set; }
        public string Seller { get; set; } //username from Claim (Auth)
        public string Winner { get; set; }
        public int SoldAmount { get; set; }
        public int CurrentHighBid { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime AuctionEnd { get; set; }
        public Status Status { get; set; } = Status.live
    }
}
