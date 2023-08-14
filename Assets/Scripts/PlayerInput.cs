using UnityEngine;

namespace WildBall.Inputs
{

    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {

        private Vector3 _movement;

        private PlayerMovement _playerMovement;

        private void Awake() => _playerMovement = GetComponent<PlayerMovement>();

        void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            float vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);

            _movement = new Vector3(-horizontal, 0, -vertical).normalized;
        }

        private void FixedUpdate() 
        {
            _playerMovement.MoveCharacter(_movement);
        }
    }
}
