using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager SharedInstance { get; private set; }
    public GameObject DefaultPlayer;
    private Transform defaultPoint;
    private Vector3 spawnlocation;
    private bool SetPoint;



    public void SetSpawn(Vector3 x)
    {
        SetPoint = true;
        spawnlocation = x;
    }
/*
    private void Awake()
    {
        if (SharedInstance == null)
        {
            SharedInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    */
    private void OnLevelWasLoaded(int level)
    {
        print(spawnlocation);
        if (level > 1)
        {
            Transform temp = GameObject.Find("SpawnHere").transform;
            Instantiate(DefaultPlayer, temp.position, Quaternion.identity);
        }
       
    }





    void spawnAtSetlocation()
    {
        Debug.Log("Done spwaning at set location");
        Instantiate(DefaultPlayer, spawnlocation, Quaternion.identity);
        SetPoint = false;
    }

    void spawnAtStart()
    {
        defaultPoint = GameObject.Find("DefaultPoint").transform;
        Instantiate(DefaultPlayer, defaultPoint.position, defaultPoint.rotation);
    }



}