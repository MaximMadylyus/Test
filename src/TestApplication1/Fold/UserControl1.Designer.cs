namespace TestApplication1.Fold
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainBtn = new System.Windows.Forms.Button();
            this.helloRichTextBox = new System.Windows.Forms.RichTextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainBtn
            // 
            this.mainBtn.Location = new System.Drawing.Point(3, 3);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(54, 23);
            this.mainBtn.TabIndex = 0;
            this.mainBtn.Text = "Show";
            this.mainBtn.UseVisualStyleBackColor = true;
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);
            // 
            // helloRichTextBox
            // 
            this.helloRichTextBox.Location = new System.Drawing.Point(3, 32);
            this.helloRichTextBox.Name = "helloRichTextBox";
            this.helloRichTextBox.Size = new System.Drawing.Size(144, 96);
            this.helloRichTextBox.TabIndex = 1;
            this.helloRichTextBox.Text = "";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(93, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(54, 23);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.helloRichTextBox);
            this.Controls.Add(this.mainBtn);
            this.Name = "UserControl1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainBtn;
        private System.Windows.Forms.RichTextBox helloRichTextBox;
        private System.Windows.Forms.Button clearBtn;
    }
}
