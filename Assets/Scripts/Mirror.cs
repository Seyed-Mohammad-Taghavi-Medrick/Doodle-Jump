using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    [SerializeField] Transform otherSide;
    [SerializeField] float makeDistance; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.position = new Vector3(otherSide.position.x + makeDistance, collision.transform.position.y, 0);
        }
    }


}
