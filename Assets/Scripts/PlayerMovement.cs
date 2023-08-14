using UnityEngine;

namespace WildBall.Inputs
{

    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float _speed = 2;

        private Rigidbody _playerRigidbody;

        private void Awake() => _playerRigidbody = GetComponent<Rigidbody>();

        public void MoveCharacter(Vector3 movement)
        {
            _playerRigidbody.AddForce(movement * _speed);
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
