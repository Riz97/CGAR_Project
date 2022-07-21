[README.pdf](https://github.com/Riz97/CGAR_Project/files/9161984/README.pdf)
# CGAR_Project
Computer Graphics &amp; Augmented Reality Final Project
Computer Graphics - Augmented Reality - Project 2021/2022
Riccardo Caprile 4370774
Giulia Benvenuto 4678610
Application for visualizing 3D models and their instructions.

The objective of this project is to scan a QR code , visualize the 3d model , interact with them and
navigate through the instructions.

The application is built and tested with an Android Device, Unity, Vuforia.

There are five different QRs bound to five different type of furniture ( QR 1 = modern Chair , QR 2
= Sofa , QR 3 = Table , QR 4 = Office Chair , QR 5 = Chest of Drawers). It’s very easy to change the
main topic of the models ( industrial purpose).

The Main Camera is the Vuforia AR Camera.

The interaction types are : Translate , Scale and Rotate. Done using gestures like pinch , drag and
twist. The scripts of the interactions are taken from a Library available in the Unity Asset Store
(Lean).

For the creation of the QRs code it was used a website. To storage theQRs it was used Vuforia
Engine Developer Portal ( the same tool that provides you with an available Vuforia Key)
Behind the model there is the instruction that tells you how to build the piece of furniture. You
can move the pages forward and backward using two different Vuforia Virtual Button attached to
two different scripts ( ForwardButton.cs and BackwardButton.cs) . The visualization of the
instruction is managed as follows : five different canvas , one for each model. The Canvas , in the
hierarchy , is child of the QR code. In this way only one canvas at the same time is visible by the
user. In the hierarchy , the Canvas has a child which is an image that displays the first page of the
instruction and the scripts above change the sprite of the Image if the user press the Virtual
Button.

The Virtual Buttons by default are transparent , so in order to see them , we used planes
positioned right above the Virtual Button. They are triggered by occlusion and you can set three
different types of sensitivity. For the project we set it as medium
