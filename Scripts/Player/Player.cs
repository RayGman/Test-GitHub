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

        }
    }
}