using System;

class Program
{
        static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSequence(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }

    static void Main(string[] args)
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Write("Enter half DNA sequence: ");
            string halfDNA = Console.ReadLine();

            if (IsValidSequence(halfDNA))
            {
                Console.WriteLine("Current half DNA sequence: " + halfDNA);

                Console.Write("Do you want to replicate it? (Y/N): ");
                char replicateChoice = Console.ReadLine().ToUpper()[0];

                if (replicateChoice == 'Y')
                {
                    string replicatedHalfDNA = ReplicateSequence(halfDNA);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedHalfDNA);
                }
                else if (replicateChoice == 'N')
                {
                    // Skip replication
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            char continueChoice = Console.ReadLine().ToUpper()[0];

            if (continueChoice == 'Y')
            {
                Console.WriteLine();
            }
            else if (continueChoice == 'N')
            {
                continueProgram = false;
            }
            else
            {
                Console.WriteLine("Please input Y or N.");
            }
        }
    }

}