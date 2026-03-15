# Kinect Depth Processing in Unity

This project demonstrates real-time depth sensing and visualization using the Microsoft Kinect sensor inside Unity.

The system reads raw depth frames from the Kinect device or from recorded XEF files, processes the depth values per pixel, and converts distance ranges into visual output.  
The result is a live depth-based segmentation that highlights objects according to their distance from the sensor.

The focus of this project is working with depth data, spatial information, and real-time pixel processing, which are common building blocks in computer vision systems.


## Overview

The Kinect sensor provides a depth stream where each pixel represents the distance between the sensor and the scene.

In this project:

The depth frame is read from the Kinect sensor  
Each pixel contains a distance value measured in millimeters  
The values are analyzed in real time  
Pixels that fall within selected depth ranges are highlighted with color  
The processed frame is rendered as a texture inside Unity


## Technical Flow

Capture a depth frame from the Kinect sensor or from an XEF recording

The frame is received as a one-dimensional array containing the depth value of every pixel

Each depth value represents the distance from the sensor in millimeters

The system analyzes the values and checks whether they fall within predefined distance ranges

Pixels that match the selected ranges are assigned a specific color

The processed pixel array is used to build a Texture2D

The texture is updated and rendered in Unity in real time


## Depth Segmentation Logic

Objects are highlighted according to their distance from the sensor.

1000–1500 millimeters are displayed in red

1500–2000 millimeters are displayed in green

All other distances are displayed as black


## Technologies

Unity  
Microsoft Kinect Sensor SDK  
C#  
Depth frame processing  
Real-time texture rendering


## Use Cases

Depth-based scene visualization

Basic spatial segmentation using distance thresholds

Exploring depth sensor data inside Unity

Prototyping systems that rely on spatial awareness

