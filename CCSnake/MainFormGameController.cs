using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

[assembly: CLSCompliant(true)]

namespace CCSnake
{
    public partial class MainFormGameController : Form      // использ патерн ModelWiewController
    {
        Model model;
        View view;

        Thread threadPlayInModel;   // создание нового Потока (ссылки в стеке)

        int sizeField = 500;      // размер поля игры
        int speedGame = 10;      // скорость игры

        bool flag = false;

        public MainFormGameController()         // конструктор
        {
            InitializeComponent();          // автоматич инициализ обязат компонентов
            
            model = new Model(sizeField, speedGame, flag);
            view = new View(model);
            this.Controls.Add(view);        // добавление Пользов-го элем-а управ-ия(доп формы) на главную форму
        }           // событие при нажатии кнопок с клавы

        void MainFormGameController_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(threadPlayInModel != null)
                threadPlayInModel.Abort();

            DialogResult dr = MessageBox.Show("Вы хотите закончить игру?", "Snake", MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (dr == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true; 
        }       // событие перед закрытием глав формы (прилож)

        private void pictureBox1_KEY_for_move(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyData.ToString())
            {
                case "A":
                    {
                        model.snake.NextDirectX = -1;
                        model.snake.NextDirectY = 0;
                    }
                    break;
                case "D":
                    {
                        model.snake.NextDirectX = 1;
                        model.snake.NextDirectY = 0;
                    }
                    break;
                case "W":
                    {
                        model.snake.NextDirectX = 0;
                        model.snake.NextDirectY = -1;
                    }
                    break;
                case "S":
                    {
                        model.snake.NextDirectX = 0;
                        model.snake.NextDirectY = 1;
                    }
                    break;
                case "M":
                    {
                        if (model.SpeedGame == 10)
                        {
                            model.SpeedGame = 1;
                            break;
                        }
                        if (model.SpeedGame == 1)
                        {
                            model.SpeedGame = 20;
                            break;
                        }
                        if (model.SpeedGame == 20)
                        {
                            model.SpeedGame = 10;
                            break;
                        }
                    }
                    break;
                case "P":
                    {
                        if (!flag)
                        {
                            flag = !flag;
                            threadPlayInModel = new Thread(model.Play);
                            threadPlayInModel.Start();
                        }
                        else
                        {
                            flag = !flag;
                            threadPlayInModel.Abort();
                        }
                    }
                    break;
            }

        }

        private void pictureBox2_NewGAME(object sender, EventArgs e)            // РеСтарт
        {
            if(threadPlayInModel != null)
                threadPlayInModel.Abort();
            model.StartGame();
            flag = false;
        }

        private void pictureBox1_StartPause(object sender, EventArgs e)         // Старт/Пауза
        {
            if (!flag)
            {
                pictureBox1_KEYS.Focus();           // для фокуса кнопки (для срабатывания изменения направления движ змей)
                flag = !flag;
                threadPlayInModel = new Thread(model.Play);
                threadPlayInModel.Start();

                //view.Invalidate();
            }
            else
            {
                flag = !flag;
                threadPlayInModel.Abort();
            }
        }

        /*
 void StartPauseButton_KeyPress(object sender, KeyPressEventArgs e)
 {
     switch (e.KeyChar)
     {
         case 'A':
         case 'a':
             {
                 model.snake.NextDirectX = -1;
                 model.snake.NextDirectY = 0;
             }
             break;
         case 'D':
         case 'd':
             {
                 model.snake.NextDirectX = 1;
                 model.snake.NextDirectY = 0;
             }
             break;
         case 'W':
         case 'w':
             {
                 model.snake.NextDirectX = 0;
                 model.snake.NextDirectY = -1;
             }
             break;
         case 'S':
         case 's':                
             {
                 model.snake.NextDirectX = 0;
                 model.snake.NextDirectY = 1;
             }
             break;
         case 'M':
         case 'm':
             {
                 if (model.SpeedGame == 10)
                 {
                     model.SpeedGame = 1;
                     break;
                 }
                 if (model.SpeedGame == 1)
                 {
                     model.SpeedGame = 20;
                     break;
                 }
                 if (model.SpeedGame == 20)
                 {
                     model.SpeedGame = 10;
                     break;
                 }
             }
             break;
         case 'P':
         case 'p':
             {
                 if (!flag)
                 {
                     flag = !flag;
                     threadPlayInModel = new Thread(model.Play);
                     threadPlayInModel.Start();
                 }
                 else
                 {
                     flag = !flag;
                     threadPlayInModel.Abort();
                 }
             }
             break;
     }
 }
         
 */

        /*
        void buttonNewGame_Click(object sender, EventArgs e)
        {
            if (threadPlayInModel != null)
            {
                threadPlayInModel.Abort();
                model.StartGame();
                flag = false;
                //view.Refresh();
            }
            else
            {
                model.StartGame();
                flag = false;
            }            

        }*/

        /*
 void button1_StartPause_Click(object sender, EventArgs e)          //  обработка события кнопки Старт
 {            
     if (!flag)
     {
         flag = !flag;
         threadPlayInModel = new Thread(model.Play);
         threadPlayInModel.Start();

         //view.Invalidate();
     }
     else
     {
         flag = !flag;
         threadPlayInModel.Abort();
     }
 }*/

    }
}
