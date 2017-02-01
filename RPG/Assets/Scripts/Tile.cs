using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    static public float tileLength;
    bool unitAndPlayerOnTile;

    // Use this for initialization
    void Start()
    {
        tileLength = transform.localScale.x;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider triggerCollider)
    {
        if (triggerCollider.tag == "Unit" && triggerCollider.tag == "Player") unitAndPlayerOnTile = true; //pending Ryan and Caden
        else unitAndPlayerOnTile = false;
    }

}
