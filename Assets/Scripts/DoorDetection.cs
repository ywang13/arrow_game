using UnityEngine;
using System.Collections;
using UnityEngineInternal;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;

public class DoorDetection : MonoBehaviour {

	public Transform player;
	public Vector3 moveDist; //distance door moves
	private Vector3 initialLocation;  //reset location of the door
	private bool canMove = true;
	//public Color newColor; <- Old version
	private Color newColor; 
	private Vector3 oldPosition; // door position tracking
	private Vector3 newPosition; // door position tracking
	public Treasure treasure; 
	public bool isLocked = false; //is the door locked?
	public bool lockTextShowing = false; //is the door is locked text showing?
	public SpriteRenderer arrow1;
	public SpriteRenderer arrow2;
	private bool isFlipped = false;
	public GameObject door;
	public GameObject activator;

	void Start () {
		initialLocation = transform.position;
	}

	void Update () {
		AudioSource audio = GetComponent<AudioSource> ();
		//Check position of door to play sound only
		//if the door has moved in the last frame
		oldPosition  = transform.position;
		newPosition = transform.position;

		//Play Sound
		if (newPosition != oldPosition) {
			playSound (audio);
		}

		//Locked or Unlocked Color
		if (treasure.isOpen  || isLocked) {
			//door is green if open 
			newColor = new Color (0,1,0,1);
		}else{
			//door is red if closed
			newColor = new Color (1,0,0,1);	
		}

		//change door color to red or green
		changeColor (newColor);


		//flip direction arrows on back track path
		//after doors are unlocked
		if(treasure.isOpen){
			flipArrows ();
		}
	}

	//change door color
	private void changeColor(Color col){
		SpriteRenderer wall = GetComponent<SpriteRenderer> ();
		wall.color = col;
	}
		

	//Play door open sound
	private void playSound(AudioSource audio){
		if (!audio.isPlaying) {
			audio.Play ();
		}
	}

	private void flipArrows(){
		if (!isFlipped) {
			arrow1.flipX = true;
			arrow2.flipX = true;
			isFlipped = true;
		}
	}


}
