﻿using System.Collections;
using UnityEngine;

namespace ScrollShooter
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
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
        }
    }
}