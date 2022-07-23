using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnpoint : MonoBehaviour
{
    private Transform SpawnOutLocation;
    public string ScToLoad;


    // Start is called before the first frame update
    void Start()
    {
        SpawnOutLocation = this.gameObject.transform.GetChild(0);
    }


    public void OnTriggerEnter(Collider point)
    {
      
        if (point.CompareTag("Player"))
        {
            //code here the location of where to come back to SpawnOutLocation 
            Destroy(point.gameObject);
           //DontDestroyOnLoad(point.gameObject);
            Debug.Log(SpawnOutLocation.position);
            //.SharedInstance.SetSpawn(SpawnOutLocation.position);
            SceneManager.LoadScene(ScToLoad);
        }
    }
  

}