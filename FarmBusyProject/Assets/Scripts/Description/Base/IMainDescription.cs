using Description.Base.Player;

namespace Description.Base
{
    public interface IMainDescription
    {
        IPlayerMovementDescription PlayerMovementDescription { get; }
    }
}