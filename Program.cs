using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> init = new List<int> { 1, 2, 3 };

        // First output
        var resultMap1 = Map(init, x => x + 1);
        var resultMap1ToString = Map(init, x => x.ToString());

        // Second output
        var resultFold = Fold(init, 0, (sum, x) => sum + x);
        var resultFoldToString = Fold(init, "", (str, x) => str + x.ToString());

        // Third output
        var resultMap2 = Map2(init, x => x + 6);
    }
}