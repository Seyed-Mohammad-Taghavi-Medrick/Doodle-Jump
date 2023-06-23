using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private Enemy[] enemyPrefabs;
    [SerializeField] private float enemyDistance = 25;
    [SerializeField] int enemyCount = 20;

    [SerializeField] Enemy firstEnemy;
    Enemy lastEnemy;
    void Start()
    {
        lastEnemy = firstEnemy;
        GenerateEnemies();
    }

    private void GenerateEnemies()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            var position = GetNextPos();

            var enemy = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
            lastEnemy = Instantiate(enemy, position, Quaternion.identity);
            lastEnemy.SetOriginPosition(position);
        }
    }

    Vector3 GetNextPos()
    {
        var yPosision = lastEnemy.transform.position.y + enemyDistance;
        return new Vector3(0, yPosision, 0);
    }

    public void MoveUpEnemy(Enemy enemy)
    {
        enemy.transform.position = GetNextPos();
        lastEnemy = enemy;
        enemy.SetOriginPosition(enemy.transform.position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            MoveUpEnemy(collision.gameObject.GetComponent<Enemy>());
        }
    }
}