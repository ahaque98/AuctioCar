using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities
{
    [Table("Items")] //setting db table name  
    public class Item
    {
        [Key]
        public Guid Id { get; set; }
        public string Make { get; set; } 
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; } 
        public int Mileage { get; set; }
        public string ImageUrl { get; set; }
        [ForeignKey("Auction")] //dependent entity of Auction (parent entity)
        public Guid AuctionId { get; set; }
        public Auction Auction { get; set; }
        
    }
}
