using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageBranchNode : MonoBehaviour
{
    private GameObject parentNode;
    public GameObject moveToPos;
    public GameObject player;

    public Material activeMaterial;
    public Material notActiveMaterial;
    private void Start()
    {
        parentNode = transform.parent.gameObject;
    }
    public void OnClick()
    {
        Debug.Log("moving player");
        player.transform.position = moveToPos.transform.position;

        moveToPos.GetComponent<ImageNode>().SetActiveNode(activeMaterial);
        parentNode.GetComponent<ImageNode>().SetActiveNode(notActiveMaterial);
    }

    private void OnDrawGizmos()
    {
        if (moveToPos == null)
            return;

        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, moveToPos.transform.position);
    }
}
