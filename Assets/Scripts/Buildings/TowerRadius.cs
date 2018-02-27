using UnityEngine;
using System.Collections;

public class TowerRadius : MonoBehaviour {

    void OnTriggerStay(Collider col)
    {
        var towerScript = transform.parent.gameObject.GetComponent<Tower>();
        towerScript.ShootEnemy(col.gameObject);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
