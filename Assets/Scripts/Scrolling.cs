using UnityEngine;

public class Scrolling : MonoBehaviour {
    //make automatic
    public int panCount;
    public GameObject panPrefab;
    [Range(0,500)]
    public int panOffset;
    private GameObject[] panelsArray;
	// Use this for initialization
	private void Start () {
        panelsArray = new GameObject[panCount];
        for (int i = 0; i < panCount; i++)
        {
            panelsArray[i] = (GameObject)Instantiate(panPrefab, transform.position, transform.rotation);
            panelsArray[i].transform.SetParent(transform, false);
            panelsArray[i].name = "Panel-" + i;
            if (i == 0){continue;}
            panelsArray[i].transform.localPosition = 
                new Vector2(panelsArray[i - 1].transform.localPosition.x + panOffset, 
                panelsArray[i].transform.localPosition.y + 5);            
        }
	}
}
