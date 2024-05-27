namespace PrimeraApp
{
    partial class Equipo
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Menu = new ContextMenuStrip(components);
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            menuUsuarioToolStripMenuItem = new ToolStripMenuItem();
            equipoToolStripMenuItem = new ToolStripMenuItem();
            mercadoToolStripMenuItem = new ToolStripMenuItem();
            rankingToolStripMenuItem = new ToolStripMenuItem();
            ligasToolStripMenuItem = new ToolStripMenuItem();
            resultadoJornadaToolStripMenuItem = new ToolStripMenuItem();
            tiendaToolStripMenuItem = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(156, 253);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 195);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jugadores";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 155);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Jugador1 (TOP)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 155);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Jugador2 (JNG)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 155);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 3;
            label3.Text = "Jugador3 (MID)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 155);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 4;
            label4.Text = "Jugador4 (ADC)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(602, 155);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 5;
            label5.Text = "Jugador5 (SUP)";
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.Control;
            Menu.Items.AddRange(new ToolStripItem[] { ayudaToolStripMenuItem, inicioToolStripMenuItem, menuUsuarioToolStripMenuItem, equipoToolStripMenuItem, mercadoToolStripMenuItem, rankingToolStripMenuItem, ligasToolStripMenuItem, resultadoJornadaToolStripMenuItem, tiendaToolStripMenuItem, configuraciónToolStripMenuItem });
            Menu.Name = "contextMenuStrip1";
            Menu.Size = new Size(171, 224);
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(170, 22);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(170, 22);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // menuUsuarioToolStripMenuItem
            // 
            menuUsuarioToolStripMenuItem.Name = "menuUsuarioToolStripMenuItem";
            menuUsuarioToolStripMenuItem.Size = new Size(170, 22);
            menuUsuarioToolStripMenuItem.Text = "Menu Usuario";
            // 
            // equipoToolStripMenuItem
            // 
            equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            equipoToolStripMenuItem.Size = new Size(170, 22);
            equipoToolStripMenuItem.Text = "Equipo";
            // 
            // mercadoToolStripMenuItem
            // 
            mercadoToolStripMenuItem.Name = "mercadoToolStripMenuItem";
            mercadoToolStripMenuItem.Size = new Size(170, 22);
            mercadoToolStripMenuItem.Text = "Mercado";
            // 
            // rankingToolStripMenuItem
            // 
            rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            rankingToolStripMenuItem.Size = new Size(170, 22);
            rankingToolStripMenuItem.Text = "Ranking";
            // 
            // ligasToolStripMenuItem
            // 
            ligasToolStripMenuItem.Name = "ligasToolStripMenuItem";
            ligasToolStripMenuItem.Size = new Size(170, 22);
            ligasToolStripMenuItem.Text = "Ligas";
            // 
            // resultadoJornadaToolStripMenuItem
            // 
            resultadoJornadaToolStripMenuItem.Name = "resultadoJornadaToolStripMenuItem";
            resultadoJornadaToolStripMenuItem.Size = new Size(170, 22);
            resultadoJornadaToolStripMenuItem.Text = "Resultado Jornada";
            // 
            // tiendaToolStripMenuItem
            // 
            tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            tiendaToolStripMenuItem.Size = new Size(170, 22);
            tiendaToolStripMenuItem.Text = "Tienda";
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(170, 22);
            configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(572, 224);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 6;
            button1.Text = "Guardar Equipo";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Location = new Point(156, 206);
            button2.Name = "button2";
            button2.Size = new Size(141, 45);
            button2.TabIndex = 7;
            button2.Text = "Informe Equipos Anteriores";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MAD_Elyoya;
            pictureBox1.Location = new Point(253, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Inicio";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Equipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Equipo";
            Text = "Equipo";
            Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ContextMenuStrip Menu;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem menuUsuarioToolStripMenuItem;
        private ToolStripMenuItem equipoToolStripMenuItem;
        private ToolStripMenuItem mercadoToolStripMenuItem;
        private ToolStripMenuItem rankingToolStripMenuItem;
        private ToolStripMenuItem ligasToolStripMenuItem;
        private ToolStripMenuItem resultadoJornadaToolStripMenuItem;
        private ToolStripMenuItem tiendaToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
    }
}