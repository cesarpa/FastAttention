using UnityEngine;
using System.Collections;

public class GeneradorPeople : MonoBehaviour {

	public GameObject[] objetcsPeople;
	public float timeInitial;
	public float timeRepeat;
	private GameObject objectPrefabs;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("GeneratePeople", timeInitial, timeRepeat);
	}
		

	// Update is called once per frame
	void Update () {
	
	}

	//Generador de prefab
	void GeneratePeople(){
		objectPrefabs = objetcsPeople[Random.Range(0, objetcsPeople.Length)];
		//Instantiate (objectPrefabs,transform.position,Quaternion.AngleAxis(90,Vector3.left));
		//Instantiate (objectPrefabs,transform.position,Quaternion.identity);
		Instantiate (objectPrefabs,transform.position,objectPrefabs.transform.rotation);
	}
}
