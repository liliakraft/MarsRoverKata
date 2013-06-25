namespace MarsRoverKata
{
    public class Rover
    {
        private readonly Location initialLocation;
        private readonly IAmCommandController commandController;

        public Rover(Location initialLocation, IAmCommandController commandController)
        {
            this.initialLocation = initialLocation;
            this.commandController = commandController;
        }

        public Location CurrentLocation
        {
            get { return initialLocation; }
        }

        public void Move(char[] commands)
        {
            commandController.ParseCommands(commands);
        }
    }
}