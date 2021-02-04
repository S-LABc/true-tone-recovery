#ifndef APPLE_TRUE_TONE_RECOVERY_H
#define APPLE_TRUE_TONE_RECOVERY_H

/**
 * Коды команд управления 
 * 
 * Код - Символ - Описание
 * 65  - "A"    - Для iPhone 8/8P
 * 66  - "B"    - Для iPhone Xr
 * 67  - "C"    - Для iPhone X/Xs/XsMax
**/
#define COMMAND_IP_8_8P 65
#define COMMAND_IP_XR 66
#define COMMAND_IP_X_XS_XSMAX 67

//Адрес устройства на линии I2C
#define DEVICE_ADDRESS 0x51

//Скорость обмена данными по I2C
#define IIC_CLOCK    100000

//Скорость обмена данными по Serial
#define SERIAL_BAUDRATE    115200

//Длинна пакета принимаемых данных (Байт)
#define DATA_LENGTH 45 //(44+1)

//Начальные адреса ячеек (dec)
#define MTSN_8_8P_FIRST_BYTE 14903
#define MTSN_XR_FIRST_BYTE_1 15933
#define MTSN_XR_FIRST_BYTE_2 16128
#define MTSN_X_XS_XSMAX_FIRST_BYTE_1 4620
#define MTSN_X_XS_XSMAX_FIRST_BYTE_2 9068
#define MTSN_X_XS_XSMAX_FIRST_BYTE_3 15660

//Массив принятых байт из UART
byte serial_input[DATA_LENGTH] = "";

//Массивы с адресами ячеек памяти
uint16_t mtsn_8_8p[DATA_LENGTH - 1];
uint16_t mtsn_xr[DATA_LENGTH - 1];
uint16_t mtsn_xr_2[DATA_LENGTH - 1];
uint16_t mtsn_x_xs_xsmax[DATA_LENGTH - 1];
uint16_t mtsn_x_xs_xsmax_2[DATA_LENGTH - 1];
uint16_t mtsn_x_xs_xsmax_3[DATA_LENGTH - 1];

#endif
