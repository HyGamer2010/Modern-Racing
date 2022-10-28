using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bullet;
    public float horizontalInput;
    public int speed;
    public bool boosting = false;
    public bool slowing;
    private BoostScript boostScript;
    // Start is called before the first frame update
    void Start()
    {
        boostScript = GameObject.Find("Boost").GetComponent<BoostScript>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        if(horizontalInput < 0 && !boosting)
    {
        slowing = true;
        speed = 3;
    } 
    if(horizontalInput > 0 && boostScript.canBoost == true)
    {
        boosting = true;
        speed = 9;
    }
    if(!boostScript.canBoost)
    {
        speed = 5;
    }
    if(horizontalInput == 0)
    {
        boosting = false;
        slowing = false;
        speed = 5;
    }
    if(Input.GetKeyDown(KeyCode.Space))
    {
        Instantiate(bullet, transform.position, bullet.transform.rotation);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Enemy Bullet"))
        {
            Destroy(other);
            Destroy(gameObject);
        }
    }
    }
    
}
