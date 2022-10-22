using Description.Base.Player;
using Player.Movement;

namespace Player
{
    public class PlayerModel
    {
        public readonly PlayerMovementModel PlayerMovementModel;

        public PlayerModel(IPlayerDescription description)
        {
            PlayerMovementModel = new PlayerMovementModel(description.IPlayerMovementDescription);
        }
    }
}