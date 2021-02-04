using Apple_True_Tone_Recovery.Properties;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Globalization;
using System.IO.Ports;
using System.Windows.Forms;

/**
 * Apple True Tone Recovery
 * 
 * Приложение формирует и отправляет в serial port пакет из байт серийного номера mtSN (Cover Board Number)
 * 
 * Copyright (C) 2020. v1.0 / Скляр Роман S-LAB
 * YouTube https://www.youtube.com/channel/UCbkE52YKRphgkvQtdwzQbZQ
 * BUILD IN Microsoft Visual Studio Professional 2019 v16.6.2
 * .NET framework 4.6
 * 
*/

namespace Apple_True_Tone_Recovery
{
    public partial class TrueToneRecovery : MetroForm
    {
        public TrueToneRecovery()
        {
            InitializeComponent();
            //Настройка порта
            PortPreparation();
            //Загрузка настроек
            ElemetsDefaultValue();
        }

        //Подготовка и автовыбор порта в списке
        private void PortPreparation()
        {
            //Заполнение массива найденными портами
            string[] ports = SerialPort.GetPortNames();
            //Очистка и заполнение списка
            cbPort.Items.Clear();
            cbPort.Items.AddRange(ports);
            //Если есть хоть один порт - выбрать его, иначе пустое поле
            cbPort.SelectedIndex = (ports.Length != 0) ? 0 : -1;
            //Доступность кнопки
            ButtonCheck();
        }

        //Проверка кнопки
        private void ButtonCheck()
        {
            //Если список портов пуст или символов меньше
            if (cbPort.Text == string.Empty ||
                tbCoverBoardSN.Text.Length < Convert.ToInt32(Resources.LIMIT_COVER_BOARD))
            {
                btnWrite.Enabled = false;
            }
            else
            {
                btnWrite.Enabled = true;
            }
        }

        //Применение основных настроек для программы
        private void ElemetsDefaultValue()
        {
            //Добавление моделей аппаратов
            cbModelType.Items.AddRange(new object[] {
            Resources.TEXT_8_8P,
            Resources.TEXT_XR,
            Resources.TEXT_X_XS_XSM});
            //Установка последнего значения COVER BOARD
            tbCoverBoardSN.Text = Settings.Default.LAST_VALUE;
            //Установить ограничение на количетсво символов COVER BOARD
            tbCoverBoardSN.MaxLength = Convert.ToInt32(Resources.LIMIT_COVER_BOARD);
            //Вывести число символов в поле для COVER BOARD
            lblNumCBSN.Text = string.Format(Resources.FORMAT_LABLE + Resources.LIMIT_COVER_BOARD, tbCoverBoardSN.Text.Length.ToString(CultureInfo.InvariantCulture));
            //Выбор последней модели выбранной пользователем
            cbModelType.Text = Settings.Default.MODEL_TYPE;
            //Установка скорости связи
            spLCD.BaudRate = Settings.Default.SERIAL_BAUDRATE;
            //Установка значка приложения
            Icon = Resources.TrueToneRecovery;
        }

        //Сохранение изменений
        private void SaveChanges()
        {
            //Переписать новое значение серийника COVER BOARD
            Settings.Default.LAST_VALUE = tbCoverBoardSN.Text;
            //Переписать новое значение выбранной модели
            Settings.Default.MODEL_TYPE = cbModelType.Text;
            //Сохранить новые настройки
            Settings.Default.Save();
        }

        //Формирование пакета данных для передачи в плату
        private string DataPrepare()
        {
            string data = tbCoverBoardSN.Text;

            if (cbModelType.Text == Resources.TEXT_8_8P)
            {
                data += Settings.Default.KEY_8_8P; //xxxxxxxxxxxxxxxxx+yyyyyyyyyyyyyyyyyyyyyyyyyyA
            }
            else if (cbModelType.Text == Resources.TEXT_XR)
            {
                data += Settings.Default.KEY_XR; //xxxxxxxxxxxxxxxxx+yyyyyyyyyyyyyyyyyyyyyyyyyyB
            }
            else if (cbModelType.Text == Resources.TEXT_X_XS_XSM)
            {
                data += Settings.Default.KEY_X_XS_XSM; //xxxxxxxxxxxxxxxxx+yyyyyyyyyyyyyyyyyyyyyyyyyyC
            }

            return data;
        }

        //Перед закрытием сохранить поля сериника и модели
        private void TrueToneRecovery_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChanges();
        }

        //Обновление списка портов кликом на список
        private void cbPort_MouseClick(object sender, MouseEventArgs e)
        {
            PortPreparation();
        }

        //Изменение полея серийника COVER BOARD
        private void tbCoverBoardSN_TextChanged(object sender, EventArgs e)
        {
            //Вывести число символов в поле COVER BOARD
            lblNumCBSN.Text = string.Format(Resources.FORMAT_LABLE + Resources.LIMIT_COVER_BOARD, tbCoverBoardSN.Text.Length.ToString(CultureInfo.InvariantCulture));
            ButtonCheck();
        }

        //Запись серийника в контроллер дисплея
        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //Выбор порта
                spLCD.PortName = Convert.ToString(cbPort.Text);
                //Открыть соединение
                spLCD.Open();
                //Отправка данных
                spLCD.Write(DataPrepare());
                spLCD.Close();
            }
            catch
            {
                spLCD.Close();
                //Сообщение об ошибке связи
                MetroMessageBox.Show(this,
                    Messages.ERROR_RELATION,
                    Messages.ERROR,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
