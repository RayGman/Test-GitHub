using System;
using UnityEngine;

namespace ScrollShooter
{
    public class InputHandler : MonoBehaviour
    {
        public event Action<Vector3> Touched;

        private Camera _camera;

        public void Init(Camera camera)
        {
            _camera = camera;
        }

        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 touch = _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
                
                if (Input.mousePosition.y <= Screen.height / 2)
                {
                    Touched?.Invoke(touch);
                }
            }
        }
    }
}