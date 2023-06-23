using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{

    [SerializeField] float power = 10f;

    Rigidbody2D PlayerRigidBody;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0)
        {
            PlayerRigidBody = collision.gameObject.GetComponent<Rigidbody2D>();
            if (PlayerRigidBody != null)
            {
                PlayerRigidBody.velocity = new Vector2(PlayerRigidBody.velocity.x, power);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
