using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour {

	public GameObject house;

	private float targetCount = 10f;
	private float currentCount = 0f;
	private int houseCount = 0;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("build", 0f, 1.0f);
	}

	private void build(){
		currentCount += transform.childCount;
		if (currentCount >= targetCount) {
			currentCount = currentCount - targetCount;
			houseCount++;
			Vector2 pos = new Vector2();
			switch (houseCount % 4) {
			case 0:
				pos = new Vector2 (Random.value * (houseCount / 3f), Random.value * (houseCount / 6f));
				break;
			case 1:
				pos = new Vector2 ((Random.value * (houseCount / 3f)) * -1, Random.value * (houseCount / 6f));
				break;
			case 2:
				pos = new Vector2 (Random.value * (houseCount / 3f), (Random.value * (houseCount / 6f)) * -1);
				break;
			case 3:
				pos = new Vector2 ((Random.value * (houseCount / 3f)) * -1, (Random.value * (houseCount / 6f)) * -1);
				break;
			}
			GameObject houseI = Instantiate (house);
			houseI.transform.position = pos;
		}
	}
}
