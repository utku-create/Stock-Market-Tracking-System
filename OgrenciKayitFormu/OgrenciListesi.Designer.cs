namespace OgrenciKayitFormu
{
    partial class OgrenciListesi
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
            btnSearch = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgList = new DataGridView();
            beyza = new Button();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Silver;
            btnSearch.Location = new Point(862, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 43);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(192, 255, 192);
            btnInsert.Location = new Point(11, 443);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(141, 59);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Ekle";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 192, 255);
            btnUpdate.Location = new Point(159, 443);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(141, 59);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Location = new Point(847, 443);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 59);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgList
            // 
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Location = new Point(11, 60);
            dgList.Name = "dgList";
            dgList.ReadOnly = true;
            dgList.RowHeadersWidth = 51;
            dgList.RowTemplate.Height = 29;
            dgList.Size = new Size(976, 377);
            dgList.TabIndex = 4;
            dgList.CellClick += dgList_CellClick;
            dgList.CellContentClick += dgList_CellContentClick;
            // 
            // beyza
            // 
            beyza.BackColor = Color.FromArgb(255, 192, 255);
            beyza.Location = new Point(457, 443);
            beyza.Name = "beyza";
            beyza.Size = new Size(141, 59);
            beyza.TabIndex = 5;
            beyza.Text = "beyza";
            beyza.UseVisualStyleBackColor = false;
            beyza.Click += beyza_Click;
            // 
            // OgrenciListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 513);
            Controls.Add(beyza);
            Controls.Add(dgList);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnSearch);
            Name = "OgrenciListesi";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSearch;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgList;
        private Button button1;
        private Button beyza;
    }
}