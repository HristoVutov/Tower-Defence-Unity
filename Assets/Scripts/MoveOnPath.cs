using UnityEngine;
using System.Collections;

public class MoveOnPath : MonoBehaviour {

    public PathEditor PathToFollow;

    public int CurrentWayPointID = 0;
    public float speed;
    private float reachDistance = 1.0f;
    public float rotatopnSpeed = 5.0f;
    public string pathName;

    Vector3 last_postion;
    Vector3 current_position;

	// Use this for initialization
	void Start () {
        //PathToFollow = GameObject.Find(pathName).GetComponent<PathEditor>();
        last_postion = transform.position;
	}
	
	// Update is called once per frame
	void Update () {        
        
        if (CurrentWayPointID != PathToFollow.path_objs.Count)
        {
            float distance = Vector3.Distance(PathToFollow.path_objs[CurrentWayPointID].position, transform.position);
            transform.position = Vector3.MoveTowards(transform.position, PathToFollow.path_objs[CurrentWayPointID].position, Time.smoothDeltaTime * speed);
            
            if (distance == 0)
            {
                CurrentWayPointID++;
            }
        }
    }
}
