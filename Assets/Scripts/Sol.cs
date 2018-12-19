using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental;

public class Sol : MonoBehaviour {

	private ProprietesSol proprietesSol;
	private string proprietesPlantes = "Propriétés de la plante";

	private GameObject Canvas;
	public GameObject infoPanelSol;
	//private GameObject InfosPlanteSolText;
	private GameObject market;
	private GameObject InfoPanelSol;

	private GameObject txtGo;
	private Text txt;
	//private Sprite sprite;
	public GameObject[] allGameObjects;

	// Use this for initialization
	void Start () {
		proprietesSol = GetComponent<ProprietesSol>();
	}

	// Update is called once per frame
	void Update () {
	}

	//void OnMouseDown(){
    public void ShowInfoPanel() {
			delete();
			market = GameObject.Find("marketPanel");

			if (market == null || !market.activeSelf){
				if (InfoPanelSol == null) {
					Canvas = GameObject.Find("UI");
					InfoPanelSol = Instantiate(infoPanelSol);
					InfoPanelSol.transform.SetParent(Canvas.transform);
					// Image img = InfoPanelSol.AddComponent<Image>();
					// sprite = Resources.Load("Sprites/cadre", typeof(Sprite)) as Sprite;
					// img.sprite = sprite;
					//
					// InfoPanelSol.transform.SetParent(Canvas.transform);
					InfoPanelSol.transform.position = new Vector3(160f,0f,0f);
					// InfoPanelSol.transform.localScale = new Vector3(1,1,0);
					// RectTransform rt = InfoPanelSol.GetComponent<RectTransform>();
					// rt.sizeDelta = new Vector2(300, 500);
					//
					// InfosPlanteSolText = new GameObject("Text");
					// txt = InfosPlanteSolText.AddComponent<Text>() as Text;
					// txt.font = Resources.Load<Font>("Fonts/films.bradybun");
					// txt.fontSize = 20;
					// txt.color = Color.black;
					// InfosPlanteSolText.transform.SetParent(InfoPanelSol.transform);
					// InfosPlanteSolText.transform.position = InfoPanelSol.transform.position;
					txtGo = InfoPanelSol.transform.GetChild(0).gameObject;
					txt = txtGo.GetComponent<Text>();
					txt.text = "Propriétés du sol : " + "\n" + proprietesSol.stringify() + "\n" + "Propriétés de la plante : " + "\n" + proprietesPlantes;
					// txt.transform.localPosition = new Vector3(-50,130,0);
					// txt.verticalOverflow = VerticalWrapMode.Overflow;
					// txt.horizontalOverflow = HorizontalWrapMode.Overflow;
					// txt.transform.localScale = new Vector3(0.75f,0.75f,0f);
				}else {
					Destroy(InfoPanelSol);
				}
			}
		}
		public void delete(){
			allGameObjects = FindObjectsOfType<GameObject>();

			foreach (GameObject go in allGameObjects){
				if(go.name == "infoPanelSol(Clone)"){
					Destroy(go);
				}
			}
		}
	}
