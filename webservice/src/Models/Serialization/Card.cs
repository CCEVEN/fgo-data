namespace FGOData.Models.Serialization
{
    public class Card
    {
        public CardType Type { get; set; }
        public int HitCount { get; set; }

        public Card(CardType type, int hitCount)
        {
            Type = type;
            HitCount = hitCount;
        }
    }
}