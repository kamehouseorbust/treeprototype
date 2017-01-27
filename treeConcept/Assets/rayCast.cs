using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class rayCast : MonoBehaviour
{
	public Canvas PressXCanvas;
	public Canvas getLetterCanvas;
	public Text canvasText;
	void start(){
		canvasText = getLetterCanvas.GetComponent<Text> ();
	}
	void FixedUpdate ()
	{
		RaycastHit hit;
		GameObject hitObj;
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
		if (Physics.Raycast (transform.position, fwd, out hit, 10f)) {
			print ("Found an object - distance: " + hit.distance);
			if(hit.collider.CompareTag ("Letter")) {
				//PressXCanvas.enabled = true;
				if (Input.GetKeyDown (KeyCode.X) && getLetterCanvas.enabled==false) {
					PressXCanvas.enabled = false;
					hitObj = hit.collider.gameObject;
					storeTXT st = hitObj.GetComponent<storeTXT> ();
					TextAsset t = st.Letter;
					string t1 = t.ToString ();
					canvasText.text = t1;
					getLetterCanvas.enabled = true;
				}
				else if((Input.GetKeyDown (KeyCode.X)) && (getLetterCanvas.enabled==true)){
					getLetterCanvas.enabled = false;
					PressXCanvas.enabled = true;
				}
				else if(getLetterCanvas.enabled == false) {
					PressXCanvas.enabled = true;
				}
			} else {
				PressXCanvas.enabled = false;
				getLetterCanvas.enabled = false;
			}
		}
	}
}



