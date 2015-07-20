namespace MassEffect.Interfaces
{
    /// <summary>
    /// Manages commands from the user
    /// </summary>
    public interface ICommandManager
    {
        IGameEngine Engine { get; set; }

        void ProcessCommand(string command);

        void SeedCommands();
    }
}
