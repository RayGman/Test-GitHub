using UnityEngine;
using UnityEngine.Serialization;

namespace ScrollShooter
{
    [CreateAssetMenu(fileName = "newPlayer", menuName = "Configs/PlayerConfig", order = 1)]
    public class PlayerConfig : ScriptableObject
    {
        [SerializeField] public float MoveSpeed;
        [SerializeField] public float AttackSpeed;
    }
}
