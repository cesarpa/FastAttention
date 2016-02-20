using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Detection ();
	}

	void Detection()
	{
		/*if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			Transform select = GameObject.FindWithTag ("select").transform;
			if (Physics.Raycast (ray, hit, 100.0f)) {
				select.tag = "none";
				hit.collider.transform.tag = "select";
			}
		}*/

		if (Input.GetMouseButtonDown(0)){ // if left button pressed...
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)){
				// the object identified by hit.transform was clicked
				// do whatever you want
				Debug.Log("Realizo Click");
			}
		}

	}

	void OnMouseDown()
	{
		if(Input.GetKey("mouse 0")){
			Debug.Log ("Click Objeto");
		}
	}
}
