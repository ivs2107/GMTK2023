using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody body;
    private float speed;
    public Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector3(speed * direction.x, 0, speed * direction.y);
    }
}
