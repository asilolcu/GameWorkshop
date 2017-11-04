using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform Planet;

    private Rigidbody2D _body;

    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

	void Update ()
    {
		Planet.Rotate(Vector3.back, -Time.deltaTime * 10);
        if (Input.GetKey(KeyCode.Space))
        {
            _body.velocity = new Vector2(0, 6);
        }
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
