using Accord.Imaging;
using Accord.Unity;
using Accord.Imaging.Filters;
using System.Drawing;
using Accord.Vision.Tracking;
using System.Collections;
using System.Collections.Generic;
using Accord.DataSets;
using UnityEngine;
using UnityEngine.UI;
using Vector3 = UnityEngine.Vector3;
using Bitmap = System.Drawing.Bitmap;


/// <summary>
/// Bits and bobs for test usability of accordNet in unity
/// </summary>
public class AccordVisionTest : MonoBehaviour
{
    public RawImage rawImage;
    public Texture2D inputTex;
    
    // Start is called before the first frame update
    void Start()
    {
        //TestImages t = new TestImages("lena");

        Bitmap image = BitmapConversion.Texture2DToBitmap(inputTex);

        FastCornersDetector fast = new FastCornersDetector(20);
       

        
        // Create a new AForge's Corner Marker Filter
        CornersMarker corners = new CornersMarker(fast, System.Drawing.Color.White);
        corners.ApplyInPlace(image);
        // Apply the filter and display it on a picturebox
        rawImage.texture = BitmapConversion.BitmapToTexture2D( image );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
