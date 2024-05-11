namespace 不同的语言数据库
{
    partial class shujuku
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shujuku));
            this.txBox_cí = new System.Windows.Forms.TextBox();
            this.cB_yǔyán = new System.Windows.Forms.ComboBox();
            this.lb_translation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txBox_cí
            // 
            this.txBox_cí.Location = new System.Drawing.Point(22, 45);
            this.txBox_cí.Name = "txBox_cí";
            this.txBox_cí.Size = new System.Drawing.Size(100, 20);
            this.txBox_cí.TabIndex = 0;
            // 
            // cB_yǔyán
            // 
            this.cB_yǔyán.FormattingEnabled = true;
            this.cB_yǔyán.Items.AddRange(new object[] {
            "西语",
            "英语",
            "葡萄牙语",
            "法语",
            "意大利语",
            "德语",
            "俄语",
            "汉语",
            "日语",
            "韩语"});
            this.cB_yǔyán.Location = new System.Drawing.Point(152, 45);
            this.cB_yǔyán.Name = "cB_yǔyán";
            this.cB_yǔyán.Size = new System.Drawing.Size(121, 21);
            this.cB_yǔyán.TabIndex = 1;
            this.cB_yǔyán.SelectedIndexChanged += new System.EventHandler(this.cB_yǔyán_SelectedIndexChanged);
            // 
            // lb_translation
            // 
            this.lb_translation.AutoSize = true;
            this.lb_translation.Location = new System.Drawing.Point(304, 52);
            this.lb_translation.Name = "lb_translation";
            this.lb_translation.Size = new System.Drawing.Size(0, 13);
            this.lb_translation.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "写一个词";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "选择语言";
            // 
            // shujuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 140);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_translation);
            this.Controls.Add(this.cB_yǔyán);
            this.Controls.Add(this.txBox_cí);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "shujuku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBox_cí;
        private System.Windows.Forms.ComboBox cB_yǔyán;
        private System.Windows.Forms.Label lb_translation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

