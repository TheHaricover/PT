using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showHideMarket : MonoBehaviour {

	public GameObject panel;
	private GameObject InfoPanel;
	int counter = 1;

	void Start () {
		panel.gameObject.SetActive(false);
	}

	public void showhidepanel(){
		InfoPanel = GameObject.Find("infoPanelSol");
		Destroy(InfoPanel);
		counter++;
		if (counter % 2 == 1) {
			panel.gameObject.SetActive (false);
		} else {
			panel.gameObject.SetActive (true);
		}
	}
}
