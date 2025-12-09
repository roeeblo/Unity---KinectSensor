# Kinect Depth Sensor - Unity Project

This home-task demonstrates depth processing using the Kinect (or XEF file), to display colors based on distances.

Kinect provides depth data as a one dimensional array of short values.  
Each value represents the distance (in millimeters) from the sensor to the detected surface at that pixel.
My project maps each depth value into a Color32 pixel and constructs a Texture2D that Unity can display.

- 1000–1500 mm is Red  
- 1500–2000 mm is Green  
- all other distances are Black

The resulting texture is updated each frame and applied to a Quad in the scene.

Fully Video presenting my project:

www.youtube.com/watch?v=Z4bHarA6ugA&feature=youtu.be
