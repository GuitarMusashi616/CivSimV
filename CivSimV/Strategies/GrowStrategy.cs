using CivSimV.Decisions;
using CivSimV.GameAI;
using CivSimV.Research;
using CivSimV.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivSimV.Strategies
{
    public class GrowStrategy
    {
        private readonly Game game = new Game();
        private List<Decision> decisionsMade = new List<Decision>();

        public void StartGame()
        {
            List<Decision> decisions = game.PendingDecisions();
            foreach (Decision decision in decisions)
            {
                HandleDecision(decision);
            }
        }

        public void HandleDecision(Decision decision)
        {
            switch (decision.DecisionType)
            {
                case DecisionType.TECH:
                    break;
                case DecisionType.POLICY:
                    break;
                case DecisionType.SETTLE:
                    Settler settler = (Settler) decision.DecisionMaker;
                    settler.Settle();
                    break;
            }
        }

        public void ChooseTech(TechResearch techResearch)
        {
            var options = techResearch;
            // decide which option to pick
            // exhaust all options somehow
            // choose first option then auto adds to civ stack
            // way in the future undo all the way back to here
            // that civ stack undo should have a decision index
            // just do the decision index + 1
            // (only works for lists) (how to do for which tile to improve?) (just come up with all options in a list with different priorities, smaller list means less DFS)

            // Decision should go into the stack?
            // Use decison in stack for undo
            // save decision index to decision
        }
    }
}
