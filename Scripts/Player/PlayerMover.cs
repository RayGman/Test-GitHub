using UnityEngine;

namespace ScrollShooter
{
    public class PlayerMover
    {
        private PlayerView _body;
        private InputHandler _inputHandler;
        
        private float _speed;

        public PlayerMover(PlayerView body, InputHandler input)
        {
            _body = body;
            _inputHandler = input;
        }

        public void Start(float speed)
        {
            _speed = speed;
            _inputHandler.Touched += OnTouched;
        }

        public void Stop()
        {
            _inputHandler.Touched -= OnTouched;
        }
        
        private void OnTouched(Vector3 touch)
        {
            _body.MoveX(touch.x, _speed);
        }
    }
}