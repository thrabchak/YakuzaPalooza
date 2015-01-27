using UnityEngine;
using System.Collections;

public class YakuzaController : MonoBehaviour {

	public MOVEMENTDIRECTION movementDirection {get; private set;}
	MOVEMENTDIRECTION lookingTo;

	public float speed;
	Animator anim;

	// Use this for initialization
	void Start () {
		movementDirection = MOVEMENTDIRECTION.LEFT;
		lookingTo = MOVEMENTDIRECTION.LEFT;
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (lookingTo == MOVEMENTDIRECTION.LEFT) {
			transform.position += new Vector3 (-speed, 0, 0);
			movementDirection = MOVEMENTDIRECTION.LEFT;
			anim.SetInteger ("Direction", 2);
		} else if (lookingTo == MOVEMENTDIRECTION.RIGHT) {
			transform.position += new Vector3 (speed, 0, 0);
			movementDirection = MOVEMENTDIRECTION.RIGHT;
			anim.SetInteger ("Direction", 1);
		}
		if (transform.position.x < 0)
			lookingTo = MOVEMENTDIRECTION.RIGHT;
		if (transform.position.x > 3)
			lookingTo = MOVEMENTDIRECTION.LEFT;
	}

	public bool isInSights = false;
	public int Sightcounter = 0;
	public int sightDuration = 15;

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") 
		{
			isInSights = true;
		}

	}

	void Update()
	{
				if (isInSights) {
						if (Sightcounter >= sightDuration) {
				Application.LoadLevel(0);
						} else {
								Sightcounter++;
						}
				}
		}
	void OnTriggerExit2D(Collider2D collider){
		if (collider.tag == "Player") 
		{
			isInSights = false;
			Sightcounter = 0;
		}
		
	}
}
