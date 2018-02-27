using UnityEngine;
using System.Collections;

public class PanelManager : MonoBehaviour {

    public GameObject towerPrefab;
    
    public void OnClick()
    {
        CreateTower();
    }

    private void CreateTower()
    {
        var towerTile = GameObject.FindGameObjectWithTag("SelectedTile");
        if (towerTile == null)
        {
            return;
        }
        if (towerTile.transform.childCount == 0)
        {
            var Tower = Instantiate(towerPrefab, towerTile.transform.position, Quaternion.identity) as GameObject;
            Tower.transform.SetParent(towerTile.transform);

            //Fix tower position
            //Debug.Log(Tower.transform.localScale.y/2);            
            //Tower.transform.position = new Vector3(towerTile.transform.position.x, towerTile.transform.position.y, towerTile.tra);

            //Selected Tile changeBuildedState
            towerTile.GetComponent<TileControl>().isBuilded = true;
        }
    }
}
