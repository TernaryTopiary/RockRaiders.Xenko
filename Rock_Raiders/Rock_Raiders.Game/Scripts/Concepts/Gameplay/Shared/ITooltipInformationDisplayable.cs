namespace Rock_Raiders.Scripts.Concepts.Gameplay.Shared
{
    public interface ITooltipInformationDisplayable
    {
        string TooltipText { get; set; }
        bool IsTooltipVocalized { get; set; }
    }
}