/*
* Author: Chenyu Zhao
* Date last Modified: 2015-10-03
*/
using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {

    // Use this for trigger destory collision game object
    void OnTriggerExit(Collider other) {
        Destroy(other.gameObject);
    }
	
	
}
