using UnityEngine;
using System.Collections;

public class MakeBombGoAWay : MonoBehaviour {

	public SpriteRenderer bomb;

	void Start () {
	
	}
	
	void OnTriggerEnter2D(Collider2D col){
		bomb.enabled = false;
		
	}
}
