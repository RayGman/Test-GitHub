using UnityEngine;

namespace ScrollShooter
{
    public class Player
    {
        private PlayerConfig _config;
        private PlayerMover _mover;
        private PlayerShooter _shooter;

        public Player(PlayerConfig config, PlayerMover mover, PlayerShooter shooter)
        {
            _config = config;
            _mover = mover;
            _shooter = shooter;
        }

        public void Start()
        {
            if (_config.MoveSpeed <= 0)
            {
                _config.MoveSpeed = 1f;
            }
            
            if (_config.AttackSpeed <= 0)
            {
                _config.AttackSpeed = 1f;
            }
            
            _mover.Start(_config.MoveSpeed);
            _shooter.Start(_config.AttackSpeed);
        }
    }
}