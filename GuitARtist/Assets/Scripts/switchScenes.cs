using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScenes : MonoBehaviour {
	Scene currScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		currScene=SceneManager.GetActiveScene();
		if (Input.GetKeyDown (KeyCode.Escape) & currScene.name=="Main") 
		{
			Application.Quit ();
		}	
	}

	public void settings()
	{
		Application.LoadLevel ("Settings");
	}

	public void instructions()
	{
		Application.LoadLevel ("Instructions");
	}

	public void input()
	{
		Application.LoadLevel ("Input");
	}

	public void menu()
	{
		Application.LoadLevel ("Main");
	}

	public void ar()
	{
		Application.LoadLevel ("AR");
	}
}
