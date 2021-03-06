using System.ComponentModel;

namespace MoneyManager
{
    partial class ItemSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.attemt = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // attemt
            // 
            this.attemt.Location = new System.Drawing.Point(70, 139);
            this.attemt.Name = "attemt";
            this.attemt.Size = new System.Drawing.Size(99, 22);
            this.attemt.TabIndex = 2;
            this.attemt.Text = "Принять";
            this.attemt.UseVisualStyleBackColor = true;
            this.attemt.Click += new System.EventHandler(this.AttemtClicked);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(124, 37);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(105, 20);
            this.price.TabIndex = 3;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceKeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(125, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(12, 98);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(99, 20);
            this.total.TabIndex = 6;
            this.total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalKeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(125, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Комментарий";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(124, 98);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(105, 20);
            this.comment.TabIndex = 8;
            // 
            // ItemSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 173);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price);
            this.Controls.Add(this.attemt);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ItemSetting";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox comment;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox total;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button attemt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;

        #endregion
    }
}