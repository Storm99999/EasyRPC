# EasyRPC
A easier way to make a DiscordRPC


# How To Use
* Goto https://discord.dev
* Create A New Application
* Goto The RPC Tab
* Upload A Image, If it's too big then resize it here https://resizeimage.net/
* Name The Image For Example "myLargeImageKey"
* Then create a visual or Rider Project
* Import the DLL, Goto Your project and right click > Add > Reference
* Then Use The Code Below
* Important: the numbers are your Application ID, means you'll need to copy it from https://discord.dev
```cs
EasyRPC.src.RPC.ActivateRPC("43843432823822993", "Very Cool Game", "myButton", "https://supercoolbutton.site", "Playing Skywars", "myLargeImageKey", "MyLargeImageText");
```
