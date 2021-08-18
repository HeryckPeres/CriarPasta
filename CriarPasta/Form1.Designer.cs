
namespace CriarPasta
{
    partial class Carrier
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Id = new System.Windows.Forms.Label();
            this.IdClient = new System.Windows.Forms.TextBox();
            this.ServiceClient = new System.Windows.Forms.TextBox();
            this.Carriers = new System.Windows.Forms.TextBox();
            this.Transportadora = new System.Windows.Forms.Label();
            this.Service = new System.Windows.Forms.Label();
            this.CreatDirectory = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(143, 9);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(18, 15);
            this.Id.TabIndex = 0;
            this.Id.Text = "ID";
            // 
            // IdClient
            // 
            this.IdClient.Location = new System.Drawing.Point(96, 30);
            this.IdClient.Name = "IdClient";
            this.IdClient.Size = new System.Drawing.Size(109, 23);
            this.IdClient.TabIndex = 1;
            // 
            // ServiceClient
            // 
            this.ServiceClient.Location = new System.Drawing.Point(95, 140);
            this.ServiceClient.Name = "ServiceClient";
            this.ServiceClient.Size = new System.Drawing.Size(110, 23);
            this.ServiceClient.TabIndex = 2;
            // 
            // Carriers
            // 
            this.Carriers.Location = new System.Drawing.Point(96, 85);
            this.Carriers.Name = "Carriers";
            this.Carriers.Size = new System.Drawing.Size(109, 23);
            this.Carriers.TabIndex = 3;
            // 
            // Transportadora
            // 
            this.Transportadora.AutoSize = true;
            this.Transportadora.Location = new System.Drawing.Point(95, 67);
            this.Transportadora.Name = "Transportadora";
            this.Transportadora.Size = new System.Drawing.Size(110, 15);
            this.Transportadora.TabIndex = 4;
            this.Transportadora.Text = "TRANSPORTADORA";
            // 
            // Service
            // 
            this.Service.AutoSize = true;
            this.Service.Location = new System.Drawing.Point(124, 122);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(53, 15);
            this.Service.TabIndex = 5;
            this.Service.Text = "SERVIÇO";
            // 
            // CreatDirectory
            // 
            this.CreatDirectory.Location = new System.Drawing.Point(42, 184);
            this.CreatDirectory.Name = "CreatDirectory";
            this.CreatDirectory.Size = new System.Drawing.Size(81, 27);
            this.CreatDirectory.TabIndex = 6;
            this.CreatDirectory.Text = "Integração";
            this.CreatDirectory.UseVisualStyleBackColor = true;
            this.CreatDirectory.Click += new System.EventHandler(this.CreatDirectory_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(172, 184);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(86, 27);
            this.Update.TabIndex = 7;
            this.Update.Text = "Atualização";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Carrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 268);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.CreatDirectory);
            this.Controls.Add(this.Service);
            this.Controls.Add(this.Transportadora);
            this.Controls.Add(this.Carriers);
            this.Controls.Add(this.ServiceClient);
            this.Controls.Add(this.IdClient);
            this.Controls.Add(this.Id);
            this.Name = "Carrier";
            this.Text = "Pasta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox IdClient;
        private System.Windows.Forms.TextBox ServiceClient;
        private System.Windows.Forms.TextBox Carriers;
        private System.Windows.Forms.Label Transportadora;
        private System.Windows.Forms.Label Service;
        private System.Windows.Forms.Button CreatDirectory;
        private System.Windows.Forms.Button Update;
    }
}

