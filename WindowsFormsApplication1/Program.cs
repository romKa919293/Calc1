using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
class MyButtonClass : Form
{
private Button mrButton;
// Метод-конструктор
public MyButtonClass()
{
mrButton = new Button();
mrButton.Text = 'Нажми меня';
mrButton.Click += new System.EventHandler(MyButtonClickEventHandler);
this.Controls.Add(mrButton);
}
// Основной метод
static void Main()
{
Application.Run(new MyButtonClass());
}
// Метод-обработчик событий
void MyButtonClickEventHandler(object sender, EventArgs e)
{
mrButton.Text = “Вы нажали меня!”;
}
}