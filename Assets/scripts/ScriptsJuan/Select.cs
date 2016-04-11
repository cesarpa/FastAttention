using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void getPosPeople(Transform posObject)
	{
		if (posObject != null) {
			gameObject.transform.position = new Vector3 (posObject.position.x, 
														 posObject.position.y+2.0f,
														 posObject.position.z);
		}
	}

	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "People") {
			GameObject objetoColision = other.gameObject;
			//gameObject.transform.position.x += 1;
			//People escogido = objetoColision.GetComponents<People>();
			transform.position = objetoColision.transform.position;
			//transform.Translate (objetoColision.transform.position.x, objetoColision.transform.position.y, objetoColision.transform.position.z);
		}
	}
}
