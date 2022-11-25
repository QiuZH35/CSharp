namespace 调查问卷
{
    partial class 调查
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimebirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.籍贯 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.men = new System.Windows.Forms.RadioButton();
            this.man = new System.Windows.Forms.RadioButton();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.labelage = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checktabletennis = new System.Windows.Forms.CheckBox();
            this.checkbadminton = new System.Windows.Forms.CheckBox();
            this.checksoccer = new System.Windows.Forms.CheckBox();
            this.checkbasketball = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textresult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimebirth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.籍贯);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.men);
            this.groupBox1.Controls.Add(this.man);
            this.groupBox1.Controls.Add(this.textBoxage);
            this.groupBox1.Controls.Add(this.labelage);
            this.groupBox1.Controls.Add(this.textBoxname);
            this.groupBox1.Controls.Add(this.labelname);
            this.groupBox1.Location = new System.Drawing.Point(63, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "生日：";
            // 
            // dateTimebirth
            // 
            this.dateTimebirth.Location = new System.Drawing.Point(94, 301);
            this.dateTimebirth.Name = "dateTimebirth";
            this.dateTimebirth.Size = new System.Drawing.Size(233, 23);
            this.dateTimebirth.TabIndex = 9;
            this.dateTimebirth.ValueChanged += new System.EventHandler(this.dateTimebirth_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "籍贯：";
            // 
            // 籍贯
            // 
            this.籍贯.FormattingEnabled = true;
            this.籍贯.Items.AddRange(new object[] {
            "广西",
            "广东",
            "北京",
            "湖南",
            "四川"});
            this.籍贯.Location = new System.Drawing.Point(94, 237);
            this.籍贯.Name = "籍贯";
            this.籍贯.Size = new System.Drawing.Size(233, 25);
            this.籍贯.TabIndex = 7;
            this.籍贯.SelectedIndexChanged += new System.EventHandler(this.籍贯_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "性别：";
            // 
            // men
            // 
            this.men.AutoSize = true;
            this.men.Location = new System.Drawing.Point(203, 165);
            this.men.Name = "men";
            this.men.Size = new System.Drawing.Size(38, 21);
            this.men.TabIndex = 5;
            this.men.Text = "女";
            this.men.UseVisualStyleBackColor = true;
            this.men.CheckedChanged += new System.EventHandler(this.men_CheckedChanged);
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Checked = true;
            this.man.Location = new System.Drawing.Point(94, 165);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(38, 21);
            this.man.TabIndex = 4;
            this.man.TabStop = true;
            this.man.Text = "男";
            this.man.UseVisualStyleBackColor = true;
            this.man.CheckedChanged += new System.EventHandler(this.man_CheckedChanged);
            // 
            // textBoxage
            // 
            this.textBoxage.Location = new System.Drawing.Point(94, 98);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(233, 23);
            this.textBoxage.TabIndex = 3;
            this.textBoxage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelage
            // 
            this.labelage.AutoSize = true;
            this.labelage.Location = new System.Drawing.Point(29, 104);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(44, 17);
            this.labelage.TabIndex = 2;
            this.labelage.Text = "年龄：";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(94, 43);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(233, 23);
            this.textBoxname.TabIndex = 1;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBoxname_TextChanged);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(29, 49);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(44, 17);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "姓名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checktabletennis);
            this.groupBox2.Controls.Add(this.checkbadminton);
            this.groupBox2.Controls.Add(this.checksoccer);
            this.groupBox2.Controls.Add(this.checkbasketball);
            this.groupBox2.Location = new System.Drawing.Point(505, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 420);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "兴趣爱好";
            // 
            // checktabletennis
            // 
            this.checktabletennis.AutoSize = true;
            this.checktabletennis.Location = new System.Drawing.Point(254, 161);
            this.checktabletennis.Name = "checktabletennis";
            this.checktabletennis.Size = new System.Drawing.Size(63, 21);
            this.checktabletennis.TabIndex = 3;
            this.checktabletennis.Text = "乒乓球";
            this.checktabletennis.UseVisualStyleBackColor = true;
            this.checktabletennis.CheckedChanged += new System.EventHandler(this.checktabletennis_CheckedChanged);
            // 
            // checkbadminton
            // 
            this.checkbadminton.AutoSize = true;
            this.checkbadminton.Location = new System.Drawing.Point(39, 161);
            this.checkbadminton.Name = "checkbadminton";
            this.checkbadminton.Size = new System.Drawing.Size(63, 21);
            this.checkbadminton.TabIndex = 2;
            this.checkbadminton.Text = "羽毛球";
            this.checkbadminton.UseVisualStyleBackColor = true;
            this.checkbadminton.CheckedChanged += new System.EventHandler(this.checkbadminton_CheckedChanged);
            // 
            // checksoccer
            // 
            this.checksoccer.AutoSize = true;
            this.checksoccer.Location = new System.Drawing.Point(254, 49);
            this.checksoccer.Name = "checksoccer";
            this.checksoccer.Size = new System.Drawing.Size(51, 21);
            this.checksoccer.TabIndex = 1;
            this.checksoccer.Text = "足球";
            this.checksoccer.UseVisualStyleBackColor = true;
            this.checksoccer.CheckedChanged += new System.EventHandler(this.checksoccer_CheckedChanged);
            // 
            // checkbasketball
            // 
            this.checkbasketball.AutoSize = true;
            this.checkbasketball.Location = new System.Drawing.Point(39, 49);
            this.checkbasketball.Name = "checkbasketball";
            this.checkbasketball.Size = new System.Drawing.Size(51, 21);
            this.checkbasketball.TabIndex = 0;
            this.checkbasketball.Text = "篮球";
            this.checkbasketball.UseVisualStyleBackColor = true;
            this.checkbasketball.CheckedChanged += new System.EventHandler(this.checkbasketball_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textresult);
            this.groupBox3.Location = new System.Drawing.Point(63, 478);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(621, 421);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "调查结构";
            // 
            // textresult
            // 
            this.textresult.Location = new System.Drawing.Point(27, 35);
            this.textresult.Multiline = true;
            this.textresult.Name = "textresult";
            this.textresult.Size = new System.Drawing.Size(561, 365);
            this.textresult.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(759, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(759, 701);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 调查
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 918);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "调查";
            this.Text = "调查";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox 籍贯;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton men;
        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.Label labelage;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checktabletennis;
        private System.Windows.Forms.CheckBox checkbadminton;
        private System.Windows.Forms.CheckBox checksoccer;
        private System.Windows.Forms.CheckBox checkbasketball;
        private System.Windows.Forms.DateTimePicker dateTimebirth;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textresult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}
