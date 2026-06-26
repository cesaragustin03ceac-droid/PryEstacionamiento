namespace PryEstacionamiento
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
            groupBox1 = new GroupBox();
            txtHoras = new TextBox();
            label2 = new Label();
            cbTipo = new ComboBox();
            label = new Label();
            BtBoton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHoras);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbTipo);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(BtBoton);
            groupBox1.Location = new Point(24, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 526);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tarifa";
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(37, 243);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(125, 27);
            txtHoras.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 194);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Horas";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(37, 127);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(151, 28);
            cbTipo.TabIndex = 2;
            cbTipo.SelectedIndexChanged += cbTipo_SelectedIndexChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(37, 70);
            label.Name = "label";
            label.Size = new Size(119, 20);
            label.TabIndex = 1;
            label.Text = "Tipo de vehiculo";
            // 
            // BtBoton
            // 
            BtBoton.Location = new Point(71, 338);
            BtBoton.Name = "BtBoton";
            BtBoton.Size = new Size(138, 65);
            BtBoton.TabIndex = 0;
            BtBoton.Text = "Calcular";
            BtBoton.UseVisualStyleBackColor = true;
            BtBoton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(405, 558);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtBoton;
        private TextBox txtHoras;
        private Label label2;
        private ComboBox cbTipo;
        private Label label;
    }
}
