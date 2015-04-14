using UnityEngine;
using System.Collections;

public class ShowInter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AdTapsy.StartSessionAndroid ("54982cf7e4b052cd2a20a7b8");
		AdTapsy.StartSessionIOS ("539777bae4b02eacca4bcb67");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ShowIntertial()
    {
        AdTapsy.ShowInterstitial();  
      
    }
}
