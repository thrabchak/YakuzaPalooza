using UnityEngine;
using System.Collections;

public class TriggerEventAndText : MonoBehaviour {

	public TextHandler textHandler;
	public string beforeText;
	public string afterText;
	public bool visitedAlready = false;
	public GameObject item;
	public bool pickUp = true;
	
	void OnTriggerEnter2D(Collider2D col){
		
		if (!visitedAlready) {
			textHandler.ShowText (beforeText);
			visitedAlready = true;
			item.SetActive(pickUp);
		} else {
			textHandler.ShowText (afterText);
		}
		
	}
	
	void OnTriggerExit2D(Collider2D col){
		textHandler.HideText ();
		
	}
	
}
