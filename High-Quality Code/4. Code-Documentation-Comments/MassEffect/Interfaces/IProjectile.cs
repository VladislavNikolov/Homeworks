namespace MassEffect.Interfaces
{
    /// <summary>
    /// Describes a projectile that can be fired from a Starship
    /// </summary>
    public interface IProjectile
    {
        int Damage { get; set; }

        void Hit(IStarship ship);
    }
}
