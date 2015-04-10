using UnityEngine;
using System.Collections;

public class ShowInter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AdTapsy.StartSessionAndroid("551b3c18e4b0eb64412af40a");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ShowIntertial()
    {
        AdTapsy.ShowInterstitial();  
      
    }
}
