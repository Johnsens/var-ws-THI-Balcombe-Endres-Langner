using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIflast : MonoBehaviour
{

    public GameObject plantPopUp;
    private float spawnDistance = 2;

    private bool stopUpdate = false;

    public GameObject levelfinishedPopUp;

    public Transform XRRigPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void closePlantFoundPopUp() {
        if (GlobalVariables.plantCounter <= 4) {
            plantPopUp.SetActive(!plantPopUp.activeSelf);
        }
        else {
            plantPopUp.SetActive(!plantPopUp.activeSelf);
            levelfinishedPopUp.SetActive(!levelfinishedPopUp.activeSelf);
            levelfinishedPopUp.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x -5, 30,XRRigPosition.forward.z + 15).normalized * spawnDistance;
            Debug.Log(levelfinishedPopUp.transform.position);
            Debug.Log("EndConditionMet");
            levelfinishedPopUp.transform.LookAt(new Vector3 (XRRigPosition.position.x, levelfinishedPopUp.transform.position.y, XRRigPosition.position.z));
            Debug.Log(levelfinishedPopUp.transform.position);
            levelfinishedPopUp.transform.forward *= -1;
        }
    }
}
