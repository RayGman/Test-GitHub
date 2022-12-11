namespace ScrollShooter
{
    public class PlayerShooter
    {        
        private float _speed;

        public PlayerShooter(PlayerView body, ShootTimer timer, Bullet bullet)
        {
            _body = body;
            _timer = timer;
            _factory = new BulletFactory(bullet);
        }

        public void Start(float speed)
        {
            _speed = speed;

            _timer.TimerSignal += OnTimerSignal;
            _timer.StartTimer(_speed);
        }

        public void Stop()
        {
            _timer.TimerSignal -= OnTimerSignal;
            _timer.StopTimer();
        }
        
        private void OnTimerSignal()
        {
            _factory.Create(_body.Barrel.position);
            _body.Shoot();
        }
    }
}