using UnityEngine;

public class HW2PlayerShootStrong : MonoBehaviour
{
    public GameObject preFab;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float Timer = 1.0f;
    private float _currentTime = 1.0f;
    private bool _canShoot = true;

    private void Update()
    {
        TimerMethod();
        Shoot();
    }

    private void TimerMethod()
    {
        if (!_canShoot)
        {
            _currentTime -= Time.deltaTime;

            if (_currentTime < 0)
            {
                _canShoot = true;
                _currentTime = Timer;
            }
        }
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && _canShoot)
        {
            GameObject red = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            red.transform.SetParent(bulletTrash);

            _canShoot = false;
        }
    }
}
