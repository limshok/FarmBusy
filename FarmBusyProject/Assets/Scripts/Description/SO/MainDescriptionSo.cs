using Description.Base;
using Description.Base.Player;
using Description.SO.Player;
using UnityEngine;

namespace Description.SO
{
    [CreateAssetMenu(menuName = "Descriptions/Main", fileName = "MainDescription")]
    public class MainDescriptionSo : ScriptableObject,IMainDescription
    {
        [SerializeField] private PlayerMovementDescriptionSo _playerMovementDescription;

        public IPlayerMovementDescription PlayerMovementDescription => _playerMovementDescription;
    }
}