using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hintpanel;
	public GameObject quitPanel;
	public GameObject couponpopuppanel;
	public UnityEngine.UI.Text hintText;


	// Use this for initialization
	void Start () {
		//Cursor.lockState = CursorLockMode.Confined;

	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			quitPanel.gameObject.SetActive (true);
		}
	}

	/*void OnTriggerEnter(Collider col)
	{
		if (col.GetComponent<Collider>().name == "InformationCenter") {
			//hintpanel.gameObject.SetActive (true);
			//hintText.text = "Press 'Space' to pick the available coupons";

		}
	}*/

	void OnTriggerStay(Collider col)
	{
		if (col.GetComponent<Collider>().name == "InformationCenter") {
			if (Input.GetKeyDown (KeyCode.Space)) {
				//couponpopuppanel.gameObject.SetActive (true);

				//Cursor.lockState = CursorLockMode.Locked;
				//Cursor.visible = true;
			}
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.GetComponent<Collider>().name == "InformationCenter") {
			hintpanel.gameObject.SetActive (false);
			hintText.text = "";

		}
	}

	public void OnDoneClicked()
	{
		couponpopuppanel.gameObject.SetActive (false);
		//Cursor.lockState = CursorLockMode.None;
		//Cursor.visible = false;
	}

	public void yesClicked()
	{
		Application.Quit ();
	}

	public void noClicked()
	{
		quitPanel.gameObject.SetActive (false);
	}
}
