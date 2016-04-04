using UnityEngine;
using System.Collections;

/*
 * Aun no se tiene implementación para la clase 
 * 
*/
public class People : MonoBehaviour {

	private Ray pulsacion;
	private RaycastHit colision;
	//public GameObject objetoApuntador;
	private Vector3 posicionAPuntador;
	private Select seleccionador;
	private bool escogido;

	// Use this for initialization
	void Start () {
		posicionAPuntador = new Vector3 (transform.position.x,transform.position.y+5,0);
		//seleccionador = new Select ();
		seleccionador = GameObject.FindGameObjectWithTag("Select").GetComponent<Select>();
		escogido = false;
	}

	// Update is called once per frame
	void Update () {
		DetectClick ();
	}

	//Función que detecta que se escogio a un cliente
	void DetectClick()
	{
		if(Input.GetKey(KeyCode.Mouse0))
		{
			pulsacion=Camera.main.ScreenPointToRay(Input.mousePosition);
			string nameCharacter = "";
			if(Physics.Raycast(pulsacion,out colision))
			{
				nameCharacter = colision.collider.tag;
				if(nameCharacter=="People"){
					//CreateSelcterCharacter ();
					if (seleccionador != null) {
						escogido = true;
						seleccionador.getPosPeople(colision.transform);
					}
				}
			}
		}
	}

	public bool getEscogido()
	{
		return this.escogido;
	}

	/*void CreateSelcterCharacter()
	{
		Instantiate (objetoApuntador,posicionAPuntador,Quaternion.identity);
	}*/
}
