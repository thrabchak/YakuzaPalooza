using UnityEngine;
using System.Collections;

public class MakeColliderProper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<BoxCollider2D>().size = GetComponent<RectTransform>().rect.size;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
