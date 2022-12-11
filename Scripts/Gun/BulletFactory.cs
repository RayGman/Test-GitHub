using UnityEngine;

namespace ScrollShooter
{
    public class BulletFactory
    {
        private Bullet _bullet;

        public BulletFactory(Bullet bullet)
        {
            _bullet = bullet;
        }

        public void Create(Vector3 position)
        {
            Bullet bullet = GameObject.Instantiate(_bullet, position, Quaternion.identity);
            bullet.Init(0.25f, 25); // ВЫНЕСТИ В КОНФИГ
        }
    }
}