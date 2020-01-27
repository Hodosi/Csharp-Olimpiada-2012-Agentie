namespace Agentie_Matrimoniala
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.textBox_prenume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_varsta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_sex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ocupatie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_adauga = new System.Windows.Forms.Button();
            this.button_Varsta_Medie = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 503);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume:";
            // 
            // textBox_nume
            // 
            this.textBox_nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nume.Location = new System.Drawing.Point(142, 24);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(200, 30);
            this.textBox_nume.TabIndex = 2;
            // 
            // textBox_prenume
            // 
            this.textBox_prenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_prenume.Location = new System.Drawing.Point(142, 72);
            this.textBox_prenume.Name = "textBox_prenume";
            this.textBox_prenume.Size = new System.Drawing.Size(200, 30);
            this.textBox_prenume.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenume:";
            // 
            // textBox_varsta
            // 
            this.textBox_varsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_varsta.Location = new System.Drawing.Point(142, 120);
            this.textBox_varsta.Name = "textBox_varsta";
            this.textBox_varsta.Size = new System.Drawing.Size(200, 30);
            this.textBox_varsta.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Varsta:";
            // 
            // textBox_sex
            // 
            this.textBox_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sex.Location = new System.Drawing.Point(142, 168);
            this.textBox_sex.Name = "textBox_sex";
            this.textBox_sex.Size = new System.Drawing.Size(200, 30);
            this.textBox_sex.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sex:";
            // 
            // textBox_ocupatie
            // 
            this.textBox_ocupatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ocupatie.Location = new System.Drawing.Point(142, 216);
            this.textBox_ocupatie.Name = "textBox_ocupatie";
            this.textBox_ocupatie.Size = new System.Drawing.Size(200, 30);
            this.textBox_ocupatie.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ocupatie:";
            // 
            // button_adauga
            // 
            this.button_adauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adauga.Location = new System.Drawing.Point(31, 279);
            this.button_adauga.Name = "button_adauga";
            this.button_adauga.Size = new System.Drawing.Size(311, 45);
            this.button_adauga.TabIndex = 11;
            this.button_adauga.Text = "Adauga Persoane";
            this.button_adauga.UseVisualStyleBackColor = true;
            this.button_adauga.Click += new System.EventHandler(this.button_adauga_Click);
            // 
            // button_Varsta_Medie
            // 
            this.button_Varsta_Medie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Varsta_Medie.Location = new System.Drawing.Point(31, 468);
            this.button_Varsta_Medie.Name = "button_Varsta_Medie";
            this.button_Varsta_Medie.Size = new System.Drawing.Size(311, 45);
            this.button_Varsta_Medie.TabIndex = 12;
            this.button_Varsta_Medie.Text = "Varsta Medie";
            this.button_Varsta_Medie.UseVisualStyleBackColor = true;
            this.button_Varsta_Medie.Click += new System.EventHandler(this.button_Varsta_Medie_Click);
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(31, 342);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(311, 45);
            this.button_edit.TabIndex = 13;
            this.button_edit.Text = "Editeaza Persoane";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(31, 405);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(311, 45);
            this.button_delete.TabIndex = 14;
            this.button_delete.Text = "Sterge Persoane";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 530);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_Varsta_Medie);
            this.Controls.Add(this.button_adauga);
            this.Controls.Add(this.textBox_ocupatie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_sex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_varsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_prenume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.TextBox textBox_prenume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_varsta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_sex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ocupatie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_adauga;
        private System.Windows.Forms.Button button_Varsta_Medie;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
    }
}

