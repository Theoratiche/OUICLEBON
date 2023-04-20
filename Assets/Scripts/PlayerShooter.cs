using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private GameObject playerBullet;
    [SerializeField] private Transform playerBulletPos;

    private float _timer;
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime; ;

        if(_timer > 0.5)
        {
            _timer = 0;
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(playerBullet, playerBulletPos.position, Quaternion.identity);
    }
}
