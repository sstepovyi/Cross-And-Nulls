namespace cross1ndnulls
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GameArea = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lplayer2sc = new System.Windows.Forms.Label();
            this.lplayer1sc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).BeginInit();
            this.SuspendLayout();
            // 
            // GameArea
            // 
            this.GameArea.AllowUserToAddRows = false;
            this.GameArea.AllowUserToDeleteRows = false;
            this.GameArea.AllowUserToResizeColumns = false;
            this.GameArea.AllowUserToResizeRows = false;
            this.GameArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GameArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GameArea.ColumnHeadersVisible = false;
            this.GameArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.GameArea.Location = new System.Drawing.Point(80, 69);
            this.GameArea.MultiSelect = false;
            this.GameArea.Name = "GameArea";
            this.GameArea.ReadOnly = true;
            this.GameArea.RowHeadersVisible = false;
            this.GameArea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GameArea.RowTemplate.Height = 80;
            this.GameArea.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GameArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GameArea.ShowCellErrors = false;
            this.GameArea.ShowCellToolTips = false;
            this.GameArea.ShowEditingIcon = false;
            this.GameArea.ShowRowErrors = false;
            this.GameArea.Size = new System.Drawing.Size(245, 244);
            this.GameArea.TabIndex = 0;
            this.GameArea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GameArea_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(331, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Computer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Player";
            // 
            // lplayer2sc
            // 
            this.lplayer2sc.AutoSize = true;
            this.lplayer2sc.BackColor = System.Drawing.Color.Transparent;
            this.lplayer2sc.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lplayer2sc.ForeColor = System.Drawing.Color.Green;
            this.lplayer2sc.Location = new System.Drawing.Point(361, 114);
            this.lplayer2sc.Name = "lplayer2sc";
            this.lplayer2sc.Size = new System.Drawing.Size(44, 45);
            this.lplayer2sc.TabIndex = 5;
            this.lplayer2sc.Text = "0";
            // 
            // lplayer1sc
            // 
            this.lplayer1sc.AutoSize = true;
            this.lplayer1sc.BackColor = System.Drawing.Color.Transparent;
            this.lplayer1sc.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lplayer1sc.ForeColor = System.Drawing.Color.Green;
            this.lplayer1sc.Location = new System.Drawing.Point(12, 114);
            this.lplayer1sc.Name = "lplayer1sc";
            this.lplayer1sc.Size = new System.Drawing.Size(44, 45);
            this.lplayer1sc.TabIndex = 6;
            this.lplayer1sc.Text = "0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cross1ndnulls.Properties.Resources.bcgrnd;
            this.ClientSize = new System.Drawing.Size(436, 326);
            this.Controls.Add(this.lplayer1sc);
            this.Controls.Add(this.lplayer2sc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Cross And Nulls";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView GameArea;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lplayer2sc;
        private System.Windows.Forms.Label lplayer1sc;
    }
}

