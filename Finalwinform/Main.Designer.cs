namespace Finalwinform
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arriveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.requestStatusToolStripMenuItem,
            this.pendingNoteToolStripMenuItem,
            this.arriveNoteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // requestStatusToolStripMenuItem
            // 
            this.requestStatusToolStripMenuItem.Name = "requestStatusToolStripMenuItem";
            this.requestStatusToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.requestStatusToolStripMenuItem.Text = "RequestStatus";
            this.requestStatusToolStripMenuItem.Click += new System.EventHandler(this.requestStatusToolStripMenuItem_Click);
            // 
            // pendingNoteToolStripMenuItem
            // 
            this.pendingNoteToolStripMenuItem.Name = "pendingNoteToolStripMenuItem";
            this.pendingNoteToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.pendingNoteToolStripMenuItem.Text = "PendingNote";
            this.pendingNoteToolStripMenuItem.Click += new System.EventHandler(this.pendingNoteToolStripMenuItem_Click);
            // 
            // arriveNoteToolStripMenuItem
            // 
            this.arriveNoteToolStripMenuItem.Name = "arriveNoteToolStripMenuItem";
            this.arriveNoteToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.arriveNoteToolStripMenuItem.Text = "ArriveNote";
            this.arriveNoteToolStripMenuItem.Click += new System.EventHandler(this.arriveNoteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "By LeHuyTai_519C0136";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arriveNoteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

