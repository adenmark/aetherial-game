using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoting : MonoBehaviour {


    public GameObject PlayerBullet;
    public GameObject bulletPosition;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {

            GameObject bullet = (GameObject)Instantiate(PlayerBullet);
            bullet.transform.position = bulletPosition.transform.position;

            Debug.Log("Pressed left click.");
        }
    }
}
