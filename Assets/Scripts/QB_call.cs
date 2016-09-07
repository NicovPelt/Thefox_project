using UnityEngine;
using System.Collections;


public class QB_call : MonoBehaviour {
	public GameObject QuestionScreen;

		void Update () {
				
		if (Input.GetKeyDown (KeyCode.I)) {
			QuestionScreen.SetActive (true);
		}
	
	}
}
