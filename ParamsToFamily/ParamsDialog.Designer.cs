namespace ParamsToFamily
{
    partial class ParamsDialog
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtbxParParentName = new System.Windows.Forms.TextBox();
            this.lblParParentName = new System.Windows.Forms.Label();
            this.lblParNestedName = new System.Windows.Forms.Label();
            this.txtbxParNestedName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.rbSymbolPar = new System.Windows.Forms.RadioButton();
            this.rbInst = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(15, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 30);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtbxParParentName
            // 
            this.txtbxParParentName.Location = new System.Drawing.Point(15, 30);
            this.txtbxParParentName.Name = "txtbxParParentName";
            this.txtbxParParentName.Size = new System.Drawing.Size(257, 20);
            this.txtbxParParentName.TabIndex = 1;
            // 
            // lblParParentName
            // 
            this.lblParParentName.AutoSize = true;
            this.lblParParentName.Location = new System.Drawing.Point(12, 10);
            this.lblParParentName.Name = "lblParParentName";
            this.lblParParentName.Size = new System.Drawing.Size(224, 13);
            this.lblParParentName.TabIndex = 2;
            this.lblParParentName.Text = "Имя параметра родительского семейства";
            this.lblParParentName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblParNestedName
            // 
            this.lblParNestedName.AutoSize = true;
            this.lblParNestedName.Location = new System.Drawing.Point(12, 60);
            this.lblParNestedName.Name = "lblParNestedName";
            this.lblParNestedName.Size = new System.Drawing.Size(199, 13);
            this.lblParNestedName.TabIndex = 4;
            this.lblParNestedName.Text = "Имя параметра вложенных семейств";
            // 
            // txtbxParNestedName
            // 
            this.txtbxParNestedName.Location = new System.Drawing.Point(15, 80);
            this.txtbxParNestedName.Name = "txtbxParNestedName";
            this.txtbxParNestedName.Size = new System.Drawing.Size(257, 20);
            this.txtbxParNestedName.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 160);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(129, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Тип объекта параметра";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(12, 110);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(124, 13);
            this.lblCat.TabIndex = 8;
            this.lblCat.Text = "Категория параметров";
            this.lblCat.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbSymbolPar
            // 
            this.rbSymbolPar.AutoSize = true;
            this.rbSymbolPar.Location = new System.Drawing.Point(15, 203);
            this.rbSymbolPar.Name = "rbSymbolPar";
            this.rbSymbolPar.Size = new System.Drawing.Size(102, 17);
            this.rbSymbolPar.TabIndex = 9;
            this.rbSymbolPar.TabStop = true;
            this.rbSymbolPar.Text = "Параметр типа";
            this.rbSymbolPar.UseVisualStyleBackColor = true;
            // 
            // rbInst
            // 
            this.rbInst.AutoSize = true;
            this.rbInst.Location = new System.Drawing.Point(123, 203);
            this.rbInst.Name = "rbInst";
            this.rbInst.Size = new System.Drawing.Size(141, 17);
            this.rbInst.TabIndex = 10;
            this.rbInst.TabStop = true;
            this.rbInst.Text = "Параметр экземпляра";
            this.rbInst.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(162, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // ParamsDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rbInst);
            this.Controls.Add(this.rbSymbolPar);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblParNestedName);
            this.Controls.Add(this.txtbxParNestedName);
            this.Controls.Add(this.lblParParentName);
            this.Controls.Add(this.txtbxParParentName);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ParamsDialog";
            this.Text = "Добавление параметров";
            this.Load += new System.EventHandler(this.ParamsDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtbxParParentName;
        private System.Windows.Forms.Label lblParParentName;
        private System.Windows.Forms.Label lblParNestedName;
        private System.Windows.Forms.TextBox txtbxParNestedName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.RadioButton rbSymbolPar;
        private System.Windows.Forms.RadioButton rbInst;
        private System.Windows.Forms.Button btnCancel;
    }
}