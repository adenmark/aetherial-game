using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {

    public float speed;

    //public int speed = 300; //This value can be modified to change the speed
    private Rigidbody2D body;



    void Start()
    {

        GameObject player = GameObject.Find("BulletPosition");

        gameObject.transform.position = player.transform.position;

        body = GetComponent<Rigidbody2D>();

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = (Input.mousePosition - sp).normalized;

        body.AddForce(dir * speed, ForceMode2D.Impulse);
        //body.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    Vector2 position = transform.position;
    //    //Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90);
    //    position = new Vector2(position.x, position.y + speed * Time.deltaTime);

    //    transform.position = position;
    //}

}
