using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourWine : MonoBehaviour
{

    public GameObject wineStream;
    public Transform wineBottle;
    public Transform bottleTop;

    private bool isPouring = false;
    private bool pourCheck;
    public float bottleTopHeight;
    public float bottleMidHeight;

     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        bottleMidHeight = wineBottle.position.y;
        bottleTopHeight = bottleTop.position.y;


        Debug.Log(isPouring);
        //Debug.Log(bottleTopHeight);

        pourCheck = (bottleTopHeight - bottleMidHeight) > 0;




        if (isPouring != pourCheck)
        {
            isPouring = pourCheck;
            wineStream.SetActive(isPouring);
            Debug.Log("why is it pouring");
        }
    }

    private void StartPour()
    {
        wineStream.SetActive(true);
    }

    private void EndPour()
    {
        wineStream.SetActive(false);
    }

}
