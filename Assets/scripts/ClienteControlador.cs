using UnityEngine;
using System.Collections;



public class ClienteControlador : MonoBehaviour {
    public float velocidadEnX = 0.1f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, velocidadEnX);
    }

   
}
