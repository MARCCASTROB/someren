namespace SomerenUI
{
    partial class ActivityParticipants
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
            Addbutton = new System.Windows.Forms.Button();
            Removebutton = new System.Windows.Forms.Button();
            listBoxParticipants = new System.Windows.Forms.ListBox();
            listBoxNonParticipants = new System.Windows.Forms.ListBox();
            comboBoxActivities = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // Addbutton
            // 
            Addbutton.Location = new System.Drawing.Point(123, 322);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new System.Drawing.Size(108, 39);
            Addbutton.TabIndex = 0;
            Addbutton.Text = "Add";
            Addbutton.UseVisualStyleBackColor = true;
            Addbutton.Click += button1_Click;
            // 
            // Removebutton
            // 
            Removebutton.Location = new System.Drawing.Point(252, 322);
            Removebutton.Name = "Removebutton";
            Removebutton.Size = new System.Drawing.Size(103, 39);
            Removebutton.TabIndex = 1;
            Removebutton.Text = "Remove";
            Removebutton.UseVisualStyleBackColor = true;
            Removebutton.Click += Removebutton_Click;
            // 
            // listBoxParticipants
            // 
            listBoxParticipants.FormattingEnabled = true;
            listBoxParticipants.ItemHeight = 15;
            listBoxParticipants.Location = new System.Drawing.Point(123, 80);
            listBoxParticipants.Name = "listBoxParticipants";
            listBoxParticipants.Size = new System.Drawing.Size(232, 184);
            listBoxParticipants.TabIndex = 2;
            // 
            // listBoxNonParticipants
            // 
            listBoxNonParticipants.FormattingEnabled = true;
            listBoxNonParticipants.ItemHeight = 15;
            listBoxNonParticipants.Location = new System.Drawing.Point(415, 80);
            listBoxNonParticipants.Name = "listBoxNonParticipants";
            listBoxNonParticipants.Size = new System.Drawing.Size(212, 184);
            listBoxNonParticipants.TabIndex = 3;
            // 
            // comboBoxActivities
            // 
            comboBoxActivities.FormattingEnabled = true;
            comboBoxActivities.Location = new System.Drawing.Point(123, 29);
            comboBoxActivities.Name = "comboBoxActivities";
            comboBoxActivities.Size = new System.Drawing.Size(121, 23);
            comboBoxActivities.TabIndex = 4;
            comboBoxActivities.SelectedIndexChanged += comboBoxActivities_SelectedIndexChanged;
            // 
            // ActivityParticipants
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(comboBoxActivities);
            Controls.Add(listBoxNonParticipants);
            Controls.Add(listBoxParticipants);
            Controls.Add(Removebutton);
            Controls.Add(Addbutton);
            Name = "ActivityParticipants";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.ListBox listBoxParticipants;
        private System.Windows.Forms.ListBox listBoxNonParticipants;
        private System.Windows.Forms.ComboBox comboBoxActivities;
    }
}