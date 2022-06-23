
namespace Bookshop.Forms
{
    partial class GenresAuthorsPublishersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAuthors = new System.Windows.Forms.DataGridView();
            this.dgvPublishers = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbPublisherName = new System.Windows.Forms.TextBox();
            this.tbAuthorName = new System.Windows.Forms.TextBox();
            this.tbGenreName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            this.btnGenreAdd = new System.Windows.Forms.Button();
            this.btnAuthorAdd = new System.Windows.Forms.Button();
            this.btnPublisherAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublishers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.AllowUserToAddRows = false;
            this.dgvAuthors.AllowUserToDeleteRows = false;
            this.dgvAuthors.AllowUserToResizeRows = false;
            this.dgvAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAuthors.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthors.EnableHeadersVisualStyles = false;
            this.dgvAuthors.Location = new System.Drawing.Point(394, 219);
            this.dgvAuthors.MultiSelect = false;
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuthors.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuthors.RowHeadersVisible = false;
            this.dgvAuthors.RowHeadersWidth = 51;
            this.dgvAuthors.RowTemplate.Height = 24;
            this.dgvAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuthors.Size = new System.Drawing.Size(325, 469);
            this.dgvAuthors.TabIndex = 84;
            this.dgvAuthors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthors_CellClick);
            // 
            // dgvPublishers
            // 
            this.dgvPublishers.AllowUserToAddRows = false;
            this.dgvPublishers.AllowUserToDeleteRows = false;
            this.dgvPublishers.AllowUserToResizeRows = false;
            this.dgvPublishers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPublishers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPublishers.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPublishers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublishers.EnableHeadersVisualStyles = false;
            this.dgvPublishers.Location = new System.Drawing.Point(775, 219);
            this.dgvPublishers.MultiSelect = false;
            this.dgvPublishers.Name = "dgvPublishers";
            this.dgvPublishers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPublishers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPublishers.RowHeadersVisible = false;
            this.dgvPublishers.RowHeadersWidth = 51;
            this.dgvPublishers.RowTemplate.Height = 24;
            this.dgvPublishers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPublishers.Size = new System.Drawing.Size(325, 469);
            this.dgvPublishers.TabIndex = 83;
            this.dgvPublishers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPublishers_CellClick);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.Indigo;
            this.label19.Location = new System.Drawing.Point(823, 31);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 29);
            this.label19.TabIndex = 77;
            this.label19.Text = "Publisher";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.Indigo;
            this.label18.Location = new System.Drawing.Point(445, 31);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 29);
            this.label18.TabIndex = 76;
            this.label18.Text = "Author";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.Indigo;
            this.label17.Location = new System.Drawing.Point(48, 31);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 29);
            this.label17.TabIndex = 75;
            this.label17.Text = "Genre";
            // 
            // tbPublisherName
            // 
            this.tbPublisherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPublisherName.Location = new System.Drawing.Point(828, 63);
            this.tbPublisherName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPublisherName.Name = "tbPublisherName";
            this.tbPublisherName.Size = new System.Drawing.Size(200, 30);
            this.tbPublisherName.TabIndex = 74;
            // 
            // tbAuthorName
            // 
            this.tbAuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAuthorName.Location = new System.Drawing.Point(446, 63);
            this.tbAuthorName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbAuthorName.Name = "tbAuthorName";
            this.tbAuthorName.Size = new System.Drawing.Size(200, 30);
            this.tbAuthorName.TabIndex = 73;
            // 
            // tbGenreName
            // 
            this.tbGenreName.Location = new System.Drawing.Point(53, 63);
            this.tbGenreName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbGenreName.Name = "tbGenreName";
            this.tbGenreName.Size = new System.Drawing.Size(200, 30);
            this.tbGenreName.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Indigo;
            this.label13.Location = new System.Drawing.Point(880, 187);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 29);
            this.label13.TabIndex = 71;
            this.label13.Text = "Publishers";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Indigo;
            this.label11.Location = new System.Drawing.Point(517, 187);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 29);
            this.label11.TabIndex = 70;
            this.label11.Text = "Authors";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(119, 187);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 29);
            this.label10.TabIndex = 69;
            this.label10.Text = "Genres";
            // 
            // dgvGenres
            // 
            this.dgvGenres.AllowUserToAddRows = false;
            this.dgvGenres.AllowUserToDeleteRows = false;
            this.dgvGenres.AllowUserToResizeRows = false;
            this.dgvGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvGenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGenres.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGenres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenres.EnableHeadersVisualStyles = false;
            this.dgvGenres.Location = new System.Drawing.Point(12, 219);
            this.dgvGenres.MultiSelect = false;
            this.dgvGenres.Name = "dgvGenres";
            this.dgvGenres.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGenres.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGenres.RowHeadersVisible = false;
            this.dgvGenres.RowHeadersWidth = 51;
            this.dgvGenres.RowTemplate.Height = 24;
            this.dgvGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGenres.Size = new System.Drawing.Size(325, 469);
            this.dgvGenres.TabIndex = 68;
            this.dgvGenres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGenres_CellClick);
            // 
            // btnGenreAdd
            // 
            this.btnGenreAdd.BackColor = System.Drawing.Color.Indigo;
            this.btnGenreAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenreAdd.ForeColor = System.Drawing.Color.White;
            this.btnGenreAdd.Location = new System.Drawing.Point(53, 99);
            this.btnGenreAdd.Name = "btnGenreAdd";
            this.btnGenreAdd.Size = new System.Drawing.Size(200, 45);
            this.btnGenreAdd.TabIndex = 85;
            this.btnGenreAdd.Text = "SAVE";
            this.btnGenreAdd.UseVisualStyleBackColor = false;
            this.btnGenreAdd.Click += new System.EventHandler(this.btnGenreAdd_Click);
            // 
            // btnAuthorAdd
            // 
            this.btnAuthorAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAuthorAdd.BackColor = System.Drawing.Color.Indigo;
            this.btnAuthorAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuthorAdd.ForeColor = System.Drawing.Color.White;
            this.btnAuthorAdd.Location = new System.Drawing.Point(446, 99);
            this.btnAuthorAdd.Name = "btnAuthorAdd";
            this.btnAuthorAdd.Size = new System.Drawing.Size(200, 45);
            this.btnAuthorAdd.TabIndex = 86;
            this.btnAuthorAdd.Text = "SAVE";
            this.btnAuthorAdd.UseVisualStyleBackColor = false;
            this.btnAuthorAdd.Click += new System.EventHandler(this.btnAuthorAdd_Click);
            // 
            // btnPublisherAdd
            // 
            this.btnPublisherAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublisherAdd.BackColor = System.Drawing.Color.Indigo;
            this.btnPublisherAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPublisherAdd.ForeColor = System.Drawing.Color.White;
            this.btnPublisherAdd.Location = new System.Drawing.Point(828, 99);
            this.btnPublisherAdd.Name = "btnPublisherAdd";
            this.btnPublisherAdd.Size = new System.Drawing.Size(200, 45);
            this.btnPublisherAdd.TabIndex = 87;
            this.btnPublisherAdd.Text = "SAVE";
            this.btnPublisherAdd.UseVisualStyleBackColor = false;
            this.btnPublisherAdd.Click += new System.EventHandler(this.btnPublisherAdd_Click);
            // 
            // GenresAuthorsPublishersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1112, 700);
            this.Controls.Add(this.btnPublisherAdd);
            this.Controls.Add(this.btnAuthorAdd);
            this.Controls.Add(this.btnGenreAdd);
            this.Controls.Add(this.dgvAuthors);
            this.Controls.Add(this.dgvPublishers);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbPublisherName);
            this.Controls.Add(this.tbAuthorName);
            this.Controls.Add(this.tbGenreName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvGenres);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GenresAuthorsPublishersForm";
            this.Text = "GenresAuthorsPublishersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublishers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.DataGridView dgvPublishers;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbPublisherName;
        private System.Windows.Forms.TextBox tbAuthorName;
        private System.Windows.Forms.TextBox tbGenreName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvGenres;
        private System.Windows.Forms.Button btnGenreAdd;
        private System.Windows.Forms.Button btnAuthorAdd;
        private System.Windows.Forms.Button btnPublisherAdd;
    }
}