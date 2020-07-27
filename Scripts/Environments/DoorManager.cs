using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public GameObject lockedTrig01;
    public GameObject lockedTrig02;
    public GameObject lockedTrig03;
    public GameObject lockedTrig04;
    
    public GameObject lockedTrig05;
    public GameObject lockedTrig06;
    public GameObject lockedTrig07;
    public GameObject lockedTrig08;
    public GameObject lockedTrig09;
    public GameObject lockedTrig10;
    public GameObject lockedTrig11;
    public int rand;
    public static GameObject foundDoor;
    public GameObject internalFound;



    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1,12);

        
    }

    // Update is called once per frame
    void Update()
    {
        if(rand == 1)
            foundDoor = lockedTrig01;
        if(rand == 2)
            foundDoor = lockedTrig02;
        if(rand == 3)
            foundDoor = lockedTrig03;
        if(rand == 4)
            foundDoor = lockedTrig04;
        if(rand == 5)
            foundDoor = lockedTrig05;
        if(rand == 6)
            foundDoor = lockedTrig06;
        if(rand == 7)
            foundDoor = lockedTrig07;
        if(rand == 8)
            foundDoor = lockedTrig08;
        if(rand == 9)
            foundDoor = lockedTrig09;

        if(rand == 10)
            foundDoor = lockedTrig10;

        if(rand == 11)
            foundDoor = lockedTrig11;

        internalFound = foundDoor;

    }
}
