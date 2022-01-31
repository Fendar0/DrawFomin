
namespace DrawNikonov
{
    partial class Form1
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
            this.Pictures = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxFigure = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.ListFigure = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pictures)).BeginInit();
            this.SuspendLayout();
            // 
            // Pictures
            // 
            this.Pictures.Location = new System.Drawing.Point(10, 12);
            this.Pictures.Name = "Pictures";
            this.Pictures.Size = new System.Drawing.Size(660, 512);
            this.Pictures.TabIndex = 0;
            this.Pictures.TabStop = false;
            this.Pictures.Paint += new System.Windows.Forms.PaintEventHandler(this.Pictures_Paint);
            this.Pictures.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pictures_MouseDown);
            this.Pictures.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pictures_MouseMove);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(680, 316);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(192, 34);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxFigure
            // 
            this.comboBoxFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFigure.FormattingEnabled = true;
            this.comboBoxFigure.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Triangle"});
            this.comboBoxFigure.Location = new System.Drawing.Point(680, 8);
            this.comboBoxFigure.Name = "comboBoxFigure";
            this.comboBoxFigure.Size = new System.Drawing.Size(192, 32);
            this.comboBoxFigure.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(680, 47);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(192, 32);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ListFigure
            // 
            this.ListFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListFigure.FormattingEnabled = true;
            this.ListFigure.ItemHeight = 24;
            this.ListFigure.Location = new System.Drawing.Point(680, 85);
            this.ListFigure.Name = "ListFigure";
            this.ListFigure.Size = new System.Drawing.Size(192, 220);
            this.ListFigure.TabIndex = 4;
            this.ListFigure.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 536);
            this.Controls.Add(this.ListFigure);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxFigure);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.Pictures);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Pictures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pictures;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxFigure;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox ListFigure;
    }
}

