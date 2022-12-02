namespace CashCounter
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        public string NrStacji { get; }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.labelSumaArkusz = new System.Windows.Forms.Label();
            this.labelSumaWszystko = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.inputTo500 = new System.Windows.Forms.TextBox();
            this.inputTo200 = new System.Windows.Forms.TextBox();
            this.inputTo100 = new System.Windows.Forms.TextBox();
            this.inputTo50 = new System.Windows.Forms.TextBox();
            this.inputTo20 = new System.Windows.Forms.TextBox();
            this.inputTo10 = new System.Windows.Forms.TextBox();
            this.inputTo5 = new System.Windows.Forms.TextBox();
            this.inputTo2 = new System.Windows.Forms.TextBox();
            this.inputTo1 = new System.Windows.Forms.TextBox();
            this.inputTo050 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.inputTo020 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.inputTo010 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.inputTo005 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.inputTo002 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.inputTo001 = new System.Windows.Forms.TextBox();
            this.labelSum500 = new System.Windows.Forms.Label();
            this.labelSum200 = new System.Windows.Forms.Label();
            this.labelSum100 = new System.Windows.Forms.Label();
            this.labelSum50 = new System.Windows.Forms.Label();
            this.labelSum20 = new System.Windows.Forms.Label();
            this.labelSum050 = new System.Windows.Forms.Label();
            this.labelSum1 = new System.Windows.Forms.Label();
            this.labelSum2 = new System.Windows.Forms.Label();
            this.labelSum5 = new System.Windows.Forms.Label();
            this.labelSum10 = new System.Windows.Forms.Label();
            this.labelSum001 = new System.Windows.Forms.Label();
            this.labelSum002 = new System.Windows.Forms.Label();
            this.labelSum005 = new System.Windows.Forms.Label();
            this.labelSum010 = new System.Windows.Forms.Label();
            this.labelSum020 = new System.Windows.Forms.Label();
            this.valueTo001 = new System.Windows.Forms.TextBox();
            this.valueTo002 = new System.Windows.Forms.TextBox();
            this.valueTo005 = new System.Windows.Forms.TextBox();
            this.valueTo010 = new System.Windows.Forms.TextBox();
            this.valueTo020 = new System.Windows.Forms.TextBox();
            this.valueTo050 = new System.Windows.Forms.TextBox();
            this.valueTo1 = new System.Windows.Forms.TextBox();
            this.valueTo2 = new System.Windows.Forms.TextBox();
            this.valueTo5 = new System.Windows.Forms.TextBox();
            this.valueTo10 = new System.Windows.Forms.TextBox();
            this.valueTo20 = new System.Windows.Forms.TextBox();
            this.valueTo50 = new System.Windows.Forms.TextBox();
            this.valueTo100 = new System.Windows.Forms.TextBox();
            this.valueTo200 = new System.Windows.Forms.TextBox();
            this.valueTo500 = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.buttonSetTo0 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(93, 217);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 217);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFinish);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.labelSumaArkusz);
            this.groupBox1.Controls.Add(this.labelSumaWszystko);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(12, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacje";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Gotówka w arkuszu:";
            // 
            // labelSumaArkusz
            // 
            this.labelSumaArkusz.AutoSize = true;
            this.labelSumaArkusz.Location = new System.Drawing.Point(6, 55);
            this.labelSumaArkusz.Name = "labelSumaArkusz";
            this.labelSumaArkusz.Size = new System.Drawing.Size(37, 13);
            this.labelSumaArkusz.TabIndex = 2;
            this.labelSumaArkusz.Text = "0,00 ,-";
            // 
            // labelSumaWszystko
            // 
            this.labelSumaWszystko.AutoSize = true;
            this.labelSumaWszystko.Location = new System.Drawing.Point(6, 29);
            this.labelSumaWszystko.Name = "labelSumaWszystko";
            this.labelSumaWszystko.Size = new System.Drawing.Size(37, 13);
            this.labelSumaWszystko.TabIndex = 1;
            this.labelSumaWszystko.Text = "0,00 ,-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Gotówka łącznie:";
            // 
            // inputTo500
            // 
            this.inputTo500.Enabled = false;
            this.inputTo500.Location = new System.Drawing.Point(205, 9);
            this.inputTo500.MaxLength = 5;
            this.inputTo500.Name = "inputTo500";
            this.inputTo500.Size = new System.Drawing.Size(43, 20);
            this.inputTo500.TabIndex = 11;
            this.inputTo500.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // inputTo200
            // 
            this.inputTo200.Enabled = false;
            this.inputTo200.Location = new System.Drawing.Point(205, 35);
            this.inputTo200.MaxLength = 5;
            this.inputTo200.Name = "inputTo200";
            this.inputTo200.Size = new System.Drawing.Size(43, 20);
            this.inputTo200.TabIndex = 12;
            this.inputTo200.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // inputTo100
            // 
            this.inputTo100.Enabled = false;
            this.inputTo100.Location = new System.Drawing.Point(205, 61);
            this.inputTo100.MaxLength = 5;
            this.inputTo100.Name = "inputTo100";
            this.inputTo100.Size = new System.Drawing.Size(43, 20);
            this.inputTo100.TabIndex = 13;
            this.inputTo100.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // inputTo50
            // 
            this.inputTo50.Enabled = false;
            this.inputTo50.Location = new System.Drawing.Point(205, 87);
            this.inputTo50.MaxLength = 5;
            this.inputTo50.Name = "inputTo50";
            this.inputTo50.Size = new System.Drawing.Size(43, 20);
            this.inputTo50.TabIndex = 14;
            this.inputTo50.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // inputTo20
            // 
            this.inputTo20.Enabled = false;
            this.inputTo20.Location = new System.Drawing.Point(205, 113);
            this.inputTo20.MaxLength = 5;
            this.inputTo20.Name = "inputTo20";
            this.inputTo20.Size = new System.Drawing.Size(43, 20);
            this.inputTo20.TabIndex = 15;
            this.inputTo20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // inputTo10
            // 
            this.inputTo10.Enabled = false;
            this.inputTo10.Location = new System.Drawing.Point(205, 139);
            this.inputTo10.MaxLength = 5;
            this.inputTo10.Name = "inputTo10";
            this.inputTo10.Size = new System.Drawing.Size(43, 20);
            this.inputTo10.TabIndex = 16;
            this.inputTo10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // inputTo5
            // 
            this.inputTo5.Enabled = false;
            this.inputTo5.Location = new System.Drawing.Point(205, 165);
            this.inputTo5.MaxLength = 5;
            this.inputTo5.Name = "inputTo5";
            this.inputTo5.Size = new System.Drawing.Size(43, 20);
            this.inputTo5.TabIndex = 17;
            this.inputTo5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // inputTo2
            // 
            this.inputTo2.Enabled = false;
            this.inputTo2.Location = new System.Drawing.Point(205, 191);
            this.inputTo2.MaxLength = 5;
            this.inputTo2.Name = "inputTo2";
            this.inputTo2.Size = new System.Drawing.Size(43, 20);
            this.inputTo2.TabIndex = 18;
            this.inputTo2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // inputTo1
            // 
            this.inputTo1.Enabled = false;
            this.inputTo1.Location = new System.Drawing.Point(205, 217);
            this.inputTo1.MaxLength = 5;
            this.inputTo1.Name = "inputTo1";
            this.inputTo1.Size = new System.Drawing.Size(43, 20);
            this.inputTo1.TabIndex = 19;
            this.inputTo1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // inputTo050
            // 
            this.inputTo050.Enabled = false;
            this.inputTo050.Location = new System.Drawing.Point(205, 243);
            this.inputTo050.MaxLength = 5;
            this.inputTo050.Name = "inputTo050";
            this.inputTo050.Size = new System.Drawing.Size(43, 20);
            this.inputTo050.TabIndex = 20;
            this.inputTo050.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "0,50";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(171, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "0,20";
            // 
            // inputTo020
            // 
            this.inputTo020.Enabled = false;
            this.inputTo020.Location = new System.Drawing.Point(205, 269);
            this.inputTo020.MaxLength = 5;
            this.inputTo020.Name = "inputTo020";
            this.inputTo020.Size = new System.Drawing.Size(43, 20);
            this.inputTo020.TabIndex = 31;
            this.inputTo020.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(171, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "0,10";
            // 
            // inputTo010
            // 
            this.inputTo010.Enabled = false;
            this.inputTo010.Location = new System.Drawing.Point(205, 295);
            this.inputTo010.MaxLength = 5;
            this.inputTo010.Name = "inputTo010";
            this.inputTo010.Size = new System.Drawing.Size(43, 20);
            this.inputTo010.TabIndex = 33;
            this.inputTo010.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(171, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "0,05";
            // 
            // inputTo005
            // 
            this.inputTo005.Enabled = false;
            this.inputTo005.Location = new System.Drawing.Point(205, 321);
            this.inputTo005.MaxLength = 5;
            this.inputTo005.Name = "inputTo005";
            this.inputTo005.Size = new System.Drawing.Size(43, 20);
            this.inputTo005.TabIndex = 35;
            this.inputTo005.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(171, 350);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "0,02";
            // 
            // inputTo002
            // 
            this.inputTo002.Enabled = false;
            this.inputTo002.Location = new System.Drawing.Point(205, 347);
            this.inputTo002.MaxLength = 5;
            this.inputTo002.Name = "inputTo002";
            this.inputTo002.Size = new System.Drawing.Size(43, 20);
            this.inputTo002.TabIndex = 37;
            this.inputTo002.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(171, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "0,01";
            // 
            // inputTo001
            // 
            this.inputTo001.Enabled = false;
            this.inputTo001.Location = new System.Drawing.Point(205, 373);
            this.inputTo001.MaxLength = 5;
            this.inputTo001.Name = "inputTo001";
            this.inputTo001.Size = new System.Drawing.Size(43, 20);
            this.inputTo001.TabIndex = 39;
            this.inputTo001.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTo500_KeyDown);
            // 
            // labelSum500
            // 
            this.labelSum500.AutoSize = true;
            this.labelSum500.Location = new System.Drawing.Point(311, 12);
            this.labelSum500.Name = "labelSum500";
            this.labelSum500.Size = new System.Drawing.Size(46, 13);
            this.labelSum500.TabIndex = 41;
            this.labelSum500.Text = "= 0,00 ,-";
            // 
            // labelSum200
            // 
            this.labelSum200.AutoSize = true;
            this.labelSum200.Location = new System.Drawing.Point(311, 38);
            this.labelSum200.Name = "labelSum200";
            this.labelSum200.Size = new System.Drawing.Size(46, 13);
            this.labelSum200.TabIndex = 42;
            this.labelSum200.Text = "= 0,00 ,-";
            // 
            // labelSum100
            // 
            this.labelSum100.AutoSize = true;
            this.labelSum100.Location = new System.Drawing.Point(311, 64);
            this.labelSum100.Name = "labelSum100";
            this.labelSum100.Size = new System.Drawing.Size(46, 13);
            this.labelSum100.TabIndex = 43;
            this.labelSum100.Text = "= 0,00 ,-";
            // 
            // labelSum50
            // 
            this.labelSum50.AutoSize = true;
            this.labelSum50.Location = new System.Drawing.Point(311, 90);
            this.labelSum50.Name = "labelSum50";
            this.labelSum50.Size = new System.Drawing.Size(46, 13);
            this.labelSum50.TabIndex = 44;
            this.labelSum50.Text = "= 0,00 ,-";
            // 
            // labelSum20
            // 
            this.labelSum20.AutoSize = true;
            this.labelSum20.Location = new System.Drawing.Point(311, 116);
            this.labelSum20.Name = "labelSum20";
            this.labelSum20.Size = new System.Drawing.Size(46, 13);
            this.labelSum20.TabIndex = 45;
            this.labelSum20.Text = "= 0,00 ,-";
            // 
            // labelSum050
            // 
            this.labelSum050.AutoSize = true;
            this.labelSum050.Location = new System.Drawing.Point(311, 246);
            this.labelSum050.Name = "labelSum050";
            this.labelSum050.Size = new System.Drawing.Size(46, 13);
            this.labelSum050.TabIndex = 50;
            this.labelSum050.Text = "= 0,00 ,-";
            // 
            // labelSum1
            // 
            this.labelSum1.AutoSize = true;
            this.labelSum1.Location = new System.Drawing.Point(311, 220);
            this.labelSum1.Name = "labelSum1";
            this.labelSum1.Size = new System.Drawing.Size(46, 13);
            this.labelSum1.TabIndex = 49;
            this.labelSum1.Text = "= 0,00 ,-";
            // 
            // labelSum2
            // 
            this.labelSum2.AutoSize = true;
            this.labelSum2.Location = new System.Drawing.Point(311, 194);
            this.labelSum2.Name = "labelSum2";
            this.labelSum2.Size = new System.Drawing.Size(46, 13);
            this.labelSum2.TabIndex = 48;
            this.labelSum2.Text = "= 0,00 ,-";
            // 
            // labelSum5
            // 
            this.labelSum5.AutoSize = true;
            this.labelSum5.Location = new System.Drawing.Point(311, 168);
            this.labelSum5.Name = "labelSum5";
            this.labelSum5.Size = new System.Drawing.Size(46, 13);
            this.labelSum5.TabIndex = 47;
            this.labelSum5.Text = "= 0,00 ,-";
            // 
            // labelSum10
            // 
            this.labelSum10.AutoSize = true;
            this.labelSum10.Location = new System.Drawing.Point(311, 142);
            this.labelSum10.Name = "labelSum10";
            this.labelSum10.Size = new System.Drawing.Size(46, 13);
            this.labelSum10.TabIndex = 46;
            this.labelSum10.Text = "= 0,00 ,-";
            // 
            // labelSum001
            // 
            this.labelSum001.AutoSize = true;
            this.labelSum001.Location = new System.Drawing.Point(311, 376);
            this.labelSum001.Name = "labelSum001";
            this.labelSum001.Size = new System.Drawing.Size(46, 13);
            this.labelSum001.TabIndex = 55;
            this.labelSum001.Text = "= 0,00 ,-";
            // 
            // labelSum002
            // 
            this.labelSum002.AutoSize = true;
            this.labelSum002.Location = new System.Drawing.Point(311, 350);
            this.labelSum002.Name = "labelSum002";
            this.labelSum002.Size = new System.Drawing.Size(46, 13);
            this.labelSum002.TabIndex = 54;
            this.labelSum002.Text = "= 0,00 ,-";
            // 
            // labelSum005
            // 
            this.labelSum005.AutoSize = true;
            this.labelSum005.Location = new System.Drawing.Point(311, 324);
            this.labelSum005.Name = "labelSum005";
            this.labelSum005.Size = new System.Drawing.Size(46, 13);
            this.labelSum005.TabIndex = 53;
            this.labelSum005.Text = "= 0,00 ,-";
            // 
            // labelSum010
            // 
            this.labelSum010.AutoSize = true;
            this.labelSum010.Location = new System.Drawing.Point(311, 298);
            this.labelSum010.Name = "labelSum010";
            this.labelSum010.Size = new System.Drawing.Size(46, 13);
            this.labelSum010.TabIndex = 52;
            this.labelSum010.Text = "= 0,00 ,-";
            // 
            // labelSum020
            // 
            this.labelSum020.AutoSize = true;
            this.labelSum020.Location = new System.Drawing.Point(311, 272);
            this.labelSum020.Name = "labelSum020";
            this.labelSum020.Size = new System.Drawing.Size(46, 13);
            this.labelSum020.TabIndex = 51;
            this.labelSum020.Text = "= 0,00 ,-";
            // 
            // valueTo001
            // 
            this.valueTo001.Enabled = false;
            this.valueTo001.Location = new System.Drawing.Point(262, 373);
            this.valueTo001.Name = "valueTo001";
            this.valueTo001.Size = new System.Drawing.Size(43, 20);
            this.valueTo001.TabIndex = 70;
            this.valueTo001.TabStop = false;
            // 
            // valueTo002
            // 
            this.valueTo002.Enabled = false;
            this.valueTo002.Location = new System.Drawing.Point(262, 347);
            this.valueTo002.Name = "valueTo002";
            this.valueTo002.Size = new System.Drawing.Size(43, 20);
            this.valueTo002.TabIndex = 69;
            this.valueTo002.TabStop = false;
            // 
            // valueTo005
            // 
            this.valueTo005.Enabled = false;
            this.valueTo005.Location = new System.Drawing.Point(262, 321);
            this.valueTo005.Name = "valueTo005";
            this.valueTo005.Size = new System.Drawing.Size(43, 20);
            this.valueTo005.TabIndex = 68;
            this.valueTo005.TabStop = false;
            // 
            // valueTo010
            // 
            this.valueTo010.Enabled = false;
            this.valueTo010.Location = new System.Drawing.Point(262, 295);
            this.valueTo010.Name = "valueTo010";
            this.valueTo010.Size = new System.Drawing.Size(43, 20);
            this.valueTo010.TabIndex = 67;
            this.valueTo010.TabStop = false;
            // 
            // valueTo020
            // 
            this.valueTo020.Enabled = false;
            this.valueTo020.Location = new System.Drawing.Point(262, 269);
            this.valueTo020.Name = "valueTo020";
            this.valueTo020.Size = new System.Drawing.Size(43, 20);
            this.valueTo020.TabIndex = 66;
            this.valueTo020.TabStop = false;
            // 
            // valueTo050
            // 
            this.valueTo050.Enabled = false;
            this.valueTo050.Location = new System.Drawing.Point(262, 243);
            this.valueTo050.Name = "valueTo050";
            this.valueTo050.Size = new System.Drawing.Size(43, 20);
            this.valueTo050.TabIndex = 65;
            this.valueTo050.TabStop = false;
            // 
            // valueTo1
            // 
            this.valueTo1.Enabled = false;
            this.valueTo1.Location = new System.Drawing.Point(262, 217);
            this.valueTo1.Name = "valueTo1";
            this.valueTo1.Size = new System.Drawing.Size(43, 20);
            this.valueTo1.TabIndex = 64;
            this.valueTo1.TabStop = false;
            // 
            // valueTo2
            // 
            this.valueTo2.Enabled = false;
            this.valueTo2.Location = new System.Drawing.Point(262, 191);
            this.valueTo2.Name = "valueTo2";
            this.valueTo2.Size = new System.Drawing.Size(43, 20);
            this.valueTo2.TabIndex = 63;
            this.valueTo2.TabStop = false;
            // 
            // valueTo5
            // 
            this.valueTo5.Enabled = false;
            this.valueTo5.Location = new System.Drawing.Point(262, 165);
            this.valueTo5.Name = "valueTo5";
            this.valueTo5.Size = new System.Drawing.Size(43, 20);
            this.valueTo5.TabIndex = 62;
            this.valueTo5.TabStop = false;
            // 
            // valueTo10
            // 
            this.valueTo10.Enabled = false;
            this.valueTo10.Location = new System.Drawing.Point(262, 139);
            this.valueTo10.Name = "valueTo10";
            this.valueTo10.Size = new System.Drawing.Size(43, 20);
            this.valueTo10.TabIndex = 61;
            this.valueTo10.TabStop = false;
            // 
            // valueTo20
            // 
            this.valueTo20.Enabled = false;
            this.valueTo20.Location = new System.Drawing.Point(262, 113);
            this.valueTo20.Name = "valueTo20";
            this.valueTo20.Size = new System.Drawing.Size(43, 20);
            this.valueTo20.TabIndex = 60;
            this.valueTo20.TabStop = false;
            // 
            // valueTo50
            // 
            this.valueTo50.Enabled = false;
            this.valueTo50.Location = new System.Drawing.Point(262, 87);
            this.valueTo50.Name = "valueTo50";
            this.valueTo50.Size = new System.Drawing.Size(43, 20);
            this.valueTo50.TabIndex = 59;
            this.valueTo50.TabStop = false;
            // 
            // valueTo100
            // 
            this.valueTo100.Enabled = false;
            this.valueTo100.Location = new System.Drawing.Point(262, 61);
            this.valueTo100.Name = "valueTo100";
            this.valueTo100.Size = new System.Drawing.Size(43, 20);
            this.valueTo100.TabIndex = 58;
            this.valueTo100.TabStop = false;
            // 
            // valueTo200
            // 
            this.valueTo200.Enabled = false;
            this.valueTo200.Location = new System.Drawing.Point(262, 35);
            this.valueTo200.Name = "valueTo200";
            this.valueTo200.Size = new System.Drawing.Size(43, 20);
            this.valueTo200.TabIndex = 57;
            this.valueTo200.TabStop = false;
            // 
            // valueTo500
            // 
            this.valueTo500.Enabled = false;
            this.valueTo500.Location = new System.Drawing.Point(262, 9);
            this.valueTo500.Name = "valueTo500";
            this.valueTo500.Size = new System.Drawing.Size(43, 20);
            this.valueTo500.TabIndex = 56;
            this.valueTo500.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Enabled = false;
            this.buttonClose.Location = new System.Drawing.Point(12, 246);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 71;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(7, 71);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(143, 45);
            this.buttonFinish.TabIndex = 4;
            this.buttonFinish.TabStop = false;
            this.buttonFinish.Text = "Podsumwanie";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(363, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(47, 50);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(34, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "▲";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(34, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "▼";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // buttonSetTo0
            // 
            this.buttonSetTo0.Enabled = false;
            this.buttonSetTo0.Location = new System.Drawing.Point(93, 246);
            this.buttonSetTo0.Name = "buttonSetTo0";
            this.buttonSetTo0.Size = new System.Drawing.Size(75, 23);
            this.buttonSetTo0.TabIndex = 73;
            this.buttonSetTo0.TabStop = false;
            this.buttonSetTo0.Text = "Wyzeruj";
            this.buttonSetTo0.UseVisualStyleBackColor = true;
            this.buttonSetTo0.Click += new System.EventHandler(this.buttonSetTo0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 407);
            this.Controls.Add(this.buttonSetTo0);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.valueTo001);
            this.Controls.Add(this.valueTo002);
            this.Controls.Add(this.valueTo005);
            this.Controls.Add(this.valueTo010);
            this.Controls.Add(this.valueTo020);
            this.Controls.Add(this.valueTo050);
            this.Controls.Add(this.valueTo1);
            this.Controls.Add(this.valueTo2);
            this.Controls.Add(this.valueTo5);
            this.Controls.Add(this.valueTo10);
            this.Controls.Add(this.valueTo20);
            this.Controls.Add(this.valueTo50);
            this.Controls.Add(this.valueTo100);
            this.Controls.Add(this.valueTo200);
            this.Controls.Add(this.valueTo500);
            this.Controls.Add(this.labelSum001);
            this.Controls.Add(this.labelSum002);
            this.Controls.Add(this.labelSum005);
            this.Controls.Add(this.labelSum010);
            this.Controls.Add(this.labelSum020);
            this.Controls.Add(this.labelSum050);
            this.Controls.Add(this.labelSum1);
            this.Controls.Add(this.labelSum2);
            this.Controls.Add(this.labelSum5);
            this.Controls.Add(this.labelSum10);
            this.Controls.Add(this.labelSum20);
            this.Controls.Add(this.labelSum50);
            this.Controls.Add(this.labelSum100);
            this.Controls.Add(this.labelSum200);
            this.Controls.Add(this.labelSum500);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.inputTo001);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.inputTo002);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.inputTo005);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.inputTo010);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.inputTo020);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTo050);
            this.Controls.Add(this.inputTo1);
            this.Controls.Add(this.inputTo2);
            this.Controls.Add(this.inputTo5);
            this.Controls.Add(this.inputTo10);
            this.Controls.Add(this.inputTo20);
            this.Controls.Add(this.inputTo50);
            this.Controls.Add(this.inputTo100);
            this.Controls.Add(this.inputTo200);
            this.Controls.Add(this.inputTo500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Raport gotówki dla stacji: SP ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputTo500;
        private System.Windows.Forms.TextBox inputTo200;
        private System.Windows.Forms.TextBox inputTo100;
        private System.Windows.Forms.TextBox inputTo50;
        private System.Windows.Forms.TextBox inputTo20;
        private System.Windows.Forms.TextBox inputTo10;
        private System.Windows.Forms.TextBox inputTo5;
        private System.Windows.Forms.TextBox inputTo2;
        private System.Windows.Forms.TextBox inputTo1;
        private System.Windows.Forms.TextBox inputTo050;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox inputTo020;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox inputTo010;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox inputTo005;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox inputTo002;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox inputTo001;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelSumaArkusz;
        private System.Windows.Forms.Label labelSumaWszystko;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelSum500;
        private System.Windows.Forms.Label labelSum200;
        private System.Windows.Forms.Label labelSum100;
        private System.Windows.Forms.Label labelSum50;
        private System.Windows.Forms.Label labelSum20;
        private System.Windows.Forms.Label labelSum050;
        private System.Windows.Forms.Label labelSum1;
        private System.Windows.Forms.Label labelSum2;
        private System.Windows.Forms.Label labelSum5;
        private System.Windows.Forms.Label labelSum10;
        private System.Windows.Forms.Label labelSum001;
        private System.Windows.Forms.Label labelSum002;
        private System.Windows.Forms.Label labelSum005;
        private System.Windows.Forms.Label labelSum010;
        private System.Windows.Forms.Label labelSum020;
        private System.Windows.Forms.TextBox valueTo001;
        private System.Windows.Forms.TextBox valueTo002;
        private System.Windows.Forms.TextBox valueTo005;
        private System.Windows.Forms.TextBox valueTo010;
        private System.Windows.Forms.TextBox valueTo020;
        private System.Windows.Forms.TextBox valueTo050;
        private System.Windows.Forms.TextBox valueTo1;
        private System.Windows.Forms.TextBox valueTo2;
        private System.Windows.Forms.TextBox valueTo5;
        private System.Windows.Forms.TextBox valueTo10;
        private System.Windows.Forms.TextBox valueTo20;
        private System.Windows.Forms.TextBox valueTo50;
        private System.Windows.Forms.TextBox valueTo100;
        private System.Windows.Forms.TextBox valueTo200;
        private System.Windows.Forms.TextBox valueTo500;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonSetTo0;
    }
}

