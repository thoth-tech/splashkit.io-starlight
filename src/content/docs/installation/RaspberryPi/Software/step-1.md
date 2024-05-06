---
title:  Download Raspberry Pi OS
sidebar:
  attrs:
    class: pi
  label: "1. Download Raspberry Pi OS"
---

:::tip[Want a pre-built image?]

The following steps get you to set up the software yourself. We recommend that you do this. However, if you need to, we also provide an image with everything already set up. Download the [FieldGuidePiImage.v1.0.img.gz](https://drive.google.com/file/d/1ieeTv6dVV7zv5vittwb82crd_wih2DPj/view?usp=share_link). Unzip it, and use this as the image you copy to the SD card in the steps below. There is a **student** user with password **student** on this Image. Please make sure to change the password.

:::

Follow the steps below to download the recommended Raspberry Pi OS:

1. Download and install the Raspberry Pi Imager from [raspberrypi.org](https://www.raspberrypi.org/software/)
    - Select the version for your operating system.
    - Run the installer and follow the instructions.
2. Insert the micro SD card into your computer.
    - You may need a Micro SD card adapter and/or a USB SD card reader.
    - We recommend using a micro SD card with a size of at least 16 GB (32 GB preferred).
3. Open the Raspberry Pi Imager.
4. Click CHOOSE OS.

    ![Image of Raspberry Pi Imager](./src/assets/images/setup-pi/1-2-setup-pi-RaspberryPiImager.png)
    <div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

5. Select Raspberry Pi OS (64b-bit)

    ![Image Showing the Raspberry Pi Imager select OS screen](./src/assets/images/setup-pi/1-2-setup-pi-SelectOS.png)
    <div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

    :::tip
    If you are using the prebuilt image, choose **Use custom** at this point and select the **FieldGuidePiImage.v1.0.img** file you downloaded. When this finishes copying onto the SD card you are all done. Just plug it into your Pi and get going.
    :::

6. Click storage and select the micro SD card and click next.

    :::danger[Which Device should I select?]
    Make sure you select the correct storage device. Selecting the wrong device will result in the data on that device being erased.

    In the image below we are using a 32 GB micro SD card connected via a USB SD card reader:

    ![Image Showing the Raspberry Pi Imager select storage screen](./src/assets/images/setup-pi/1-2-setup-pi-SelectStorage.png)
    <div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>

    :::

7. Click `No` to the question "Would you like to apply OS customisation setting?
    - Optionally you can click edit settings to preconfigure options like the hostname, password, and Wi-Fi settings. Click yes if you want to do this.
8. Click `Yes` to the question Are you sure you want to continue?
    - **WARNING**: This will erase all data on the selected storage device.
9. Wait until the Raspberry Pi Imager has downloaded, written and verified the image on micro SD card. (This may take a while)
10. Click continue and remove the micro SD card from your computer.

    ![Image showing the Raspberry Pi Imager has completed writing to the SD card](./src/assets/images/setup-pi/1-2-setup-pi-Complete.png)
    <div class="caption">Image not subject to The Programmer's Field Guide <a href="https://creativecommons.org/licenses/by-nc-nd/4.0/">CC BY-NC-ND 4.0 License</a></div>