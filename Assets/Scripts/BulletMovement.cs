using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	public Rigidbody2D bullet;
	GameObject player;
	public float bulletSpeed;
	public float maxRange = 50f;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");

		this.transform.up = player.transform.up;
	}

	// Update is called once per frame
	void Update () {
		transform.position += this.transform.up * bulletSpeed * Time.deltaTime;
		if (Vector3.Distance (this.transform.position, player.transform.position) > maxRange) {
			Destroy (this);
		}
	}
}
