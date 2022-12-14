using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PlantOverlayTrigger : MonoBehaviour
{

    public GameObject plantPopUp;
    public GameObject plant;
    public GameObject levelfinishedPopUp;
    public Transform XRRigPosition;
    public float spawnDistance = 2;
    //This counter would be for different plants of the same type
    //public int counter = 0;


    // Start is called before the first frame update
    void Start()
    {      
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void plantShown() {
                plantPopUp.SetActive(!plantPopUp.activeSelf);
                countPlants();
                Debug.Log("Plant pop up shown");
                plant.SetActive(!plant.activeSelf);
                Debug.Log("Plant disappeared");
    }

    //Counts the plants and every plant given a special tag
    public void countPlants() {
        GlobalVariables.plantCounter = GlobalVariables.plantCounter + 1;
        Debug.Log("The PlantCounter is " + GlobalVariables.plantCounter);
        if (plant.CompareTag("Poisonous")){
            GlobalVariables.poisonPlantCounter = GlobalVariables.poisonPlantCounter +1;
            Debug.Log("The PoisonousPlantCounter is " + GlobalVariables.poisonPlantCounter);
        }

    }

}
