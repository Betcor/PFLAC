namespace PFLAC
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.oficerRdBtn = new System.Windows.Forms.RadioButton();
            this.soldierRdBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femaleRdBtn = new System.Windows.Forms.RadioButton();
            this.maleRdBtn = new System.Windows.Forms.RadioButton();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.norm3Lbl = new System.Windows.Forms.Label();
            this.norm2Lbl = new System.Windows.Forms.Label();
            this.norm1Lbl = new System.Windows.Forms.Label();
            this.calcGradeBtn = new System.Windows.Forms.Button();
            this.getNormsBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ageTxtBox = new System.Windows.Forms.TextBox();
            this.fullNameTxtBox = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 596);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.loadFileBtn);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.norm3Lbl);
            this.tabPage1.Controls.Add(this.norm2Lbl);
            this.tabPage1.Controls.Add(this.norm1Lbl);
            this.tabPage1.Controls.Add(this.calcGradeBtn);
            this.tabPage1.Controls.Add(this.getNormsBtn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ageTxtBox);
            this.tabPage1.Controls.Add(this.fullNameTxtBox);
            this.tabPage1.Controls.Add(this.nextBtn);
            this.tabPage1.Controls.Add(this.previousBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Обрахунок";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.oficerRdBtn);
            this.groupBox2.Controls.Add(this.soldierRdBtn);
            this.groupBox2.Location = new System.Drawing.Point(248, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 123);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вибір статусу";
            // 
            // oficerRdBtn
            // 
            this.oficerRdBtn.AutoSize = true;
            this.oficerRdBtn.Location = new System.Drawing.Point(13, 23);
            this.oficerRdBtn.Name = "oficerRdBtn";
            this.oficerRdBtn.Size = new System.Drawing.Size(105, 29);
            this.oficerRdBtn.TabIndex = 6;
            this.oficerRdBtn.TabStop = true;
            this.oficerRdBtn.Text = "Офіцер";
            this.oficerRdBtn.UseVisualStyleBackColor = true;
            // 
            // soldierRdBtn
            // 
            this.soldierRdBtn.AutoSize = true;
            this.soldierRdBtn.Location = new System.Drawing.Point(13, 73);
            this.soldierRdBtn.Name = "soldierRdBtn";
            this.soldierRdBtn.Size = new System.Drawing.Size(176, 29);
            this.soldierRdBtn.TabIndex = 7;
            this.soldierRdBtn.TabStop = true;
            this.soldierRdBtn.Text = "За контрактом";
            this.soldierRdBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.femaleRdBtn);
            this.groupBox1.Controls.Add(this.maleRdBtn);
            this.groupBox1.Location = new System.Drawing.Point(11, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 123);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вибір статі";
            // 
            // femaleRdBtn
            // 
            this.femaleRdBtn.AutoSize = true;
            this.femaleRdBtn.Location = new System.Drawing.Point(5, 73);
            this.femaleRdBtn.Name = "femaleRdBtn";
            this.femaleRdBtn.Size = new System.Drawing.Size(87, 29);
            this.femaleRdBtn.TabIndex = 9;
            this.femaleRdBtn.TabStop = true;
            this.femaleRdBtn.Text = "Жінка";
            this.femaleRdBtn.UseVisualStyleBackColor = true;
            // 
            // maleRdBtn
            // 
            this.maleRdBtn.AutoSize = true;
            this.maleRdBtn.Location = new System.Drawing.Point(5, 23);
            this.maleRdBtn.Name = "maleRdBtn";
            this.maleRdBtn.Size = new System.Drawing.Size(104, 29);
            this.maleRdBtn.TabIndex = 8;
            this.maleRdBtn.TabStop = true;
            this.maleRdBtn.Text = "Чоловік";
            this.maleRdBtn.UseVisualStyleBackColor = true;
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Location = new System.Drawing.Point(16, 18);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(851, 45);
            this.loadFileBtn.TabIndex = 18;
            this.loadFileBtn.Text = "Завантажити таблицю з файлу (excel)";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            this.loadFileBtn.Click += new System.EventHandler(this.LoadFileBtn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(540, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(105, 30);
            this.textBox3.TabIndex = 17;
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(540, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 30);
            this.textBox2.TabIndex = 16;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(540, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 30);
            this.textBox1.TabIndex = 15;
            this.textBox1.Visible = false;
            // 
            // norm3Lbl
            // 
            this.norm3Lbl.AutoSize = true;
            this.norm3Lbl.Location = new System.Drawing.Point(535, 239);
            this.norm3Lbl.Name = "norm3Lbl";
            this.norm3Lbl.Size = new System.Drawing.Size(123, 25);
            this.norm3Lbl.TabIndex = 14;
            this.norm3Lbl.Text = "Норматив 3";
            this.norm3Lbl.Visible = false;
            // 
            // norm2Lbl
            // 
            this.norm2Lbl.AutoSize = true;
            this.norm2Lbl.Location = new System.Drawing.Point(535, 165);
            this.norm2Lbl.Name = "norm2Lbl";
            this.norm2Lbl.Size = new System.Drawing.Size(123, 25);
            this.norm2Lbl.TabIndex = 13;
            this.norm2Lbl.Text = "Норматив 2";
            this.norm2Lbl.Visible = false;
            // 
            // norm1Lbl
            // 
            this.norm1Lbl.AutoSize = true;
            this.norm1Lbl.Location = new System.Drawing.Point(535, 91);
            this.norm1Lbl.Name = "norm1Lbl";
            this.norm1Lbl.Size = new System.Drawing.Size(123, 25);
            this.norm1Lbl.TabIndex = 12;
            this.norm1Lbl.Text = "Норматив 1";
            this.norm1Lbl.Visible = false;
            // 
            // calcGradeBtn
            // 
            this.calcGradeBtn.Location = new System.Drawing.Point(540, 400);
            this.calcGradeBtn.Name = "calcGradeBtn";
            this.calcGradeBtn.Size = new System.Drawing.Size(227, 81);
            this.calcGradeBtn.TabIndex = 11;
            this.calcGradeBtn.Text = "Обрахувати оцінку";
            this.calcGradeBtn.UseVisualStyleBackColor = true;
            this.calcGradeBtn.Visible = false;
            // 
            // getNormsBtn
            // 
            this.getNormsBtn.Location = new System.Drawing.Point(102, 400);
            this.getNormsBtn.Name = "getNormsBtn";
            this.getNormsBtn.Size = new System.Drawing.Size(227, 81);
            this.getNormsBtn.TabIndex = 10;
            this.getNormsBtn.Text = "Визначити нормативи";
            this.getNormsBtn.UseVisualStyleBackColor = true;
            this.getNormsBtn.Click += new System.EventHandler(this.getNormsBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вік";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ПІБ військовослужбовця";
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.Location = new System.Drawing.Point(11, 193);
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(71, 30);
            this.ageTxtBox.TabIndex = 3;
            // 
            // fullNameTxtBox
            // 
            this.fullNameTxtBox.Location = new System.Drawing.Point(11, 119);
            this.fullNameTxtBox.Name = "fullNameTxtBox";
            this.fullNameTxtBox.Size = new System.Drawing.Size(442, 30);
            this.fullNameTxtBox.TabIndex = 2;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(821, 515);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(46, 41);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(11, 512);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(46, 41);
            this.previousBtn.TabIndex = 0;
            this.previousBtn.Text = "<";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.saveFileBtn);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Таблиця результатів";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(11, 497);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(856, 45);
            this.saveFileBtn.TabIndex = 19;
            this.saveFileBtn.Text = "Зберегти таблицю у файл";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Таблиця результатів";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(856, 434);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 597);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button nextBtn;
    private System.Windows.Forms.Button previousBtn;
    private System.Windows.Forms.RadioButton femaleRdBtn;
    private System.Windows.Forms.RadioButton maleRdBtn;
    private System.Windows.Forms.RadioButton soldierRdBtn;
    private System.Windows.Forms.RadioButton oficerRdBtn;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox ageTxtBox;
    private System.Windows.Forms.TextBox fullNameTxtBox;
    private System.Windows.Forms.Button getNormsBtn;
    private System.Windows.Forms.Button calcGradeBtn;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label norm3Lbl;
    private System.Windows.Forms.Label norm2Lbl;
    private System.Windows.Forms.Label norm1Lbl;
    private System.Windows.Forms.Button loadFileBtn;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Button saveFileBtn;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label4;
  }
}

