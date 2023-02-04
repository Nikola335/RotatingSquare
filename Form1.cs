using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotatingSquare
{
    public partial class Form1 : Form
    {
        int x = 0, y = 0; // координаты верхнего левого угла квадрата  
        int side = 100; // сторона квадрата  

        public Form1()
        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(Form1_Paint); // подписка на событие Paint  

            Timer timer = new Timer(); // Создание таймера  

            timer.Interval = 10; // Задержку  

            timer.Tick += new EventHandler(timer1_Tick); // Подписку на события Tick  

            timer.Start(); // Запуск таймера  

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 5; // Изменяются координаты x y   

            y += 5;

            Invalidate(); // Очищение PictureBox     

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;     // Graphics - "ключ"    

            g.DrawRectangle(new Pen(Color.Blue), x, y, side, side);    // DrawRectangle - "ключ"    

            g.FillRectangle(new SolidBrush(Color.Red), x, y, side, side);    // FillRectangle - "ключ"    

        }
    }
}
