using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {

	 
	float velocity = 1.0f;
	Transform posObjectUpdate = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Left();
	}


	void Left(){
		if (posObjectUpdate != null) {     
			//transform.position -= (Vector3.right * velocity);
			gameObject.transform.position = new Vector3 (posObjectUpdate.position.x, 
				posObjectUpdate.position.y+2.0f,
				posObjectUpdate.position.z);
		}
	}


	public void getPosPeople(Transform posObject)
	{
		if (posObject != null) {
			posObjectUpdate = posObject;
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
