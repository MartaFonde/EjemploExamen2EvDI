
namespace Forms
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAficciones = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSexoH = new System.Windows.Forms.RadioButton();
            this.rbSexoM = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSexoOpH = new System.Windows.Forms.RadioButton();
            this.rbSexoOpM = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.validateTbEdad = new ValidateTextBox.ValidateTextBoxComponente();
            this.validateTbNombre = new ValidateTextBox.ValidateTextBoxComponente();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad";
            // 
            // cbAficciones
            // 
            this.cbAficciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAficciones.FormattingEnabled = true;
            this.cbAficciones.Location = new System.Drawing.Point(172, 163);
            this.cbAficciones.Name = "cbAficciones";
            this.cbAficciones.Size = new System.Drawing.Size(121, 21);
            this.cbAficciones.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aficción";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSexoM);
            this.groupBox1.Controls.Add(this.rbSexoH);
            this.groupBox1.Location = new System.Drawing.Point(33, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbSexoH
            // 
            this.rbSexoH.AutoSize = true;
            this.rbSexoH.Location = new System.Drawing.Point(32, 34);
            this.rbSexoH.Name = "rbSexoH";
            this.rbSexoH.Size = new System.Drawing.Size(62, 17);
            this.rbSexoH.TabIndex = 0;
            this.rbSexoH.Text = "Hombre";
            this.rbSexoH.UseVisualStyleBackColor = true;
            // 
            // rbSexoM
            // 
            this.rbSexoM.AutoSize = true;
            this.rbSexoM.Checked = true;
            this.rbSexoM.Location = new System.Drawing.Point(32, 71);
            this.rbSexoM.Name = "rbSexoM";
            this.rbSexoM.Size = new System.Drawing.Size(51, 17);
            this.rbSexoM.TabIndex = 1;
            this.rbSexoM.TabStop = true;
            this.rbSexoM.Text = "Mujer";
            this.rbSexoM.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSexoOpM);
            this.groupBox2.Controls.Add(this.rbSexoOpH);
            this.groupBox2.Location = new System.Drawing.Point(269, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 94);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo opuesto";
            // 
            // rbSexoOpH
            // 
            this.rbSexoOpH.AutoSize = true;
            this.rbSexoOpH.Checked = true;
            this.rbSexoOpH.Location = new System.Drawing.Point(50, 34);
            this.rbSexoOpH.Name = "rbSexoOpH";
            this.rbSexoOpH.Size = new System.Drawing.Size(62, 17);
            this.rbSexoOpH.TabIndex = 0;
            this.rbSexoOpH.TabStop = true;
            this.rbSexoOpH.Text = "Hombre";
            this.rbSexoOpH.UseVisualStyleBackColor = true;
            // 
            // rbSexoOpM
            // 
            this.rbSexoOpM.AutoSize = true;
            this.rbSexoOpM.Location = new System.Drawing.Point(50, 71);
            this.rbSexoOpM.Name = "rbSexoOpM";
            this.rbSexoOpM.Size = new System.Drawing.Size(51, 17);
            this.rbSexoOpM.TabIndex = 1;
            this.rbSexoOpM.Text = "Mujer";
            this.rbSexoOpM.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Imagen";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 9;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(436, 362);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 10;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(158, 411);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(306, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // validateTbEdad
            // 
            this.validateTbEdad.Location = new System.Drawing.Point(158, 89);
            this.validateTbEdad.Multilinea = false;
            this.validateTbEdad.Name = "validateTbEdad";
            this.validateTbEdad.Size = new System.Drawing.Size(150, 40);
            this.validateTbEdad.TabIndex = 1;
            this.validateTbEdad.Texto = "";
            this.validateTbEdad.Tipo = ValidateTextBox.eTipo.Numérico;
            // 
            // validateTbNombre
            // 
            this.validateTbNombre.Location = new System.Drawing.Point(158, 23);
            this.validateTbNombre.Multilinea = false;
            this.validateTbNombre.Name = "validateTbNombre";
            this.validateTbNombre.Size = new System.Drawing.Size(150, 40);
            this.validateTbNombre.TabIndex = 0;
            this.validateTbNombre.Texto = "";
            this.validateTbNombre.Tipo = ValidateTextBox.eTipo.Textual;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAficciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validateTbEdad);
            this.Controls.Add(this.validateTbNombre);
            this.Name = "Form2";
            this.Text = "Introducción datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        internal ValidateTextBox.ValidateTextBoxComponente validateTbNombre;
        internal ValidateTextBox.ValidateTextBoxComponente validateTbEdad;
        internal System.Windows.Forms.ComboBox cbAficciones;
        internal System.Windows.Forms.RadioButton rbSexoM;
        internal System.Windows.Forms.RadioButton rbSexoH;
        internal System.Windows.Forms.RadioButton rbSexoOpM;
        internal System.Windows.Forms.RadioButton rbSexoOpH;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.GroupBox groupBox1;
    }
}