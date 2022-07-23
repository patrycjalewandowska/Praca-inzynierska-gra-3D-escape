using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryPanel : MonoBehaviour
{
    public GameObject InventoryUI;
    bool Inventorydisplay = false;

  



    void Start()
    {
      

    }
     void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Q))
        {
        
           
            if (Inventorydisplay)
            {
                   InventoryUI.SetActive(false);
                   Inventorydisplay = false;
                   Time.timeScale = 1f;
            }
            else
            {             
                InventoryUI.SetActive(true);
                Inventorydisplay = true;
                Time.timeScale = 0f;
                
            }
            /*
            if (PauseMenuUI)
            {
                InventoryUI.SetActive(false);
                Inventorydisplay = false;
            }
            */
        }

      
    }

}
