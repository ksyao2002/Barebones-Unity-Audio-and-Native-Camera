using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public AudioSource explain1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void playAudio()
    {
        print("playing audio");
        explain1.PlayOneShot(explain1.clip);
    }

    public void record()
    {
        RecordVideo();
    }

    private void RecordVideo()
    {
        NativeCamera.Permission permission = NativeCamera.RecordVideo((path) =>
        {
            UnityEngine.Debug.Log("Video path: " + path + " is the path");
            if (path != null)
            {
                // Play the recorded video
                //Handheld.PlayFullScreenMovie("file://" + path);
            }
        });//, NativeCamera.Quality.Medium, 100, 100L, NativeCamera.PreferredCamera.Front);

        UnityEngine.Debug.Log("Permission result: " + permission);
    }
}
