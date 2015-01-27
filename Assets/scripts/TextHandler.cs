using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextHandler : MonoBehaviour {

	public GameObject TextPanel;
	public GameObject TextBox;
	Text onScreenText;
	
	void Start(){
		HideText ();
		onScreenText = TextBox.GetComponent<Text> ();
	}

	public void ShowText(string new_text){
		TextPanel.SetActive (true);
		onScreenText.text = new_text;
	}

	public void HideText(){
		TextPanel.SetActive (false);
	}
}
