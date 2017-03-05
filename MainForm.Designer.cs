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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(37, 561);
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
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(784, 561);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графический редактор";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton ToolStripButtonLine;
        private System.Windows.Forms.ToolStripButton ToolStripButtonRectangle;
        private System.Windows.Forms.ToolStripButton ToolStripButtonSquare;
        private System.Windows.Forms.ToolStripButton ToolStripButtonEllipse;
        private System.Windows.Forms.ToolStripButton ToolStripButtonCircle;
    }
}

