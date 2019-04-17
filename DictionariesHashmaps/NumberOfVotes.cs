namespace NumberOfVotes
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, minVotes;
            int[] numOfCandidates;
            int[] numOfVotes;
            double avgMarks;

            string[] candidateName;

            Console.WriteLine("Enter number of candidates");
            size = int.Parse(Console.ReadLine());

            numOfCandidates = new int[size];
            candidateName = new string[size];
            numOfVotes = new int[size];

            for (int i = 0; i < numOfCandidates.Length; i++)
            {
                Console.WriteLine("Enter a Candidate Name");
                candidateName[i] = Console.ReadLine();

                Console.WriteLine("Enter number of votes thus far");
                numOfVotes[i] = int.Parse(Console.ReadLine());
            }

            int max = numOfVotes.Max();          
            avgMarks = numOfVotes.Average();
            minVotes = numOfVotes.Min();

            Console.WriteLine("Average votes: {0}", avgMarks);
            Console.WriteLine("Min number of votes is: {0}", minVotes);
        }
    }
}