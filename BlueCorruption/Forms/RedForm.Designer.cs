namespace BlueCorruption.Forms {
    partial class RedForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedForm));
            this.file_selector_button = new System.Windows.Forms.Button();
            this.file_selector_label = new System.Windows.Forms.Label();
            this.presets_menu = new System.Windows.Forms.ComboBox();
            this.presets_label = new System.Windows.Forms.Label();
            this.corrupt_button = new System.Windows.Forms.Button();
            this.process_button = new System.Windows.Forms.Button();
            this.process_label = new System.Windows.Forms.Label();
            this.starting_byte_menu = new System.Windows.Forms.NumericUpDown();
            this.starting_byte_label = new System.Windows.Forms.Label();
            this.ending_byte_menu = new System.Windows.Forms.NumericUpDown();
            this.ending_byte_label = new System.Windows.Forms.Label();
            this.corrupt_every_label = new System.Windows.Forms.Label();
            this.corrupt_every_menu = new System.Windows.Forms.NumericUpDown();
            this.result_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.bytes_number_label = new System.Windows.Forms.Label();
            this.byte_to_change_menu = new System.Windows.Forms.NumericUpDown();
            this.changing_byte_menu = new System.Windows.Forms.NumericUpDown();
            this.by_label = new System.Windows.Forms.Label();
            this.reset_process_button = new System.Windows.Forms.Button();
            this.default_save_path_menu = new System.Windows.Forms.TextBox();
            this.default_save_path_selector = new System.Windows.Forms.Button();
            this.move_away_menu = new System.Windows.Forms.NumericUpDown();
            this.distance_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.auto_save_checkbox = new System.Windows.Forms.CheckBox();
            this.auto_open_checkbox = new System.Windows.Forms.CheckBox();
            this.randoms_extra_values_checkbox = new System.Windows.Forms.CheckBox();
            this.min_random_extra_menu_1 = new System.Windows.Forms.NumericUpDown();
            this.random_extra_label1_1 = new System.Windows.Forms.Label();
            this.random_extra_label2_1 = new System.Windows.Forms.Label();
            this.max_random_extra_menu_1 = new System.Windows.Forms.NumericUpDown();
            this.random_extra_label1_2 = new System.Windows.Forms.Label();
            this.min_random_extra_menu_2 = new System.Windows.Forms.NumericUpDown();
            this.random_extra_label2_2 = new System.Windows.Forms.Label();
            this.max_random_extra_menu_2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.starting_byte_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ending_byte_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corrupt_every_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.byte_to_change_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changing_byte_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.move_away_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_random_extra_menu_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_random_extra_menu_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_random_extra_menu_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_random_extra_menu_2)).BeginInit();
            this.SuspendLayout();
            // 
            // file_selector_button
            // 
            this.file_selector_button.AllowDrop = true;
            this.file_selector_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.file_selector_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.file_selector_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.file_selector_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file_selector_button.Location = new System.Drawing.Point(150, 41);
            this.file_selector_button.Name = "file_selector_button";
            this.file_selector_button.Size = new System.Drawing.Size(200, 80);
            this.file_selector_button.TabIndex = 0;
            this.file_selector_button.Text = "Sélectionner un fichier";
            this.file_selector_button.UseVisualStyleBackColor = false;
            this.file_selector_button.Click += new System.EventHandler(this.rom_selector_button_Click);
            this.file_selector_button.DragDrop += new System.Windows.Forms.DragEventHandler(this.file_selector_button_DragDrop);
            this.file_selector_button.DragEnter += new System.Windows.Forms.DragEventHandler(this.file_selector_button_DragEnter);
            // 
            // file_selector_label
            // 
            this.file_selector_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.file_selector_label.AutoSize = true;
            this.file_selector_label.ForeColor = System.Drawing.Color.White;
            this.file_selector_label.Location = new System.Drawing.Point(150, 25);
            this.file_selector_label.Name = "file_selector_label";
            this.file_selector_label.Size = new System.Drawing.Size(135, 13);
            this.file_selector_label.TabIndex = 1;
            this.file_selector_label.Text = "Aucun fichier sélectionné...";
            // 
            // presets_menu
            // 
            this.presets_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.presets_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.presets_menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presets_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.presets_menu.ForeColor = System.Drawing.Color.Black;
            this.presets_menu.FormattingEnabled = true;
            this.presets_menu.Location = new System.Drawing.Point(12, 189);
            this.presets_menu.Name = "presets_menu";
            this.presets_menu.Size = new System.Drawing.Size(200, 21);
            this.presets_menu.TabIndex = 2;
            this.presets_menu.SelectedIndexChanged += new System.EventHandler(this.presets_menu_SelectedIndexChanged);
            // 
            // presets_label
            // 
            this.presets_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.presets_label.AutoSize = true;
            this.presets_label.ForeColor = System.Drawing.Color.White;
            this.presets_label.Location = new System.Drawing.Point(9, 173);
            this.presets_label.Name = "presets_label";
            this.presets_label.Size = new System.Drawing.Size(40, 13);
            this.presets_label.TabIndex = 3;
            this.presets_label.Text = "Preset:";
            // 
            // corrupt_button
            // 
            this.corrupt_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.corrupt_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.corrupt_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.corrupt_button.Location = new System.Drawing.Point(150, 710);
            this.corrupt_button.Name = "corrupt_button";
            this.corrupt_button.Size = new System.Drawing.Size(200, 40);
            this.corrupt_button.TabIndex = 4;
            this.corrupt_button.Text = "Corrompre !";
            this.corrupt_button.UseVisualStyleBackColor = false;
            this.corrupt_button.Click += new System.EventHandler(this.corrupt_button_Click);
            // 
            // process_button
            // 
            this.process_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.process_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.process_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.process_button.Location = new System.Drawing.Point(150, 650);
            this.process_button.Name = "process_button";
            this.process_button.Size = new System.Drawing.Size(200, 25);
            this.process_button.TabIndex = 5;
            this.process_button.Text = "Sélectionner un programme";
            this.process_button.UseVisualStyleBackColor = false;
            this.process_button.Click += new System.EventHandler(this.process_button_Click);
            // 
            // process_label
            // 
            this.process_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.process_label.AutoSize = true;
            this.process_label.ForeColor = System.Drawing.Color.White;
            this.process_label.Location = new System.Drawing.Point(150, 634);
            this.process_label.Name = "process_label";
            this.process_label.Size = new System.Drawing.Size(63, 13);
            this.process_label.TabIndex = 6;
            this.process_label.Text = "Programme:";
            // 
            // starting_byte_menu
            // 
            this.starting_byte_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.starting_byte_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.starting_byte_menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.starting_byte_menu.Location = new System.Drawing.Point(12, 237);
            this.starting_byte_menu.Name = "starting_byte_menu";
            this.starting_byte_menu.Size = new System.Drawing.Size(120, 16);
            this.starting_byte_menu.TabIndex = 7;
            // 
            // starting_byte_label
            // 
            this.starting_byte_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.starting_byte_label.AutoSize = true;
            this.starting_byte_label.ForeColor = System.Drawing.Color.White;
            this.starting_byte_label.Location = new System.Drawing.Point(9, 221);
            this.starting_byte_label.Name = "starting_byte_label";
            this.starting_byte_label.Size = new System.Drawing.Size(79, 13);
            this.starting_byte_label.TabIndex = 8;
            this.starting_byte_label.Text = "Byte de départ:";
            // 
            // ending_byte_menu
            // 
            this.ending_byte_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ending_byte_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ending_byte_menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ending_byte_menu.Location = new System.Drawing.Point(12, 272);
            this.ending_byte_menu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ending_byte_menu.Name = "ending_byte_menu";
            this.ending_byte_menu.Size = new System.Drawing.Size(120, 16);
            this.ending_byte_menu.TabIndex = 9;
            this.ending_byte_menu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ending_byte_label
            // 
            this.ending_byte_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ending_byte_label.AutoSize = true;
            this.ending_byte_label.ForeColor = System.Drawing.Color.White;
            this.ending_byte_label.Location = new System.Drawing.Point(9, 256);
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
            this.corrupt_every_label.Location = new System.Drawing.Point(12, 302);
            this.corrupt_every_label.Name = "corrupt_every_label";
            this.corrupt_every_label.Size = new System.Drawing.Size(114, 26);
            this.corrupt_every_label.TabIndex = 12;
            this.corrupt_every_label.Text = "Nombre de bytes entre\r\nchaque modification:";
            // 
            // corrupt_every_menu
            // 
            this.corrupt_every_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.corrupt_every_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.corrupt_every_menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.corrupt_every_menu.Location = new System.Drawing.Point(12, 331);
            this.corrupt_every_menu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.corrupt_every_menu.Name = "corrupt_every_menu";
            this.corrupt_every_menu.Size = new System.Drawing.Size(120, 16);
            this.corrupt_every_menu.TabIndex = 13;
            this.corrupt_every_menu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // bytes_number_label
            // 
            this.bytes_number_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bytes_number_label.AutoSize = true;
            this.bytes_number_label.ForeColor = System.Drawing.Color.White;
            this.bytes_number_label.Location = new System.Drawing.Point(362, 75);
            this.bytes_number_label.Name = "bytes_number_label";
            this.bytes_number_label.Size = new System.Drawing.Size(0, 13);
            this.bytes_number_label.TabIndex = 16;
            // 
            // byte_to_change_menu
            // 
            this.byte_to_change_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.byte_to_change_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.byte_to_change_menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.byte_to_change_menu.Location = new System.Drawing.Point(218, 193);
            this.byte_to_change_menu.Name = "byte_to_change_menu";
            this.byte_to_change_menu.Size = new System.Drawing.Size(50, 16);
            this.byte_to_change_menu.TabIndex = 17;
            this.byte_to_change_menu.Visible = false;
            this.byte_to_change_menu.ValueChanged += new System.EventHandler(this.byte_to_change_menu_ValueChanged);
            // 
            // changing_byte_menu
            // 
            this.changing_byte_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changing_byte_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.changing_byte_menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changing_byte_menu.Location = new System.Drawing.Point(302, 193);
            this.changing_byte_menu.Name = "changing_byte_menu";
            this.changing_byte_menu.Size = new System.Drawing.Size(50, 16);
            this.changing_byte_menu.TabIndex = 18;
            this.changing_byte_menu.Visible = false;
            this.changing_byte_menu.ValueChanged += new System.EventHandler(this.changing_byte_menu_ValueChanged);
            // 
            // by_label
            // 
            this.by_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.by_label.AutoSize = true;
            this.by_label.ForeColor = System.Drawing.Color.White;
            this.by_label.Location = new System.Drawing.Point(274, 193);
            this.by_label.Name = "by_label";
            this.by_label.Size = new System.Drawing.Size(22, 13);
            this.by_label.TabIndex = 19;
            this.by_label.Text = "par";
            this.by_label.Visible = false;
            // 
            // reset_process_button
            // 
            this.reset_process_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reset_process_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.reset_process_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_process_button.Location = new System.Drawing.Point(356, 650);
            this.reset_process_button.Name = "reset_process_button";
            this.reset_process_button.Size = new System.Drawing.Size(75, 25);
            this.reset_process_button.TabIndex = 20;
            this.reset_process_button.Text = "Enlever";
            this.reset_process_button.UseVisualStyleBackColor = false;
            this.reset_process_button.Click += new System.EventHandler(this.reset_process_button_Click);
            // 
            // default_save_path_menu
            // 
            this.default_save_path_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.default_save_path_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.default_save_path_menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.default_save_path_menu.Location = new System.Drawing.Point(150, 605);
            this.default_save_path_menu.Name = "default_save_path_menu";
            this.default_save_path_menu.Size = new System.Drawing.Size(200, 13);
            this.default_save_path_menu.TabIndex = 21;
            this.default_save_path_menu.TextChanged += new System.EventHandler(this.default_save_menu_TextChanged);
            // 
            // default_save_path_selector
            // 
            this.default_save_path_selector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.default_save_path_selector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.default_save_path_selector.Cursor = System.Windows.Forms.Cursors.Default;
            this.default_save_path_selector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.default_save_path_selector.Location = new System.Drawing.Point(356, 601);
            this.default_save_path_selector.Name = "default_save_path_selector";
            this.default_save_path_selector.Size = new System.Drawing.Size(24, 20);
            this.default_save_path_selector.TabIndex = 22;
            this.default_save_path_selector.Text = "...";
            this.default_save_path_selector.UseVisualStyleBackColor = false;
            this.default_save_path_selector.Click += new System.EventHandler(this.default_save_selector_Click);
            // 
            // move_away_menu
            // 
            this.move_away_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.move_away_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.move_away_menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.move_away_menu.Location = new System.Drawing.Point(218, 194);
            this.move_away_menu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.move_away_menu.Name = "move_away_menu";
            this.move_away_menu.Size = new System.Drawing.Size(50, 16);
            this.move_away_menu.TabIndex = 24;
            this.move_away_menu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.move_away_menu.Visible = false;
            this.move_away_menu.ValueChanged += new System.EventHandler(this.move_away_menu_ValueChanged);
            // 
            // distance_label
            // 
            this.distance_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.distance_label.AutoSize = true;
            this.distance_label.ForeColor = System.Drawing.Color.White;
            this.distance_label.Location = new System.Drawing.Point(215, 177);
            this.distance_label.Name = "distance_label";
            this.distance_label.Size = new System.Drawing.Size(95, 13);
            this.distance_label.TabIndex = 25;
            this.distance_label.Text = "Distance en bytes:";
            this.distance_label.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Emplacement de sauvegarde par défaut:";
            // 
            // auto_save_checkbox
            // 
            this.auto_save_checkbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.auto_save_checkbox.AutoSize = true;
            this.auto_save_checkbox.ForeColor = System.Drawing.Color.White;
            this.auto_save_checkbox.Location = new System.Drawing.Point(34, 588);
            this.auto_save_checkbox.Name = "auto_save_checkbox";
            this.auto_save_checkbox.Size = new System.Drawing.Size(107, 30);
            this.auto_save_checkbox.TabIndex = 27;
            this.auto_save_checkbox.Text = "Sauvegarder\r\nautomatiquement";
            this.auto_save_checkbox.UseVisualStyleBackColor = true;
            this.auto_save_checkbox.CheckedChanged += new System.EventHandler(this.auto_save_checkbox_CheckedChanged);
            // 
            // auto_open_checkbox
            // 
            this.auto_open_checkbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.auto_open_checkbox.AutoSize = true;
            this.auto_open_checkbox.ForeColor = System.Drawing.Color.White;
            this.auto_open_checkbox.Location = new System.Drawing.Point(34, 645);
            this.auto_open_checkbox.Name = "auto_open_checkbox";
            this.auto_open_checkbox.Size = new System.Drawing.Size(107, 30);
            this.auto_open_checkbox.TabIndex = 28;
            this.auto_open_checkbox.Text = "Ouvrir le fichier\r\nautomatiquement";
            this.auto_open_checkbox.UseVisualStyleBackColor = true;
            this.auto_open_checkbox.CheckedChanged += new System.EventHandler(this.auto_open_checkbox_CheckedChanged);
            // 
            // randoms_extra_values_checkbox
            // 
            this.randoms_extra_values_checkbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.randoms_extra_values_checkbox.AutoSize = true;
            this.randoms_extra_values_checkbox.ForeColor = System.Drawing.Color.White;
            this.randoms_extra_values_checkbox.Location = new System.Drawing.Point(356, 185);
            this.randoms_extra_values_checkbox.Name = "randoms_extra_values_checkbox";
            this.randoms_extra_values_checkbox.Size = new System.Drawing.Size(66, 30);
            this.randoms_extra_values_checkbox.TabIndex = 29;
            this.randoms_extra_values_checkbox.Text = "Valeur\r\naléatoire";
            this.randoms_extra_values_checkbox.UseVisualStyleBackColor = true;
            this.randoms_extra_values_checkbox.CheckedChanged += new System.EventHandler(this.randoms_extra_values_checkbox_CheckedChanged);
            // 
            // min_random_extra_menu_1
            // 
            this.min_random_extra_menu_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.min_random_extra_menu_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.min_random_extra_menu_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.min_random_extra_menu_1.Location = new System.Drawing.Point(218, 237);
            this.min_random_extra_menu_1.Name = "min_random_extra_menu_1";
            this.min_random_extra_menu_1.Size = new System.Drawing.Size(60, 16);
            this.min_random_extra_menu_1.TabIndex = 30;
            this.min_random_extra_menu_1.Visible = false;
            this.min_random_extra_menu_1.ValueChanged += new System.EventHandler(this.min_random_extra_menu_ValueChanged);
            // 
            // random_extra_label1_1
            // 
            this.random_extra_label1_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.random_extra_label1_1.AutoSize = true;
            this.random_extra_label1_1.ForeColor = System.Drawing.Color.White;
            this.random_extra_label1_1.Location = new System.Drawing.Point(215, 221);
            this.random_extra_label1_1.Name = "random_extra_label1_1";
            this.random_extra_label1_1.Size = new System.Drawing.Size(32, 13);
            this.random_extra_label1_1.TabIndex = 31;
            this.random_extra_label1_1.Text = "Entre";
            this.random_extra_label1_1.Visible = false;
            // 
            // random_extra_label2_1
            // 
            this.random_extra_label2_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.random_extra_label2_1.AutoSize = true;
            this.random_extra_label2_1.ForeColor = System.Drawing.Color.White;
            this.random_extra_label2_1.Location = new System.Drawing.Point(215, 256);
            this.random_extra_label2_1.Name = "random_extra_label2_1";
            this.random_extra_label2_1.Size = new System.Drawing.Size(16, 13);
            this.random_extra_label2_1.TabIndex = 32;
            this.random_extra_label2_1.Text = "et";
            this.random_extra_label2_1.Visible = false;
            // 
            // max_random_extra_menu_1
            // 
            this.max_random_extra_menu_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.max_random_extra_menu_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.max_random_extra_menu_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.max_random_extra_menu_1.Location = new System.Drawing.Point(218, 272);
            this.max_random_extra_menu_1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.max_random_extra_menu_1.Name = "max_random_extra_menu_1";
            this.max_random_extra_menu_1.Size = new System.Drawing.Size(60, 16);
            this.max_random_extra_menu_1.TabIndex = 33;
            this.max_random_extra_menu_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.max_random_extra_menu_1.Visible = false;
            this.max_random_extra_menu_1.ValueChanged += new System.EventHandler(this.max_random_extra_menu_ValueChanged);
            // 
            // random_extra_label1_2
            // 
            this.random_extra_label1_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.random_extra_label1_2.AutoSize = true;
            this.random_extra_label1_2.ForeColor = System.Drawing.Color.White;
            this.random_extra_label1_2.Location = new System.Drawing.Point(299, 221);
            this.random_extra_label1_2.Name = "random_extra_label1_2";
            this.random_extra_label1_2.Size = new System.Drawing.Size(32, 13);
            this.random_extra_label1_2.TabIndex = 34;
            this.random_extra_label1_2.Text = "Entre";
            this.random_extra_label1_2.Visible = false;
            // 
            // min_random_extra_menu_2
            // 
            this.min_random_extra_menu_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.min_random_extra_menu_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.min_random_extra_menu_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.min_random_extra_menu_2.Location = new System.Drawing.Point(302, 237);
            this.min_random_extra_menu_2.Name = "min_random_extra_menu_2";
            this.min_random_extra_menu_2.Size = new System.Drawing.Size(60, 16);
            this.min_random_extra_menu_2.TabIndex = 35;
            this.min_random_extra_menu_2.Visible = false;
            this.min_random_extra_menu_2.ValueChanged += new System.EventHandler(this.min_random_extra_menu_2_ValueChanged);
            // 
            // random_extra_label2_2
            // 
            this.random_extra_label2_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.random_extra_label2_2.AutoSize = true;
            this.random_extra_label2_2.ForeColor = System.Drawing.Color.White;
            this.random_extra_label2_2.Location = new System.Drawing.Point(299, 256);
            this.random_extra_label2_2.Name = "random_extra_label2_2";
            this.random_extra_label2_2.Size = new System.Drawing.Size(16, 13);
            this.random_extra_label2_2.TabIndex = 36;
            this.random_extra_label2_2.Text = "et";
            this.random_extra_label2_2.Visible = false;
            // 
            // max_random_extra_menu_2
            // 
            this.max_random_extra_menu_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.max_random_extra_menu_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.max_random_extra_menu_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.max_random_extra_menu_2.Location = new System.Drawing.Point(302, 272);
            this.max_random_extra_menu_2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.max_random_extra_menu_2.Name = "max_random_extra_menu_2";
            this.max_random_extra_menu_2.Size = new System.Drawing.Size(60, 16);
            this.max_random_extra_menu_2.TabIndex = 37;
            this.max_random_extra_menu_2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.max_random_extra_menu_2.Visible = false;
            this.max_random_extra_menu_2.ValueChanged += new System.EventHandler(this.max_random_extra_menu_2_ValueChanged);
            // 
            // RedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(58)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(484, 761);
            this.Controls.Add(this.max_random_extra_menu_2);
            this.Controls.Add(this.random_extra_label2_2);
            this.Controls.Add(this.min_random_extra_menu_2);
            this.Controls.Add(this.random_extra_label1_2);
            this.Controls.Add(this.max_random_extra_menu_1);
            this.Controls.Add(this.random_extra_label2_1);
            this.Controls.Add(this.random_extra_label1_1);
            this.Controls.Add(this.min_random_extra_menu_1);
            this.Controls.Add(this.randoms_extra_values_checkbox);
            this.Controls.Add(this.auto_open_checkbox);
            this.Controls.Add(this.auto_save_checkbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.distance_label);
            this.Controls.Add(this.move_away_menu);
            this.Controls.Add(this.default_save_path_selector);
            this.Controls.Add(this.default_save_path_menu);
            this.Controls.Add(this.reset_process_button);
            this.Controls.Add(this.by_label);
            this.Controls.Add(this.changing_byte_menu);
            this.Controls.Add(this.byte_to_change_menu);
            this.Controls.Add(this.bytes_number_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.corrupt_every_menu);
            this.Controls.Add(this.corrupt_every_label);
            this.Controls.Add(this.ending_byte_label);
            this.Controls.Add(this.ending_byte_menu);
            this.Controls.Add(this.starting_byte_label);
            this.Controls.Add(this.starting_byte_menu);
            this.Controls.Add(this.process_label);
            this.Controls.Add(this.process_button);
            this.Controls.Add(this.corrupt_button);
            this.Controls.Add(this.presets_label);
            this.Controls.Add(this.presets_menu);
            this.Controls.Add(this.file_selector_label);
            this.Controls.Add(this.file_selector_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RedForm";
            this.Text = "BlueCorruption - v.1.0 - Par Tytraman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RedForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.starting_byte_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ending_byte_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corrupt_every_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.byte_to_change_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changing_byte_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.move_away_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_random_extra_menu_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_random_extra_menu_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_random_extra_menu_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_random_extra_menu_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button file_selector_button;
        private System.Windows.Forms.Label file_selector_label;
        private System.Windows.Forms.ComboBox presets_menu;
        private System.Windows.Forms.Label presets_label;
        private System.Windows.Forms.Button corrupt_button;
        private System.Windows.Forms.Button process_button;
        private System.Windows.Forms.Label process_label;
        private System.Windows.Forms.NumericUpDown starting_byte_menu;
        private System.Windows.Forms.Label starting_byte_label;
        private System.Windows.Forms.NumericUpDown ending_byte_menu;
        private System.Windows.Forms.Label ending_byte_label;
        private System.Windows.Forms.Label corrupt_every_label;
        private System.Windows.Forms.NumericUpDown corrupt_every_menu;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Label bytes_number_label;
        private System.Windows.Forms.NumericUpDown byte_to_change_menu;
        private System.Windows.Forms.NumericUpDown changing_byte_menu;
        private System.Windows.Forms.Label by_label;
        private System.Windows.Forms.Button reset_process_button;
        private System.Windows.Forms.TextBox default_save_path_menu;
        private System.Windows.Forms.Button default_save_path_selector;
        private System.Windows.Forms.NumericUpDown move_away_menu;
        private System.Windows.Forms.Label distance_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox auto_save_checkbox;
        private System.Windows.Forms.CheckBox auto_open_checkbox;
        private System.Windows.Forms.CheckBox randoms_extra_values_checkbox;
        private System.Windows.Forms.NumericUpDown min_random_extra_menu_1;
        private System.Windows.Forms.Label random_extra_label1_1;
        private System.Windows.Forms.Label random_extra_label2_1;
        private System.Windows.Forms.NumericUpDown max_random_extra_menu_1;
        private System.Windows.Forms.Label random_extra_label1_2;
        private System.Windows.Forms.NumericUpDown min_random_extra_menu_2;
        private System.Windows.Forms.Label random_extra_label2_2;
        private System.Windows.Forms.NumericUpDown max_random_extra_menu_2;
    }
}