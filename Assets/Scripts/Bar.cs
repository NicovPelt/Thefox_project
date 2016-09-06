using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Bar : MonoBehaviour, IDropHandler {
	
	#region IDropHandler implementation
	void IDropHandler.OnDrop (PointerEventData eventData)
	{
		eventData.pointerDrag.transform.SetParent (transform);
		arrangeBlocks ();
	}
	#endregion

	public void arrangeBlocks(){
		for (int i = 0; i < transform.childCount; i++) {
			Vector2 temp = new Vector2 ((18 + (i * 34)), 17);
			transform.GetChild (i).gameObject.GetComponent<RectTransform> ().anchoredPosition = temp;

		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
