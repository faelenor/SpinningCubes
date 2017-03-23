# Spinning Cubes

## 1. Physics - Constant torque

This method uses the "Constant Force" component to set a contant torque on the rigid body. Angular drag is used to stabilize the rotation to an acceptable speed.

## 2. Physics - Initial angular velocity

This method sets an initial angular velocity on the rigid body via script. Angular drag is set to zero to make sure that the rotation won't stop.

## 3. Animated cube

We add a component "Animator" to a cube. This component plays an animation which modifies the cube's transform. This animation has been created via Unity's curve editor in the Animation Window.

## 4. Video player
We play a video on the near plane of the camera which represents a spinning cube.

## 5. Scripted rotation
In the update of a C# script attached to the cube we rotate the object.

## 6. Animating VS
Using a vertex shader to rotate the cube.

## 7. Web Player
Jennifer - couldnt find a ogg movie on the internet with a spinning cube YET

## 8. API drawcalls
Drawing via GL utilities a spinning cube.

## 9. Animated Texture 
Using an array of textures representing a spinning cube and using a script to animate them.

## 10. Sprite
Using a sprite to show an animated spinning cube.

## 11. Rotating camera
WIP

## 12. Navmesh ?

## 13. Draw Mesh
This method simply pushes a request each frame to draw a cube at different rotation.

## 14. 

## 15. 


