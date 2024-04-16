namespace _2.zhgyak
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            class1BindingSource = new BindingSource(components);
            szamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kerdesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kepDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            helyesValaszDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(530, 381);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(647, 381);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(514, 127);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(32, 26);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { szamDataGridViewTextBoxColumn, kerdesDataGridViewTextBoxColumn, v1DataGridViewTextBoxColumn, v2DataGridViewTextBoxColumn, v3DataGridViewTextBoxColumn, kepDataGridViewTextBoxColumn, helyesValaszDataGridViewTextBoxColumn });
            dataGridView1.DataSource = class1BindingSource;
            dataGridView1.Location = new Point(12, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(465, 254);
            dataGridView1.TabIndex = 4;
            // 
            // class1BindingSource
            // 
            class1BindingSource.DataSource = typeof(Class1);
            // 
            // szamDataGridViewTextBoxColumn
            // 
            szamDataGridViewTextBoxColumn.DataPropertyName = "Szam";
            szamDataGridViewTextBoxColumn.HeaderText = "Szam";
            szamDataGridViewTextBoxColumn.Name = "szamDataGridViewTextBoxColumn";
            // 
            // kerdesDataGridViewTextBoxColumn
            // 
            kerdesDataGridViewTextBoxColumn.DataPropertyName = "Kerdes";
            kerdesDataGridViewTextBoxColumn.HeaderText = "Kerdes";
            kerdesDataGridViewTextBoxColumn.Name = "kerdesDataGridViewTextBoxColumn";
            // 
            // v1DataGridViewTextBoxColumn
            // 
            v1DataGridViewTextBoxColumn.DataPropertyName = "V1";
            v1DataGridViewTextBoxColumn.HeaderText = "V1";
            v1DataGridViewTextBoxColumn.Name = "v1DataGridViewTextBoxColumn";
            // 
            // v2DataGridViewTextBoxColumn
            // 
            v2DataGridViewTextBoxColumn.DataPropertyName = "V2";
            v2DataGridViewTextBoxColumn.HeaderText = "V2";
            v2DataGridViewTextBoxColumn.Name = "v2DataGridViewTextBoxColumn";
            // 
            // v3DataGridViewTextBoxColumn
            // 
            v3DataGridViewTextBoxColumn.DataPropertyName = "V3";
            v3DataGridViewTextBoxColumn.HeaderText = "V3";
            v3DataGridViewTextBoxColumn.Name = "v3DataGridViewTextBoxColumn";
            // 
            // kepDataGridViewTextBoxColumn
            // 
            kepDataGridViewTextBoxColumn.DataPropertyName = "Kep";
            kepDataGridViewTextBoxColumn.HeaderText = "Kep";
            kepDataGridViewTextBoxColumn.Name = "kepDataGridViewTextBoxColumn";
            // 
            // helyesValaszDataGridViewTextBoxColumn
            // 
            helyesValaszDataGridViewTextBoxColumn.DataPropertyName = "HelyesValasz";
            helyesValaszDataGridViewTextBoxColumn.HeaderText = "HelyesValasz";
            helyesValaszDataGridViewTextBoxColumn.Name = "helyesValaszDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)class1BindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn szamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kerdesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn helyesValaszDataGridViewTextBoxColumn;
        private BindingSource class1BindingSource;
    }
}
