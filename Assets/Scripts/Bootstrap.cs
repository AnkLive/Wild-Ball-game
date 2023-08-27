using UnityEngine;

namespace WildBall.PlayerSystems
{
    public class Bootstrap : MonoBehaviour
    {
        [Header("Objects")]
        [SerializeField] private PlayerMovement _playerMovement;

        [Header("Scriptable Objects")]
        [SerializeField] private PlayerStats _playerStats;
        private void Awake()
        {
            _playerMovement.Initialize(_playerStats);
        }
    }
}
