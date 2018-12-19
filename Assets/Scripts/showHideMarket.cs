using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showHideMarket : MonoBehaviour {

	public GameObject panel;
	int counter = 1;

	void Start () {
		panel.gameObject.SetActive(false);
	}

	public void showhidepanel(){
		counter++;
		if (counter % 2 == 1) {
			panel.gameObject.SetActive (false);
		} else {
			panel.gameObject.SetActive (true);
		}
	}
}
