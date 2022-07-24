using System.ComponentModel.DataAnnotations.Schema;

namespace Kalemati.Models
{
    public class Cards
    {
        private int Id { get; set; }
        private string card_name { get; set; }
        private string card_src { get; set; }
        public string Card_code { get; set; }
        [ForeignKey("Card_Category")]
        public int Category_Id { get; set; }
        public Card_Category Card_Category { get; set; }
    }
}
