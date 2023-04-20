using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectils : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;
    private float _timer;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

            if (_timer > 5)
            {
                Destroy(gameObject);
            }

    }
}
