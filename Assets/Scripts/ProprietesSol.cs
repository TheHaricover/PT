using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProprietesSol : MonoBehaviour {

	public GameObject Plante;
	[Range(0.0f, 1.0f)]
	public float matiereOrganique = 0.0f;
	[Range(0.0f, 1.0f)]
	public float eau = 0.0f;

	// Use this for initialization
	public void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public string stringify(){
		return "Plante : Aucune" + "\n"
				 + "Matière organique : " + matiereOrganique.ToString() + "\n"
				 + "Eau : " + eau.ToString() + "\n";
	}
}
