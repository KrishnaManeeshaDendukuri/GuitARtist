using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class noKillMe : MonoBehaviour {

	// Use this for initialization
	void Awake () 
	{
		if (SceneManager.GetActiveScene().name == "AR") 
		{
			DontDestroyOnLoad (transform.gameObject);
			GetComponent<VuforiaBehaviour> ().enabled = true;
			GetComponent<DefaultInitializationErrorHandler> ().enabled = true;
		}

		else if (SceneManager.GetActiveScene().name == "Database") 
		{
			DontDestroyOnLoad (transform.gameObject);
			GetComponent<VuforiaBehaviour> ().enabled = true;
			GetComponent<DefaultInitializationErrorHandler> ().enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
