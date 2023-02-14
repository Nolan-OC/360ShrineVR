using System.IO;
using UnityEngine;

public class LoopImages : MonoBehaviour
{
    public string directoryPath;

    void Start()
    {
        LoopThroughImages();
    }

    private void LoopThroughImages()
    {
        string[] imagePaths = Directory.GetFiles(directoryPath);

        foreach (string imagePath in imagePaths)
        {
            Debug.Log("file detected at " + imagePath);

            //if the image is a 3d image,
        }
    }
}
