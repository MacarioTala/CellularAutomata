using System;

namespace CellularAutomata
{
    class Program
    {
        
        static void Main(string[] args)
        {
      
            int length = 231;
            var generations = 1000;

            RunAutomata(length, generations, AutomataRules.Rule110);     
        }

       
        static void RunAutomata(int length, int generations, bool[] ruleToApply)
        {
            var midpoint = length % 2 > 0 ? (int)(length / 2) : (length / 2) - 1;
            var currentRow = new bool[length];
            currentRow[midpoint] = true;
            var previousRow = new bool[length];
            Array.Copy(currentRow, previousRow, length);

            plotRow(currentRow);
            for (int j = 1; j < generations; j++)
            {
                Array.Copy(applyRule(previousRow, ruleToApply), currentRow, length);

                plotRow(currentRow);

                Array.Copy(currentRow, previousRow, length);
            }
        }

        static bool[] applyRule(bool[] previousRow, bool[] condition)
        {
            var length = previousRow.Length;
            int leftEdge = 0;
            int rightEdge = length - 1;

            var currentRow = new bool[length];

            for (int i = 0; i <= length; i++)
            {
                var value = false;
                if (i == leftEdge)
                {
                    value = previousRow[i + 1] == false ? false : true;
                }
                if (i == rightEdge)
                { value = previousRow[i - 1] == true ? true : false; }

                if (i - 1 >= leftEdge && i + 1 <= rightEdge)
                {
                    if(previousRow[i-1]==true)
                    {
                        if (previousRow[i]==true)
                        { 
                            if(previousRow[i+1]==true)
                                { value = condition[0]; } //Condition 1 TTT 
                            else
                                { value = condition[1]; } //Condition 2 TTF
                        }
                        else
                        {
                            if (previousRow[i-1]==true)
                            {
                                if(previousRow[i+1]==true)
                                { value = condition[2]; }//Condition 3 TFT
                                else
                                { value = condition[3]; }//Condition 4 TFF
                            }
                        }
                    }
                    else
                    {
                        if(previousRow[i]==true)
                        {
                            if(previousRow[i+1] == true)
                            { value = condition[4]; }//Condition 5 FTT 
                            else
                            { value = condition[5]; }//Condition 6 Condition 6 FTF
                        }
                        else
                        {
                            if(previousRow[i+1]==true)
                            {value = condition[6];}//Condition 7 FFT
                            else 
                            { value = condition[7];}//Condition 8 FFF
                        }
                    }
                }

                if (i < length) { currentRow[i] = value;  }
            }
            return currentRow;
        }

        static void plotRow(bool[] currentRow )
        {
            foreach (bool cell in currentRow)
            {
                var value = cell == true ? 'X' : ' ';
                Console.Write(value);
            }
            Console.WriteLine();
        }
    }

}
