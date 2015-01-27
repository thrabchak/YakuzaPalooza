using UnityEngine;
using System.Collections;

public class HoboTalk : MonoBehaviour {

	public TextHandler textHandler;
	public string[] sayings;
	public GameObject item;//ramen
	public GameObject Bag;//
	public string afterText;
	public bool tradedRamen = false;
	public SpecialDoor hellokittydoor;


	int numSayings = 10;
	//bool ramenTrade = false;
	int cycle;

	void Start(){
		cycle = 0;
		sayings = new string[numSayings];

		sayings [0] = "If you need to cover up a crime, you have to start by eliminating evidence. Your Lucky Number is 7";
		sayings [1] = "I want some noodles";
		sayings [2] = "You will be hungry again in one hour";
		sayings [3] = "A starship rise has been promised to you by a galactic wizard";
		sayings [4] = "There is a bomb in the dump. No really.";
		sayings [5] = "Only listen to the fortune cookie, disregard all other fortune telling units";
		sayings [6] = "Don't sweat the petty things and don't pet the sweaty things";
		sayings [7] = "Have you seen my wife?";
		sayings [8] = "A closed mouth gathers no feet";
		sayings [9] = "I miss my wife";

		afterText = "Thanks for the ramen, I have a present for you located ... well I forget";

		}

	void OnTriggerEnter2D(Collider2D col){
		if (tradedRamen) {
			textHandler.ShowText(afterText);
		} else if (item.activeSelf) 
		{
				textHandler.ShowText ("Whoa... Whats that smell?? Do you have Ramen? I'd do ANYTHING for some ramen right now!");
				item.SetActive (false);
				Bag.SetActive (false);
				tradedRamen = true;
				hellokittydoor.isLocked = false;
		} 
		else 
		{
			textHandler.ShowText(sayings[cycle]);
		}
		
	}
	
	void OnTriggerExit2D(Collider2D col){
		textHandler.HideText();
		if(cycle++ >= numSayings) cycle = 0;
		
	}

}
