using Model;

namespace ConsoleHandler
{
    public class ConsoleHandler
    {
        public Player Initialize(string name, string capcha)
        {
            if (capcha.ToLower() == "notbot")
            {
                return new Player(name, true);
            }
            else
            {
                return new Player("bot", false);
            }
        }

        public void MarkGrid(int x, int y)
        {
            
        }
        
        
        
        
    }
}