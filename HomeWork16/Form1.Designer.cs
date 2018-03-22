namespace HomeWork16
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
            this.String = new System.Windows.Forms.Label();
            this.String1 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Label();
            this.PathValue = new System.Windows.Forms.TextBox();
            this.TextString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ResultSearch = new System.Windows.Forms.ListBox();
            this.ExtValue1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // String
            // 
            this.String.AutoSize = true;
            this.String.Location = new System.Drawing.Point(29, 40);
            this.String.Name = "String";
            this.String.Size = new System.Drawing.Size(25, 13);
            this.String.TabIndex = 1;
            this.String.Text = "Ext ";
            // 
            // String1
            // 
            this.String1.AutoSize = true;
            this.String1.Location = new System.Drawing.Point(29, 66);
            this.String1.Name = "String1";
            this.String1.Size = new System.Drawing.Size(34, 13);
            this.String1.TabIndex = 2;
            this.String1.Text = "String";
            this.String1.Click += new System.EventHandler(this.String1_Click);
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Location = new System.Drawing.Point(29, 95);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(42, 13);
            this.Results.TabIndex = 3;
            this.Results.Text = "Results";
            this.Results.Click += new System.EventHandler(this.Results_Click);
            // 
            // PathValue
            // 
            this.PathValue.Location = new System.Drawing.Point(71, 6);
            this.PathValue.Name = "PathValue";
            this.PathValue.Size = new System.Drawing.Size(119, 20);
            this.PathValue.TabIndex = 4;
            this.PathValue.TextChanged += new System.EventHandler(this.PathValue_TextChanged);
            // 
            // TextString
            // 
            this.TextString.Location = new System.Drawing.Point(70, 58);
            this.TextString.Name = "TextString";
            this.TextString.Size = new System.Drawing.Size(122, 20);
            this.TextString.TabIndex = 6;
            this.TextString.TextChanged += new System.EventHandler(this.TextString_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path ";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(-5, 189);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(159, 189);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ResultSearch
            // 
            this.ResultSearch.FormattingEnabled = true;
            this.ResultSearch.Location = new System.Drawing.Point(70, 95);
            this.ResultSearch.Name = "ResultSearch";
            this.ResultSearch.Size = new System.Drawing.Size(120, 95);
            this.ResultSearch.TabIndex = 10;
            this.ResultSearch.SelectedIndexChanged += new System.EventHandler(this.ResultSearch_SelectedIndexChanged);
            // 
            // ExtValue1
            // 
            this.ExtValue1.Location = new System.Drawing.Point(71, 32);
            this.ExtValue1.Name = "ExtValue1";
            this.ExtValue1.Size = new System.Drawing.Size(119, 20);
            this.ExtValue1.TabIndex = 11;
            this.ExtValue1.TextChanged += new System.EventHandler(this.ExtValue1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 261);
            this.Controls.Add(this.ExtValue1);
            this.Controls.Add(this.ResultSearch);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextString);
            this.Controls.Add(this.PathValue);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.String1);
            this.Controls.Add(this.String);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label String;
        private System.Windows.Forms.Label String1;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.TextBox PathValue;
        private System.Windows.Forms.TextBox TextString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ListBox ResultSearch;
        private System.Windows.Forms.TextBox ExtValue1;
    }
}

