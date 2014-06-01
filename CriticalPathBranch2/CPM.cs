using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CriticalPathBranch2
{

    }
    class CPM
    {
        
        private double TotalTime;
       public double GetTotalTime() { return TotalTime; }
        private DataTable InputData;
        public CPM(DataTable Data)
        {
            InputData = Data;
            
         }

        //1-й проход. Приложение просматривает данные в DataSet построчно, 
        //сверху вниз, вычисляя ES, и занося его в DataSet.
        //Вычисление EF организовано непосредственно внутри DataSet
        public void ViewDown()
        {   
            bool hasFirst; //флаг бутет равен false при отсутствии начальной работы
            hasFirst = false;
            //Количество строк
            int WorkCount = InputData.Rows.Count;
            for (int i = 0; i < WorkCount; ++i) InputData.Rows[i]["ES"] = 0;
            //ПОЕХАЛИ ВНИЗ...
            for (int i = 0; i < WorkCount; ++i)
            {
                //Приводим тип ссылки на i-ю строку:
                // DataSet1.WorkListRow CurrentRow= (DataSet1.WorkListRow)InputData.Rows[i];
                //Извлекаем список предшествующих операций:
                string Previous;
                try
                {
                    Previous = (string)InputData.Rows[i]["Previous"];
                }
                catch (Exception e) { hasFirst = true; continue; }
                if (Previous == null) { hasFirst = true; continue; }
                if (Previous.Trim() == "") { hasFirst = true; continue; }//завершить итерацию, если предшествующих работ нет
                //Получаем массив идентификаторов 
                string[] Successors = Previous.Split(',');

                List<double> RequriedTime = new List<double>();//Для сбора моментов (EF) выполнения предшествующих работ 
                //для каждого идентификатора найти соответствующую строку...
                foreach (string Successor in Successors)
                {
                    try
                    {
                        DataRow PreviousWork = InputData.Select("ID=" + Successor)[0];
                        //...и занести в список моменты окончания работы
                        RequriedTime.Add((double)PreviousWork["EF"]);
                    }
                    catch (Exception e)
                    {
                        //MessageBox.Show();
                        throw new Exception("Ошибка входных данных в строке " + (i + 1).ToString() + ".");
                    }
                }
                //Максимальное значение предшествующих ES и будет значением ES для текущей работы
                InputData.Rows[i]["ES"] = RequriedTime.Max();
            }
            if (!hasFirst) throw new Exception("Ошибка входных данных: отсутствует начальная работа");

        }
        //2-й проход. Приложение просматривает данные в DataSet
        //снизу вверх, вычисляя LF, изанося его в DataSet.
        //Вычисление LS организовано непосредственно внутри DataSet.
        //Собственно, вызываемый для начала обработки снизу вверх метод:
        public void ViewUp()
        {
            //для последней работы, т. е.  с максимальным ранним завершением EF...
            DataRow[] RowsEFdesc = InputData.Select("", "EF DESC");
            //момент позднего завершения равен моменту раннего
            TotalTime = (double)RowsEFdesc[0]["EF"];

            foreach (DataRow row in RowsEFdesc) row["LF"] = RowsEFdesc[0]["EF"];
            // //рекурсивный поиск в ширину по "графу"
            int WorkCount = RowsEFdesc.Count();
            for (int i = 0; i < WorkCount; ++i)
            {
                string PreviousIDs;
                try
                {
                    PreviousIDs = (string)RowsEFdesc[i]["Previous"];
                }
                catch (Exception e) { continue; }
                if (PreviousIDs == null) continue; //выйти, если их нет: достигнуто начало
                if (PreviousIDs.Trim() == "") continue;
                DataRow[] PreviousWorks = InputData.Select("ID in (" + PreviousIDs + ")");
                //для каждой задать LF как LS текущей:
                foreach (DataRow PreviousWork in PreviousWorks) 
                    if ((double)PreviousWork["LF"] > (double)RowsEFdesc[i]["LS"]) 
                        PreviousWork["LF"] = (double)RowsEFdesc[i]["LS"];
            }
        }
       
        public void validate()
        {
            foreach (DataRow DR in InputData.Rows)
            {
            if ((double)DR["R"]<0)
                throw new Exception("Получилась явно какая-то ерунда. Попробуйте ввести все данные с самого начала."); 
            }
        
        }

        public void execute()
        {
            ViewDown();
            ViewUp();
            validate();
        }
    }

