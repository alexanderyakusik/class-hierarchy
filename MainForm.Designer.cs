namespace graphics_editor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ShapesListBox = new System.Windows.Forms.ListBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CircleRadioButton = new System.Windows.Forms.RadioButton();
            this.EllipseRadioButton = new System.Windows.Forms.RadioButton();
            this.SquareRadioButton = new System.Windows.Forms.RadioButton();
            this.RectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.LineRadioButton = new System.Windows.Forms.RadioButton();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.ShapeBorderColorLabel = new System.Windows.Forms.Label();
            this.ShapeBorderWidthLabel = new System.Windows.Forms.Label();
            this.ShapeBorderColorComboBox = new System.Windows.Forms.ComboBox();
            this.ShapeBorderWidthComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonClearSelection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(126, 67);
            this.PictureBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(750, 485);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(984, 24);
            this.MenuStrip.TabIndex = 2;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.LoadToolStripMenuItem.Text = "Открыть";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // FolderBrowserDialog
            // 
            this.FolderBrowserDialog.SelectedPath = "C:\\Users\\user\\Documents\\Graphics Editor";
            // 
            // ShapesListBox
            // 
            this.ShapesListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShapesListBox.FormattingEnabled = true;
            this.ShapesListBox.Location = new System.Drawing.Point(876, 67);
            this.ShapesListBox.Name = "ShapesListBox";
            this.ShapesListBox.Size = new System.Drawing.Size(108, 485);
            this.ShapesListBox.TabIndex = 3;
            this.ShapesListBox.SelectedValueChanged += new System.EventHandler(this.ShapesListBox_SelectedValueChanged);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.CircleRadioButton);
            this.MainPanel.Controls.Add(this.EllipseRadioButton);
            this.MainPanel.Controls.Add(this.SquareRadioButton);
            this.MainPanel.Controls.Add(this.RectangleRadioButton);
            this.MainPanel.Controls.Add(this.LineRadioButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanel.Location = new System.Drawing.Point(0, 67);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(126, 485);
            this.MainPanel.TabIndex = 4;
            // 
            // CircleRadioButton
            // 
            this.CircleRadioButton.AutoSize = true;
            this.CircleRadioButton.Location = new System.Drawing.Point(13, 110);
            this.CircleRadioButton.Name = "CircleRadioButton";
            this.CircleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.CircleRadioButton.TabIndex = 4;
            this.CircleRadioButton.TabStop = true;
            this.CircleRadioButton.Text = "Круг";
            this.CircleRadioButton.UseVisualStyleBackColor = true;
            this.CircleRadioButton.CheckedChanged += new System.EventHandler(this.CircleRadioButton_CheckedChanged);
            // 
            // EllipseRadioButton
            // 
            this.EllipseRadioButton.AutoSize = true;
            this.EllipseRadioButton.Location = new System.Drawing.Point(13, 86);
            this.EllipseRadioButton.Name = "EllipseRadioButton";
            this.EllipseRadioButton.Size = new System.Drawing.Size(62, 17);
            this.EllipseRadioButton.TabIndex = 3;
            this.EllipseRadioButton.TabStop = true;
            this.EllipseRadioButton.Text = "Эллипс";
            this.EllipseRadioButton.UseVisualStyleBackColor = true;
            this.EllipseRadioButton.CheckedChanged += new System.EventHandler(this.EllipseRadioButton_CheckedChanged);
            // 
            // SquareRadioButton
            // 
            this.SquareRadioButton.AutoSize = true;
            this.SquareRadioButton.Location = new System.Drawing.Point(13, 62);
            this.SquareRadioButton.Name = "SquareRadioButton";
            this.SquareRadioButton.Size = new System.Drawing.Size(67, 17);
            this.SquareRadioButton.TabIndex = 2;
            this.SquareRadioButton.TabStop = true;
            this.SquareRadioButton.Text = "Квадрат";
            this.SquareRadioButton.UseVisualStyleBackColor = true;
            this.SquareRadioButton.CheckedChanged += new System.EventHandler(this.SquareRadioButton_CheckedChanged);
            // 
            // RectangleRadioButton
            // 
            this.RectangleRadioButton.AutoSize = true;
            this.RectangleRadioButton.Location = new System.Drawing.Point(13, 38);
            this.RectangleRadioButton.Name = "RectangleRadioButton";
            this.RectangleRadioButton.Size = new System.Drawing.Size(105, 17);
            this.RectangleRadioButton.TabIndex = 1;
            this.RectangleRadioButton.TabStop = true;
            this.RectangleRadioButton.Text = "Прямоугольник";
            this.RectangleRadioButton.UseVisualStyleBackColor = true;
            this.RectangleRadioButton.CheckedChanged += new System.EventHandler(this.RectangleRadioButton_CheckedChanged);
            // 
            // LineRadioButton
            // 
            this.LineRadioButton.AutoSize = true;
            this.LineRadioButton.Location = new System.Drawing.Point(13, 14);
            this.LineRadioButton.Name = "LineRadioButton";
            this.LineRadioButton.Size = new System.Drawing.Size(57, 17);
            this.LineRadioButton.TabIndex = 0;
            this.LineRadioButton.TabStop = true;
            this.LineRadioButton.Text = "Линия";
            this.LineRadioButton.UseVisualStyleBackColor = true;
            this.LineRadioButton.CheckedChanged += new System.EventHandler(this.LineRadioButton_CheckedChanged);
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolsPanel.Controls.Add(this.ShapeBorderColorLabel);
            this.ToolsPanel.Controls.Add(this.ShapeBorderWidthLabel);
            this.ToolsPanel.Controls.Add(this.ShapeBorderColorComboBox);
            this.ToolsPanel.Controls.Add(this.ShapeBorderWidthComboBox);
            this.ToolsPanel.Controls.Add(this.ButtonClearSelection);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsPanel.Location = new System.Drawing.Point(0, 24);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(984, 43);
            this.ToolsPanel.TabIndex = 5;
            // 
            // ShapeBorderColorLabel
            // 
            this.ShapeBorderColorLabel.AutoSize = true;
            this.ShapeBorderColorLabel.Location = new System.Drawing.Point(432, 15);
            this.ShapeBorderColorLabel.Name = "ShapeBorderColorLabel";
            this.ShapeBorderColorLabel.Size = new System.Drawing.Size(35, 13);
            this.ShapeBorderColorLabel.TabIndex = 4;
            this.ShapeBorderColorLabel.Text = "Цвет:";
            // 
            // ShapeBorderWidthLabel
            // 
            this.ShapeBorderWidthLabel.AutoSize = true;
            this.ShapeBorderWidthLabel.Location = new System.Drawing.Point(141, 15);
            this.ShapeBorderWidthLabel.Name = "ShapeBorderWidthLabel";
            this.ShapeBorderWidthLabel.Size = new System.Drawing.Size(95, 13);
            this.ShapeBorderWidthLabel.TabIndex = 3;
            this.ShapeBorderWidthLabel.Text = "Ширина границы:";
            // 
            // ShapeBorderColorComboBox
            // 
            this.ShapeBorderColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShapeBorderColorComboBox.FormattingEnabled = true;
            this.ShapeBorderColorComboBox.Location = new System.Drawing.Point(473, 12);
            this.ShapeBorderColorComboBox.Name = "ShapeBorderColorComboBox";
            this.ShapeBorderColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.ShapeBorderColorComboBox.TabIndex = 2;
            this.ShapeBorderColorComboBox.SelectedIndexChanged += new System.EventHandler(this.ShapeBorderColorComboBox_SelectedIndexChanged);
            // 
            // ShapeBorderWidthComboBox
            // 
            this.ShapeBorderWidthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShapeBorderWidthComboBox.FormattingEnabled = true;
            this.ShapeBorderWidthComboBox.Location = new System.Drawing.Point(242, 12);
            this.ShapeBorderWidthComboBox.Name = "ShapeBorderWidthComboBox";
            this.ShapeBorderWidthComboBox.Size = new System.Drawing.Size(121, 21);
            this.ShapeBorderWidthComboBox.TabIndex = 1;
            this.ShapeBorderWidthComboBox.SelectedIndexChanged += new System.EventHandler(this.ShapeBorderWidthComboBox_SelectedIndexChanged);
            // 
            // ButtonClearSelection
            // 
            this.ButtonClearSelection.Location = new System.Drawing.Point(875, 13);
            this.ButtonClearSelection.Name = "ButtonClearSelection";
            this.ButtonClearSelection.Size = new System.Drawing.Size(104, 23);
            this.ButtonClearSelection.TabIndex = 0;
            this.ButtonClearSelection.Text = "Снять выделение";
            this.ButtonClearSelection.UseVisualStyleBackColor = true;
            this.ButtonClearSelection.Click += new System.EventHandler(this.ButtonClearSelection_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 552);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ShapesListBox);
            this.Controls.Add(this.ToolsPanel);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графический редактор";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ToolsPanel.ResumeLayout(false);
            this.ToolsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.ListBox ShapesListBox;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.RadioButton RectangleRadioButton;
        private System.Windows.Forms.RadioButton LineRadioButton;
        private System.Windows.Forms.RadioButton CircleRadioButton;
        private System.Windows.Forms.RadioButton EllipseRadioButton;
        private System.Windows.Forms.RadioButton SquareRadioButton;
        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.Button ButtonClearSelection;
        private System.Windows.Forms.Label ShapeBorderColorLabel;
        private System.Windows.Forms.Label ShapeBorderWidthLabel;
        private System.Windows.Forms.ComboBox ShapeBorderColorComboBox;
        private System.Windows.Forms.ComboBox ShapeBorderWidthComboBox;
    }
}

