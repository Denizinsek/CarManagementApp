namespace DbFirst_NoProcedure
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBxCSerialNo = new System.Windows.Forms.TextBox();
            this.TxtBxBrand = new System.Windows.Forms.TextBox();
            this.TxtBxModel = new System.Windows.Forms.TextBox();
            this.TxtBxColor = new System.Windows.Forms.TextBox();
            this.DGridView = new System.Windows.Forms.DataGridView();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Seri No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(68, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Renk:";
            // 
            // TxtBxCSerialNo
            // 
            this.TxtBxCSerialNo.Location = new System.Drawing.Point(152, 12);
            this.TxtBxCSerialNo.Name = "TxtBxCSerialNo";
            this.TxtBxCSerialNo.Size = new System.Drawing.Size(168, 20);
            this.TxtBxCSerialNo.TabIndex = 4;
            // 
            // TxtBxBrand
            // 
            this.TxtBxBrand.Location = new System.Drawing.Point(152, 70);
            this.TxtBxBrand.Name = "TxtBxBrand";
            this.TxtBxBrand.Size = new System.Drawing.Size(168, 20);
            this.TxtBxBrand.TabIndex = 5;
            // 
            // TxtBxModel
            // 
            this.TxtBxModel.Location = new System.Drawing.Point(152, 128);
            this.TxtBxModel.Name = "TxtBxModel";
            this.TxtBxModel.Size = new System.Drawing.Size(168, 20);
            this.TxtBxModel.TabIndex = 6;
            // 
            // TxtBxColor
            // 
            this.TxtBxColor.Location = new System.Drawing.Point(152, 186);
            this.TxtBxColor.Name = "TxtBxColor";
            this.TxtBxColor.Size = new System.Drawing.Size(168, 20);
            this.TxtBxColor.TabIndex = 7;
            // 
            // DGridView
            // 
            this.DGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView.Location = new System.Drawing.Point(339, 12);
            this.DGridView.Name = "DGridView";
            this.DGridView.Size = new System.Drawing.Size(680, 400);
            this.DGridView.TabIndex = 8;
            this.DGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridView_CellClick);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.Location = new System.Drawing.Point(152, 230);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(79, 46);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.Location = new System.Drawing.Point(241, 230);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(79, 46);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnList
            // 
            this.BtnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnList.Location = new System.Drawing.Point(152, 282);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(79, 46);
            this.BtnList.TabIndex = 11;
            this.BtnList.Text = "Listele";
            this.BtnList.UseVisualStyleBackColor = true;

            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Location = new System.Drawing.Point(241, 282);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(79, 46);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.DGridView);
            this.Controls.Add(this.TxtBxColor);
            this.Controls.Add(this.TxtBxModel);
            this.Controls.Add(this.TxtBxBrand);
            this.Controls.Add(this.TxtBxCSerialNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBxCSerialNo;
        private System.Windows.Forms.TextBox TxtBxBrand;
        private System.Windows.Forms.TextBox TxtBxModel;
        private System.Windows.Forms.TextBox TxtBxColor;
        private System.Windows.Forms.DataGridView DGridView;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnDelete;
    }
}

