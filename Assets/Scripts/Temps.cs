using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temps : MonoBehaviour {

	private float time;
	private int day;
	private int year;
	private string[] days =  {"Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"};
	private enum Month {Janvier, Février, Mars, Avril, Mai, Juin, Juillet, Août, Septembre, Octobre, Novembre, Décembre};
	private string dayName;
	private Month monthName;
	private Text timeText;
	private float fillAmount;
	private Image timeBar;
	private int mod;
	private int month;
	private float daysPassed;
	private int ancientDay;
	private Text textTimeForwardButton;

	// Use this for initialization
	void Start () {
		ancientDay = 0;
		year = 2018;
		Time.timeScale = 1f;
		dayName = days[0];
		month = 0;
		daysPassed = 0f;
	}

	// Update is called once per frame
	void Update () {
		//Temps, à la seconde décimale
		time = Mathf.Round(Time.time*100f)/100f;

		timeText = GameObject.Find("textTime").GetComponent<Text>();
		textTimeForwardButton = GameObject.Find("textTimeForwardButton").GetComponent<Text>();
		timeBar = GameObject.Find("Status Fill 01").GetComponent<Image>();
		timeBar.fillAmount = daysPassed/360f;

		//Temps modulo 60
		mod = (((int) time) % 60 + 60) % 60;

		//((Temps/60) modulo 60) + 1 car 1 jour = 1 minute
		day = 1 + (int) ((time/60f)%60f) - month;

		if (day != ancientDay){
			daysPassed ++;
			if (daysPassed > 360f){
				daysPassed = 0f;
			}
			ancientDay = day;
		}

		//Ici, on cherche le nom du jour
		if (mod == 0){
			dayName = days[(day-1+month/15)%7];
		}

		if (day > 30){
			month += 30;
			if (monthName == Month.Décembre){
				year++;
				monthName = Month.Janvier;
			}else{
				monthName ++;
			}
			//Debug.Log(day);
		}
		timeText.text = dayName + " " + day + " " + monthName + " " + year;
		textTimeForwardButton.text = "x" + Time.timeScale.ToString();
	}

	float getTime(){
		return time;
	}

	public void timeForward(){
		if (Time.timeScale == 1f){
			Time.timeScale = 2f;
		}else if (Time.timeScale == 2f){
			Time.timeScale = 5f;
		}else if(Time.timeScale == 5f){
			Time.timeScale = 10f;
		}else if(Time.timeScale == 10f){
			Time.timeScale = 1f;
		}
	}
}
