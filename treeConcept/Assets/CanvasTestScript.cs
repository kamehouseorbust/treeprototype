using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CanvasTestScript : MonoBehaviour {

	public Canvas PressXCanvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.X)) {
			PressXCanvas.enabled = !PressXCanvas.enabled;

		}
		if (this.gameObject.CompareTag ("Letter")) {
			Debug.Log ("This is a letter");
		}
	}
}
