namespace TSA_Phoenix_Tunnels
{
    partial class frmTunnelInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTunnelInterface));
            this.ctrlOpcTsaBag1 = new Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag();
            this.SuspendLayout();
            // 
            // ctrlOpcTsaBag1
            // 
            this.ctrlOpcTsaBag1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlOpcTsaBag1.BagBackColor = System.Drawing.SystemColors.Control;
            this.ctrlOpcTsaBag1.BagMode = Wdw_Sust.Core.Enums.FormMode.NORMAL;
            this.ctrlOpcTsaBag1.BagRundownZone = Wdw_Sust.Textile.Core.Enums.LintRundownZone.UNKNOWN;
            this.ctrlOpcTsaBag1.BagTextColor = System.Drawing.Color.Black;
            this.ctrlOpcTsaBag1.Category = 88;
            this.ctrlOpcTsaBag1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlOpcTsaBag1.GroupName = "arTunnel_7_Bag_Buffer[0]";
            this.ctrlOpcTsaBag1.Location = new System.Drawing.Point(14, 699);
            this.ctrlOpcTsaBag1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlOpcTsaBag1.Name = "ctrlOpcTsaBag1";
            this.ctrlOpcTsaBag1.PLC_Bag_ID = 0;
            this.ctrlOpcTsaBag1.PlcName = "TSA_Aquamizer";
            this.ctrlOpcTsaBag1.Size = new System.Drawing.Size(36, 36);
            this.ctrlOpcTsaBag1.TabIndex = 0;
            this.ctrlOpcTsaBag1.TagName = "Category";
            this.ctrlOpcTsaBag1.Zone = Wdw_Sust.Textile.Core.Enums.LintZone.UNKNOWN;
            this.ctrlOpcTsaBag1.Load += new System.EventHandler(this.ctrlOpcTsaBag1_Load);
            // 
            // frmTunnelInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(478, 890);
            this.Controls.Add(this.ctrlOpcTsaBag1);
            this.Name = "frmTunnelInterface";
            this.Text = "Phoenix  Tunnels";
            this.ResumeLayout(false);

        }

        #endregion

        private Wdw_Sust.Textile.Tsa.Opc.WinForms.CtrlOpcTsaBag ctrlOpcTsaBag1;
    }
}

