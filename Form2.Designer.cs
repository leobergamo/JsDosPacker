namespace JsDosPacker
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            tbEditor = new TextBox();
            btnCancel = new Button();
            btnOk = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // tbEditor
            // 
            tbEditor.Location = new Point(12, 12);
            tbEditor.Multiline = true;
            tbEditor.Name = "tbEditor";
            tbEditor.ScrollBars = ScrollBars.Both;
            tbEditor.Size = new Size(984, 588);
            tbEditor.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(921, 694);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(840, 694);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(759, 694);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            ControlBox = false;
            Controls.Add(btnReset);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(tbEditor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JsDos Packer - Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox tbEditor;
        private Button btnCancel;
        private Button btnOk;
        private Button btnReset;
    }
}