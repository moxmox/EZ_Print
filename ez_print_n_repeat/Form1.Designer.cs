namespace ez_print_n_repeat
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
            this.choose_folder_label = new System.Windows.Forms.Label();
            this.choose_folder_button = new System.Windows.Forms.Button();
            this.Print_Button = new System.Windows.Forms.Button();
            this.FilesListView = new System.Windows.Forms.ListView();
            this.printer_select_combo_box = new System.Windows.Forms.ComboBox();
            this.printer_select_button = new System.Windows.Forms.Label();
            this.print_progress_bar = new System.Windows.Forms.ProgressBar();
            this.print_progress_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choose_folder_label
            // 
            this.choose_folder_label.AutoSize = true;
            this.choose_folder_label.Location = new System.Drawing.Point(186, 49);
            this.choose_folder_label.Name = "choose_folder_label";
            this.choose_folder_label.Size = new System.Drawing.Size(245, 20);
            this.choose_folder_label.TabIndex = 0;
            this.choose_folder_label.Text = "Choose a Folder to Print From . . .";
            // 
            // choose_folder_button
            // 
            this.choose_folder_button.Location = new System.Drawing.Point(42, 41);
            this.choose_folder_button.Name = "choose_folder_button";
            this.choose_folder_button.Size = new System.Drawing.Size(121, 36);
            this.choose_folder_button.TabIndex = 1;
            this.choose_folder_button.Text = "Choose";
            this.choose_folder_button.UseVisualStyleBackColor = true;
            this.choose_folder_button.Click += new System.EventHandler(this.choose_folder_button_Click);
            // 
            // Print_Button
            // 
            this.Print_Button.Location = new System.Drawing.Point(564, 369);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(256, 46);
            this.Print_Button.TabIndex = 3;
            this.Print_Button.Text = "Print";
            this.Print_Button.UseVisualStyleBackColor = true;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
            // 
            // FilesListView
            // 
            this.FilesListView.GridLines = true;
            this.FilesListView.Location = new System.Drawing.Point(42, 97);
            this.FilesListView.Name = "FilesListView";
            this.FilesListView.Size = new System.Drawing.Size(488, 247);
            this.FilesListView.TabIndex = 4;
            this.FilesListView.UseCompatibleStateImageBehavior = false;
            // 
            // printer_select_combo_box
            // 
            this.printer_select_combo_box.FormattingEnabled = true;
            this.printer_select_combo_box.Location = new System.Drawing.Point(564, 133);
            this.printer_select_combo_box.Name = "printer_select_combo_box";
            this.printer_select_combo_box.Size = new System.Drawing.Size(256, 28);
            this.printer_select_combo_box.TabIndex = 6;
            this.printer_select_combo_box.SelectedIndexChanged += new System.EventHandler(this.printer_select_combo_box_SelectedIndexChanged);
            // 
            // printer_select_button
            // 
            this.printer_select_button.AutoSize = true;
            this.printer_select_button.Location = new System.Drawing.Point(560, 97);
            this.printer_select_button.Name = "printer_select_button";
            this.printer_select_button.Size = new System.Drawing.Size(108, 20);
            this.printer_select_button.TabIndex = 7;
            this.printer_select_button.Text = "Select Printer:";
            this.printer_select_button.Click += new System.EventHandler(this.printer_select_button_Click);
            // 
            // print_progress_bar
            // 
            this.print_progress_bar.Location = new System.Drawing.Point(190, 384);
            this.print_progress_bar.Name = "print_progress_bar";
            this.print_progress_bar.Size = new System.Drawing.Size(340, 31);
            this.print_progress_bar.TabIndex = 8;
            this.print_progress_bar.Visible = false;
            // 
            // print_progress_label
            // 
            this.print_progress_label.AutoSize = true;
            this.print_progress_label.Location = new System.Drawing.Point(38, 384);
            this.print_progress_label.Name = "print_progress_label";
            this.print_progress_label.Size = new System.Drawing.Size(86, 20);
            this.print_progress_label.TabIndex = 9;
            this.print_progress_label.Text = "Printing . . .";
            this.print_progress_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 437);
            this.Controls.Add(this.print_progress_label);
            this.Controls.Add(this.print_progress_bar);
            this.Controls.Add(this.printer_select_button);
            this.Controls.Add(this.printer_select_combo_box);
            this.Controls.Add(this.FilesListView);
            this.Controls.Add(this.Print_Button);
            this.Controls.Add(this.choose_folder_button);
            this.Controls.Add(this.choose_folder_label);
            this.Name = "Form1";
            this.Text = "EZ Print & Repeat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choose_folder_label;
        private System.Windows.Forms.Button choose_folder_button;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.ListView FilesListView;
        private System.Windows.Forms.ComboBox printer_select_combo_box;
        private System.Windows.Forms.Label printer_select_button;
        private System.Windows.Forms.ProgressBar print_progress_bar;
        private System.Windows.Forms.Label print_progress_label;
    }
}

