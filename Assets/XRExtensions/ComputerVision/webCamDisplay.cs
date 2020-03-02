using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace XRExtensions
{
    public class webCamDisplay : MonoBehaviour
    {
        // Starts the default camera and assigns the texture to the current renderer

        public RawImage rawimage;
        public int requestedHeight = 480;
        public int requestedWidth = 640;
        void Start()
        {
            
            WebCamTexture webcamTexture = new WebCamTexture(requestedHeight,requestedWidth);
            webcamTexture.Play();
            rawimage.texture = webcamTexture;
            rawimage.SetNativeSize();
            rawimage.material.mainTexture = webcamTexture;

        }

    }
}

