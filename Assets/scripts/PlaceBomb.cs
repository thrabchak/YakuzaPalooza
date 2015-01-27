using UnityEngine;
using System.Collections;

public class PlaceBomb : MonoBehaviour {

	public TextHandler textHandler;
	public string beforeText;
	public string afterText;
	public bool visitedAlready = false;
	public GameObject inventoryBomb;
	public Leaveable leaver;
	public AudioSource trainSound;
	public AudioSource normalSound;
	public GameObject pickupSoundObject;
	public GameObject player;
	public AudioSource pickupSound;

	void Start(){
		this.GetComponent<SpriteRenderer> ().enabled = false;
		this.GetComponent<ParticleSystem> ().Stop ();

	}
	
	void OnTriggerEnter2D(Collider2D col){
		
		if (!visitedAlready && inventoryBomb.activeSelf ) {
			textHandler.ShowText (beforeText);
			visitedAlready = true;
			inventoryBomb.SetActive(false);
			this.GetComponent<SpriteRenderer> ().enabled = true;
			this.GetComponent<ParticleSystem> ().Play ();
			leaver.canLeave = true;
			normalSound.mute = true;
			normalSound = trainSound;
			trainSound.mute = false;
			pickupSoundObject.transform.position = player.transform.position;
			pickupSound.PlayDelayed(1.5f);
		} else if(visitedAlready){
			textHandler.ShowText (afterText);
		}
		
	}
	
	void OnTriggerExit2D(Collider2D col){
		textHandler.HideText ();
		
	}
}
