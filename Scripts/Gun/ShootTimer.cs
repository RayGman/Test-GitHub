using System;
using System.Collections;
using UnityEngine;

namespace ScrollShooter
{
    public class ShootTimer : MonoBehaviour
    {
        public event Action TimerSignal;
        
        private float _cooldown;
        
        public void StartTimer(float cooldown)
        {
            _cooldown = cooldown;
            StartCoroutine(Timer());
        }
        
        public void StopTimer()
        {
            StopCoroutine(Timer());
        }

        private IEnumerator Timer()
        {
            while (true)
            {
                yield return new WaitForSeconds(_cooldown);
                TimerSignal?.Invoke();
            }
        }
    }
}