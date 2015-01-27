using UnityEngine;
using System.Collections;

public class SpecialDoor : MonoBehaviour {

	public bool isLocked = true;
	public Transform TeleportTo;
	public Transform Character;
	public TextHandler textHandler;
	public string myText;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (!isLocked) {
			Character.position = TeleportTo.position;
		}
		else {
			textHandler.ShowText(myText);
		}
			
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		textHandler.HideText ();
	}
}
