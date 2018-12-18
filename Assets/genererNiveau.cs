using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genererNiveau : MonoBehaviour {

	public GameObject Sol;
	public int nbLig = 4;
	public int nbCol = 4;

	// Use this for initialization
	void Start () {
		for (int z = 0-(nbLig/2); z < 0+(nbLig/2); z++)
		{
			for (int x = 0-(nbCol/2); x < 0+(nbCol/2); x++) 
			{
				Instantiate(Sol, new Vector3(x, 0, z), Quaternion.identity);
				var prop = Sol.GetComponent ("ProprietesSol");
				Debug.Log (prop);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
