namespace MassEffect.Interfaces
{
    using System.Collections.Generic;
    using GameObjects.Enhancements;

    /// <summary>
    /// Describes  a game object that can be enhanced
    /// </summary>
    public interface IEnhanceable
    {
        IEnumerable<Enhancement> Enhancements { get; }

        void AddEnhancement(Enhancement enhancement);
    }
}
