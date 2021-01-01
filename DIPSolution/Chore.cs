namespace DIPSolution
{
    public class Chore : IChore
    {
        private ILogger logger;
        private IMessageSender messageSender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            this.logger = logger;
            this.messageSender = messageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            logger.Log($"Performed work on { ChoreName }");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            logger.Log($"Completed { ChoreName }");

            messageSender.SendMessage(Owner, $"The chore { ChoreName } is complete.");
        }
    }
}
