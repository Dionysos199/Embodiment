/*
 * Code based on sample script from the Uduino WiFi Extension.
 * Adapted for the project's use case by Florian Beck.
 */

// Uduino settings
#include <Uduino_Wifi.h>
Uduino_Wifi uduino("Arduino"); // Declare and name your object
int AN_In1 = 34; // GPIO 34 is Now AN Input 1

void setup()
{
  Serial.begin(115200);

  // Optional function,  to add BEFORE connectWifi(...)
  uduino.setPort(4222);   // default 4222

  uduino.useSendBuffer(true); // default true
  uduino.setConnectionTries(35); // default 35
  uduino.useSerial(true); // default is true

  // mendatory function
  uduino.connectWifi("ERP6_2_4", "P6udoino");

  uduino.addCommand("readSensors", GetSensorValues); // Link your sensor reading (called "readSensors") to a function
}

void GetSensorValues() {
  uduino.println(analogRead(AN_In1));
  // uduino.println(analogRead(A1));
}

void loop()
{
  uduino.update();

  if (uduino.isConnected()) {
    uduino.delay(15);
  }
}
