using System;
using UnityEngine;

namespace ScrollShooter
{
    public class CubeView : MonoBehaviour
    {
        [SerializeField] private float _health;

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            _health -= damage;

            if (_health <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Destroy(gameObject);
        }
    }
}