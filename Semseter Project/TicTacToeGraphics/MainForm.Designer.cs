namespace TicTacToeGraphics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartNewGame = new System.Windows.Forms.Button();
            this.GoComputer = new System.Windows.Forms.Button();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gameCell8 = new TicTacToeGraphics.GameCell();
            this.gameCell7 = new TicTacToeGraphics.GameCell();
            this.gameCell6 = new TicTacToeGraphics.GameCell();
            this.gameCell5 = new TicTacToeGraphics.GameCell();
            this.gameCell4 = new TicTacToeGraphics.GameCell();
            this.gameCell3 = new TicTacToeGraphics.GameCell();
            this.gameCell2 = new TicTacToeGraphics.GameCell();
            this.gameCell1 = new TicTacToeGraphics.GameCell();
            this.gameCell = new TicTacToeGraphics.GameCell();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartNewGame
            // 
            this.StartNewGame.Location = new System.Drawing.Point(33, 56);
            this.StartNewGame.Name = "StartNewGame";
            this.StartNewGame.Size = new System.Drawing.Size(130, 49);
            this.StartNewGame.TabIndex = 0;
            this.StartNewGame.Text = "Start New Game";
            this.StartNewGame.UseVisualStyleBackColor = true;
            this.StartNewGame.Click += new System.EventHandler(this.StartNewGame_Click);
            // 
            // GoComputer
            // 
            this.GoComputer.Location = new System.Drawing.Point(33, 123);
            this.GoComputer.Name = "GoComputer";
            this.GoComputer.Size = new System.Drawing.Size(130, 47);
            this.GoComputer.TabIndex = 1;
            this.GoComputer.Text = "GO! Computer";
            this.GoComputer.UseVisualStyleBackColor = true;
            this.GoComputer.Click += new System.EventHandler(this.GoComputer_Click);
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(33, 13);
            this.PlayerName.MaxLength = 25;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(295, 23);
            this.PlayerName.TabIndex = 2;
            this.PlayerName.Text = "Kenneth Rodriguez";
            this.PlayerName.TextChanged += new System.EventHandler(this.PlayerName_TextChanged);
            this.PlayerName.Validated += new System.EventHandler(this.PlayerName_Validated);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(33, 305);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(130, 48);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit Tic Tac Toe";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.gameCell8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameCell7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameCell6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameCell5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCell4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCell3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCell2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCell1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCell, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(228, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(316, 297);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // gameCell8
            // 
            this.gameCell8.BackColor = System.Drawing.Color.Gold;
            this.gameCell8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell8.BackgroundImage")));
            this.gameCell8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell8.GameCellCol = 2;
            this.gameCell8.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell8.GameCellRow = 2;
            this.gameCell8.Location = new System.Drawing.Point(214, 201);
            this.gameCell8.Name = "gameCell8";
            this.gameCell8.Size = new System.Drawing.Size(99, 93);
            this.gameCell8.TabIndex = 0;
            this.gameCell8.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell7
            // 
            this.gameCell7.BackColor = System.Drawing.Color.Gold;
            this.gameCell7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell7.BackgroundImage")));
            this.gameCell7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell7.GameCellCol = 2;
            this.gameCell7.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell7.GameCellRow = 1;
            this.gameCell7.Location = new System.Drawing.Point(107, 201);
            this.gameCell7.Name = "gameCell7";
            this.gameCell7.Size = new System.Drawing.Size(101, 93);
            this.gameCell7.TabIndex = 0;
            this.gameCell7.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell6
            // 
            this.gameCell6.BackColor = System.Drawing.Color.Gold;
            this.gameCell6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell6.BackgroundImage")));
            this.gameCell6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell6.GameCellCol = 2;
            this.gameCell6.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell6.GameCellRow = 0;
            this.gameCell6.Location = new System.Drawing.Point(3, 201);
            this.gameCell6.Name = "gameCell6";
            this.gameCell6.Size = new System.Drawing.Size(98, 93);
            this.gameCell6.TabIndex = 0;
            this.gameCell6.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell5
            // 
            this.gameCell5.BackColor = System.Drawing.Color.Gold;
            this.gameCell5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell5.BackgroundImage")));
            this.gameCell5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell5.GameCellCol = 1;
            this.gameCell5.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell5.GameCellRow = 2;
            this.gameCell5.Location = new System.Drawing.Point(214, 101);
            this.gameCell5.Name = "gameCell5";
            this.gameCell5.Size = new System.Drawing.Size(99, 94);
            this.gameCell5.TabIndex = 0;
            this.gameCell5.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell4
            // 
            this.gameCell4.BackColor = System.Drawing.Color.Gold;
            this.gameCell4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell4.BackgroundImage")));
            this.gameCell4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell4.GameCellCol = 1;
            this.gameCell4.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell4.GameCellRow = 1;
            this.gameCell4.Location = new System.Drawing.Point(107, 101);
            this.gameCell4.Name = "gameCell4";
            this.gameCell4.Size = new System.Drawing.Size(101, 94);
            this.gameCell4.TabIndex = 0;
            this.gameCell4.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell3
            // 
            this.gameCell3.BackColor = System.Drawing.Color.Gold;
            this.gameCell3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell3.BackgroundImage")));
            this.gameCell3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell3.GameCellCol = 1;
            this.gameCell3.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell3.GameCellRow = 0;
            this.gameCell3.Location = new System.Drawing.Point(3, 101);
            this.gameCell3.Name = "gameCell3";
            this.gameCell3.Size = new System.Drawing.Size(98, 94);
            this.gameCell3.TabIndex = 0;
            this.gameCell3.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell2
            // 
            this.gameCell2.BackColor = System.Drawing.Color.Gold;
            this.gameCell2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell2.BackgroundImage")));
            this.gameCell2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell2.GameCellCol = 0;
            this.gameCell2.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell2.GameCellRow = 2;
            this.gameCell2.Location = new System.Drawing.Point(214, 3);
            this.gameCell2.Name = "gameCell2";
            this.gameCell2.Size = new System.Drawing.Size(99, 92);
            this.gameCell2.TabIndex = 0;
            this.gameCell2.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell1
            // 
            this.gameCell1.BackColor = System.Drawing.Color.Gold;
            this.gameCell1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell1.BackgroundImage")));
            this.gameCell1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell1.GameCellCol = 0;
            this.gameCell1.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell1.GameCellRow = 1;
            this.gameCell1.Location = new System.Drawing.Point(107, 3);
            this.gameCell1.Name = "gameCell1";
            this.gameCell1.Size = new System.Drawing.Size(101, 92);
            this.gameCell1.TabIndex = 0;
            this.gameCell1.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // gameCell
            // 
            this.gameCell.BackColor = System.Drawing.Color.Gold;
            this.gameCell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCell.BackgroundImage")));
            this.gameCell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCell.GameCellCol = 0;
            this.gameCell.GameCellOwner = TicTacToe_Interfaces.CellOwners.Error;
            this.gameCell.GameCellRow = 0;
            this.gameCell.Location = new System.Drawing.Point(3, 3);
            this.gameCell.Name = "gameCell";
            this.gameCell.Size = new System.Drawing.Size(98, 92);
            this.gameCell.TabIndex = 0;
            this.gameCell.CellOwnerChanged += new TicTacToeGraphics.GameCell.CellOwnerChangedHandler(this.gameCell_CellOwnerChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(580, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.GoComputer);
            this.Controls.Add(this.StartNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "TicTacToe with UserControls - Kenneth Rodriguez";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartNewGame;
        private System.Windows.Forms.Button GoComputer;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GameCell gameCell;
        private GameCell gameCell8;
        private GameCell gameCell7;
        private GameCell gameCell6;
        private GameCell gameCell5;
        private GameCell gameCell4;
        private GameCell gameCell3;
        private GameCell gameCell2;
        private GameCell gameCell1;
    }
}

