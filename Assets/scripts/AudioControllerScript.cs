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
			audiosources[i].mute = true;
			audiosources[i].Play();
		}
		audiosources[currentlyPlaying].mute = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (pc.room != currentlyPlaying) 
		{
			audiosources[currentlyPlaying].mute=true;
			currentlyPlaying = pc.room;
			audiosources [pc.room].mute = false;
		}
	}
}
