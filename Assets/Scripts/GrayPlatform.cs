using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrayPlatform : MonoBehaviour
{
        /* private bool To_Right = true;*/
        [SerializeField] private float Offset = 1.2f;
        /* [SerializeField] private float multiplier = 2;*/
        [SerializeField] private float speed = 1f;
    [SerializeField] private float maxDistance = 2f;
    /* [SerializeField] private float velocity ;*/

    private float randomOffset;
    private Platform platform;

    private void Start()
    {
        platform = GetComponent<Platform>();
        randomOffset = Random.Range(-1f, 1f);
    }

    void FixedUpdate()
    {
        transform.position = platform.GetOriginPosition() + new Vector3(0, Mathf.Sin((Time.time + randomOffset) * speed) * maxDistance , 0);
    }
}

/*// For moving platforms
private bool To_Right = true;
private float Offset = 1.2f;

void FixedUpdate()
{
    // Move the platform
    Vector3 Top_Left = UnityEngine.Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));

    if (To_Right) // Move to right
    {
        if (transform.position.y < -Top_Left.y - Offset)
            transform.position += new Vector3(0, 0.1f, 0);
        else
            To_Right = false;
    }
    else // Move to left
    {
        if (transform.position.y > Top_Left.y + Offset)
            transform.position -= new Vector3(0,0.1f , 0);
        else
            To_Right = true;
    }
}*/