﻿namespace BloodAndBaconSaveEditor.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.WeaponsButton = new System.Windows.Forms.Button();
            this.ConsumablesButton = new System.Windows.Forms.Button();
            this.DaysButton = new System.Windows.Forms.Button();
            this.CharactersButton = new System.Windows.Forms.Button();
            this.HatsButton = new System.Windows.Forms.Button();
            this.CollectiblesButton = new System.Windows.Forms.Button();
            this.FlashlightsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(12, 167);
            this.SelectFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(117, 27);
            this.SelectFileButton.TabIndex = 0;
            this.SelectFileButton.Text = "Select save file";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Enabled = false;
            this.SaveFileButton.Location = new System.Drawing.Point(166, 167);
            this.SaveFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(117, 27);
            this.SaveFileButton.TabIndex = 1;
            this.SaveFileButton.Text = "Save as...";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // WeaponsButton
            // 
            this.WeaponsButton.Enabled = false;
            this.WeaponsButton.Location = new System.Drawing.Point(12, 12);
            this.WeaponsButton.Name = "WeaponsButton";
            this.WeaponsButton.Size = new System.Drawing.Size(117, 27);
            this.WeaponsButton.TabIndex = 2;
            this.WeaponsButton.Text = "Weapons";
            this.WeaponsButton.UseVisualStyleBackColor = true;
            this.WeaponsButton.Click += new System.EventHandler(this.WeaponsButton_Click);
            // 
            // ConsumablesButton
            // 
            this.ConsumablesButton.Enabled = false;
            this.ConsumablesButton.Location = new System.Drawing.Point(166, 12);
            this.ConsumablesButton.Name = "ConsumablesButton";
            this.ConsumablesButton.Size = new System.Drawing.Size(117, 27);
            this.ConsumablesButton.TabIndex = 3;
            this.ConsumablesButton.Text = "Consumables";
            this.ConsumablesButton.UseVisualStyleBackColor = true;
            this.ConsumablesButton.Click += new System.EventHandler(this.ConsumablesButton_Click);
            // 
            // DaysButton
            // 
            this.DaysButton.Enabled = false;
            this.DaysButton.Location = new System.Drawing.Point(12, 45);
            this.DaysButton.Name = "DaysButton";
            this.DaysButton.Size = new System.Drawing.Size(117, 27);
            this.DaysButton.TabIndex = 4;
            this.DaysButton.Text = "Days";
            this.DaysButton.UseVisualStyleBackColor = true;
            this.DaysButton.Click += new System.EventHandler(this.DaysButton_Click);
            // 
            // CharactersButton
            // 
            this.CharactersButton.Enabled = false;
            this.CharactersButton.Location = new System.Drawing.Point(166, 45);
            this.CharactersButton.Name = "CharactersButton";
            this.CharactersButton.Size = new System.Drawing.Size(117, 27);
            this.CharactersButton.TabIndex = 5;
            this.CharactersButton.Text = "Characters";
            this.CharactersButton.UseVisualStyleBackColor = true;
            this.CharactersButton.Click += new System.EventHandler(this.CharactersButton_Click);
            // 
            // HatsButton
            // 
            this.HatsButton.Enabled = false;
            this.HatsButton.Location = new System.Drawing.Point(12, 78);
            this.HatsButton.Name = "HatsButton";
            this.HatsButton.Size = new System.Drawing.Size(117, 27);
            this.HatsButton.TabIndex = 6;
            this.HatsButton.Text = "Hats";
            this.HatsButton.UseVisualStyleBackColor = true;
            this.HatsButton.Click += new System.EventHandler(this.HatsButton_Click);
            // 
            // CollectiblesButton
            // 
            this.CollectiblesButton.Enabled = false;
            this.CollectiblesButton.Location = new System.Drawing.Point(166, 78);
            this.CollectiblesButton.Name = "CollectiblesButton";
            this.CollectiblesButton.Size = new System.Drawing.Size(117, 27);
            this.CollectiblesButton.TabIndex = 7;
            this.CollectiblesButton.Text = "Collectibles";
            this.CollectiblesButton.UseVisualStyleBackColor = true;
            this.CollectiblesButton.Click += new System.EventHandler(this.CollectiblesButton_Click);
            // 
            // FlashlightsButton
            // 
            this.FlashlightsButton.Enabled = false;
            this.FlashlightsButton.Location = new System.Drawing.Point(12, 111);
            this.FlashlightsButton.Name = "FlashlightsButton";
            this.FlashlightsButton.Size = new System.Drawing.Size(117, 27);
            this.FlashlightsButton.TabIndex = 8;
            this.FlashlightsButton.Text = "Flashlights";
            this.FlashlightsButton.UseVisualStyleBackColor = true;
            this.FlashlightsButton.Click += new System.EventHandler(this.FlashlightsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 206);
            this.Controls.Add(this.FlashlightsButton);
            this.Controls.Add(this.CollectiblesButton);
            this.Controls.Add(this.HatsButton);
            this.Controls.Add(this.CharactersButton);
            this.Controls.Add(this.DaysButton);
            this.Controls.Add(this.ConsumablesButton);
            this.Controls.Add(this.WeaponsButton);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.SelectFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Blood And Bacon Save Editor";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button WeaponsButton;
        private System.Windows.Forms.Button ConsumablesButton;
        #endregion

        private System.Windows.Forms.Button DaysButton;
        private System.Windows.Forms.Button CharactersButton;
        private System.Windows.Forms.Button HatsButton;
        private System.Windows.Forms.Button CollectiblesButton;
        private System.Windows.Forms.Button FlashlightsButton;
    }
}