using UnityEngine;
using System.Collections;

public class TileControl : MonoBehaviour {

    MeshRenderer m_Renderer;
    public bool isBuilded = false;

    private bool isSelected = false;
    private GameObject[] tileArray;
    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
        tileArray = GameObject.FindGameObjectsWithTag("Tile");
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        m_Renderer.material.color = new Color(255, 0, 0, 255);
        transform.tag = "SelectedTile";
        if (transform.childCount > 0 && transform.tag == "SelectedTile")
        {
            var sphere = transform.GetChild(0).GetChild(0).gameObject;
            sphere.SetActive(!sphere.active);
        }

        foreach (var item in tileArray)
        {
            if (item.name == transform.name)
            {
                continue;
            }
            if(item.tag == "Tile")
            {                
                continue;
            }
            var mesh = item.GetComponent<MeshRenderer>();
            mesh.material.color = new Color(1, 0, 0, 0.103f);
            item.tag = "Tile";

            if (item.transform.childCount > 0)
            {
                var sphere = item.transform.GetChild(0).GetChild(0).gameObject;
                sphere.SetActive(false);
            }

        }
    }
}
