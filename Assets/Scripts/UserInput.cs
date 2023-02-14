using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public Camera firstPersonCam, birdsEyeCam;
    private bool isFirstPerson = true;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
            MouseClicked();

        if (Input.GetKeyDown(KeyCode.M))
            ToggleView();

    }
    private void MouseClicked()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            GameObject objectHit = hit.transform.gameObject;
            if (hit.collider.TryGetComponent(out ImageBranchNode node))
            {
                node.OnClick();
            }
        }
    }

    private void ToggleView()
    {
        if(isFirstPerson)
        {
            //enter 3rd person
            isFirstPerson = false;
            Debug.Log("entering 3rd person");

            birdsEyeCam.enabled = true;
            firstPersonCam.enabled = false;
            birdsEyeCam.tag = "MainCamera";

            //lock and hide cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
        else
        {
            //enter 1st person
            isFirstPerson=true;
            Debug.Log("entering 1st person");

            firstPersonCam.enabled = true;
            birdsEyeCam.enabled = false;
            
            firstPersonCam.tag = "MainCamera";

            //unlock and reveal cursor
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    

}
