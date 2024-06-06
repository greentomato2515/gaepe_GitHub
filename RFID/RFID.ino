#include <SPI.h>
#include <MFRC522.h>

#define RST_PIN 9
#define SS_PIN 10

MFRC522 mfrc522(SS_PIN, RST_PIN);
String switchState = "switch";
bool previousButtonState = digitalRead(2);
String heavy = "heavy";
int current_heavy;
int before_heavy;

void setup() {
  Serial.begin(9600);
  while (!Serial);
  SPI.begin();
  mfrc522.PCD_Init();
  delay(4);
  mfrc522.PCD_DumpVersionToSerial();
  Serial.println(F("Scan PICC to see UID, SAK, type, and data blocks..."));
  pinMode(2, INPUT_PULLUP);
  current_heavy = analogRead(0);
  before_heavy = current_heavy;
}

void loop() {
  bool currentButtonState = digitalRead(2);
  current_heavy = analogRead(0);
  if (current_heavy - before_heavy >= 150) {
    Serial.println(heavy);
  }
  before_heavy = current_heavy;

  if (previousButtonState != currentButtonState) {
    Serial.print(switchState);
    Serial.println();
  }

  previousButtonState = currentButtonState;

  if (!mfrc522.PICC_IsNewCardPresent()) {
    return;
  }

  if (!mfrc522.PICC_ReadCardSerial()) {
    return;
  }

  mfrc522.PICC_DumpToSerial(&(mfrc522.uid));
}
