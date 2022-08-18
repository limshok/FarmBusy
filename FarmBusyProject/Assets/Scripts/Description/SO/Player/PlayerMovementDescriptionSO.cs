using Description.Base.Player;
using UnityEngine;

namespace Description.SO.Player
{
    [CreateAssetMenu(menuName = "Descriptions/Player/Movement", fileName = "PlayerMovementDescription")]
    public class PlayerMovementDescriptionSo : ScriptableObject, IPlayerMovementDescription
    {
        [SerializeField] private float _maxSpeed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _rotationSpeed;

        public float MaxSpeed => _maxSpeed;
        public float Acceleration => _acceleration;
        public float RotationSpeed => _rotationSpeed;
    }
}