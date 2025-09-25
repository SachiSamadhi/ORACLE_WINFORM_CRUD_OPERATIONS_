using System.Xml.Linq;

namespace NewCRUDoperation
{
    partial class Form1
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
            ID = new MaskedTextBox();
            NAME = new TextBox();
            GENDER = new TextBox();
            AGE = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Insert = new Button();
            DELETE = new Button();
            UPDATE = new Button();
            SELECTION = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.Location = new Point(84, 246);
            ID.Mask = "0000";
            ID.Name = "ID";
            ID.Size = new Size(210, 31);
            ID.TabIndex = 1;
            // 
            // NAME
            // 
            NAME.Location = new Point(315, 246);
            NAME.Name = "NAME";
            NAME.Size = new Size(236, 31);
            NAME.TabIndex = 2;
            // 
            // GENDER
            // 
            GENDER.Location = new Point(572, 246);
            GENDER.Name = "GENDER";
            GENDER.Size = new Size(215, 31);
            GENDER.TabIndex = 3;
            GENDER.TextChanged += textBox2_TextChanged;
            // 
            // AGE
            // 
            AGE.Location = new Point(809, 246);
            AGE.Mask = "00";
            AGE.Name = "AGE";
            AGE.Size = new Size(262, 31);
            AGE.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 208);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 5;
            label1.Text = "Enter ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 208);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 6;
            label2.Text = "Enter Name :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(572, 208);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 7;
            label3.Text = "Enter Gender :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(809, 208);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 8;
            label4.Text = "Enter AGE :";
            // 
            // Insert
            // 
            Insert.Cursor = Cursors.Hand;
            Insert.Font = new Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insert.Location = new Point(106, 358);
            Insert.Name = "Insert";
            Insert.Size = new Size(223, 71);
            Insert.TabIndex = 9;
            Insert.Text = "INSERT";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // DELETE
            // 
            DELETE.Cursor = Cursors.Hand;
            DELETE.Font = new Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DELETE.Location = new Point(594, 358);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(223, 71);
            DELETE.TabIndex = 10;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            DELETE.Click += DELETE_Click;
            // 
            // UPDATE
            // 
            UPDATE.Cursor = Cursors.Hand;
            UPDATE.Font = new Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UPDATE.Location = new Point(350, 358);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(223, 71);
            UPDATE.TabIndex = 11;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            UPDATE.Click += UPDATE_Click;
            // 
            // SELECTION
            // 
            SELECTION.Cursor = Cursors.Hand;
            SELECTION.Font = new Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SELECTION.Location = new Point(831, 358);
            SELECTION.Name = "SELECTION";
            SELECTION.Size = new Size(223, 71);
            SELECTION.TabIndex = 12;
            SELECTION.Text = "SELECTION";
            SELECTION.UseVisualStyleBackColor = true;
            SELECTION.Click += SELECTION_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(185, 447);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(787, 401);
            dataGridView1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(392, 40);
            label5.Name = "label5";
            label5.Size = new Size(395, 50);
            label5.TabIndex = 14;
            label5.Text = "CRUD OPERATIONS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(1180, 882);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(SELECTION);
            Controls.Add(UPDATE);
            Controls.Add(DELETE);
            Controls.Add(Insert);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AGE);
            Controls.Add(GENDER);
            Controls.Add(NAME);
            Controls.Add(ID);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD OPERATION";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox ID;
        private TextBox NAME;
        private TextBox GENDER;
        private MaskedTextBox AGE;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Insert;
        private Button DELETE;
        private Button UPDATE;
        private Button SELECTION;
        private DataGridView dataGridView1;
        private Label label5;
    }
}
