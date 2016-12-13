#include <OneWire.h>
#include <DallasTemperature.h>

// Data wire is plugged into pin 7 on the Arduino
#define ONE_WIRE_BUS 7

// Setup a oneWire instance to communicate with ANY OneWire devices 
OneWire oneWire(ONE_WIRE_BUS);

// Set oneWire reference to Dallas Temperature sensor. 
DallasTemperature sensors(&oneWire);

void setup(void)
{
Serial.begin(9600);
sensors.begin();
pinMode(A0,INPUT);
}
void loop(void)
{

  


int swiatlo = analogRead(A0);


Serial.println(swiatlo);

char connection = Serial.read();

if(connection == '1'){
sensors.requestTemperatures();
Serial.println(sensors.getTempCByIndex(0)); // first founded sensor have Index 0
connection = '0';
}
delay(1000);
}
