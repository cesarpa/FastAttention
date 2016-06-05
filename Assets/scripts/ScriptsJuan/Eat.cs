using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Eat : MonoBehaviour {

	Vector3 dist;
	float posX;
	float posY;
	public Camera mainCamare;
	private Ray pulsacion;
	private RaycastHit colision;
	public Select selectPersonaAMandarComida;


	// Use this for initialization
	void Start () {
		selectPersonaAMandarComida = new Select ();
		selectPersonaAMandarComida = GameObject.FindGameObjectWithTag("Select").GetComponent<Select>();
	}
	
	// Update is called once per frame
	void Update () {
		//this.OnMouseDown();
		//this.OnMouseDrag();
		clickComida();
	}

	void OnMouseDown(){
		Debug.Log ("Entro al mousedown");
		dist = Camera.main.WorldToScreenPoint(transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;

	}

	void clickComida(){
		if (Input.GetKey (KeyCode.Mouse0)) {

			pulsacion=Camera.main.ScreenPointToRay(Input.mousePosition);
			string nameComidaMesa = "";
			if (Physics.Raycast (pulsacion, out colision)) {
				if (this.gameObject == colision.transform.gameObject) {

					nameComidaMesa = colision.collider.name;
					Debug.Log ("name comida Mesa  --->" + nameComidaMesa);
					this.lanzarComidaMesa(nameComidaMesa);

				}
			}
		}

	}

	void OnMouseDrag(){
		
		Vector3 curPos = 
			new Vector3(Input.mousePosition.x - posX, 
				Input.mousePosition.y - posY, dist.z);  

		Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
		transform.position = worldPos;
	}


	public void lanzarComidaMesa(string name)
	{
		
		if (name == "prefabEatHamburguer(Clone)"||name == "prefabEatHamburguer") {
			if (selectPersonaAMandarComida != null) {
				this.transform.Translate (
					new Vector3 (selectPersonaAMandarComida.transform.position.x - this.transform.position.x, 
						0,
						0));
			}
		}
	}
}
