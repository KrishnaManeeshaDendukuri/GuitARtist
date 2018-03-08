using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class noKillMe : MonoBehaviour {

	// Use this for initialization
	void Awake () 
	{
		DontDestroyOnLoad (transform.gameObject);
		GetComponent<VuforiaBehaviour> ().enabled = true;
		GetComponent<DefaultInitializationErrorHandler> ().enabled = true;

		if (SceneManager.GetActiveScene ().name == "Main")
		{
			Destroy (transform.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
