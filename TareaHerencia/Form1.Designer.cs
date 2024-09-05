namespace TareaHerencia
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
            ClaseMiembros = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // ClaseMiembros
            // 
            ClaseMiembros.Location = new Point(44, 43);
            ClaseMiembros.Name = "ClaseMiembros";
            ClaseMiembros.Size = new Size(114, 31);
            ClaseMiembros.TabIndex = 0;
            ClaseMiembros.Text = "ClaseMiembros";
            ClaseMiembros.UseVisualStyleBackColor = true;
            ClaseMiembros.Click += ClaseMiembros_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(401, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(387, 304);
            listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(ClaseMiembros);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ClaseMiembros;
        private ListBox listBox1;
    }
}
