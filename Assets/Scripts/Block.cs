using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Block : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public Sprite CultureIcon;
	public Sprite BuildingIcon;
	public Sprite MilitaryIcon;
	public Sprite ScienceIcon;

	#region IDragHandler implementation
	void IDragHandler.OnDrag (PointerEventData eventData)
	{
		
		//Vector2 pos;// = eventData.position;
		//RectTransformUtility.ScreenPointToLocalPointInRectangle(GameObject.FindGameObjectWithTag("Canvas").transform as RectTransform, Input.mousePosition, GameObject.FindGameObjectWithTag("Canvas").GetComponent<Canvas>().worldCamera, out pos);
		transform.position = Input.mousePosition;
	}
	#endregion

	#region IBeginDragHandler implementation

	void IBeginDragHandler.OnBeginDrag (PointerEventData eventData)
	{
		var temp = transform.parent.gameObject.GetComponent<Bar> ();
		transform.SetParent(transform.parent.parent);
		temp.arrangeBlocks ();
		GetComponent<Image> ().raycastTarget = false;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		GetComponent<Image> ().raycastTarget = true;
	}

	#endregion

	public void iconChange(Bar.BarName newIcon){
		Image temp = GetComponent<Image> ();
		switch (newIcon) {
		case Bar.BarName.Building:
			temp.sprite = BuildingIcon;
			break;
		case Bar.BarName.Culture:
			temp.sprite = CultureIcon;
			break;
		case Bar.BarName.Military:
			temp.sprite = MilitaryIcon;
			break;
		case Bar.BarName.Science:
			temp.sprite = ScienceIcon;
			break;
		}
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
