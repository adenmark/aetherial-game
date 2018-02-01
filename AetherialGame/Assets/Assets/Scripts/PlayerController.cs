using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //public GameObject PlayerBullet;
    //public GameObject bulletPosition;
    public float speed;
    private Rigidbody2D rb2d;
    

     // Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D> ();
	}



    // Update is called once per frame
	void FixedUpdate () {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    GameObject bullet = (GameObject)Instantiate(PlayerBullet);
        //    bullet.transform.position = bulletPosition.transform.position;

        // Debug.Log("Pressed left click.");
        //}

            

        //if (Input.GetMouseButtonDown(1))
        //    Debug.Log("Pressed right click.");

       


        //movment of the player 
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
	}


	
	
	
}
