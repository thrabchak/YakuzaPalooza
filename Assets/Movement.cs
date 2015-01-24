using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	float speed = 2f;
	//Components for accessing background properties
	public RectTransform background_RectTran;
	Rect background_Rect;
	//Components for accessing moving bound properties
	public RectTransform moveBound_RectTran;
	Rect moveBound_Rect;
	//Components for accessing character properties
	RectTransform character_RectTran;
	Rect character_Rect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void FixedUpdate() 
	{
		
		///////////////////////////////////////////
		/// Getting different components for update
		moveBound_Rect = moveBound_RectTran.rect;
		character_RectTran = this.GetComponent<RectTransform>();
		character_Rect = character_RectTran.rect;
		background_Rect = background_RectTran.rect;
		
		
		////////////////
		//Basic Movement
		////////////////
		if (Input.GetKey(KeyCode.W))
		{
			if(moveBound_RectTran.rect.height/2 > character_RectTran.localPosition.y)
				rigidbody2D.transform.Translate(0f, speed * Time.deltaTime,0f);
			else
				background_RectTran.transform.Translate(0f, -speed * Time.deltaTime,0f);
		}
		else if (Input.GetKey(KeyCode.S))
		{
			if(-moveBound_RectTran.rect.height/2 < character_RectTran.localPosition.y)
				rigidbody2D.transform.Translate(0f, -speed * Time.deltaTime,0f);
			else
				background_RectTran.transform.Translate(0f, speed * Time.deltaTime,0f);
		}
		else if (Input.GetKey(KeyCode.A))
		{
			if(-moveBound_RectTran.rect.width/2 < character_RectTran.localPosition.x)
				rigidbody2D.transform.Translate(-speed * Time.deltaTime,0f,0f);
			else
				background_RectTran.transform.Translate(speed * Time.deltaTime,0f,0f);
		}
		else if (Input.GetKey(KeyCode.D))
		{
			if(moveBound_RectTran.rect.width/2 > character_RectTran.localPosition.x)
				rigidbody2D.transform.Translate(speed * Time.deltaTime,0f,0f);
			else
				background_RectTran.transform.Translate(-speed * Time.deltaTime,0f,0f);
		}	
	}
}