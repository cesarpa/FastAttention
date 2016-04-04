using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Eat : MonoBehaviour {

	Vector3 dist;
	float posX;
	float posY;
	public Camera mainCamare;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//this.OnMouseDown();
		//this.OnMouseDrag();
	}

	void OnMouseDown(){
		Debug.Log ("Entro al mousedown");
		dist = Camera.main.WorldToScreenPoint(transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;

	}

	void OnMouseDrag(){
		Debug.Log ("Entro al mousedrag");
		Vector3 curPos = 
			new Vector3(Input.mousePosition.x - posX, 
				Input.mousePosition.y - posY, dist.z);  

		Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
		transform.position = worldPos;
	}
}
