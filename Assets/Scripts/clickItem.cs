using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickItem : MonoBehaviour {

	//public GameObject inputF;
	public Button achatBtn;
	public GameObject panel;
	int i;

	void Start () {
		achatBtn.gameObject.SetActive (false);
	}


	public void showAchatBtn() {
		achatBtn.gameObject.SetActive (true);
		panel.gameObject.SetActive (false);

	}

	/*
	public void activateinput () {

		i++;

		if (i % 2 == 1) {
			inputF.gameObject.SetActive (false);
		} else {
			inputF.gameObject.SetActive (true);
		}

	}
	*/

}
