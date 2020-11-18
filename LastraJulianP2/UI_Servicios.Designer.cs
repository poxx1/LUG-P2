namespace UI
{
    partial class UI_Servicios
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
            this.bt_Insert = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Insert
            // 
            this.bt_Insert.Location = new System.Drawing.Point(283, 13);
            this.bt_Insert.Name = "bt_Insert";
            this.bt_Insert.Size = new System.Drawing.Size(75, 23);
            this.bt_Insert.TabIndex = 0;
            this.bt_Insert.Text = "INSERT";
            this.bt_Insert.UseVisualStyleBackColor = true;
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(283, 43);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(75, 23);
            this.bt_Update.TabIndex = 1;
            this.bt_Update.Text = "UPDATE";
            this.bt_Update.UseVisualStyleBackColor = true;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(283, 73);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_Delete.TabIndex = 2;
            this.bt_Delete.Text = "DELETE";
            this.bt_Delete.UseVisualStyleBackColor = true;
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(283, 103);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(75, 23);
            this.bt_Close.TabIndex = 3;
            this.bt_Close.Text = "CLOSE";
            this.bt_Close.UseVisualStyleBackColor = true;
            // 
            // ABM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.bt_Insert);
            this.Name = "ABM2";
            this.Text = "ABM2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Insert;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Close;
    }
}