using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public GameObject buildingTiles;

    private MeshRenderer m_Renderer;
    private bool changeBuildingTilesActiveStatus = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {

            for (int i = 0; i < buildingTiles.transform.childCount; i++)
            {
                var currentChild = buildingTiles.transform.GetChild(i);
                if (currentChild.GetComponent<TileControl>().isBuilded != true)
                {
                    currentChild.gameObject.SetActive(!currentChild.gameObject.active);
                }
                else
                {
                    //Fix this if not selected
                    m_Renderer = currentChild.GetComponent<MeshRenderer>();
                    m_Renderer.material.color = new Color(1, 0, 0, 0.103f);
                }
            }
        }
    }

    
}
