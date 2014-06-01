
//Form1.cs - класс окна приложения.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriticalPathBranch2
{   public enum Mode {Simple, Sigma }
    
    public partial class Form1 : Form
    {

        CPM CriticalPathFinder;
        Mode ProgramMode;
        DataTable InputData;
        private double Sigma2;
       // private double TotalTime;
        public Form1()//Конструктор
        {
       
            SelectModeForm SMF = new SelectModeForm();
            SMF.ShowDialog();

            ProgramMode=SMF.M;
            InitializeComponent();//Инициализация компонентов: Фукнкция, созанная IDE
            //Рабочая ссылка на таблицу исходных данных... 
            switch (ProgramMode)
            {
                case Mode.Simple :
                    InputData =     new DataSet1.WorkList1DataTable(true);
                    dataGridView1.Columns["a"].Visible = false;
                    dataGridView1.Columns["m"].Visible = false;
                    dataGridView1.Columns["b"].Visible = false;
                    dataGridView1.Columns["Dispercy"].Visible = false;
                    break;
                case Mode.Sigma :
                    InputData = new DataSet1.WorkListDataTable(true);
                    break;
          }
            dataGridView1.DataSource = InputData;
            CriticalPathFinder = new CPM(InputData);
         }
        
        //Обработчик для Большой Красной кнопки вызывает функции
        // для 1-го и 2-го проходов
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            
                CriticalPathFinder.execute();
                textBox4.Text= CriticalPathFinder.GetTotalTime().ToString();
                
                if (ProgramMode == Mode.Sigma)
                {
                    //Вычисление Суммарной дисперсии на критическом пути
                    DataRow[] CriticalPath = InputData.Select("R < 0.00001", "EF DESC");
                    Sigma2 = 0;
                    foreach (DataSet1.WorkListRow Curr in CriticalPath)
                    { Sigma2 += Curr.Dispercy; }
                    textBox1.Text = Sigma2.ToString();
                    textBox5.Text = (Math.Sqrt(Sigma2)).ToString();
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); };
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (CriticalPathFinder.GetTotalTime() == 0 || Sigma2==0) return;
           double t0;
            if(Double.TryParse(textBox2.Text, out t0))
            {
                double z = (t0 - CriticalPathFinder.GetTotalTime()) / Math.Sqrt(Sigma2);
           
            double P=0.5+Meta.Numerics.Functions.AdvancedMath.Erf(z / Math.Sqrt(2))/2;
            textBox3.Text = P.ToString("F4");
            }
        }


    }
}
