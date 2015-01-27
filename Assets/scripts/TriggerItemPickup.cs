using UnityEngine;
using System.Collections;

public class TriggerItemPickup : MonoBehaviour {

	public TextHandler textHandler;
	public string beforeText;
	public string afterText;
	public bool visitedAlready = false;
	public GameObject item;
	public bool putDown;
	
	void OnTriggerEnter2D(Collider2D col){
		
		if (!visitedAlready) {
			textHandler.ShowText (beforeText);
			visitedAlready = true;
			item.SetActive(putDown);
		} else {
			textHandler.ShowText (afterText);
		}
		
	}
	
	void OnTriggerExit2D(Collider2D col){
		textHandler.HideText ();
		
	}
}
