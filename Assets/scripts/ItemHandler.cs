using UnityEngine;
using System.Collections;

public class ItemHandler : MonoBehaviour {

	public GameObject[] items;

	public void hideItem(int i){
			items [i].SetActive (false);
	}
	public void showItem(int i){
			items [i].SetActive (true);
	}
}
