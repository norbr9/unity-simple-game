using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlUI : MonoBehaviour {
	// Enable or Disable buttom depending on wich window is being shown
	[SerializeField]
	GameObject playButtom;
	[SerializeField]
	GameObject exitButtom;
	[SerializeField]
	GameObject helpButtom;
	[SerializeField]
	GameObject settingsButtom;

	[SerializeField]
	GameObject help;
	[SerializeField]
	GameObject settings;




	public void quit() { Application.Quit(); }
    public void play() { SceneManager.LoadScene(0); }


    public void helpON() { 
			
		help.SetActive(true);
	 }
    public void helpOFF() { help.SetActive(false); }
	public void settingsOn(){
		settings.SetActive(true);
		activeFondoButtoms(false);
	}
	public void settingsOff(){
		settings.SetActive(false);
		activeFondoButtoms(true);
	}




	private void activeFondoButtoms(bool active){
		playButtom.GetComponent<Button>().interactable = active;
	 	exitButtom.GetComponent<Button>().interactable = active;
	 	helpButtom.GetComponent<Button>().interactable = active;
		settingsButtom.GetComponent<Button>().interactable = active;
	}



}
