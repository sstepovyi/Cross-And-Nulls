using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cross1ndnulls
{
   public  class Player
    {
        public Image image;
        public int   score;
        public string Name;

        public void Turn(DataGridView grid)
        {
            Random rnd = new Random();
            bool find  = false;
            while (find == false)
            {
                int a = rnd.Next(0, 3);
                int b = rnd.Next(0, 3);
                if (grid.Rows[a].Cells[b].Value == null)
                {
                    grid.Rows[a].Cells[b].Value = image;
                    find = true;
                }  
                else
                {
                    find = false;
                }             
            }               
        }

        public bool CheckForparitet(DataGridView grid)
        {
            int countEmpty = 0;
            for (int j = 0; j < grid.ColumnCount; j++)
            {
                for (int i = 0; i < grid.RowCount; i++)
                {
                    if (grid.Rows[i].Cells[j].Value == null)
                    {
                        countEmpty++;
                    }
                }
            }
            if (countEmpty==0)
            {
                MessageBox.Show("Tie");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckForWin(DataGridView grid)
        {       
                    // По горизонтали
                if ((grid.Rows[0].Cells[0].Value == image && grid.Rows[1].Cells[0].Value == image && grid.Rows[2].Cells[0].Value == image) ||
                    (grid.Rows[0].Cells[1].Value == image && grid.Rows[1].Cells[1].Value == image && grid.Rows[2].Cells[1].Value == image) ||
                    (grid.Rows[0].Cells[2].Value == image && grid.Rows[1].Cells[2].Value == image && grid.Rows[2].Cells[2].Value == image) ||

                    // По вертикали
                    (grid.Rows[0].Cells[0].Value == image && grid.Rows[0].Cells[1].Value == image && grid.Rows[0].Cells[2].Value == image) ||
                    (grid.Rows[1].Cells[0].Value == image && grid.Rows[1].Cells[1].Value == image && grid.Rows[1].Cells[2].Value == image) ||
                    (grid.Rows[2].Cells[0].Value == image && grid.Rows[2].Cells[1].Value == image && grid.Rows[2].Cells[2].Value == image) ||

                    // По диагонали
                    (grid.Rows[0].Cells[0].Value == image && grid.Rows[1].Cells[1].Value == image && grid.Rows[2].Cells[2].Value == image) ||
                    (grid.Rows[2].Cells[0].Value == image && grid.Rows[1].Cells[1].Value == image && grid.Rows[0].Cells[2].Value == image))
                {
                    MessageBox.Show(Name +" Win");
                    score ++;
                    return true;
                }
                return false;

        }
    }
}
