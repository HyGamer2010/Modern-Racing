using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public int speed;
    public int randSpeed;
    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomSpeed", 2, 0.5f);
        InvokeRepeating("SpawnBullet", 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(randSpeed <= 33)
        {
            speed = 3;
        }else if(randSpeed >= 66)
        {
            speed = 9;
        }else if(randSpeed > 33 && randSpeed < 66)
        {
            speed = 5;
        }
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
    void RandomSpeed()
    {
        randSpeed = Random.Range(1, 99);
    }
    void SpawnBullet()
    {
        if(gameObject.CompareTag("Enemy1"))
        {
            Instantiate(bullet1, gameObject.transform.position, bullet1.transform.rotation);
        }
        if(gameObject.CompareTag("Enemy2"))
        {
            Instantiate(bullet2, gameObject.transform.position, bullet2.transform.rotation);
        }
        if(gameObject.CompareTag("Enemy3"))
        {
            Instantiate(bullet3, gameObject.transform.position, bullet3.transform.rotation);
        }
    }
}
