using Description.Base.Player;
using UnityEngine;

namespace Player.Movement
{
    public class PlayerMovementModel
    {
        public Vector2 Input;
        public float Speed;
        public IPlayerMovementDescription Description { get; }

        public PlayerMovementModel(IPlayerMovementDescription description)
        {
            Description = description;
        }
    }
}