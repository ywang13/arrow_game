using UnityEngine;
using System.Collections;
using UnityEngineInternal;
using UnityEngine.UI;

public class DoorTrigger : MonoBehaviour {

	public GameObject door;
	public GameObject Activator;
	public GameObject lockeddoor;
	public Treasure treasure; 

	//DoorOpen
	void OnTriggerStay2D ( Collider2D Activator ) {

		//Open on player proximity
		if (Activator.GetComponent<Killable> () != null ) {
			door.SetActive(false);
		} 

		//Open on player proximity
		if (Activator.GetComponent<Killable> () != null && treasure.isOpen) {
			lockeddoor.SetActive(false);
		} 
			
	}

	//PlaySound
	void OntriggerEnter2D ( Collider2D Activator ) {

		AudioSource audio = GetComponent<AudioSource> ();

		if (Activator.GetComponent<Killable> () != null ) {
			audio.Play ();
		}
	} 

	//DoorClose
	void OnTriggerExit2D ( Collider2D Activator ) {

		door.SetActive(true);
		lockeddoor.SetActive (true);
		}
}
