using UnityEngine;
using System.Collections;

public class ButtonsDown : MonoBehaviour {

	private Ray pulsacion;
	private RaycastHit colision;
	public GameObject[] eats;
	public GameObject objetoPosiscion;

	// Use this for initialization
	void Start () {
	
	}



	// Update is called once per frame
	void Update () {
		//if(Time.frameCount==1){
			DetectClick();	
		//}
	}

	/*
	 * Función que permite detectar a que objeto se le realizo el clic 
	 */
	void DetectClick()
	{
		if(Input.GetKey(KeyCode.Mouse0))
		{
			pulsacion=Camera.main.ScreenPointToRay(Input.mousePosition);
			string nameEat = "";
			if(Physics.Raycast(pulsacion,out colision))
			{
				nameEat = colision.collider.name;
				this.InitEatTable(nameEat);
			}
		}
	}

	public void InitEatTable(string name)
	{
		if(name=="Hambuger"){
			Vector3 vectorPosicion = new Vector3 (objetoPosiscion.transform.position.x-13,
												  objetoPosiscion.transform.position.y+2,
												  objetoPosiscion.transform.position.z);
			Instantiate (eats [0], vectorPosicion, Quaternion.identity);
		}
	}
}
