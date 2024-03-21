using System;
using System.Runtime.InteropServices;
using ConsoleHandler;
using Model;

namespace Othello3
{
    public class TwoBotSession
    {
        public TwoBotSession()
        {
            }
        public void Lanunch()
        {
            RuleSet _ruleSet = new RuleSet(8, 8);
            Player Player1 = new Player("A", true);
            Player Player2 = new Player("B", true);

            ConsoleWriter writer = new ConsoleWriter();
            
            Random random = new Random();

            
            _ruleSet.CurrentGrid.Cells[3,3].MarkBy(Player1);
            _ruleSet.CurrentGrid.Cells[4,4].MarkBy(Player1);
            _ruleSet.CurrentGrid.Cells[3,4].MarkBy(Player2);
            _ruleSet.CurrentGrid.Cells[4,3].MarkBy(Player2);

            while (_ruleSet.HasAvailableMoves())
            {
                var p1_options = _ruleSet.AvailableMoves(Player1);
                var p2_options = _ruleSet.AvailableMoves(Player2);
                
                int randomIndex1 = random.Next(0, p1_options.Count);
                var chosen_cell1 = p1_options[randomIndex1];
                chosen_cell1.MarkBy(Player1);
                p1_options.RemoveAt(randomIndex1);
                writer.BroadcastGame(_ruleSet.CurrentGrid);
                
                int randomIndex2 = random.Next(0, p2_options.Count);
                var chosen_cell2 = p2_options[randomIndex1];
                chosen_cell2.MarkBy(Player2);
                p2_options.RemoveAt(randomIndex2);
                writer.BroadcastGame(_ruleSet.CurrentGrid);
            }
            
        }
    }
}