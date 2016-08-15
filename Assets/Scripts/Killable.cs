using UnityEngine;
using System.Collections;

public class Killable : MonoBehaviour {

	private int maxhealth = 100;
	private int currenthealth = 0;

	// Use this for initialization
	void Start () {

		currenthealth = maxhealth;
	
	}

	public void Hurt ( int damage ) {

		currenthealth -= damage;

		if (currenthealth <= 0) {
			Destroy (gameObject);
		}

	}

}
