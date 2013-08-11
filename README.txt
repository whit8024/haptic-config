TO SETUP TELEOPERATION:

Run Haptic_Config.exe

Select the type of device that you will be running on the computer. 
In the Target Address field add the ip address of the other computer. For more information on obtaining this information look up the windows command 'ipconfig'. 
Check the box labeled 'Use Force Sensors' if the slave device is using labview instruments to measure forces.  
Click the apply button to save the configuration. 
Click the OK button to save the configuration and close the window.  

You should now be able to run the teleoperation simulation.  


NOTE: Please ensure that UDP ports 2212 and 2222 are open on both device computers. They are required for the data transmission in teleoperation. 
Do not connect more than one of each type of device(master or slave). This will cause communication errors. 