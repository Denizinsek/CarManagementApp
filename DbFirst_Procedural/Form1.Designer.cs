namespace DbFirst_Procedural
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
            this.TxtBxNameSurname = new System.Windows.Forms.TextBox();
            this.TxtBxTc = new System.Windows.Forms.TextBox();
            this.TxtBxProduct = new System.Windows.Forms.TextBox();
            this.TxtBxPrice = new System.Windows.Forms.TextBox();
            this.DGridView = new System.Windows.Forms.DataGridView();
            this.TxtSearching = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch_Name = new System.Windows.Forms.Button();
            this.BtnSearch_Tc = new System.Windows.Forms.Button();
            this.BtnFindMe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(96, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aldığı Ürün:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(42, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Satış Fiyatı:";
            // 
            // TxtBxNameSurname
            // 
            this.TxtBxNameSurname.Location = new System.Drawing.Point(123, 46);
            this.TxtBxNameSurname.Name = "TxtBxNameSurname";
            this.TxtBxNameSurname.Size = new System.Drawing.Size(213, 20);
            this.TxtBxNameSurname.TabIndex = 4;
            // 
            // TxtBxTc
            // 
            this.TxtBxTc.Location = new System.Drawing.Point(123, 92);
            this.TxtBxTc.Name = "TxtBxTc";
            this.TxtBxTc.Size = new System.Drawing.Size(213, 20);
            this.TxtBxTc.TabIndex = 5;
            // 
            // TxtBxProduct
            // 
            this.TxtBxProduct.Location = new System.Drawing.Point(123, 138);
            this.TxtBxProduct.Name = "TxtBxProduct";
            this.TxtBxProduct.Size = new System.Drawing.Size(213, 20);
            this.TxtBxProduct.TabIndex = 6;
            // 
            // TxtBxPrice
            // 
            this.TxtBxPrice.Location = new System.Drawing.Point(123, 184);
            this.TxtBxPrice.Name = "TxtBxPrice";
            this.TxtBxPrice.Size = new System.Drawing.Size(213, 20);
            this.TxtBxPrice.TabIndex = 7;
            // 
            // DGridView
            // 
            this.DGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView.Location = new System.Drawing.Point(342, 8);
            this.DGridView.Name = "DGridView";
            this.DGridView.Size = new System.Drawing.Size(624, 373);
            this.DGridView.TabIndex = 8;
            this.DGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridView_CellClick);
            // 
            // TxtSearching
            // 
            this.TxtSearching.Location = new System.Drawing.Point(342, 402);
            this.TxtSearching.Name = "TxtSearching";
            this.TxtSearching.Size = new System.Drawing.Size(213, 20);
            this.TxtSearching.TabIndex = 9;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(123, 228);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(89, 53);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(247, 228);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(89, 53);
            this.BtnList.TabIndex = 11;
            this.BtnList.Text = "Listele";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(123, 287);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(89, 53);
            this.BtnUpdate.TabIndex = 12;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(247, 287);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(89, 53);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSearch_Name
            // 
            this.BtnSearch_Name.Location = new System.Drawing.Point(561, 387);
            this.BtnSearch_Name.Name = "BtnSearch_Name";
            this.BtnSearch_Name.Size = new System.Drawing.Size(89, 53);
            this.BtnSearch_Name.TabIndex = 14;
            this.BtnSearch_Name.Text = "Ad Ara:";
            this.BtnSearch_Name.UseVisualStyleBackColor = true;
            this.BtnSearch_Name.Click += new System.EventHandler(this.BtnSearch_Name_Click);
            // 
            // BtnSearch_Tc
            // 
            this.BtnSearch_Tc.Location = new System.Drawing.Point(656, 385);
            this.BtnSearch_Tc.Name = "BtnSearch_Tc";
            this.BtnSearch_Tc.Size = new System.Drawing.Size(89, 53);
            this.BtnSearch_Tc.TabIndex = 15;
            this.BtnSearch_Tc.Text = "TC Ara:";
            this.BtnSearch_Tc.UseVisualStyleBackColor = true;
            this.BtnSearch_Tc.Click += new System.EventHandler(this.BtnSearch_Tc_Click);
            // 
            // BtnFindMe
            // 
            this.BtnFindMe.Location = new System.Drawing.Point(751, 385);
            this.BtnFindMe.Name = "BtnFindMe";
            this.BtnFindMe.Size = new System.Drawing.Size(89, 53);
            this.BtnFindMe.TabIndex = 16;
            this.BtnFindMe.Text = "Beni Bul:";
            this.BtnFindMe.UseVisualStyleBackColor = true;
            this.BtnFindMe.Click += new System.EventHandler(this.BtnFindMe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.BtnFindMe);
            this.Controls.Add(this.BtnSearch_Tc);
            this.Controls.Add(this.BtnSearch_Name);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtSearching);
            this.Controls.Add(this.DGridView);
            this.Controls.Add(this.TxtBxPrice);
            this.Controls.Add(this.TxtBxProduct);
            this.Controls.Add(this.TxtBxTc);
            this.Controls.Add(this.TxtBxNameSurname);
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
        private System.Windows.Forms.TextBox TxtBxNameSurname;
        private System.Windows.Forms.TextBox TxtBxTc;
        private System.Windows.Forms.TextBox TxtBxProduct;
        private System.Windows.Forms.TextBox TxtBxPrice;
        private System.Windows.Forms.DataGridView DGridView;
        private System.Windows.Forms.TextBox TxtSearching;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch_Name;
        private System.Windows.Forms.Button BtnSearch_Tc;
        private System.Windows.Forms.Button BtnFindMe;
    }
}

