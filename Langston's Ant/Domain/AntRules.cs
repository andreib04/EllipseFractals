using System;

namespace Langston_s_Ant.Domain
{
    public class AntRules
    {
        private readonly string rules;

        public AntRules(string rules)
        {
            if (string.IsNullOrWhiteSpace(rules))
                throw new ArgumentException("Rules invalid");

            this.rules = rules.ToUpper();
        }

        public char GetTurn(int state) => rules[state];

        public int StatesCount => rules.Length;
    }
}
