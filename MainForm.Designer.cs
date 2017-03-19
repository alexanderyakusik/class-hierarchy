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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonRectangle = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonSquare = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonCircle = new System.Windows.Forms.ToolStripButton();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonLine,
            this.ToolStripButtonRectangle,
            this.ToolStripButtonSquare,
            this.ToolStripButtonEllipse,
            this.ToolStripButtonCircle});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(37, 537);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "ToolStrip";
            this.ToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip_ItemClicked);
            // 
            // ToolStripButtonLine
            // 
            this.ToolStripButtonLine.CheckOnClick = true;
            this.ToolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonLine.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonLine.Image")));
            this.ToolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonLine.Name = "ToolStripButtonLine";
            this.ToolStripButtonLine.Size = new System.Drawing.Size(34, 36);
            this.ToolStripButtonLine.Text = "Инструмент «Линия»";
            this.ToolStripButtonLine.Click += new System.EventHandler(this.ToolStripButtonLine_Click);
            // 
            // ToolStripButtonRectangle
            // 
            this.ToolStripButtonRectangle.CheckOnClick = true;
            this.ToolStripButtonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonRectangle.Image")));
            this.ToolStripButtonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonRectangle.Name = "ToolStripButtonRectangle";
            this.ToolStripButtonRectangle.Size = new System.Drawing.Size(34, 36);
            this.ToolStripButtonRectangle.Text = "Инструмент «Прямоугольник»";
            this.ToolStripButtonRectangle.ToolTipText = "Инструмент «Прямоугольник»";
            this.ToolStripButtonRectangle.Click += new System.EventHandler(this.ToolStripButtonRectangle_Click);
            // 
            // ToolStripButtonSquare
            // 
            this.ToolStripButtonSquare.CheckOnClick = true;
            this.ToolStripButtonSquare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonSquare.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonSquare.Image")));
            this.ToolStripButtonSquare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonSquare.Name = "ToolStripButtonSquare";
            this.ToolStripButtonSquare.Size = new System.Drawing.Size(34, 36);
            this.ToolStripButtonSquare.Text = "Инструмент «Квадрат»";
            this.ToolStripButtonSquare.ToolTipText = "Инструмент «Квадрат»";
            this.ToolStripButtonSquare.Click += new System.EventHandler(this.ToolStripButtonSquare_Click);
            // 
            // ToolStripButtonEllipse
            // 
            this.ToolStripButtonEllipse.CheckOnClick = true;
            this.ToolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonEllipse.Image")));
            this.ToolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonEllipse.Name = "ToolStripButtonEllipse";
            this.ToolStripButtonEllipse.Size = new System.Drawing.Size(34, 36);
            this.ToolStripButtonEllipse.Text = "Инструмент «Эллипс»";
            this.ToolStripButtonEllipse.Click += new System.EventHandler(this.ToolStripButtonEllipse_Click);
            // 
            // ToolStripButtonCircle
            // 
            this.ToolStripButtonCircle.CheckOnClick = true;
            this.ToolStripButtonCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonCircle.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonCircle.Image")));
            this.ToolStripButtonCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonCircle.Name = "ToolStripButtonCircle";
            this.ToolStripButtonCircle.Size = new System.Drawing.Size(34, 36);
            this.ToolStripButtonCircle.Text = "Инструмент «Круг»";
            this.ToolStripButtonCircle.ToolTipText = "Инструмент «Круг»";
            this.ToolStripButtonCircle.Click += new System.EventHandler(this.ToolStripButtonCircle_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox.Location = new System.Drawing.Point(40, 0);
            this.PictureBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(744, 561);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MenuStrip.TabIndex = 2;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.PictureBox);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графический редактор";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton ToolStripButtonLine;
        private System.Windows.Forms.ToolStripButton ToolStripButtonRectangle;
        private System.Windows.Forms.ToolStripButton ToolStripButtonSquare;
        private System.Windows.Forms.ToolStripButton ToolStripButtonEllipse;
        private System.Windows.Forms.ToolStripButton ToolStripButtonCircle;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    }
}

