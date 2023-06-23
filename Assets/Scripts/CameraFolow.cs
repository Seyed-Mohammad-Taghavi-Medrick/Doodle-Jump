using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour
{
    [SerializeField] Palyer Player;
    [SerializeField] float Speed;
    private void FixedUpdate()
    {
        if (Player.IsDead())
            return;

        if (Player.transform.position.y > transform.position.y)
        {
            Vector3 Positions = new Vector3(transform.position.x, Player.transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, Positions, Speed * Time.deltaTime);
        }

    }
}
