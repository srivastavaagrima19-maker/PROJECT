using UnityEngine;

public class FurniturePlacer : MonoBehaviour
{
    public GameObject currentFurniture;

    public void SetFurniture(GameObject furniture)
    {
        currentFurniture = furniture;
        Debug.Log("Selected: " + furniture.name);
    }

    void Start()
    {
        if(currentFurniture != null)
        {
            Instantiate(currentFurniture,
                        new Vector3(0,0,2),
                        Quaternion.identity);
        }
    }
}