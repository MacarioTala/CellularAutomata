namespace CellularAutomata
{
    public static class AutomataRules
    {
        public static readonly bool[] Rule1 = new bool[8]
                       {
                    true,
                    true,
                    true,
                    true,
                    true,
                    true,
                    true,
                    false
                       };

        public static readonly bool[] Rule2 = new bool[8]
                       {
                    true,
                    true,
                    true,
                    true,
                    true,
                    false,
                    true,
                    false
                       };

        public static readonly bool[] Rule3 = new bool[8]
                      {
                    false,
                    true,
                    false,
                    true,
                    true,
                    false,
                    true,
                    false
                      };

        public static readonly bool[] Rule30 = new bool[8]
              {
                    false,
                    false,
                    false,
                    true,
                    true,
                    true,
                    true,
                    false
              };

        public static readonly bool[] Rule90 = new bool[8]
              {
                    false,
                    true,
                    false,
                    true,
                    true,
                    false,
                    true,
                    false
              };

        public static readonly bool[] Rule110 = new bool[8]
            {
                    false,
                    true,
                    true,
                    false,
                    true,
                    true,
                    true,
                    false
            };

        public static readonly bool[] Rule250 = new bool[8]
              {
                    true,
                    true,
                    true,
                    true,
                    true,
                    false,
                    true,
                    false
              };

        
    }
}
