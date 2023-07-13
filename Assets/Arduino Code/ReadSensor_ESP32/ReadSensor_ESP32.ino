/*
 * Code based on sample script from the Uduino Extension.
 * Adapted for the project's use case by Florian Beck.
 */

#include<Uduino.h>
Uduino uduino("Arduino"); // Declare and name your object
int AN_In1 = 34; // GPIO 34 is Now AN Input 1

void setup()
{
  Serial.begin(115200);
  uduino.addCommand("readSensors", GetSensorValues); // Link your sensor reading (called "mySensor") to a function
}

void GetSensorValues() {
  uduino.println(analogRead(AN_In1));
  // uduino.println(analogRead(A1));
}

void loop()
{
  uduino.update();       //!\ This part is mandatory
  delay(15);
}
