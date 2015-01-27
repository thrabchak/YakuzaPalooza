using UnityEngine;
using System.Collections;



// Possible movement directions
public enum MOVEMENTDIRECTION {UP,DOWN,LEFT,RIGHT,NONE};
// Weapons
public enum WEAPON {SWORD,BOOMERANG,LASTWEAPON};

/*
Player actions
 */
public class PlayerController : MonoBehaviour {
	
	public MOVEMENTDIRECTION movementDirection {get; private set;}
	MOVEMENTDIRECTION lookingTo;
	public WEAPON weapon {get; private set;}
	public int room;
	
	public GameObject boomerang,sword;
	
	public float speed = 0.05f;
	Animator anim;

	public AudioClip footstepSound;
	public float footstepVolume = .5f;

	
	void Start () {
		movementDirection = MOVEMENTDIRECTION.DOWN;
		lookingTo = MOVEMENTDIRECTION.DOWN;
		anim = GetComponent<Animator> ();
	}

	void PlayFootstep(){
		AudioSource.PlayClipAtPoint (footstepSound, transform.position, footstepVolume);
	}
	
	void Update () {
	}
	
	void FixedUpdate () {
		
		//Player basic control
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += new Vector3(0,speed,0);
			movementDirection = MOVEMENTDIRECTION.UP;
			anim.SetInteger("Direction", 1);
		} else
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position += new Vector3(0,-speed,0);
			movementDirection = MOVEMENTDIRECTION.DOWN;
			anim.SetInteger("Direction", 3);
		} else
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += new Vector3(-speed,0,0);
			movementDirection = MOVEMENTDIRECTION.LEFT;
			anim.SetInteger("Direction", 4);
		} else
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += new Vector3(speed,0,0);
			movementDirection = MOVEMENTDIRECTION.RIGHT;
			anim.SetInteger("Direction", 2);
		} else {
			movementDirection = MOVEMENTDIRECTION.NONE;
			anim.SetInteger("Direction", 0);
		}
		
		if (movementDirection!=MOVEMENTDIRECTION.NONE) lookingTo = movementDirection;

	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name.Equals ("crimeSceneDoor")) {
				room = 1;
		} else if (other.gameObject.name.Equals ("DojoDoor")) {
				room = 2;
		} else if (other.gameObject.name.Equals ("RamenShopDoor")) {
				room = 3;
		} else if (other.gameObject.name.Equals ("laundryDoor")) {
				room = 4;
		} else if (other.gameObject.name.Equals ("HelloKittyDoor")) {
				room = 5;
		} else if (other.gameObject.name.Equals ("hardwareStoreDoor")) {
				room = 6;
		}
		else if(!other.tag.Contains("timeline") && !other.tag.Contains("kittyBomb"))
		{
			room = 0;
		}
	}
	
	
}
