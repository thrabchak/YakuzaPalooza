using UnityEngine;
using System.Collections;

public class TriggerEventAndText : MonoBehaviour {

	public TextHandler textHandler;
	public string beforeText;
	public string afterText;
	public bool visitedAlready = false;
	public GameObject item;
	public bool pickUp = true;
	public AudioSource pickupSound;
	public GameObject pickupSoundObject;
	public GameObject player;
	
	void OnTriggerEnter2D(Collider2D col){
		
		if (!visitedAlready) {
			textHandler.ShowText (beforeText);
			visitedAlready = true;
			item.SetActive(pickUp);
			pickupSoundObject.transform.position = player.transform.position;
			pickupSound.PlayDelayed(1.5f);
		} else {
			textHandler.ShowText (afterText);
		}
		
	}
	
	void OnTriggerExit2D(Collider2D col){
		textHandler.HideText ();
		
	}
	
}
