namespace BachecaTodeschini
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.bacheca = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descrizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.modbutton = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            this.pricebutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.orderbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.datebox = new System.Windows.Forms.DateTimePicker();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bacheca
            // 
            this.bacheca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nome,
            this.Descrizione,
            this.Data,
            this.Prezzo});
            this.bacheca.HideSelection = false;
            this.bacheca.Location = new System.Drawing.Point(12, 54);
            this.bacheca.Name = "bacheca";
            this.bacheca.Size = new System.Drawing.Size(594, 384);
            this.bacheca.TabIndex = 0;
            this.bacheca.UseCompatibleStateImageBehavior = false;
            this.bacheca.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 52;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 119;
            // 
            // Descrizione
            // 
            this.Descrizione.Text = "Descrizione";
            this.Descrizione.Width = 253;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 99;
            // 
            // Prezzo
            // 
            this.Prezzo.Text = "Prezzo";
            // 
            // namebox
            // 
            this.namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebox.Location = new System.Drawing.Point(12, 26);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(167, 22);
            this.namebox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrizione";
            // 
            // descbox
            // 
            this.descbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descbox.Location = new System.Drawing.Point(185, 26);
            this.descbox.Name = "descbox";
            this.descbox.Size = new System.Drawing.Size(167, 22);
            this.descbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prezzo";
            // 
            // pricebox
            // 
            this.pricebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricebox.Location = new System.Drawing.Point(531, 26);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(75, 22);
            this.pricebox.TabIndex = 5;
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(612, 18);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(159, 33);
            this.addbutton.TabIndex = 7;
            this.addbutton.Text = "AGGIUNGI";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // modbutton
            // 
            this.modbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modbutton.Location = new System.Drawing.Point(612, 162);
            this.modbutton.Name = "modbutton";
            this.modbutton.Size = new System.Drawing.Size(159, 33);
            this.modbutton.TabIndex = 8;
            this.modbutton.Text = "MODIFICA";
            this.modbutton.UseVisualStyleBackColor = true;
            this.modbutton.Click += new System.EventHandler(this.modbutton_Click);
            // 
            // delbutton
            // 
            this.delbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbutton.Location = new System.Drawing.Point(612, 201);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(159, 33);
            this.delbutton.TabIndex = 9;
            this.delbutton.Text = "ELIMINA";
            this.delbutton.UseVisualStyleBackColor = true;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // pricebutton
            // 
            this.pricebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricebutton.Location = new System.Drawing.Point(612, 387);
            this.pricebutton.Name = "pricebutton";
            this.pricebutton.Size = new System.Drawing.Size(159, 33);
            this.pricebutton.TabIndex = 10;
            this.pricebutton.Text = "PREZZO TOT";
            this.pricebutton.UseVisualStyleBackColor = true;
            this.pricebutton.Click += new System.EventHandler(this.pricebutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(612, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prezzo:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(666, 423);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(47, 16);
            this.price.TabIndex = 12;
            this.price.Text = "prezzo";
            // 
            // orderbutton
            // 
            this.orderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderbutton.Location = new System.Drawing.Point(612, 300);
            this.orderbutton.Name = "orderbutton";
            this.orderbutton.Size = new System.Drawing.Size(159, 33);
            this.orderbutton.TabIndex = 13;
            this.orderbutton.Text = "ORDINA PREZZO";
            this.orderbutton.UseVisualStyleBackColor = true;
            this.orderbutton.Click += new System.EventHandler(this.orderbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data";
            // 
            // datebox
            // 
            this.datebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datebox.Location = new System.Drawing.Point(358, 26);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(167, 22);
            this.datebox.TabIndex = 16;
            // 
            // idbox
            // 
            this.idbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idbox.Location = new System.Drawing.Point(612, 134);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(51, 22);
            this.idbox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID";
            // 
            // searchbutton
            // 
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.Location = new System.Drawing.Point(669, 123);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(102, 33);
            this.searchbutton.TabIndex = 19;
            this.searchbutton.Text = "CERCA";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orderbutton);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pricebutton);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.modbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.bacheca);
            this.Name = "Form1";
            this.Text = "Bacheca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bacheca;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button modbutton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.Button pricebutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button orderbutton;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Descrizione;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Prezzo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datebox;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button searchbutton;
    }
}

