using System;

namespace ConsoleHandler
{
    public class ConsoleReader
    {
        private ConsoleHandler _handler = new ConsoleHandler();


        public void Read(string input)
        {
            
            string input_ = input.ToLower();
            string[] parts = input_.Split(' ');
            
            switch (parts[0]) 
            {
                case "start":
                    _handler.Initialize(parts[1], parts[2]);
                    break;
                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }
        }
        
        
    }
}