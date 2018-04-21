using Rock_Raiders.Scripts.Concepts.Cosmic.Time;

namespace Rock_Raiders.Scripts.Concepts.Gameplay.Shared
{
    public interface ITakeTimeToCreateable : ICreatable
    {
        Seconds TimeToCreate { get; set; }
    }
}