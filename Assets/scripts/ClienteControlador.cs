using UnityEngine;
using System.Collections;



public class ClienteControlador : MonoBehaviour {
    public float velocidadEnX = 0.1f;
    public GameObject enemigoACrear;
    public float posicionEnemigoCrear;
    public float xMaximo;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, velocidadEnX);

        if(gameObject.transform.position.x < xMaximo)
        {
            Instantiate(enemigoACrear);
            enemigoACrear.transform.Translate(gameObject.transform.position.x-5, gameObject.transform.position.y, gameObject.transform.position.z);
            Destroy(gameObject);
        }
    }


}
