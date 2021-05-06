namespace LoupGarou
{
    partial class Plateforme
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rb_Osalle = new System.Windows.Forms.RadioButton();
            this.rb_Rsalle = new System.Windows.Forms.RadioButton();
            this.p_Osalle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_narration = new System.Windows.Forms.Label();
            this.tb_AdresseSOS = new System.Windows.Forms.TextBox();
            this.tb_PortPOS = new System.Windows.Forms.TextBox();
            this.tb_Capacite = new System.Windows.Forms.TextBox();
            this.p_Rsalle = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_AdresseCRS = new System.Windows.Forms.TextBox();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_PortCRs = new System.Windows.Forms.TextBox();
            this.tb_AdresseSRS = new System.Windows.Forms.TextBox();
            this.tc_Client = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gb_Narration = new System.Windows.Forms.GroupBox();
            this.lb_Narration = new System.Windows.Forms.ListBox();
            this.gb_ForumV = new System.Windows.Forms.GroupBox();
            this.lb_lesMessagesFV = new System.Windows.Forms.ListBox();
            this.tb_leMessageFV = new System.Windows.Forms.RichTextBox();
            this.bt_FV = new System.Windows.Forms.Button();
            this.gb_Vote = new System.Windows.Forms.GroupBox();
            this.cb_Vote = new System.Windows.Forms.ComboBox();
            this.bt_Vote = new System.Windows.Forms.Button();
            this.gb_ForumL = new System.Windows.Forms.GroupBox();
            this.tb_leMessageFL = new System.Windows.Forms.RichTextBox();
            this.lb_lesMessagesFL = new System.Windows.Forms.ListBox();
            this.bt_FL = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gb_Reseau = new System.Windows.Forms.GroupBox();
            this.bt_R = new System.Windows.Forms.Button();
            this.tb_leMessageR = new System.Windows.Forms.RichTextBox();
            this.lb_lesMessagesR = new System.Windows.Forms.ListBox();
            this.bt_Salle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_Osalle.SuspendLayout();
            this.p_Rsalle.SuspendLayout();
            this.tc_Client.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_Narration.SuspendLayout();
            this.gb_ForumV.SuspendLayout();
            this.gb_Vote.SuspendLayout();
            this.gb_ForumL.SuspendLayout();
            this.gb_Reseau.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_Osalle
            // 
            this.rb_Osalle.AutoSize = true;
            this.rb_Osalle.Location = new System.Drawing.Point(11, 15);
            this.rb_Osalle.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Osalle.Name = "rb_Osalle";
            this.rb_Osalle.Size = new System.Drawing.Size(165, 21);
            this.rb_Osalle.TabIndex = 0;
            this.rb_Osalle.TabStop = true;
            this.rb_Osalle.Text = "Ouverture d\'une salle";
            this.rb_Osalle.UseVisualStyleBackColor = true;
            this.rb_Osalle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_Rsalle
            // 
            this.rb_Rsalle.AutoSize = true;
            this.rb_Rsalle.Location = new System.Drawing.Point(11, 108);
            this.rb_Rsalle.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Rsalle.Name = "rb_Rsalle";
            this.rb_Rsalle.Size = new System.Drawing.Size(151, 21);
            this.rb_Rsalle.TabIndex = 1;
            this.rb_Rsalle.TabStop = true;
            this.rb_Rsalle.Text = "Réjoindre une salle";
            this.rb_Rsalle.UseVisualStyleBackColor = true;
            // 
            // p_Osalle
            // 
            this.p_Osalle.Controls.Add(this.label3);
            this.p_Osalle.Controls.Add(this.label2);
            this.p_Osalle.Controls.Add(this.l_narration);
            this.p_Osalle.Controls.Add(this.tb_AdresseSOS);
            this.p_Osalle.Controls.Add(this.tb_PortPOS);
            this.p_Osalle.Controls.Add(this.tb_Capacite);
            this.p_Osalle.Location = new System.Drawing.Point(28, 43);
            this.p_Osalle.Margin = new System.Windows.Forms.Padding(4);
            this.p_Osalle.Name = "p_Osalle";
            this.p_Osalle.Size = new System.Drawing.Size(596, 54);
            this.p_Osalle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Capacité:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Port:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // l_narration
            // 
            this.l_narration.AutoSize = true;
            this.l_narration.Location = new System.Drawing.Point(20, 22);
            this.l_narration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_narration.Name = "l_narration";
            this.l_narration.Size = new System.Drawing.Size(118, 17);
            this.l_narration.TabIndex = 0;
            this.l_narration.Text = "Adresse Serveur:";
            this.l_narration.Click += new System.EventHandler(this.L_narration_Click);
            // 
            // tb_AdresseSOS
            // 
            this.tb_AdresseSOS.Location = new System.Drawing.Point(143, 18);
            this.tb_AdresseSOS.Margin = new System.Windows.Forms.Padding(4);
            this.tb_AdresseSOS.Name = "tb_AdresseSOS";
            this.tb_AdresseSOS.Size = new System.Drawing.Size(92, 22);
            this.tb_AdresseSOS.TabIndex = 10;
            // 
            // tb_PortPOS
            // 
            this.tb_PortPOS.Location = new System.Drawing.Point(297, 18);
            this.tb_PortPOS.Margin = new System.Windows.Forms.Padding(4);
            this.tb_PortPOS.Name = "tb_PortPOS";
            this.tb_PortPOS.Size = new System.Drawing.Size(52, 22);
            this.tb_PortPOS.TabIndex = 11;
            // 
            // tb_Capacite
            // 
            this.tb_Capacite.Location = new System.Drawing.Point(473, 18);
            this.tb_Capacite.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Capacite.Name = "tb_Capacite";
            this.tb_Capacite.Size = new System.Drawing.Size(71, 22);
            this.tb_Capacite.TabIndex = 12;
            // 
            // p_Rsalle
            // 
            this.p_Rsalle.Controls.Add(this.label7);
            this.p_Rsalle.Controls.Add(this.label6);
            this.p_Rsalle.Controls.Add(this.label5);
            this.p_Rsalle.Controls.Add(this.label4);
            this.p_Rsalle.Controls.Add(this.tb_AdresseCRS);
            this.p_Rsalle.Controls.Add(this.tb_Login);
            this.p_Rsalle.Controls.Add(this.tb_PortCRs);
            this.p_Rsalle.Controls.Add(this.tb_AdresseSRS);
            this.p_Rsalle.Location = new System.Drawing.Point(28, 137);
            this.p_Rsalle.Margin = new System.Windows.Forms.Padding(4);
            this.p_Rsalle.Name = "p_Rsalle";
            this.p_Rsalle.Size = new System.Drawing.Size(711, 60);
            this.p_Rsalle.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Login:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Adresse Client:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adresse Serveur:";
            // 
            // tb_AdresseCRS
            // 
            this.tb_AdresseCRS.Location = new System.Drawing.Point(481, 21);
            this.tb_AdresseCRS.Margin = new System.Windows.Forms.Padding(4);
            this.tb_AdresseCRS.Name = "tb_AdresseCRS";
            this.tb_AdresseCRS.Size = new System.Drawing.Size(63, 22);
            this.tb_AdresseCRS.TabIndex = 10;
            this.tb_AdresseCRS.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(615, 21);
            this.tb_Login.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(75, 22);
            this.tb_Login.TabIndex = 15;
            // 
            // tb_PortCRs
            // 
            this.tb_PortCRs.Location = new System.Drawing.Point(297, 21);
            this.tb_PortCRs.Margin = new System.Windows.Forms.Padding(4);
            this.tb_PortCRs.Name = "tb_PortCRs";
            this.tb_PortCRs.Size = new System.Drawing.Size(52, 22);
            this.tb_PortCRs.TabIndex = 14;
            this.tb_PortCRs.TextChanged += new System.EventHandler(this.Tb_PortCRs_TextChanged);
            // 
            // tb_AdresseSRS
            // 
            this.tb_AdresseSRS.Location = new System.Drawing.Point(141, 21);
            this.tb_AdresseSRS.Margin = new System.Windows.Forms.Padding(4);
            this.tb_AdresseSRS.Name = "tb_AdresseSRS";
            this.tb_AdresseSRS.Size = new System.Drawing.Size(93, 22);
            this.tb_AdresseSRS.TabIndex = 13;
            this.tb_AdresseSRS.TextChanged += new System.EventHandler(this.Tb_AdresseSRS_TextChanged);
            // 
            // tc_Client
            // 
            this.tc_Client.Controls.Add(this.tabPage1);
            this.tc_Client.Controls.Add(this.tabPage2);
            this.tc_Client.Controls.Add(this.tabPage3);
            this.tc_Client.Location = new System.Drawing.Point(33, 257);
            this.tc_Client.Margin = new System.Windows.Forms.Padding(4);
            this.tc_Client.Name = "tc_Client";
            this.tc_Client.SelectedIndex = 0;
            this.tc_Client.Size = new System.Drawing.Size(743, 293);
            this.tc_Client.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.gb_Narration);
            this.tabPage1.Controls.Add(this.gb_ForumV);
            this.tabPage1.Controls.Add(this.gb_Vote);
            this.tabPage1.Controls.Add(this.gb_ForumL);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(735, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Accueil";
            // 
            // gb_Narration
            // 
            this.gb_Narration.Controls.Add(this.lb_Narration);
            this.gb_Narration.Location = new System.Drawing.Point(17, 27);
            this.gb_Narration.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Narration.Name = "gb_Narration";
            this.gb_Narration.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Narration.Size = new System.Drawing.Size(267, 91);
            this.gb_Narration.TabIndex = 5;
            this.gb_Narration.TabStop = false;
            this.gb_Narration.Text = "Histoire";
            // 
            // lb_Narration
            // 
            this.lb_Narration.FormattingEnabled = true;
            this.lb_Narration.ItemHeight = 16;
            this.lb_Narration.Location = new System.Drawing.Point(29, 23);
            this.lb_Narration.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Narration.Name = "lb_Narration";
            this.lb_Narration.Size = new System.Drawing.Size(197, 52);
            this.lb_Narration.TabIndex = 0;
            this.lb_Narration.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // gb_ForumV
            // 
            this.gb_ForumV.Controls.Add(this.lb_lesMessagesFV);
            this.gb_ForumV.Controls.Add(this.tb_leMessageFV);
            this.gb_ForumV.Controls.Add(this.bt_FV);
            this.gb_ForumV.Location = new System.Drawing.Point(295, 27);
            this.gb_ForumV.Margin = new System.Windows.Forms.Padding(4);
            this.gb_ForumV.Name = "gb_ForumV";
            this.gb_ForumV.Padding = new System.Windows.Forms.Padding(4);
            this.gb_ForumV.Size = new System.Drawing.Size(176, 209);
            this.gb_ForumV.TabIndex = 7;
            this.gb_ForumV.TabStop = false;
            this.gb_ForumV.Text = "Forum des Villageois";
            // 
            // lb_lesMessagesFV
            // 
            this.lb_lesMessagesFV.FormattingEnabled = true;
            this.lb_lesMessagesFV.ItemHeight = 16;
            this.lb_lesMessagesFV.Location = new System.Drawing.Point(31, 23);
            this.lb_lesMessagesFV.Margin = new System.Windows.Forms.Padding(4);
            this.lb_lesMessagesFV.Name = "lb_lesMessagesFV";
            this.lb_lesMessagesFV.Size = new System.Drawing.Size(112, 116);
            this.lb_lesMessagesFV.TabIndex = 0;
            // 
            // tb_leMessageFV
            // 
            this.tb_leMessageFV.Location = new System.Drawing.Point(31, 148);
            this.tb_leMessageFV.Margin = new System.Windows.Forms.Padding(4);
            this.tb_leMessageFV.Name = "tb_leMessageFV";
            this.tb_leMessageFV.Size = new System.Drawing.Size(112, 24);
            this.tb_leMessageFV.TabIndex = 16;
            this.tb_leMessageFV.Text = "";
            this.tb_leMessageFV.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // bt_FV
            // 
            this.bt_FV.Location = new System.Drawing.Point(31, 177);
            this.bt_FV.Margin = new System.Windows.Forms.Padding(4);
            this.bt_FV.Name = "bt_FV";
            this.bt_FV.Size = new System.Drawing.Size(113, 25);
            this.bt_FV.TabIndex = 10;
            this.bt_FV.Text = "VALIDER";
            this.bt_FV.UseVisualStyleBackColor = true;
            this.bt_FV.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // gb_Vote
            // 
            this.gb_Vote.Controls.Add(this.cb_Vote);
            this.gb_Vote.Controls.Add(this.bt_Vote);
            this.gb_Vote.Location = new System.Drawing.Point(17, 134);
            this.gb_Vote.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Vote.Name = "gb_Vote";
            this.gb_Vote.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Vote.Size = new System.Drawing.Size(267, 102);
            this.gb_Vote.TabIndex = 6;
            this.gb_Vote.TabStop = false;
            this.gb_Vote.Text = "Vote";
            // 
            // cb_Vote
            // 
            this.cb_Vote.FormattingEnabled = true;
            this.cb_Vote.Location = new System.Drawing.Point(57, 37);
            this.cb_Vote.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Vote.Name = "cb_Vote";
            this.cb_Vote.Size = new System.Drawing.Size(160, 24);
            this.cb_Vote.TabIndex = 10;
            // 
            // bt_Vote
            // 
            this.bt_Vote.Location = new System.Drawing.Point(57, 70);
            this.bt_Vote.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Vote.Name = "bt_Vote";
            this.bt_Vote.Size = new System.Drawing.Size(161, 25);
            this.bt_Vote.TabIndex = 13;
            this.bt_Vote.Text = "VALIDER";
            this.bt_Vote.UseVisualStyleBackColor = true;
            // 
            // gb_ForumL
            // 
            this.gb_ForumL.Controls.Add(this.tb_leMessageFL);
            this.gb_ForumL.Controls.Add(this.lb_lesMessagesFL);
            this.gb_ForumL.Controls.Add(this.bt_FL);
            this.gb_ForumL.Location = new System.Drawing.Point(497, 27);
            this.gb_ForumL.Margin = new System.Windows.Forms.Padding(4);
            this.gb_ForumL.Name = "gb_ForumL";
            this.gb_ForumL.Padding = new System.Windows.Forms.Padding(4);
            this.gb_ForumL.Size = new System.Drawing.Size(208, 209);
            this.gb_ForumL.TabIndex = 8;
            this.gb_ForumL.TabStop = false;
            this.gb_ForumL.Text = "Forum des Loups";
            // 
            // tb_leMessageFL
            // 
            this.tb_leMessageFL.Location = new System.Drawing.Point(41, 148);
            this.tb_leMessageFL.Margin = new System.Windows.Forms.Padding(4);
            this.tb_leMessageFL.Name = "tb_leMessageFL";
            this.tb_leMessageFL.Size = new System.Drawing.Size(127, 24);
            this.tb_leMessageFL.TabIndex = 17;
            this.tb_leMessageFL.Text = "";
            this.tb_leMessageFL.TextChanged += new System.EventHandler(this.RichTextBox3_TextChanged);
            // 
            // lb_lesMessagesFL
            // 
            this.lb_lesMessagesFL.FormattingEnabled = true;
            this.lb_lesMessagesFL.ItemHeight = 16;
            this.lb_lesMessagesFL.Location = new System.Drawing.Point(41, 23);
            this.lb_lesMessagesFL.Margin = new System.Windows.Forms.Padding(4);
            this.lb_lesMessagesFL.Name = "lb_lesMessagesFL";
            this.lb_lesMessagesFL.Size = new System.Drawing.Size(127, 116);
            this.lb_lesMessagesFL.TabIndex = 1;
            this.lb_lesMessagesFL.SelectedIndexChanged += new System.EventHandler(this.lb_lesMessagesFL_SelectedIndexChanged);
            // 
            // bt_FL
            // 
            this.bt_FL.Location = new System.Drawing.Point(41, 177);
            this.bt_FL.Margin = new System.Windows.Forms.Padding(4);
            this.bt_FL.Name = "bt_FL";
            this.bt_FL.Size = new System.Drawing.Size(128, 25);
            this.bt_FL.TabIndex = 11;
            this.bt_FL.Text = "VALIDER";
            this.bt_FL.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(735, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compte";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(735, 264);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Déconnexion";
            // 
            // gb_Reseau
            // 
            this.gb_Reseau.Controls.Add(this.bt_R);
            this.gb_Reseau.Controls.Add(this.tb_leMessageR);
            this.gb_Reseau.Controls.Add(this.lb_lesMessagesR);
            this.gb_Reseau.Location = new System.Drawing.Point(784, 22);
            this.gb_Reseau.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Reseau.Name = "gb_Reseau";
            this.gb_Reseau.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Reseau.Size = new System.Drawing.Size(267, 517);
            this.gb_Reseau.TabIndex = 9;
            this.gb_Reseau.TabStop = false;
            this.gb_Reseau.Text = "Test Reseau";
            // 
            // bt_R
            // 
            this.bt_R.ForeColor = System.Drawing.Color.Black;
            this.bt_R.Location = new System.Drawing.Point(39, 466);
            this.bt_R.Margin = new System.Windows.Forms.Padding(4);
            this.bt_R.Name = "bt_R";
            this.bt_R.Size = new System.Drawing.Size(188, 25);
            this.bt_R.TabIndex = 12;
            this.bt_R.Text = "VALIDER";
            this.bt_R.UseVisualStyleBackColor = true;
            this.bt_R.Click += new System.EventHandler(this.Button3_Click);
            // 
            // tb_leMessageR
            // 
            this.tb_leMessageR.Location = new System.Drawing.Point(39, 439);
            this.tb_leMessageR.Margin = new System.Windows.Forms.Padding(4);
            this.tb_leMessageR.Name = "tb_leMessageR";
            this.tb_leMessageR.Size = new System.Drawing.Size(188, 24);
            this.tb_leMessageR.TabIndex = 17;
            this.tb_leMessageR.Text = "";
            this.tb_leMessageR.TextChanged += new System.EventHandler(this.RichTextBox4_TextChanged);
            // 
            // lb_lesMessagesR
            // 
            this.lb_lesMessagesR.FormattingEnabled = true;
            this.lb_lesMessagesR.ItemHeight = 16;
            this.lb_lesMessagesR.Location = new System.Drawing.Point(39, 23);
            this.lb_lesMessagesR.Margin = new System.Windows.Forms.Padding(4);
            this.lb_lesMessagesR.Name = "lb_lesMessagesR";
            this.lb_lesMessagesR.Size = new System.Drawing.Size(188, 404);
            this.lb_lesMessagesR.TabIndex = 2;
            this.lb_lesMessagesR.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // bt_Salle
            // 
            this.bt_Salle.Enabled = false;
            this.bt_Salle.Location = new System.Drawing.Point(300, 208);
            this.bt_Salle.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Salle.Name = "bt_Salle";
            this.bt_Salle.Size = new System.Drawing.Size(100, 28);
            this.bt_Salle.TabIndex = 14;
            this.bt_Salle.Text = "VALIDER";
            this.bt_Salle.UseVisualStyleBackColor = true;
            this.bt_Salle.Click += new System.EventHandler(this.Bt_Salle_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rb_Osalle);
            this.panel1.Controls.Add(this.bt_Salle);
            this.panel1.Controls.Add(this.p_Osalle);
            this.panel1.Controls.Add(this.rb_Rsalle);
            this.panel1.Controls.Add(this.p_Rsalle);
            this.panel1.Location = new System.Drawing.Point(33, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 240);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Plateforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_Reseau);
            this.Controls.Add(this.tc_Client);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Plateforme";
            this.Text = "Loup Garou";
            this.Load += new System.EventHandler(this.Plateforme_Load);
            this.p_Osalle.ResumeLayout(false);
            this.p_Osalle.PerformLayout();
            this.p_Rsalle.ResumeLayout(false);
            this.p_Rsalle.PerformLayout();
            this.tc_Client.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gb_Narration.ResumeLayout(false);
            this.gb_ForumV.ResumeLayout(false);
            this.gb_Vote.ResumeLayout(false);
            this.gb_ForumL.ResumeLayout(false);
            this.gb_Reseau.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Osalle;
        private System.Windows.Forms.RadioButton rb_Rsalle;
        private System.Windows.Forms.Panel p_Osalle;
        private System.Windows.Forms.Panel p_Rsalle;
        private System.Windows.Forms.TabControl tc_Client;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gb_ForumV;
        private System.Windows.Forms.GroupBox gb_Narration;
        private System.Windows.Forms.GroupBox gb_Vote;
        private System.Windows.Forms.GroupBox gb_ForumL;
        private System.Windows.Forms.GroupBox gb_Reseau;
        private System.Windows.Forms.Label l_narration;
        private System.Windows.Forms.ListBox lb_lesMessagesFV;
        private System.Windows.Forms.ListBox lb_lesMessagesFL;
        private System.Windows.Forms.ListBox lb_lesMessagesR;
        private System.Windows.Forms.TextBox tb_AdresseSOS;
        private System.Windows.Forms.TextBox tb_PortPOS;
        private System.Windows.Forms.TextBox tb_Capacite;
        private System.Windows.Forms.TextBox tb_AdresseSRS;
        private System.Windows.Forms.TextBox tb_PortCRs;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_AdresseCRS;
        private System.Windows.Forms.Button bt_FV;
        private System.Windows.Forms.ComboBox cb_Vote;
        private System.Windows.Forms.Button bt_Vote;
        private System.Windows.Forms.Button bt_FL;
        private System.Windows.Forms.Button bt_R;
        private System.Windows.Forms.Button bt_Salle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lb_Narration;
        private System.Windows.Forms.RichTextBox tb_leMessageFV;
        private System.Windows.Forms.RichTextBox tb_leMessageFL;
        private System.Windows.Forms.RichTextBox tb_leMessageR;
    }
}

