#include <Wire.h>
#include "APPLE_TRUE_TONE_RECOVERY.h"

/**
 * Apple True Tone Recovery
 * 
 * Позволяет восстановить функцию True Tone
 * при помощи перезаписи серийного номера mtSN (Cover Board Number) 
 * Поддерживаемые модели iPhone 8/8P/X/Xr/Xs/XsMax
 * 
 * Copyright (C) 2020. v1.0 / Скляр Роман S-LAB
 * YouTube https://www.youtube.com/channel/UCbkE52YKRphgkvQtdwzQbZQ
 * COMPILED IN ARDUINO V1.8.12
 * 
*/

void setup() {
  mtsnAarrayFilling();
  Serial.begin(SERIAL_BAUDRATE);
  Wire.begin();
  Wire.setClock(IIC_CLOCK);
}

void loop() {
  if(Serial.available() == DATA_LENGTH){
    //Чтение принятых данных
    readBufer();
    //Выбор действия
    switch(serial_input[DATA_LENGTH - 1]){
      case COMMAND_IP_8_8P:
      writeArray(mtsn_8_8p);
      break;
      case COMMAND_IP_XR:
      writeArray(mtsn_xr);
      writeArray(mtsn_xr_2);
      break;
      case COMMAND_IP_X_XS_XSMAX:
      writeArray(mtsn_x_xs_xsmax);
      writeArray(mtsn_x_xs_xsmax_2);
      writeArray(mtsn_x_xs_xsmax_3);
      break;
    }
  }
}
