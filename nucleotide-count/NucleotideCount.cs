using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {   
        
        char[] validGenes = {'A', 'C', 'G', 'T' };
       
        Dictionary<char, int> genes = new Dictionary<char, int> 
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        for(int i = 0; i < sequence.Length; i++)
        {
             if(validGenes.Contains(sequence[i]))
             {
                genes[sequence[i]] = genes[sequence[i]] + 1;
             }
             else
             {
                throw new ArgumentException(); 
             }
        }
        return genes;
    }
}