namespace StoneShardItemEnchantEditor
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
            this.CharacterNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadCharacter = new System.Windows.Forms.Button();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoadItem = new System.Windows.Forms.Button();
            this.Enchantonitem = new System.Windows.Forms.DataGridView();
            this.SaveFile = new System.Windows.Forms.Button();
            this.SwapEnchant = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.EnchantList = new System.Windows.Forms.ListBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enchant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnchantAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OverAllAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Enchantonitem)).BeginInit();
            this.SuspendLayout();
            // 
            // CharacterNames
            // 
            this.CharacterNames.FormattingEnabled = true;
            this.CharacterNames.Location = new System.Drawing.Point(162, 41);
            this.CharacterNames.Name = "CharacterNames";
            this.CharacterNames.Size = new System.Drawing.Size(121, 21);
            this.CharacterNames.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character";
            // 
            // LoadCharacter
            // 
            this.LoadCharacter.Location = new System.Drawing.Point(289, 41);
            this.LoadCharacter.Name = "LoadCharacter";
            this.LoadCharacter.Size = new System.Drawing.Size(75, 23);
            this.LoadCharacter.TabIndex = 2;
            this.LoadCharacter.Text = "Load";
            this.LoadCharacter.UseVisualStyleBackColor = true;
            this.LoadCharacter.Click += new System.EventHandler(this.LoadCharacter_Click);
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.Location = new System.Drawing.Point(36, 135);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(136, 251);
            this.ItemListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enchant";
            // 
            // LoadItem
            // 
            this.LoadItem.Location = new System.Drawing.Point(197, 246);
            this.LoadItem.Name = "LoadItem";
            this.LoadItem.Size = new System.Drawing.Size(52, 23);
            this.LoadItem.TabIndex = 7;
            this.LoadItem.Text = ">>>";
            this.LoadItem.UseVisualStyleBackColor = true;
            this.LoadItem.Click += new System.EventHandler(this.LoadItem_Click);
            // 
            // Enchantonitem
            // 
            this.Enchantonitem.AllowUserToAddRows = false;
            this.Enchantonitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Enchantonitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Enchant,
            this.EName,
            this.EnchantAmount,
            this.OverAllAmount});
            this.Enchantonitem.Location = new System.Drawing.Point(255, 135);
            this.Enchantonitem.Name = "Enchantonitem";
            this.Enchantonitem.ReadOnly = true;
            this.Enchantonitem.Size = new System.Drawing.Size(457, 251);
            this.Enchantonitem.TabIndex = 9;
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(439, 39);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(75, 23);
            this.SaveFile.TabIndex = 11;
            this.SaveFile.Text = "Save";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // SwapEnchant
            // 
            this.SwapEnchant.Location = new System.Drawing.Point(510, 102);
            this.SwapEnchant.Name = "SwapEnchant";
            this.SwapEnchant.Size = new System.Drawing.Size(75, 23);
            this.SwapEnchant.TabIndex = 12;
            this.SwapEnchant.Text = "Swap";
            this.SwapEnchant.UseVisualStyleBackColor = true;
            this.SwapEnchant.Click += new System.EventHandler(this.SwapEnchant_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "List of Know Enchnats";
            // 
            // EnchantList
            // 
            this.EnchantList.FormattingEnabled = true;
            this.EnchantList.Location = new System.Drawing.Point(761, 135);
            this.EnchantList.Name = "EnchantList";
            this.EnchantList.Size = new System.Drawing.Size(120, 251);
            this.EnchantList.TabIndex = 14;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // Enchant
            // 
            this.Enchant.HeaderText = "Enchant";
            this.Enchant.Name = "Enchant";
            this.Enchant.ReadOnly = true;
            // 
            // EName
            // 
            this.EName.HeaderText = "IGN";
            this.EName.Name = "EName";
            this.EName.ReadOnly = true;
            // 
            // EnchantAmount
            // 
            this.EnchantAmount.HeaderText = "Amount %";
            this.EnchantAmount.Name = "EnchantAmount";
            this.EnchantAmount.ReadOnly = true;
            this.EnchantAmount.Width = 60;
            // 
            // OverAllAmount
            // 
            this.OverAllAmount.HeaderText = "OverallAmount";
            this.OverAllAmount.Name = "OverAllAmount";
            this.OverAllAmount.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.EnchantList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SwapEnchant);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.Enchantonitem);
            this.Controls.Add(this.LoadItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.LoadCharacter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CharacterNames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Enchantonitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CharacterNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadCharacter;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoadItem;
        private System.Windows.Forms.DataGridView Enchantonitem;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button SwapEnchant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox EnchantList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enchant;
        private System.Windows.Forms.DataGridViewTextBoxColumn EName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnchantAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OverAllAmount;
    }
}

