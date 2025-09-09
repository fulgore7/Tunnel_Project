using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSA_Phoenix_Tunnels.Logic;

namespace TSA_Phoenix_Tunnels.UI
{
    public partial class MainForm : Form
    {
        private ITagManager _tagManager;

        public MainForm(ITagManager tagManager)
        {
            InitializeComponent();
            _tagManager = tagManager;
            _tagManager.TagUpdated += TagManager_TagUpdated;
        }

        private Button btnWashCycle;
        private Button btnMainQ;
        private TextBox txtCycles;

        private void InitializeComponent()
        {
            this.btnWashCycle = new System.Windows.Forms.Button();
            this.btnMainQ = new System.Windows.Forms.Button();
            this.txtCycles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWashCycle
            // 
            this.btnWashCycle.Location = new System.Drawing.Point(30, 30);
            this.btnWashCycle.Name = "btnWashCycle";
            this.btnWashCycle.Size = new System.Drawing.Size(100, 30);
            this.btnWashCycle.TabIndex = 0;
            this.btnWashCycle.Text = "Wash Cycle";
            this.btnWashCycle.UseVisualStyleBackColor = true;
            this.btnWashCycle.Click += new System.EventHandler(this.btnWashCycle_Click);
            // 
            // btnMainQ
            // 
            this.btnMainQ.Location = new System.Drawing.Point(150, 30);
            this.btnMainQ.Name = "btnMainQ";
            this.btnMainQ.Size = new System.Drawing.Size(100, 30);
            this.btnMainQ.TabIndex = 1;
            this.btnMainQ.Text = "MainQ";
            this.btnMainQ.UseVisualStyleBackColor = true;
            this.btnMainQ.Click += new System.EventHandler(this.btnMainQ_Click);
            // 
            // txtCycles
            // 
            this.txtCycles.Location = new System.Drawing.Point(30, 80);
            this.txtCycles.Name = "txtCycles";
            this.txtCycles.ReadOnly = true;
            this.txtCycles.Size = new System.Drawing.Size(220, 20);
            this.txtCycles.TabIndex = 2;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.txtCycles);
            this.Controls.Add(this.btnMainQ);
            this.Controls.Add(this.btnWashCycle);
            this.Name = "MainForm";
            this.Text = "OPC DA Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnWashCycle_Click(object sender, EventArgs e)
        {
            // Toggle Wash_Cycle tag
            var tag = _tagManager.GetTag("MyPLC.Wash_Cycle");
            bool newValue = !(tag != null && tag.Value is bool && (bool)tag.Value);
            WriteTag("MyPLC.Wash_Cycle", newValue);
        }

        private void btnMainQ_Click(object sender, EventArgs e)
        {
            // Toggle MainQ tag
            var tag = _tagManager.GetTag("MyPLC.MainQ");
            bool newValue = !(tag != null && tag.Value is bool && (bool)tag.Value);
            WriteTag("MyPLC.MainQ", newValue);
        }

        private void WriteTag(string tagName, object value)
        {
            // You need to add a WriteTag method to your IOPCDAClient and TagManager for true write support.
            // For demonstration, you can call directly if implemented in your business logic.
            // Use TagManager's WriteTag method directly
            if (_tagManager != null)
            {
                _tagManager.WriteTag(tagName, value);
            }
        }

        private void TagManager_TagUpdated(object sender, TagUpdatedEventArgs e)
        {
            // Update UI controls when tags change
            if (e.Tag.Name == "MyPLC.Wash_Cycle")
            {
                btnWashCycle.BackColor = (e.Tag.Value is bool && (bool)e.Tag.Value) ? System.Drawing.Color.LightGreen : System.Drawing.Color.LightGray;
            }
            else if (e.Tag.Name == "MyPLC.MainQ")
            {
                btnMainQ.BackColor = (e.Tag.Value is bool && (bool)e.Tag.Value) ? System.Drawing.Color.LightGreen : System.Drawing.Color.LightGray;
            }
            else if (e.Tag.Name == "MyPLC.Cycles")
            {
                txtCycles.Text = e.Tag.Value != null ? e.Tag.Value.ToString() : "";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_tagManager != null)
                _tagManager.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
