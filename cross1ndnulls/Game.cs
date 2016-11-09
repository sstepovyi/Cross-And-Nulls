using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace cross1ndnulls
{   
    public partial class Game : Form
    {
        [BrowsableAttribute(false)]
        public override Image BackgroundImage { get; set; }
        Player human = new Player();
        Player ai = new Player();

        public void PrepareGrid()
        {
            GameArea.Rows.Clear();
            GameArea.DefaultCellStyle.SelectionBackColor = Color.White;
            GameArea.RowCount = 3;
            foreach (var column in GameArea.Columns)
            {
                if (column is DataGridViewImageColumn)
                    (column as DataGridViewImageColumn).DefaultCellStyle.NullValue = null;
            }         

        }
        public void PreparePlayers()
        {           
            human.image = new Bitmap(Properties.Resources.cross);
            ai.image = new Bitmap(Properties.Resources._null);
            human.score = 0;
            ai.score = 0;
            human.Name = "Player";
            ai.Name = "Computer";
        }

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            PrepareGrid();
            PreparePlayers();
        }

        private void GameArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)
            GameArea.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value == null)
            {
                cell.Value = human.image;
                    
            if ((human.CheckForWin(GameArea) == true) || (human.CheckForparitet(GameArea) == true))
                {
                    PrepareGrid();
                }
                else
                {
                    ai.Turn(GameArea);
                    if (ai.CheckForWin(GameArea) == true)
                    {                   
                        PrepareGrid();
                    }
                }
            }
        }
    }
}
