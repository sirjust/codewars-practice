using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplementaryDNA
{
    class DnaStrand
    {
        public static string MakeComplement(string dna)
        {
            // my solution
            Dictionary<char, char> correspondingChemicals = new Dictionary<char, char> { { 'A', 'T' }, { 'T', 'A' }, { 'G', 'C' }, { 'C', 'G' } };
            string result = "";
            foreach (char c in dna)
            {
                result += correspondingChemicals[c];
            }
            return result;
        }

        public static string MakeComplement2(string dna)
        {
            // one line solution
            return dna.Replace('T', 'a').Replace('A', 't').Replace('G', 'c').Replace('C', 'g').ToUpper();
        }

        public static string MakeComplement3(string dna)
        {
            // linq query syntax solution
            return String.Join("", from c in dna
                                   select "TCGA"["AGCT".IndexOf(c)]);
        }
    }
}
