﻿namespace Ajouter_Chefeur
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
            this.id = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.salaire = new System.Windows.Forms.TextBox();
            this.dateRecrutement = new System.Windows.Forms.DateTimePicker();
            this.Ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(165, 66);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 0;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(165, 111);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 1;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(165, 157);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 20);
            this.prenom.TabIndex = 2;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(165, 211);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(100, 20);
            this.adresse.TabIndex = 3;
            // 
            // salaire
            // 
            this.salaire.Location = new System.Drawing.Point(165, 266);
            this.salaire.Name = "salaire";
            this.salaire.Size = new System.Drawing.Size(100, 20);
            this.salaire.TabIndex = 4;
            // 
            // dateRecrutement
            // 
            this.dateRecrutement.Location = new System.Drawing.Point(165, 322);
            this.dateRecrutement.Name = "dateRecrutement";
            this.dateRecrutement.Size = new System.Drawing.Size(200, 20);
            this.dateRecrutement.TabIndex = 5;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(423, 66);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 6;
            this.Ajouter.Text = "Ajoute";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "salaire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "date recrutement";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 442);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.dateRecrutement);
            this.Controls.Add(this.salaire);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox salaire;
        private System.Windows.Forms.DateTimePicker dateRecrutement;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

