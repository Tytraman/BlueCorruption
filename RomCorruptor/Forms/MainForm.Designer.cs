namespace RomCorruptor.Forms {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rom_selector_button = new System.Windows.Forms.Button();
            this.rom_selector_label = new System.Windows.Forms.Label();
            this.presets_menu = new System.Windows.Forms.ComboBox();
            this.presets_label = new System.Windows.Forms.Label();
            this.corrupt_button = new System.Windows.Forms.Button();
            this.emulator_button = new System.Windows.Forms.Button();
            this.emulator_label = new System.Windows.Forms.Label();
            this.starting_byte_menu = new System.Windows.Forms.NumericUpDown();
            this.starting_byte_label = new System.Windows.Forms.Label();
            this.ending_byte_menu = new System.Windows.Forms.NumericUpDown();
            this.ending_byte_label = new System.Windows.Forms.Label();
            this.corrupt_every_label = new System.Windows.Forms.Label();
            this.corrupt_every_menu = new System.Windows.Forms.NumericUpDown();
            this.result_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.starting_byte_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ending_byte_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corrupt_every_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // rom_selector_button
            // 
            this.rom_selector_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rom_selector_button.BackColor = System.Drawing.Color.DarkGray;
            this.rom_selector_button.Location = new System.Drawing.Point(150, 80);
            this.rom_selector_button.Name = "rom_selector_button";
            this.rom_selector_button.Size = new System.Drawing.Size(200, 80);
            this.rom_selector_button.TabIndex = 0;
            this.rom_selector_button.Text = "Sélectionner une ROM";
            this.rom_selector_button.UseVisualStyleBackColor = false;
            this.rom_selector_button.Click += new System.EventHandler(this.rom_selector_button_Click);
            // 
            // rom_selector_label
            // 
            this.rom_selector_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rom_selector_label.AutoSize = true;
            this.rom_selector_label.ForeColor = System.Drawing.Color.White;
            this.rom_selector_label.Location = new System.Drawing.Point(150, 64);
            this.rom_selector_label.Name = "rom_selector_label";
            this.rom_selector_label.Size = new System.Drawing.Size(144, 13);
            this.rom_selector_label.TabIndex = 1;
            this.rom_selector_label.Text = "Aucune ROM sélectionnée...";
            // 
            // presets_menu
            // 
            this.presets_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.presets_menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presets_menu.FormattingEnabled = true;
            this.presets_menu.Location = new System.Drawing.Point(150, 185);
            this.presets_menu.Name = "presets_menu";
            this.presets_menu.Size = new System.Drawing.Size(150, 21);
            this.presets_menu.TabIndex = 2;
            this.presets_menu.SelectedIndexChanged += new System.EventHandler(this.presets_menu_SelectedIndexChanged);
            // 
            // presets_label
            // 
            this.presets_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.presets_label.AutoSize = true;
            this.presets_label.ForeColor = System.Drawing.Color.White;
            this.presets_label.Location = new System.Drawing.Point(150, 169);
            this.presets_label.Name = "presets_label";
            this.presets_label.Size = new System.Drawing.Size(40, 13);
            this.presets_label.TabIndex = 3;
            this.presets_label.Text = "Preset:";
            // 
            // corrupt_button
            // 
            this.corrupt_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.corrupt_button.Location = new System.Drawing.Point(150, 710);
            this.corrupt_button.Name = "corrupt_button";
            this.corrupt_button.Size = new System.Drawing.Size(200, 40);
            this.corrupt_button.TabIndex = 4;
            this.corrupt_button.Text = "Corrompre !";
            this.corrupt_button.UseVisualStyleBackColor = true;
            this.corrupt_button.Click += new System.EventHandler(this.corrupt_button_Click);
            // 
            // emulator_button
            // 
            this.emulator_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emulator_button.Location = new System.Drawing.Point(150, 650);
            this.emulator_button.Name = "emulator_button";
            this.emulator_button.Size = new System.Drawing.Size(200, 25);
            this.emulator_button.TabIndex = 5;
            this.emulator_button.Text = "Sélectionner un émulateur";
            this.emulator_button.UseVisualStyleBackColor = true;
            this.emulator_button.Click += new System.EventHandler(this.emulator_button_Click);
            // 
            // emulator_label
            // 
            this.emulator_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emulator_label.AutoSize = true;
            this.emulator_label.ForeColor = System.Drawing.Color.White;
            this.emulator_label.Location = new System.Drawing.Point(150, 634);
            this.emulator_label.Name = "emulator_label";
            this.emulator_label.Size = new System.Drawing.Size(57, 13);
            this.emulator_label.TabIndex = 6;
            this.emulator_label.Text = "Émulateur:";
            // 
            // starting_byte_menu
            // 
            this.starting_byte_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.starting_byte_menu.Location = new System.Drawing.Point(150, 245);
            this.starting_byte_menu.Name = "starting_byte_menu";
            this.starting_byte_menu.Size = new System.Drawing.Size(120, 20);
            this.starting_byte_menu.TabIndex = 7;
            // 
            // starting_byte_label
            // 
            this.starting_byte_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.starting_byte_label.AutoSize = true;
            this.starting_byte_label.ForeColor = System.Drawing.Color.White;
            this.starting_byte_label.Location = new System.Drawing.Point(150, 229);
            this.starting_byte_label.Name = "starting_byte_label";
            this.starting_byte_label.Size = new System.Drawing.Size(79, 13);
            this.starting_byte_label.TabIndex = 8;
            this.starting_byte_label.Text = "Byte de départ:";
            // 
            // ending_byte_menu
            // 
            this.ending_byte_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ending_byte_menu.Location = new System.Drawing.Point(150, 287);
            this.ending_byte_menu.Name = "ending_byte_menu";
            this.ending_byte_menu.Size = new System.Drawing.Size(120, 20);
            this.ending_byte_menu.TabIndex = 9;
            // 
            // ending_byte_label
            // 
            this.ending_byte_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ending_byte_label.AutoSize = true;
            this.ending_byte_label.ForeColor = System.Drawing.Color.White;
            this.ending_byte_label.Location = new System.Drawing.Point(150, 271);
            this.ending_byte_label.Name = "ending_byte_label";
            this.ending_byte_label.Size = new System.Drawing.Size(60, 13);
            this.ending_byte_label.TabIndex = 10;
            this.ending_byte_label.Text = "Byte de fin:";
            // 
            // corrupt_every_label
            // 
            this.corrupt_every_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.corrupt_every_label.AutoSize = true;
            this.corrupt_every_label.ForeColor = System.Drawing.Color.White;
            this.corrupt_every_label.Location = new System.Drawing.Point(150, 322);
            this.corrupt_every_label.Name = "corrupt_every_label";
            this.corrupt_every_label.Size = new System.Drawing.Size(114, 26);
            this.corrupt_every_label.TabIndex = 12;
            this.corrupt_every_label.Text = "Nombre de bytes entre\r\nchaque modification:";
            // 
            // corrupt_every_menu
            // 
            this.corrupt_every_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.corrupt_every_menu.Location = new System.Drawing.Point(150, 351);
            this.corrupt_every_menu.Name = "corrupt_every_menu";
            this.corrupt_every_menu.Size = new System.Drawing.Size(120, 20);
            this.corrupt_every_menu.TabIndex = 13;
            // 
            // result_label
            // 
            this.result_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result_label.AutoSize = true;
            this.result_label.ForeColor = System.Drawing.Color.White;
            this.result_label.Location = new System.Drawing.Point(150, 694);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(144, 13);
            this.result_label.TabIndex = 14;
            this.result_label.Text = "Rien ne s\'est encore passé...";
            // 
            // time_label
            // 
            this.time_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time_label.AutoSize = true;
            this.time_label.ForeColor = System.Drawing.Color.White;
            this.time_label.Location = new System.Drawing.Point(356, 724);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(0, 13);
            this.time_label.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(484, 761);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.corrupt_every_menu);
            this.Controls.Add(this.corrupt_every_label);
            this.Controls.Add(this.ending_byte_label);
            this.Controls.Add(this.ending_byte_menu);
            this.Controls.Add(this.starting_byte_label);
            this.Controls.Add(this.starting_byte_menu);
            this.Controls.Add(this.emulator_label);
            this.Controls.Add(this.emulator_button);
            this.Controls.Add(this.corrupt_button);
            this.Controls.Add(this.presets_label);
            this.Controls.Add(this.presets_menu);
            this.Controls.Add(this.rom_selector_label);
            this.Controls.Add(this.rom_selector_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "RomCorruptor - v.1.0 - Par Tytraman";
            ((System.ComponentModel.ISupportInitialize)(this.starting_byte_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ending_byte_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corrupt_every_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rom_selector_button;
        private System.Windows.Forms.Label rom_selector_label;
        private System.Windows.Forms.ComboBox presets_menu;
        private System.Windows.Forms.Label presets_label;
        private System.Windows.Forms.Button corrupt_button;
        private System.Windows.Forms.Button emulator_button;
        private System.Windows.Forms.Label emulator_label;
        private System.Windows.Forms.NumericUpDown starting_byte_menu;
        private System.Windows.Forms.Label starting_byte_label;
        private System.Windows.Forms.NumericUpDown ending_byte_menu;
        private System.Windows.Forms.Label ending_byte_label;
        private System.Windows.Forms.Label corrupt_every_label;
        private System.Windows.Forms.NumericUpDown corrupt_every_menu;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label result_label;
    }
}