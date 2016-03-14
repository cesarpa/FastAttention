using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Eat : MonoBehaviour, IBeginDragHandler,IDragHandler, IEndDragHandler {
	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		throw new System.NotImplementedException ();
	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		throw new System.NotImplementedException ();
	}

	#endregion

	
	#region IBeginDragHandler implementation
	public void OnBeginDrag (PointerEventData eventData)
	{
		throw new System.NotImplementedException ();
	}
	#endregion

	#region IBeginDragHandler implementation
	void IBeginDragHandler.OnBeginDrag (PointerEventData eventData)
	{
		throw new System.NotImplementedException ();
	}
	#endregion

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDrag() {
		Debug.Log("Entro al drag and drop");
		Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		point.y = gameObject.transform.position.y;
		gameObject.transform.position = point;
	}
}
