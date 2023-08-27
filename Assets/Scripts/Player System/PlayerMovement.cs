using UnityEngine;

namespace WildBall.PlayerSystems
{
    [RequireComponent(typeof(Rigidbody), typeof(KeyboardInput))]
    public class PlayerMovement : MonoBehaviour
    {
        private float _speed;
        private Rigidbody _playerRigidbody;
        private InputData _input;
        private IInput[] _inputsArray;
        private Vector3 _movement;

        public void Initialize(PlayerStats pStats) 
        {
            _speed = pStats.Speed;
            _playerRigidbody = GetComponent<Rigidbody>();
            _inputsArray = GetComponents<IInput>();
        }

        void Update()
        {
            GatherInputs();
            _movement = new Vector3(_input.horizontal, 0, _input.vertical).normalized;
        }

        private void FixedUpdate() 
        {
            MoveCharacter(_movement);
        }

        public void MoveCharacter(Vector3 movement)
        {
            _playerRigidbody.AddForce(movement * _speed);
        }

        void GatherInputs()
        {
            _input = new InputData();

            for (int i = 0; i < _inputsArray.Length; i++)
            {
                _input = _inputsArray[i].GenerateInput();
            }
        }

#if UNITY_EDITOR
        [ContextMenu("Reset Values")]
        public void ResetValues()
        {
            _speed = 2;
        }
#endif
    }
}
