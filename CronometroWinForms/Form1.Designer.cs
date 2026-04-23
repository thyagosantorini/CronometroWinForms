namespace CronometroWinForms
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
            lblHoras = new Label();
            label2 = new Label();
            label3 = new Label();
            lblMinutos = new Label();
            label5 = new Label();
            lblSegundos = new Label();
            lblMilisegundos = new Label();
            btnParar = new Button();
            btnResetar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btIniciar = new Button();
            SuspendLayout();
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoras.Location = new Point(51, 43);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(80, 65);
            lblHoras.TabIndex = 0;
            lblHoras.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 43);
            label2.Name = "label2";
            label2.Size = new Size(38, 65);
            label2.TabIndex = 1;
            label2.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(221, 43);
            label3.Name = "label3";
            label3.Size = new Size(38, 65);
            label3.TabIndex = 3;
            label3.Text = ":";
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMinutos.Location = new Point(152, 43);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(80, 65);
            lblMinutos.TabIndex = 2;
            lblMinutos.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(317, 43);
            label5.Name = "label5";
            label5.Size = new Size(38, 65);
            label5.TabIndex = 5;
            label5.Text = ".";
            // 
            // lblSegundos
            // 
            lblSegundos.AutoSize = true;
            lblSegundos.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSegundos.Location = new Point(248, 43);
            lblSegundos.Name = "lblSegundos";
            lblSegundos.Size = new Size(80, 65);
            lblSegundos.TabIndex = 4;
            lblSegundos.Text = "00";
            // 
            // lblMilisegundos
            // 
            lblMilisegundos.AutoSize = true;
            lblMilisegundos.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMilisegundos.Location = new Point(343, 59);
            lblMilisegundos.Name = "lblMilisegundos";
            lblMilisegundos.Size = new Size(54, 45);
            lblMilisegundos.TabIndex = 6;
            lblMilisegundos.Text = "00";
            // 
            // btnParar
            // 
            btnParar.Location = new Point(170, 137);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(97, 42);
            btnParar.TabIndex = 8;
            btnParar.Text = "PARAR";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // btnResetar
            // 
            btnResetar.Location = new Point(283, 137);
            btnResetar.Name = "btnResetar";
            btnResetar.Size = new Size(97, 42);
            btnResetar.TabIndex = 9;
            btnResetar.Text = "RESETAR";
            btnResetar.UseVisualStyleBackColor = true;
            btnResetar.Click += btnResetar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // btIniciar
            // 
            btIniciar.Location = new Point(51, 137);
            btIniciar.Name = "btIniciar";
            btIniciar.Size = new Size(97, 42);
            btIniciar.TabIndex = 10;
            btIniciar.Text = "INICIAR";
            btIniciar.UseVisualStyleBackColor = true;
            btIniciar.Click += btIniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 238);
            Controls.Add(btIniciar);
            Controls.Add(btnResetar);
            Controls.Add(btnParar);
            Controls.Add(lblMilisegundos);
            Controls.Add(label5);
            Controls.Add(lblSegundos);
            Controls.Add(label3);
            Controls.Add(lblMinutos);
            Controls.Add(label2);
            Controls.Add(lblHoras);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoras;
        private Label label2;
        private Label label3;
        private Label lblMinutos;
        private Label label5;
        private Label lblSegundos;
        private Label lblMilisegundos;
        private Button btnParar;
        private Button btnResetar;
        private System.Windows.Forms.Timer timer1;
        private Button btIniciar;
    }
}
