using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Net.Sockets;
using System.Threading;
using System.IO;
using System;

public class streamChords : MonoBehaviour 
{
	TcpClient client;
    Stream s;
    StreamReader sr;
    StreamWriter sw;
    Thread recvT;
    public bool ready = false;
    public bool running = true;
    public string message;
    string temp;

	public Text chord;

	// Use this for initialization
	void Start () 
	{
		 new Thread(initThread).Start();
	}
	
	// Update is called once per frame
	void Update () 
	{
		StartCoroutine(play());
	}

	 public void initThread()
    {
        TcpClient client = new TcpClient("192.168.43.13", 5204); //Change IP here; Not the port
        s = client.GetStream();
        sr = new StreamReader(s);
        sw = new StreamWriter(s);
        sw.AutoFlush = true;

        recvT = new Thread(recvThread);
        recvT.Start();

        ready = true;
    }

    public void recvThread()
    {
        print("RecvThread started..");
        while (running)
        {
            try
            {
                message = sr.ReadLine();
                print("Recieved : " + message);
            }
            catch (Exception e)
            {
                print(e);
            }
        }
    }

	IEnumerator play()
	{
		WaitForSeconds wait = new WaitForSeconds (2f);
		yield return wait;
		foreach (char c in message) 
		{
			chord.text = c.ToString();

			if (c.ToString() == "-") 
			{
				chord.text = "Non Guitar tones here";
			}

			yield return wait;
		}
	}
}
