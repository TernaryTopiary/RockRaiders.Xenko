using Rock_Raiders.Scripts.Concepts.Cosmic.Time;

namespace Rock_Raiders.Scripts.Concepts.Gameplay
{
    public interface ITakeTimeToCreateable : ICreatable
    {
        Seconds TimeToCreate { get; set; }
    }
}