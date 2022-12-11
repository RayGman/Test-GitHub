using DG.Tweening;
using UnityEngine;

namespace ScrollShooter
{
    public class PlayerView : MonoBehaviour
    {
        [field: SerializeField] public Transform Barrel { get; private set; }

        public void Init(PlayerConfig config)
        {
            _config = config;
        }

        public void MoveX(float toX, float speed)
        {
            _move.Kill();
            _move = transform.DOMoveX(toX, speed).SetEase(Ease.Linear);
        }

        public void Shoot()
        {
            _shoot.Kill();
            transform.localScale = Vector3.one;
            _shoot = transform.DOShakeScale(_config.AttackSpeed / 5f, Vector3.right / 10f); // ВЫНЕСТИ В КОНФИГ
        }
    }
}