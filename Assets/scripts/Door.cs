using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	
	public Transform TeleportTo;
	public Transform Character;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Character.position =  TeleportTo.position;
		//StartCoroutine (MyFun());
	}

	void OnTriggerExit2D(Collider2D other)
	{
	}

	//IEnumerator MyFun(){
		//yield return new WaitForSeconds(.25f);
		//Character.position =  TeleportTo.position;
	//}
}
