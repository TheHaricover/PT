using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionManager : MonoBehaviour {

	public GameObject ActionList;
	public GameObject ActionButtonPrefab;

	// Use this for initialization
	void Start () {
		ActionList = GameObject.Find ("ActionList");
		//Instancie des actions vides
		for (int i = 0; i < 15; i++) {
			GameObject actionButton = Instantiate (ActionButtonPrefab) as GameObject;
			actionButton.transform.SetParent (ActionList.transform);
			actionButton.GetComponentInChildren<UnityEngine.UI.Text> ().text = ("Action" + i);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void GetTopPriority() {
		
	}

	public void UpPriority(GameObject actionButton) {
		actionButton.transform.SetSiblingIndex (actionButton.transform.GetSiblingIndex() - 1);
		GetTopPriority ();
	}

	public void DownPriority(GameObject actionButton) {
		actionButton.transform.SetSiblingIndex (actionButton.transform.GetSiblingIndex() + 1);
		GetTopPriority ();
	}
}
