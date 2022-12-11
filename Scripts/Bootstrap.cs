using UnityEngine;

namespace ScrollShooter
{
    [RequireComponent(typeof(ShootTimer))]
    [RequireComponent(typeof(InputHandler))]
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private PlayerView _prefab;
        [SerializeField] private PlayerConfig _playerConfig;
        [SerializeField] private Transform _playerSpawn;
        [SerializeField] private Camera _camera;
        [SerializeField] private Bullet _bullet;
        
        private InputHandler _inputHandler;
        private ShootTimer _timer;

        private void Awake()
        {
            _inputHandler = GetComponent<InputHandler>();
            _timer = GetComponent<ShootTimer>();
            
            PlayerView playerView = Instantiate(_prefab, _playerSpawn.position, Quaternion.identity);
            playerView.Init(_playerConfig);

            PlayerMover mover = new PlayerMover(playerView, _inputHandler);
            PlayerShooter _shooter = new PlayerShooter(playerView, _timer, _bullet);
            
            Player player = new Player(_playerConfig, mover, _shooter);
            
            _inputHandler.Init(_camera);
            player.Start();
        }
    }
}