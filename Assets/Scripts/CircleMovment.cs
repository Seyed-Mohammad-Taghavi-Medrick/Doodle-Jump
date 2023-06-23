using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovment : MonoBehaviour
{
    [SerializeField] float rotationradius = 2f, angularSpeed = 2f;

    float posx, posy, angle = 0f;
    private Vector3 rotationCenter;
    private Enemy enemy;

    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    void Update()
    {
        posx = rotationCenter.x + Mathf.Cos(angle) * rotationradius;
        posy = rotationCenter.y + Mathf.Sin(angle) * rotationradius;
        transform.position = enemy.GetOriginPosition() + new Vector3(posx, posy, 0);
        angle = angle + Time.deltaTime * angularSpeed;

        if (angle >= 360f)
        {
            angle = 0f;
        }
    }
}