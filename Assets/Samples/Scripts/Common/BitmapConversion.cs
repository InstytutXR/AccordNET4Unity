using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using Bitmap = System.Drawing.Bitmap;

/// <summary>
/// Helper functions for accord.net
/// </summary>
namespace Accord.Unity
{
    
    public class BitmapConversion : MonoBehaviour
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_outputBitmap"></param>
        /// <param name="_inputTex"></param>
        public static void Texture2DToBitmap( Bitmap _outputBitmap, Texture2D _inputTex)
        {

            byte[] bytes = _inputTex.EncodeToPNG();
            MemoryStream ms = new MemoryStream(bytes);
            ms.Seek(0, SeekOrigin.Begin);
            
            _outputBitmap = new Bitmap(ms);

        }
        public static Bitmap Texture2DToBitmap(Texture2D _inputTex)
        {

            byte[] bytes = _inputTex.EncodeToPNG();
            MemoryStream ms = new MemoryStream(bytes);
            ms.Seek(0, SeekOrigin.Begin);
            Bitmap outputBitmap = new Bitmap(ms);
            return outputBitmap;
        }
        /// <summary>
        /// Function that converts system bitmap used in aforge and accord to Unity Texture2D
        /// </summary>
        /// <param name="_inputBitmap"> Input system.drawing.bitmap </param>
        /// <param name="_outputTex"> output unity.texture2d </param>
        public static void BitmapToTexture2D(Bitmap _inputBitmap, Texture2D _outputTex)
        {
            MemoryStream ms = new MemoryStream();
            _inputBitmap.Save(ms, _inputBitmap.RawFormat);
            _outputTex.LoadImage(ms.ToArray());

        }
        public static Texture2D BitmapToTexture2D(Bitmap _inputBitmap)
        {
            MemoryStream ms = new MemoryStream();
            _inputBitmap.Save(ms, _inputBitmap.RawFormat);
            Texture2D outputTex = new Texture2D(1, 1);
            outputTex.LoadImage(ms.ToArray());
            return outputTex;
        }
    }
}

