using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	private AndroidJavaObject jo;
	// Use this for initialization
	void Start () {
		AndroidJavaClass jc = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");  
		jo = jc.GetStatic<AndroidJavaObject> ("currentActivity");
	}

	public void showscreen(){
		jo.Call ("onRTSPVRLibClicked");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
