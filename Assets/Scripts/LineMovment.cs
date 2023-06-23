using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMovment : MonoBehaviour
{

    // For moving platforms
 /*   private bool To_Right = true;*/
    [SerializeField] private float Offset = 1.2f;
/*    [SerializeField] private float multiplier = 2;*/
    [SerializeField] private float speed = 1f;
 /*   [SerializeField] private float velocity;*/

    private Vector3 lastPos;
    private Platform platform;
    private float randomPos;
    private Enemy enemy;

    private void Start()
    {
        enemy = GetComponent<Enemy>();
      /*  randomPos = Random.Range(-1, 1);
        platform = GetComponent<Platform>();*/
    }

    void FixedUpdate()
    {
        /*        PlayerPrefs.SetString("Key", "name");
                var save = PlayerPrefs.GetString("Key");*/
        Vector3 Top_Left = UnityEngine.Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        var maxDistance = -Top_Left.x - Offset;
        transform.position = enemy.GetOriginPosition() + new Vector3(Mathf.Sin((Time.time + randomPos) * speed / maxDistance) * maxDistance,0 /*platform.GetInitialPosition()*//*.y*/, 0);
       
        
        
        /*velocity = Mathf.Abs((transform.position - lastPos).magnitude);
        lastPos = transform.position;*/

        // Instantiate enemy
        // Set parent
        // Set local position
        // Raycast to platform ground
        // Set new position

        // Move the platform

        //if (To_Right) // Move to right
        //{
        //    if (transform.position.x < -Top_Left.x - Offset)
        //        transform.position += new Vector3(0.1f, 0, 0);
        //    else
        //        To_Right = false;
        //}
        //else // Move to left
        //{
        //    if (transform.position.x > Top_Left.x + Offset)
        //        transform.position -= new Vector3(0.1f, 0, 0);
        //    else
        //        To_Right = true;
        //}
    }

    /* private int health = 3;

     public void Damage(int damage = 1)
     {
         health -= damage;

         if (health <= 0)
             Destroy(gameObject);
     }*/
}
