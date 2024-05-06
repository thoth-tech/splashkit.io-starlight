---
title:  Building your multi-tool
sidebar:
  attrs:
    class: pi
  label: "2. Building your multi-tool"
---

:::tip
Using your own SD card? Make sure you have installed Raspberry Pi OS on it. You can find the instructions in the [Set up my Raspberry Pi](/book/part-0-getting-started/2-computer-use/0-installation/2-3-setup-pi) section.
If we have provided you with an SD card, it will already have the OS installed.
:::

Check you have all the components listed above, or equivalent alternatives.

Here is what the components above look like:

![Picture of Raspberry Pi components laid out in their original packaging](./src/assets/images/Pi-Computer/AllComponets.jpg)

### Prepare the Raspberry Pi board

To help prevent the Raspberry Pi from overheating, it is a good idea to use something called a [**heat sink**](https://en.wikipedia.org/wiki/Heat_sink) on the areas that are most likely to get hot when in use.

Locate the Raspberry Pi and 3 piece heatsink kit. Remove the Pi from its packaging.

![Picture of Raspberry Pi and heatsink kit](./src/assets/images/Pi-Computer/Pi_Heatsink.jpg)

Peel the backing off the heat sinks and stick them to the Pi.

:::note
The largest heatsink goes on the CPU(SOC), the two smaller ones go on the RAM and USB chips (as shown below):

![Picture showing the heat sinks installed on the Pi and Heat Sync Peeled](./src/assets/images/Pi-Computer/PiHeatsinkPeelInstalled.jpg)

:::

### Secure the Raspberry Pi into the Case

Now we need to put the board inside the case so that we can access the ports, and attach the board to the screen in the next step.  
_Note: You will need a small Phillips Head screwdriver for some steps in this part._

Open the black Raspberry Pi case (and put the screws and feet aside for the moment).

![Picture of the Pi case and screws](./src/assets/images/Pi-Computer/PiandCase.jpg)

:::tip[Insert the Pi into the case]
This case is a bit fiddly to get the Pi in correctly, but it doesn't require much force.

- Place the Pi in the case
- Align the network port with the opening.
- Apply a little pressure to the back of the USB ports, the headphone jack should slide into place.
- Push the board across so the USB-C power and Mini HDMI ports are seated correctly.
- All 4 Pi screws should line up with the holes in the case.

![Gif showing the Pi installed in the case](./src/assets/gifs/pi-computer/PiCaseInstall.gif)

:::

To keep the Raspberry Pi from moving around, use the screwdriver to screw the four **short screws** through the yellow circles on the board to secure the Pi to the case:

<MySwiper client:only height="" images={Swiper1}></MySwiper>

### Install the cooling fan on Case Lid

The case we have suggested allows for you to attach a cooling fan. Similar to the heat sinks mentioned above, this will help prevent the board from overheating and running slower.

Peel the plastic protective layer off the lid of the case, and place it on your work space upside down (as shown below). Take the fan out of its packaging, as well as the four included screws.

![Picture of the fan and case top](./src/assets/images/Pi-Computer/CaseTopFan.jpg)

Place the fan on the case mounts with the label facing up and use **two** of the screws to secure it in place using the two mounting holes shown above.

:::note
Facing the label up will ensure the fan blows air into the case.  
Only two screws are required to secure the fan. The other two screws and the four nuts are not required.  
Ensure the fan cable is close to one of the long sides.

![Picture of the fan installed on the case lid](./src/assets/images/Pi-Computer/FanInstalled.jpg)

:::

To power the cooling fan, you will need to connect the fan to the GPIO pins on the Pi. (See image at top of this document for pin locations)

Put the case lid and secured fan next to the base part of the case, and connect the 3 wires to the following GPIO pins:

- <span style="color:red">_Red_</span> wire to pin 4 (5V)
- _Black_ wire to pin 6 (Ground)
- <span style="color:blue">_Blue_</span> wire to pin 8 (GPIO14)

You should now have something that looks similar to this:

![Picture of the fan connected to the Pi](./src/assets/images/Pi-Computer/FanConnected.jpg)

Lastly, place the lid on the case, ready for the next step:

![Picture of placing lid onto case](./src/assets/images/Pi-Computer/CaseLid.png)

### Attach VESA Mount to Case

This next step will allow you to attach your Raspberry Pi's Case to the back of the screen which will allow it to be more portable.

Open the VESA mount packaging and peel the protective layer off the VESA mount (as shown below).  
_Keep the nylon screws/spaces aside for the next part._

![Picture of the case and VESA mount](./src/assets/images/Pi-Computer/VESAMountUnWrap.png)

Secure the VESA mount to the case using the four **long screws** that were included in the packaging for the Case. This will also keep the case lid securely attached.

![Picture of the VESA mount installed on the case](./src/assets/images/Pi-Computer/VESAMountScrews.jpg)

:::danger[Important!]

- Make sure to line up mount so that the 75 x 75mm VESA mount holes are on opposite side to the USB-C and Mini HDMI ports.
- It doesn't matter if the mount is flipped (as it is in the image above), as the middle holes won't be used.

:::

### Insert the Micro SD Card

Due to the position of the Micro SD card slot on the Raspberry Pi, it is easier to insert the Micro SD card at this point, while it is more easily accessed.

To insert the Micro SD card into the Raspberry Pi:

- Remove the Micro SD card form the SD card adapter.
- Position the Pi with the VESA mount on top.
- Insert the SD card into the Pi with the label facing up.

<MySwiper client:only height="" images={Swiper2}></MySwiper>