using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disparar : MonoBehaviour {

	[SerializeField]
	GameObject mirilla;
	AudioSource m_AudioSource;


	[SerializeField] 
	private AudioClip m_GunSound;  

	float fuerza=30;

	float nextFire = 0.5f;
	public float fireRate = .25f;
	private WaitForSeconds shotDuration = new WaitForSeconds(.07f);


	
	void Start() {
		gunAudio = GetComponent<AudioSource>();
		
	}

	void Update () {

		if (!mirilla.activeSelf) return;

		if(Input.GetMouseButtonDown(0) && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			StartCoroutine(ShotEffect());
		
			Vector3 P = transform.position-0.2f*Vector3.up;
			Ray rayo = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (rayo, out hit)) {
				Debug.Log("Disparo a objetivo");

				if(hit.collider.gameObject.GetComponent<Rigidbody>() != null){
					Rigidbody objetivo = hit.collider.gameObject.GetComponent<Rigidbody> ();
					objetivo.AddForceAtPosition (fuerza*rayo.direction,hit.point,ForceMode.Impulse);
				}
			}
			
		}
	}


	private IEnumerator ShotEffect(){

    	gunAudio.Play ();
    	yield return shotDuration;

    
	}
		

}
