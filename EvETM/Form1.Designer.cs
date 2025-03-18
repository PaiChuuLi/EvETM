using System.Windows.Forms;

namespace EvETM
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
               
                components.Dispose();
                

            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splConntainer = new System.Windows.Forms.SplitContainer();
            this.btnBuyOrder = new System.Windows.Forms.Button();
            this.btnIndustry = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.pnIndustry = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splConntainer)).BeginInit();
            this.splConntainer.Panel1.SuspendLayout();
            this.splConntainer.Panel2.SuspendLayout();
            this.splConntainer.SuspendLayout();
            this.pnIndustry.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splConntainer
            // 
            this.splConntainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splConntainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splConntainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splConntainer.IsSplitterFixed = true;
            this.splConntainer.Location = new System.Drawing.Point(0, 0);
            this.splConntainer.Name = "splConntainer";
            // 
            // splConntainer.Panel1
            // 
            this.splConntainer.Panel1.Controls.Add(this.btnBuyOrder);
            this.splConntainer.Panel1.Controls.Add(this.btnIndustry);
            this.splConntainer.Panel1.Controls.Add(this.btnMainMenu);
            this.splConntainer.Panel1MinSize = 217;
            // 
            // splConntainer.Panel2
            // 
            this.splConntainer.Panel2.Controls.Add(this.pnIndustry);
            this.splConntainer.Panel2.Controls.Add(this.pnMain);
            this.splConntainer.Size = new System.Drawing.Size(2298, 1268);
            this.splConntainer.SplitterDistance = 217;
            this.splConntainer.TabIndex = 0;
            // 
            // btnBuyOrder
            // 
            this.btnBuyOrder.Location = new System.Drawing.Point(12, 224);
            this.btnBuyOrder.Name = "btnBuyOrder";
            this.btnBuyOrder.Size = new System.Drawing.Size(300, 100);
            this.btnBuyOrder.TabIndex = 2;
            this.btnBuyOrder.Text = "Buy Order";
            this.btnBuyOrder.UseVisualStyleBackColor = true;
            // 
            // btnIndustry
            // 
            this.btnIndustry.Location = new System.Drawing.Point(12, 118);
            this.btnIndustry.Name = "btnIndustry";
            this.btnIndustry.Size = new System.Drawing.Size(300, 100);
            this.btnIndustry.TabIndex = 1;
            this.btnIndustry.Text = "Industry";
            this.btnIndustry.UseVisualStyleBackColor = true;
            this.btnIndustry.Click += new System.EventHandler(this.btnIndustry_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(300, 100);
            this.btnMainMenu.TabIndex = 0;
            this.btnMainMenu.Text = "Main";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // pnIndustry
            // 
            this.pnIndustry.Controls.Add(this.label2);
            this.pnIndustry.Location = new System.Drawing.Point(4, 4);
            this.pnIndustry.Name = "pnIndustry";
            this.pnIndustry.Size = new System.Drawing.Size(681, 483);
            this.pnIndustry.TabIndex = 1;
            this.pnIndustry.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "INDUSTRY";
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Location = new System.Drawing.Point(4, 4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1000, 1000);
            this.pnMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2298, 1268);
            this.Controls.Add(this.splConntainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splConntainer.Panel1.ResumeLayout(false);
            this.splConntainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splConntainer)).EndInit();
            this.splConntainer.ResumeLayout(false);
            this.pnIndustry.ResumeLayout(false);
            this.pnIndustry.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private SplitContainer splConntainer;
        private Button btnMainMenu;
        private Button btnBuyOrder;
        private Button btnIndustry;
        private Panel pnIndustry;
        private Label label2;
        private Panel pnMain;
        private Label label1;
    }
}

