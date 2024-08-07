using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CivSimV.Decisions
{
    public class Decision
    {
        public Decision(DecisionType decisionType, object decisionMaker, Type decisionMakerType)
        {
            DecisionType = decisionType;
            DecisionMaker = decisionMaker;
            DecisionMakerType = decisionMakerType;
        }

        public DecisionType DecisionType { get; }
        public Object DecisionMaker { get; }
        public Type DecisionMakerType { get; }
        public int DecisionIndex { get; set; } = 0;
    }
}
