# AccordNET4Unity
Port of AccordNET to unity with some glue code for interfacing with system.drawing

# Usage:
- project contains Bitmapconversion class that is used by almost self explanatory methods : BitmapToTexture2d and Texture2dToBitmap
- both are used to convert to and from the system drawing compliant format that is used by accordnet for image processing
- there are some examples that try to asess the usability of accord in unity, for now we have a feature extractor from static image
- and a jumping ball
- hopefully we will get to extract the features from webcam

# TODO
- Get rid of system.drawing for image processing
- probably use skiasharp
- port it to android because who actualy use computer vision in desktop apps anyway
- do something usefull with it
