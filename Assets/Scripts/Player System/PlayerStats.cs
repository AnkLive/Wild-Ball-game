using UnityEngine;

namespace WildBall.PlayerSystems
{
    [CreateAssetMenu(fileName = "PlayerStats", menuName = "Scriptable Objects/Player Stats", order = 0)]
    public class PlayerStats : ScriptableObject
    {
        [Range(0, 10)] public readonly float Speed = 2f;
    }
}
