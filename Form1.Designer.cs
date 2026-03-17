namespace Devsploit
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.RichTextBox();
            this.Execute = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inject = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.gl = new System.Windows.Forms.Button();
            this.killrb = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.openoutput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.attachwarn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Devsploit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(817, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.Black;
            this.text.Location = new System.Drawing.Point(259, 51);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(602, 474);
            this.text.TabIndex = 3;
            this.text.Text = "";
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.Black;
            this.Execute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Execute.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Execute.Location = new System.Drawing.Point(6, 93);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(246, 52);
            this.Execute.TabIndex = 4;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Devsploit.Properties.Resources.icons8_roblox_logo_96;
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // inject
            // 
            this.inject.BackColor = System.Drawing.Color.Black;
            this.inject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inject.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inject.Location = new System.Drawing.Point(6, 151);
            this.inject.Name = "inject";
            this.inject.Size = new System.Drawing.Size(246, 49);
            this.inject.TabIndex = 5;
            this.inject.Text = "Inject";
            this.inject.UseVisualStyleBackColor = false;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Black;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save.Location = new System.Drawing.Point(6, 206);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(246, 47);
            this.save.TabIndex = 6;
            this.save.Text = "Save Script";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.Black;
            this.open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.open.Location = new System.Drawing.Point(7, 259);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(246, 49);
            this.open.TabIndex = 7;
            this.open.Text = "Open Script";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // gl
            // 
            this.gl.BackColor = System.Drawing.Color.Black;
            this.gl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gl.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gl.Location = new System.Drawing.Point(7, 311);
            this.gl.Name = "gl";
            this.gl.Size = new System.Drawing.Size(246, 49);
            this.gl.TabIndex = 8;
            this.gl.Text = " Get Loadstring ";
            this.gl.UseVisualStyleBackColor = false;
            this.gl.Click += new System.EventHandler(this.gl_Click);
            // 
            // killrb
            // 
            this.killrb.BackColor = System.Drawing.Color.Black;
            this.killrb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.killrb.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killrb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.killrb.Location = new System.Drawing.Point(6, 366);
            this.killrb.Name = "killrb";
            this.killrb.Size = new System.Drawing.Size(246, 49);
            this.killrb.TabIndex = 9;
            this.killrb.Text = "Kill Roblox";
            this.killrb.UseVisualStyleBackColor = false;
            this.killrb.Click += new System.EventHandler(this.killrb_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Black;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.Location = new System.Drawing.Point(6, 421);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(246, 49);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // openoutput
            // 
            this.openoutput.BackColor = System.Drawing.Color.Black;
            this.openoutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openoutput.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openoutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openoutput.Location = new System.Drawing.Point(7, 476);
            this.openoutput.Name = "openoutput";
            this.openoutput.Size = new System.Drawing.Size(246, 49);
            this.openoutput.TabIndex = 11;
            this.openoutput.Text = "Open Output";
            this.openoutput.UseVisualStyleBackColor = false;
            this.openoutput.Click += new System.EventHandler(this.openoutput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // attachwarn
            // 
            this.attachwarn.AutoSize = true;
            this.attachwarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachwarn.ForeColor = System.Drawing.Color.Red;
            this.attachwarn.Location = new System.Drawing.Point(282, 13);
            this.attachwarn.Name = "attachwarn";
            this.attachwarn.Size = new System.Drawing.Size(115, 20);
            this.attachwarn.TabIndex = 13;
            this.attachwarn.Text = "Not Attached";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(873, 544);
            this.Controls.Add(this.attachwarn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openoutput);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.killrb);
            this.Controls.Add(this.gl);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.inject);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Devsploit";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button inject;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button gl;
        private System.Windows.Forms.Button killrb;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button openoutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label attachwarn;
    }
}
