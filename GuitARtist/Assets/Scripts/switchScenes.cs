using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class switchScenes : MonoBehaviour {
	Scene currScene;
	static int db_song = 0;
	public songScript songDatabase;

	void Start () 
	{
		songDatabase = GameObject.FindObjectOfType (typeof(songScript)) as songScript;
		songDatabase.dbSong (db_song);
	}
	
	// Update is called once per frame
	void Update () 
	{
		currScene=SceneManager.GetActiveScene();
		if (Input.GetKeyDown (KeyCode.Escape) & currScene.name == "Main") 
		{
			Application.Quit ();
		}
		else if (Input.GetKeyDown (KeyCode.Escape) & currScene.name == "AR") 
		{
			VuforiaRuntime.Instance.Deinit ();
			Application.LoadLevel ("Input");
		}
		else if (Input.GetKeyDown (KeyCode.Escape) & currScene.name == "Database") 
		{
			VuforiaRuntime.Instance.Deinit ();
			Application.LoadLevel ("Input");
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
		VuforiaRuntime.Instance.Deinit ();
		Destroy (GameObject.Find("ARCamera"));
		Application.LoadLevel ("Main");
	}

	public void ar()
	{
		VuforiaRuntime.Instance.InitVuforia ();
		Application.LoadLevel ("AR");
	}

	public void db1()
	{
		VuforiaRuntime.Instance.InitVuforia ();
		Application.LoadLevel ("Database");
		db_song = 1;
	}

	public void db2()
	{
		VuforiaRuntime.Instance.InitVuforia ();
		Application.LoadLevel ("Database");
		db_song = 2;
	}
}
