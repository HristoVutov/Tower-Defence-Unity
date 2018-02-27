using UnityEngine;

public class Building : MonoBehaviour
{
    [Range(0, 50)]
    public int radius;

    // Use this for initialization
    void Start()
    {
        // TODO: Change radius to be on when shop activated or tower clicked
        //Creating radius of Tower
        var transf = gameObject.transform.GetChild(0).GetComponent<Transform>();
        transf.eulerAngles = new Vector3(90,0,0);
        transf.localScale = new Vector3(radius, 0.000001f, radius);

    }
}

