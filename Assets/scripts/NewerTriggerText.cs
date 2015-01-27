using UnityEngine;
using System.Collections;

public class NewerTriggerText : MonoBehaviour {

	public TextHandler textHandler;
	public string someText;
	
	void OnTriggerEnter2D(Collider2D col){
		
		textHandler.ShowText (someText);
		
	}
	
	void OnTriggerExit2D(Collider2D col){
		textHandler.HideText ();
		
	}
}
