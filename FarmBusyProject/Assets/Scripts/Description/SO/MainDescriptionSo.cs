using Description.Base;
using Description.Base.Player;
using Description.SO.Player;
using UnityEngine;

namespace Description.SO
{
    [CreateAssetMenu(menuName = "Descriptions/Main", fileName = "MainDescription")]
    public class MainDescriptionSo : ScriptableObject,IMainDescription
    {
        [SerializeField] private PlayerDescriptionSo _playerMovementDescription;

        public IPlayerDescription PlayerMovementDescription => _playerMovementDescription;
    }
}