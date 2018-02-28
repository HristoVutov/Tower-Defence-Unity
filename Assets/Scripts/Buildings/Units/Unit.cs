using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Unit : MonoBehaviour {
    //TODO: Create abstract

    //TODO: FIX 
    public List<GameObject> projectilesList;

    [Range(1,10000)]
    public float Healt = 100;

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Projectile")
        {
            var projectileDamage = col.gameObject.GetComponent<Projectile>().damage;
            this.Healt -= projectileDamage;
            Debug.Log("Hitted");
            if (this.Healt < 0)
            {
                foreach (var projectile in projectilesList)
                {
                    Destroy(projectile);
                }
                Destroy(gameObject); 
            }
            Destroy(col.gameObject, 0.1f);
        }
    }

    // Use this for initialization
    void Start () {
	    projectilesList = new List<GameObject>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
