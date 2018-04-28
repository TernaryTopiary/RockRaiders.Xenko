namespace Rock_Raiders.Scripts.Miscellaneous
{
    public interface IFactory<out T>
    {
        T New();
    }
}