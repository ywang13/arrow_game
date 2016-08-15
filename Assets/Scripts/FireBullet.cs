using UnityEngine;
using System.Collections;

public class FireBullet : MonoBehaviour {
	
	public GameObject bullet;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			fireBullet ();
		}
	}


	//Functions and stuff
	void fireBullet(){
		Instantiate (bullet,this.transform.position, Quaternion.Euler(0f,0f,0f) );
	}

}
