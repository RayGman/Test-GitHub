using System.Collections;
using UnityEngine;

namespace ScrollShooter
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        private float _speed;
        private int _damage;
        
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            StartCoroutine(DestroyBullet());
        }

        public void Init(float speed, int damage)
        {
            _speed = speed;
            _damage = damage;
        }

        private void FixedUpdate()
        {
            _rigidbody.MovePosition(_rigidbody.position + Vector3.forward * _speed);
        }
        
        private IEnumerator DestroyBullet()
        {
            yield return new WaitForSeconds(2f);
            Destroy(gameObject);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out CubeView cube))
            {
                cube.TakeDamage(_damage);
            }
            
            Destroy(gameObject);
        }
    }
}