using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            DateTime creationDate = new DateTime();
            Priority priority = 0;
            string summary = null;
            string precondition = null;
            Status status = 0;
            int testCaseId = 0; 
            int stepNumber = 0;
            string actualResult = null;
            string expectedResult = null;




            for(;;)
            {
                Console.WriteLine("Choose an action:\n" +
                              "1 - Fill in the bug fields\n" +
                              "2 - Display bug fields");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Fill(
                        ref id,
                        ref creationDate,
                        ref priority,
                        ref summary,
                        ref precondition,
                        ref status,
                        ref testCaseId,
                        ref stepNumber,
                        ref actualResult,
                        ref expectedResult
                        );
                        break;
                    case 2:
                        Output(
                        ref id,
                        ref creationDate,
                        ref priority,
                        ref summary,
                        ref precondition,
                        ref status,
                        ref testCaseId,
                        ref stepNumber,
                        ref actualResult,
                        ref expectedResult
                        );
                        break;
                    default:
                        Console.WriteLine("Incorrect entry. Try again.");
                        break;
                }
            }
            
        }




        enum Priority
        {
            Low,
            Medium,
            High
        }
        enum Status
        {
            New,
            InProgress,
            Failed,
            Done
        }



        static void Fill(ref int id,
           ref DateTime creationDate,
           ref Priority priority,
           ref string summary,
           ref string precondition,
           ref Status status,
           ref int testCaseId,
           ref int stepNumber,
           ref string actualResult,
           ref string expectedResult)
        {
            Console.Write("Enter id:");
            id = int.Parse(Console.ReadLine());

            Console.Write("Enter priority(Low,Medium,High):");
            string prior = Console.ReadLine();
            switch (prior)
            {
                case "Low":
                    priority = Priority.Low;
                    break;
                case "Medium":
                    priority = Priority.Medium;
                    break;
                case "High":
                    priority = Priority.High;
                    break;
                default:
                    break;
            }
            creationDate = DateTime.Now;

            Console.Write("Enter summary:");
            summary = Console.ReadLine();

            Console.Write("Enter precondition:");
            precondition = Console.ReadLine();

            Console.Write("Enter status(New,InProgress,Failed,Done):");
            string stat = Console.ReadLine();
            switch (stat)
            {
                case "New":
                    status = Status.New;
                    break;
                case "InProgress":
                    status = Status.InProgress;
                    break;
                case "Failed":
                    status = Status.Failed;
                    break;
                case "Done":
                    status = Status.Done;
                    break;
                default:
                    break;
            }

            Console.Write("Enter Test Case Id:");
            testCaseId = int.Parse(Console.ReadLine());

            Console.Write("Enter Step Number:");
            stepNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Actual Result:");
            actualResult = Console.ReadLine();

            Console.Write("Enter Expected Result:");
            expectedResult = Console.ReadLine();
        }


        static void Output(
           ref int id,
           ref DateTime creationDate,
           ref Priority priority,
           ref string summary,
           ref string precondition,
           ref Status status,
           ref int testCaseId,
           ref int stepNumber,
           ref string actualResult,
           ref string expectedResult)
        {
            Console.WriteLine("OUTPUT");
            Console.WriteLine($"Id:{id} " +
                $"\nCreation Date: {creationDate} " +
                $"\nPriority:{priority} " +
                $"\nSummary:{summary} " +
                $"\nPrecondition:{precondition} " +
                $"\nStatus:{status}" +
                $"\nTest Case Id:{testCaseId}" +
                $"\nStep Number:{stepNumber}" +
                $"\nActual Result:{actualResult}" +
                $"\nExpected Result:{expectedResult}");
        }

    }




    

   
}
