using UnityEngine;
using System.Collections;

public class Cliente : MonoBehaviour {

	public float velocityCliente;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MoveClient ();
	}

	void MoveClient()
	{
		transform.Translate ((velocityCliente*Time.deltaTime)*-1,0,0);	
	}
}
