using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;



public class GameMenuManager : MonoBehaviour
{

    // Different Overlays

    public GameObject gamemenu;
    public GameObject plantPopUp; //Will be deprecated -> See different PlantFoundPopUps
    public GameObject endPopUp;
    public GameObject startMissionOverlay;

    //Button declarations on the Overlays

    //Not used right now, would be used to change the content of the Overlays when going through the pages

    public Transform XRRigPosition;

    //Values used for counting inventories


    public InputActionProperty showButton;
    //public Scene multiUserStartScene;

    public Plant plant;

    private NetworkPlayer networkPlayer;

    //variables needed to keep Menu in front of player
    public float spawnDistance = 2;

    // Start is called before the first frame update
    void Start()
    {
        showStartMissionOverlay();
        //    showPlantFoundPopUp();
    }

    // Update is called once per frame
    void Update()
    {
    }


    //Functions to show Overlays
    void showMenuSwitch()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            gamemenu.SetActive(!gamemenu.activeSelf);

            //Defining a Vector to place the menu in front of player by using the normalized vector and manipulating the x and z axis
            gamemenu.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x, 0, XRRigPosition.forward.z).normalized * spawnDistance;
        }

        //Making Sure menu is always facing the player by manipulting the y axis
        gamemenu.transform.LookAt(new Vector3(XRRigPosition.position.x, gamemenu.transform.position.y, XRRigPosition.position.z));
        //flipping the menu around, as it was backwards
        gamemenu.transform.forward *= -1;
    }


    /*void showEndPopup() {
        if (ClosePlantPopup.clicked) {
            plantPopup.SetActive(false);
            endPopUp.SetActive(true);
        }
    }*/

    void showStartMissionOverlay()
    {
        //XROrigin rig = FindObjectOfType<XROrigin>();
        //headRig = rig.transform.Find("ViveCameraRig/Camera");
        startMissionOverlay.SetActive(!startMissionOverlay.activeSelf);


    }

    void updateStartMissionOverlay()
    {
        startMissionOverlay.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x, 0, XRRigPosition.forward.z).normalized * spawnDistance;
        startMissionOverlay.transform.LookAt(new Vector3(XRRigPosition.position.x, startMissionOverlay.transform.position.y, XRRigPosition.position.z));
        //flipping the menu around, as it was backwards
        startMissionOverlay.transform.forward *= -1;
    }

    public void showEndoverlay()
    {
        if (endPopUp.activeSelf == true)
        {
            endPopUp.SetActive(!endPopUp.activeSelf);
            endPopUp.transform.position = XRRigPosition.position + new Vector3(XRRigPosition.forward.x, 0, XRRigPosition.forward.z).normalized * spawnDistance;
        }
    }
}
