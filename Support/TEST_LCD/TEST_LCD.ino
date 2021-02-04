/**
 * mode: 1 - скан 2 - чтение 3 - запись
 */

#include <Wire.h>
#define DEV_ADDR 0x51 //адрес микросхемы на шине I2C
#define EMPTY_BYTE 0xFF //байт-пустышка (может быть любым)
#define START_BYTE 14900 //начальный адрес памяти 8/8p-14903 xr-15933:16128 x/xs/xsmax-4620:9068:15660
#define END_BYTE 14950 //конечный адрес памяти 8/8p-14946 xr-15976:16171 x/xs/xsmax-4663:9111:15703
#define IIC_CLOCK 100000 //частота шины I2C
#define SERIAL_BAUDRATE 115200 //скорость связи по Serial

void Scanner() {
  byte err, addr;
  for (addr = 8; addr < 127; addr++ ) {
    Wire.beginTransmission(addr);
    err = Wire.endTransmission();
    if (err == 0) {
      Serial.print("found address 0x");
      if (addr < 16)
        Serial.print("0");
        Serial.print(addr, HEX);
        Serial.print("\n");
      }
    }
}

void Read_byte(uint8_t addr_eeprom, uint16_t addr) {
  char result;
  Wire.beginTransmission(addr_eeprom);
  Wire.write((int)(addr >> 8));
  Wire.write((int)(addr & 0xFF));
  Wire.endTransmission();
  Wire.requestFrom(addr_eeprom, 1);
  delay(5);
  if(Wire.available()){
    result = Wire.read();
    Serial.print(result);
  }
}

void Write_byte(uint8_t addr_eeprom, uint16_t addr, uint8_t data) {
  Wire.beginTransmission(addr_eeprom);
  Wire.write((int)(addr >> 8));
  Wire.write((int)(addr & 0xFF));
  Wire.write(data);
  Wire.endTransmission();
}

void Read(uint16_t start_b, uint16_t end_b) {
  for(uint16_t i = start_b ; i <= end_b; i++){
    Read_byte(DEV_ADDR, i);
  }
  Serial.print("\n");
}

void Write(uint16_t start_b, uint16_t end_b) {
  for(uint16_t i = start_b ; i <= end_b; i++){
    Write_byte(DEV_ADDR, i, EMPTY_BYTE);
    delay(5);
  }
  Serial.println("cleaning finished");
}

void setup() {
  Serial.begin(SERIAL_BAUDRATE);
  Wire.begin();
  Wire.setClock(IIC_CLOCK);
}

void loop() {
  if(Serial.available() > 0) {
    uint8_t mode = Serial.read() - '0';
    switch(mode) {
    case 1:
      Scanner();
      break;
    case 2:
      Read(START_BYTE, END_BYTE);
      break;
    case 3:
      Write(START_BYTE, END_BYTE);
      break;
    default:
      Serial.println("error command");
      Serial.println("1-scan 2-read 3-write");
    }
  }
}
