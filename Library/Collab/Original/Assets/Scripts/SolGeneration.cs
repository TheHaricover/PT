using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolGeneration : MonoBehaviour {

	float nbSols = 100f;
	public GameObject Sol;
	private GameObject InfoPanel;

	// Use this for initialization
	void Start () {

		float nbLignes = Random.Range (0f, nbSols-77f);
		float nbColonnes = nbSols/nbLignes;

		for (float i = 0f;i<=nbLignes; i++){
			for (float j = 0f; j<=nbColonnes; j++){
				// Debug.Log ("On instancie un sol.");
				Instantiate(Sol);
				// Debug.Log ("Un sol a été instancié.");
				Sol.transform.position = new Vector3(-5+i,0,-3+j);
				//Debug.Log(Sol.transform.position);
			}
		}
		Sol.SetActive(false);
		//Debug.Log(nbLignes*nbColonnes);

		/*InfoPanel = GameObject.Find("InfosPlanteSol");
		if (InfoPanel.activeSelf){
			InfoPanel.gameObject.SetActive(false);
		}*/
	}

	// Update is called once per frame
	void Update () {

	}
}
