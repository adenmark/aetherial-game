using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {


    public float speed;

	// Use this for initialization
	void Start () {
        //speed = 8f;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 position = transform.position;
        //Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90);
        position = new Vector2(position.x, position.y + speed * Time.deltaTime);

        transform.position = position;
	}
    
}
