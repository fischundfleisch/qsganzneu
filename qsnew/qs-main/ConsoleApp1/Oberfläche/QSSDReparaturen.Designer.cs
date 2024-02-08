using MailInterop;

namespace Oberfläche
{
    partial class SDReparatur
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       
        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListItemRep = new System.Windows.Forms.ListBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonLog = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ListItemRep
            // 
            this.ListItemRep.FormattingEnabled = true;
            this.ListItemRep.Location = new System.Drawing.Point(12, 49);
            this.ListItemRep.Name = "ListItemRep";
            this.ListItemRep.Size = new System.Drawing.Size(470, 576);
            this.ListItemRep.TabIndex = 0;
            this.ListItemRep.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(12, 9);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(40, 13);
            this.LabelStatus.TabIndex = 1;
            this.LabelStatus.Text = "Status:";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(541, 49);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(174, 96);
            this.ButtonStart.TabIndex = 2;
            this.ButtonStart.Text = "Ausführen";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(541, 186);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(174, 102);
            this.ButtonStop.TabIndex = 3;
            this.ButtonStop.Text = "Abbrechen";
            this.ButtonStop.UseVisualStyleBackColor = true;
            // 
            // ButtonLog
            // 
            this.ButtonLog.Location = new System.Drawing.Point(541, 323);
            this.ButtonLog.Name = "ButtonLog";
            this.ButtonLog.Size = new System.Drawing.Size(174, 95);
            this.ButtonLog.TabIndex = 4;
            this.ButtonLog.Text = "Logfile anzeigen";
            this.ButtonLog.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(541, 445);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Warte";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // SDReparatur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 640);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.ButtonLog);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.ListItemRep);
            this.Name = "SDReparatur";
            this.Text = "SDReparatur";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListItemRep;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonLog;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

