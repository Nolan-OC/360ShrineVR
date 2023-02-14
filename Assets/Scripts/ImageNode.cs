using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageNode : MonoBehaviour
{
    [SerializeField]
    private Sprite image;

    public void SetActiveNode(Material material)
    {
        this.GetComponent<Renderer>().material = material;
    }

    /*
    private void OnValidate()
    {
        if (endingNodes != previousList)
        {

            foreach (ImageNode node in endingNodes)
            {
                //do not update nodes which already exist
                if (previousList.Contains(node))
                    break;

                //create branches between two images
                Vector3 spawnPos = Vector3.Lerp(transform.position, node.transform.position, 0.5f);
                Instantiate(pfBranch, spawnPos, Quaternion.identity);
            }
            //create branches from this to ending node
            //move branches inbetween nodes
            //move branch links to the nodes
            Debug.Log(transform.name + " is changing the list");
            previousList = endingNodes;
        }
    }
    */
}
