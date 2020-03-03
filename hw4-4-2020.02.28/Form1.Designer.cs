namespace hw4_4_2020._02._28
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Atomicbrush_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pencil_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eraser_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruler_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liquid_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atomicbrush = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pencil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eraser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liquid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesName,
            this.Atomicbrush,
            this.Pencil,
            this.Eraser,
            this.Ruler,
            this.Liquid,
            this.SalesTotal});
            this.dataGridView1.Location = new System.Drawing.Point(28, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 95);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Atomicbrush_t,
            this.Pencil_t,
            this.Eraser_t,
            this.Ruler_t,
            this.Liquid_t});
            this.dataGridView2.Location = new System.Drawing.Point(28, 198);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(544, 47);
            this.dataGridView2.TabIndex = 1;
            // 
            // Atomicbrush_t
            // 
            this.Atomicbrush_t.DataPropertyName = "Atomicbrush_t";
            this.Atomicbrush_t.HeaderText = "原子筆";
            this.Atomicbrush_t.Name = "Atomicbrush_t";
            this.Atomicbrush_t.ReadOnly = true;
            // 
            // Pencil_t
            // 
            this.Pencil_t.DataPropertyName = "Pencil_t";
            this.Pencil_t.HeaderText = "鉛筆";
            this.Pencil_t.Name = "Pencil_t";
            this.Pencil_t.ReadOnly = true;
            // 
            // Eraser_t
            // 
            this.Eraser_t.DataPropertyName = "Eraser_t";
            this.Eraser_t.HeaderText = "橡皮擦";
            this.Eraser_t.Name = "Eraser_t";
            this.Eraser_t.ReadOnly = true;
            // 
            // Ruler_t
            // 
            this.Ruler_t.DataPropertyName = "Ruler_t";
            this.Ruler_t.HeaderText = "直尺";
            this.Ruler_t.Name = "Ruler_t";
            this.Ruler_t.ReadOnly = true;
            // 
            // Liquid_t
            // 
            this.Liquid_t.DataPropertyName = "Liquid_t";
            this.Liquid_t.HeaderText = "立可白";
            this.Liquid_t.Name = "Liquid_t";
            this.Liquid_t.ReadOnly = true;
            // 
            // SalesName
            // 
            this.SalesName.DataPropertyName = "SalesName";
            this.SalesName.HeaderText = "業務員";
            this.SalesName.Name = "SalesName";
            this.SalesName.ReadOnly = true;
            // 
            // Atomicbrush
            // 
            this.Atomicbrush.DataPropertyName = "Atomicbrush";
            this.Atomicbrush.HeaderText = "原子筆(支)";
            this.Atomicbrush.Name = "Atomicbrush";
            this.Atomicbrush.ReadOnly = true;
            // 
            // Pencil
            // 
            this.Pencil.DataPropertyName = "Pencil";
            this.Pencil.HeaderText = "鉛筆(支)";
            this.Pencil.Name = "Pencil";
            this.Pencil.ReadOnly = true;
            // 
            // Eraser
            // 
            this.Eraser.DataPropertyName = "Eraser";
            this.Eraser.HeaderText = "橡皮擦(個)";
            this.Eraser.Name = "Eraser";
            this.Eraser.ReadOnly = true;
            // 
            // Ruler
            // 
            this.Ruler.DataPropertyName = "Ruler";
            this.Ruler.HeaderText = "直尺(個)";
            this.Ruler.Name = "Ruler";
            this.Ruler.ReadOnly = true;
            // 
            // Liquid
            // 
            this.Liquid.DataPropertyName = "Liquid";
            this.Liquid.HeaderText = "立可白(個)";
            this.Liquid.Name = "Liquid";
            this.Liquid.ReadOnly = true;
            // 
            // SalesTotal
            // 
            this.SalesTotal.DataPropertyName = "SalesTotal";
            this.SalesTotal.HeaderText = "銷售總金額";
            this.SalesTotal.Name = "SalesTotal";
            this.SalesTotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atomicbrush_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pencil_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eraser_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruler_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liquid_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atomicbrush;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pencil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eraser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liquid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

