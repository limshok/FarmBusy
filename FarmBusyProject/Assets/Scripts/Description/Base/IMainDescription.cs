using Description.Base.Player;

namespace Description.Base
{
    public interface IMainDescription
    {
        IPlayerDescription PlayerMovementDescription { get; }
    }
}