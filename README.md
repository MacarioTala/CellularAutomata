# CellularAutomata
Configurable console app that shows cellular automata visualisations
Needs no external libraries
AutomataRules.cs contains rules that correspond to the Wolfram book. The order is:(from 0-7).
For example: if position 0 is true : if the previous row's cell is true, and the left and right cells are also true, mark this cell as true.

Conditions for the edge of the matrix are taken into account. 

length is the number of cells in a row
generations is the number of rows

TTT 
TTF
TFT
TFF
FTT
FTF
FFT
FFF
