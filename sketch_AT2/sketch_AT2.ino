#include <Adafruit_Sensor.h>

#include <DHT.h>
#include <DHT_U.h>


const int sensorLM35 = A2; //The LM35 sensor is connected to A2 of the Arduino
int DHT11Pin = 4; //The DHT11 sensor is connected pin 4 of the Arduino
int buzzerPin = 5; //The buzzer is connected pin 5 of the Arduino
DHT dht(DHT11Pin, DHT11); //declare DHT sensor
double outsidetemp; // declare outsidetemp 
double insidetemp; // declare insidetemp 
double humidity; // declare humidity
int RGBRedPin = 9; //The red RGB is connected pin 9 of the Arduino.
int RGBGreenPin = 10; //The green RGB is connected pin 10 of the Arduino.
int RGBBluePin = 11; //The blue RGB is connected pin 11 of the Arduino.
int redLED = 12; //The red LED is connected pin 12 of the Arduino.
int blueLED = 13; //The blue LED is connected pin 13 of the Arduino.
int rotationPin = A0; //The rotation sensor is plugged into pin A0 of the Arduino.
int lightPin = A1;//The light sensor is plugged into pin A0 of the Arduino.

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600); //Serial monitor port
  pinMode(sensorLM35, INPUT); // Setup LM35 sensor as input pin for reading data
  dht.begin();
  pinMode(RGBRedPin, OUTPUT); //Setup red RGB LED as an output pin.
  pinMode(RGBGreenPin, OUTPUT); //Setup green RGB pin as an output pin.
  pinMode(RGBBluePin, OUTPUT); //Setup blue RGB pin as an output pin.
  pinMode(redLED, OUTPUT); //Setup red LED pin as an output pin.
  pinMode(blueLED, OUTPUT); //Setup blue LED pin as an output pin.
}

void loop() {
  // put your main code here, to run repeatedly:

  //QUESTION 1 & 2
  outsidetemp = analogRead(sensorLM35); //read temperature data from LM35
  outsidetemp = (outsidetemp * 500) / 1023; // convert it into celsius format
  insidetemp = dht.readTemperature(); //read temperature data from dht sensor
  humidity = dht.readHumidity(); //read humidity data data from dht sensor
  Serial.print(outsidetemp);
  Serial.print(',');
  Serial.print(insidetemp);
  Serial.print(',');
  Serial.println(humidity);
  delay(50);


  //QUESTION 6
  int tonee = false;
  int tempmax = dht.readTemperature(); // declare max temperature 
  switch (tempmax) {
    case 25: tone(buzzerPin, 1000, 50); break; //if 25 degree then buzzer
      delay(1000);
    case 26: tone(buzzerPin, 3000, 100); break;//if 26 degree then buzzer sound higher
  }

  //QUESTION 7
  int val = Serial.parseInt(); //The Arduino sketch uses a Serial.parseInt method to read the string data from C# and convert into an Integer.
//this code is event driven and requires the user to click the
//button before any data is sent. The code sends a text values of 101,102,103, 200, 201,202 or 300,301 to the
//Arduino which is read and converted into and integer for the Arduino Switch/Case statement.
  switch (val) { 
    case 101: analogWrite(RGBGreenPin, HIGH);
      analogWrite(RGBRedPin, LOW);
      analogWrite(RGBBluePin, LOW);
      break;
    case 102: analogWrite(RGBRedPin, HIGH);
      analogWrite(RGBBluePin, LOW);
      analogWrite(RGBGreenPin, LOW);
      break;
    case 103: analogWrite(RGBBluePin, HIGH);
      analogWrite(RGBRedPin, LOW);
      analogWrite(RGBGreenPin, LOW);
      break;
    case 200: analogWrite(RGBGreenPin, LOW); break;
    case 201: analogWrite(RGBRedPin, LOW); break;
    case 202: analogWrite(RGBBluePin, LOW); break;
    // Question 3
    case 300: digitalWrite(redLED, HIGH); break;
    case 301: digitalWrite(redLED, LOW); break;

  } // end of switch

  //QUESTION 4 & 5
  if (analogRead(lightPin) < 500) {//read data from light sensor if greater than 500(bright)
    digitalWrite(blueLED, HIGH);
    delay(100);
  }
  else {
    digitalWrite(blueLED, LOW);
    delay(500);
  }
}
