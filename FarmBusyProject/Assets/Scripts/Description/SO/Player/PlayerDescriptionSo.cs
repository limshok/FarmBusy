using Description.Base.Player;
using UnityEngine;

namespace Description.SO.Player
{
    [CreateAssetMenu(menuName = "Descriptions/Player/Main",fileName = "PlayerDescription") ]
    public class PlayerDescriptionSo : ScriptableObject,IPlayerDescription
    {
        [SerializeField] private PlayerMovementDescriptionSo _playerMovementDescription;
        
        public IPlayerMovementDescription IPlayerMovementDescription => _playerMovementDescription;
    }
}