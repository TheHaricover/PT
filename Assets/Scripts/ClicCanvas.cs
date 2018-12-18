using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicCanvas : MonoBehaviour {

	//private GameObject InfoPanel;

	// Use this for initialization
	void Start () {
		//InfoPanel = GameObject.Find("InfosPlanteSol");
		Debug.Log("Le canvas démarre.");
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		Debug.Log("Appui souris sur le canvas.");
		/*if (InfoPanel.activeSelf){
			InfoPanel.gameObject.SetActive(false);
			Debug.Log("On cache le panel d'infos.");
		}*/
  }
}
