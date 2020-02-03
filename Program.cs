using System;

namespace CellularAutomata
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var methods = new AutomataMethods();
            int length = 231;
            var generations = 1000;

            methods.RunAutomata(length, generations, AutomataRules.Rule110);     
        }

       
        
    }

}
