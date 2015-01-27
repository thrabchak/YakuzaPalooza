using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerController))]
public class AudioControllerScript : MonoBehaviour {
	public AudioSource[] audiosources;
	public PlayerController pc;
	public int currentlyPlaying;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < audiosources.Length; i++) {
			//audiosources[i].Play();
			audiosources[i].mute = true;
		}
		audiosources[currentlyPlaying].mute = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (pc.room != currentlyPlaying) 
		{
			audiosources[currentlyPlaying].mute=true;
			currentlyPlaying = pc.room;

			if(pc.room == 0){
				audiosources [pc.room].mute = false;

			} else if (pc.room == 1){
				audiosources [pc.room].mute = false;
			} else if (pc.room == 2){
				audiosources [pc.room].mute = false;
			} else if (pc.room == 3){
				audiosources [pc.room].mute = false;
			} else if (pc.room == 4){
				audiosources [pc.room].mute = false;
			} else if (pc.room == 5){
				audiosources [pc.room].mute = false;
			}
		}
	}
}
