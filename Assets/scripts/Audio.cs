using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

	//Audio Script sample starts here. we will provide the folder of sfx and bgm
	//Add component: Audio Source for each scene
	//prior to importing, make all sounds 2D EXCEPT footsteps. that should be in 3D.
	//All BGM should have Play on Awake and Loop checked
	public AudioClip startScreen;
	public AudioClip endScreen;
	public AudioClip outside;
	public AudioClip hardwareStore;
	public AudioClip laundromat;
	public AudioClip theT;
	public AudioClip MAStore;
	public AudioClip ramenShop;
	public AudioClip convenienceStore;
	public AudioClip yakuzaDen;
	public AudioClip helloKittyDen;
	public AudioClip closeToEnd; 
	public AudioClip water; //3D? 
	public AudioClip train; // 3D?
	public AudioClip cars; //3D?
	public AudioClip footSteps; 
	public AudioClip girlyScreamHaha;
	public AudioClip itemSound;
	public AudioClip door;

	//this should be the npc walking around. sound should be in 3D. Set to Loop and Play on Awake.
	//Player should have Audio Listener Component added to enable the sound and make it
	//relative to the player
	//Adding echo: Add Audio Reverb Zone component. Min and Max Distance, try 5 and 10, respectively.
	//Reverb Preset to City. I can check to see if City is a good choice later. 

	void PlayfootSteps(){
				if (footSteps)
						AudioSource.PlayClipAtPoint (footSteps, transform.position); //assuming it will play when npc moves
		}
	//end of footsteps for NPC


	//this is when the player gets an item. it plays a sound.
	//this code should be in the Player script, i think.
	//the script will create then destroy the item being held after playing the sound
	void PlayitemSound(){
		if (!itemSound || GameObject.Find ("itemSound"))
			return;

		GameObject go = new GameObject ("item");
		AudioSource aSrc = go.AddComponent<AudioSource>();
		aSrc.clip = itemSound;
		aSrc.volume = 0.8f; //volume is lowered
		aSrc.Play ();

		Destroy (go, itemSound.length);
	}
	//Add the folowing code to the item script within the Player script when the player interacts with the item
	//PlayitemSound();
	//end of itemsound script


	//When pause screen/inventory screen is opened, the current audio in the background is lowered
	//this should be after the if statement
	//aSrc.volume = 0.6f;
	
	//For all BGM scripts, just add Audio Source component to each building and attach the audio clip
	
	//End of Audio Script

}