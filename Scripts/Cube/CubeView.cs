using System;
using UnityEngine;

namespace ScrollShooter
{
    public class CubeView : MonoBehaviour
    {
        [SerializeField] private float _health;

        public void TakeDamage(int damage)
        {
        }

        private void Die()
        {
            Destroy(gameObject);
        }
    }
}