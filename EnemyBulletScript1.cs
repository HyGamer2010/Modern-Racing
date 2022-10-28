using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript1 : MonoBehaviour
{
    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("Enemy2");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(enemy.transform.position.x, transform.position.y - 0.01f, enemy.transform.position.z);
    }
}
