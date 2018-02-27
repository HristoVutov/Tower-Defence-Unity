using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {
    //TODO: Create abstract

    [Range(1,10000)]
    public float Healt = 100;

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Projectile")
        {
            var projectileDamage = col.gameObject.GetComponent<Projectile>().damage;
            this.Healt -= projectileDamage;
            if(this.Healt < 0)
            {

                Destroy(gameObject); 
            }
            Destroy(col.gameObject, 0.1f);
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
