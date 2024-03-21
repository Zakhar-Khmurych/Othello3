namespace Model
{
    public class Player
    {
        public string Name { get; set; }
        
        public bool IsHuman { get; set; }

        public Player(string name, bool is_bot)
        {
            Name = name;
            IsHuman = is_bot;
        }
    }
}