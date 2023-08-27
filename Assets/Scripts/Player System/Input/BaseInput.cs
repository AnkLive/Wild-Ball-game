using UnityEngine;

namespace WildBall.PlayerSystems
{
    public struct InputData
    {
        public float horizontal;
        public float vertical;
    }

    public interface IInput
    {
        InputData GenerateInput();
    }
    public abstract class BaseInput : MonoBehaviour, IInput
    {  
        public abstract InputData GenerateInput();
    }
}
