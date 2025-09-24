namespace Dichotomy_method;

partial class DichotomyForm {
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  ///  Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing) {
    if (disposing && (components != null)) {
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DichotomyForm));
        plot = new Panel();
        aLabel = new Label();
        bLabel = new Label();
        aTextBox = new TextBox();
        bTextBox = new TextBox();
        eLabel = new Label();
        eTextBox = new TextBox();
        rootLabel = new Label();
        formulaTextBox = new TextBox();
        label4 = new Label();
        allowCustomRange = new CheckBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        stepTextBox = new TextBox();
        stepLabel = new Label();
        x2TextBox = new TextBox();
        x1TextBox = new TextBox();
        x2Label = new Label();
        x1Label = new Label();
        menuStrip1 = new MenuStrip();
        файлToolStripMenuItem = new ToolStripMenuItem();
        calculateRootToolStripMenuItem = new ToolStripMenuItem();
        buildAGraphToolStripMenuItem = new ToolStripMenuItem();
        resetToolStripMenuItem = new ToolStripMenuItem();
        создатьToolStripMenuItem = new ToolStripMenuItem();
        открытьToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator = new ToolStripSeparator();
        сохранитьToolStripMenuItem = new ToolStripMenuItem();
        сохранитькакToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        печатьToolStripMenuItem = new ToolStripMenuItem();
        предварительныйпросмотрToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator2 = new ToolStripSeparator();
        выходToolStripMenuItem = new ToolStripMenuItem();
        правкаToolStripMenuItem = new ToolStripMenuItem();
        отменадействияToolStripMenuItem = new ToolStripMenuItem();
        отменадействияToolStripMenuItem1 = new ToolStripMenuItem();
        toolStripSeparator3 = new ToolStripSeparator();
        вырезатьToolStripMenuItem = new ToolStripMenuItem();
        копироватьToolStripMenuItem = new ToolStripMenuItem();
        вставкаToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator4 = new ToolStripSeparator();
        выделитьвсеToolStripMenuItem = new ToolStripMenuItem();
        сервисToolStripMenuItem = new ToolStripMenuItem();
        настройкиToolStripMenuItem = new ToolStripMenuItem();
        параметрыToolStripMenuItem = new ToolStripMenuItem();
        справкаToolStripMenuItem = new ToolStripMenuItem();
        содержаниеToolStripMenuItem = new ToolStripMenuItem();
        индексToolStripMenuItem = new ToolStripMenuItem();
        поискToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator5 = new ToolStripSeparator();
        опрограммеToolStripMenuItem = new ToolStripMenuItem();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // plot
        // 
        plot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        plot.Location = new Point(419, 85);
        plot.Name = "plot";
        plot.Size = new Size(422, 337);
        plot.TabIndex = 0;
        // 
        // aLabel
        // 
        aLabel.Location = new Point(3, 0);
        aLabel.Name = "aLabel";
        aLabel.Size = new Size(40, 34);
        aLabel.TabIndex = 1;
        aLabel.Text = "A =";
        aLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // bLabel
        // 
        bLabel.Location = new Point(3, 35);
        bLabel.Name = "bLabel";
        bLabel.Size = new Size(40, 28);
        bLabel.TabIndex = 2;
        bLabel.Text = "B =";
        bLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // aTextBox
        // 
        aTextBox.Location = new Point(55, 3);
        aTextBox.Multiline = true;
        aTextBox.Name = "aTextBox";
        aTextBox.Size = new Size(98, 29);
        aTextBox.TabIndex = 3;
        aTextBox.Tag = "Signed";
        aTextBox.Text = "2.5";
        aTextBox.KeyPress += ApplyInputRestrictionByTag;
        // 
        // bTextBox
        // 
        bTextBox.Location = new Point(55, 38);
        bTextBox.Multiline = true;
        bTextBox.Name = "bTextBox";
        bTextBox.Size = new Size(98, 29);
        bTextBox.TabIndex = 4;
        bTextBox.Tag = "Signed";
        bTextBox.Text = "3.5";
        bTextBox.KeyPress += ApplyInputRestrictionByTag;
        // 
        // eLabel
        // 
        eLabel.Location = new Point(3, 70);
        eLabel.Name = "eLabel";
        eLabel.Size = new Size(40, 36);
        eLabel.TabIndex = 5;
        eLabel.Text = "E =";
        eLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // eTextBox
        // 
        eTextBox.Location = new Point(55, 73);
        eTextBox.Multiline = true;
        eTextBox.Name = "eTextBox";
        eTextBox.Size = new Size(98, 30);
        eTextBox.TabIndex = 6;
        eTextBox.Tag = "Unsigned";
        eTextBox.Text = "0.1";
        eTextBox.KeyPress += ApplyInputRestrictionByTag;
        // 
        // rootLabel
        // 
        rootLabel.BackColor = SystemColors.Control;
        rootLabel.BorderStyle = BorderStyle.FixedSingle;
        rootLabel.Location = new Point(32, 286);
        rootLabel.Name = "rootLabel";
        rootLabel.Size = new Size(216, 52);
        rootLabel.TabIndex = 7;
        rootLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // formulaTextBox
        // 
        formulaTextBox.Location = new Point(92, 102);
        formulaTextBox.Multiline = true;
        formulaTextBox.Name = "formulaTextBox";
        formulaTextBox.RightToLeft = RightToLeft.No;
        formulaTextBox.Size = new Size(192, 52);
        formulaTextBox.TabIndex = 9;
        formulaTextBox.Text = "sin(x)";
        // 
        // label4
        // 
        label4.Location = new Point(35, 102);
        label4.Name = "label4";
        label4.Size = new Size(45, 52);
        label4.TabIndex = 8;
        label4.Text = "f(x) =";
        label4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // allowCustomRange
        // 
        allowCustomRange.Location = new Point(32, 356);
        allowCustomRange.Name = "allowCustomRange";
        allowCustomRange.Size = new Size(156, 56);
        allowCustomRange.TabIndex = 10;
        allowCustomRange.Text = "Use cutstom range\r\nfor plot render";
        allowCustomRange.UseVisualStyleBackColor = true;
        allowCustomRange.MouseCaptureChanged += allowCustomRange_MouseCaptureChanged;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.42619F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.5738144F));
        tableLayoutPanel1.Controls.Add(aTextBox, 1, 0);
        tableLayoutPanel1.Controls.Add(bTextBox, 1, 1);
        tableLayoutPanel1.Controls.Add(eTextBox, 1, 2);
        tableLayoutPanel1.Controls.Add(aLabel, 0, 0);
        tableLayoutPanel1.Controls.Add(bLabel, 0, 1);
        tableLayoutPanel1.Controls.Add(eLabel, 0, 2);
        tableLayoutPanel1.Location = new Point(32, 160);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.Size = new Size(156, 106);
        tableLayoutPanel1.TabIndex = 12;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.05128F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.9487152F));
        tableLayoutPanel2.Controls.Add(stepTextBox, 1, 2);
        tableLayoutPanel2.Controls.Add(stepLabel, 0, 2);
        tableLayoutPanel2.Controls.Add(x2TextBox, 1, 1);
        tableLayoutPanel2.Controls.Add(x1TextBox, 1, 0);
        tableLayoutPanel2.Controls.Add(x2Label, 0, 1);
        tableLayoutPanel2.Controls.Add(x1Label, 0, 0);
        tableLayoutPanel2.Location = new Point(35, 418);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 3;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.00971F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30.0970879F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 36.8932037F));
        tableLayoutPanel2.Size = new Size(156, 103);
        tableLayoutPanel2.TabIndex = 13;
        tableLayoutPanel2.Visible = false;
        // 
        // stepTextBox
        // 
        stepTextBox.Location = new Point(53, 68);
        stepTextBox.Name = "stepTextBox";
        stepTextBox.Size = new Size(100, 27);
        stepTextBox.TabIndex = 16;
        stepTextBox.Tag = "Unsigned";
        stepTextBox.KeyPress += ApplyInputRestrictionByTag;
        // 
        // stepLabel
        // 
        stepLabel.Location = new Point(3, 65);
        stepLabel.Name = "stepLabel";
        stepLabel.Size = new Size(44, 23);
        stepLabel.TabIndex = 14;
        stepLabel.Text = "Step";
        stepLabel.TextAlign = ContentAlignment.BottomCenter;
        // 
        // x2TextBox
        // 
        x2TextBox.Location = new Point(53, 37);
        x2TextBox.Name = "x2TextBox";
        x2TextBox.Size = new Size(100, 27);
        x2TextBox.TabIndex = 15;
        x2TextBox.Tag = "Signed";
        x2TextBox.KeyPress += ApplyInputRestrictionByTag;
        // 
        // x1TextBox
        // 
        x1TextBox.Location = new Point(53, 3);
        x1TextBox.Name = "x1TextBox";
        x1TextBox.Size = new Size(100, 27);
        x1TextBox.TabIndex = 14;
        x1TextBox.Tag = "Signed";
        x1TextBox.KeyPress += ApplyInputRestrictionByTag;
        // 
        // x2Label
        // 
        x2Label.Location = new Point(3, 34);
        x2Label.Name = "x2Label";
        x2Label.Size = new Size(38, 23);
        x2Label.TabIndex = 14;
        x2Label.Text = "x2 =";
        x2Label.TextAlign = ContentAlignment.BottomCenter;
        // 
        // x1Label
        // 
        x1Label.Location = new Point(3, 0);
        x1Label.Name = "x1Label";
        x1Label.Size = new Size(38, 23);
        x1Label.TabIndex = 15;
        x1Label.Text = "x1 =";
        x1Label.TextAlign = ContentAlignment.BottomCenter;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem, сервисToolStripMenuItem, справкаToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(911, 28);
        menuStrip1.TabIndex = 14;
        menuStrip1.Text = "menuStrip1";
        // 
        // файлToolStripMenuItem
        // 
        файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculateRootToolStripMenuItem, buildAGraphToolStripMenuItem, resetToolStripMenuItem, создатьToolStripMenuItem, открытьToolStripMenuItem, toolStripSeparator, сохранитьToolStripMenuItem, сохранитькакToolStripMenuItem, toolStripSeparator1, печатьToolStripMenuItem, предварительныйпросмотрToolStripMenuItem, toolStripSeparator2, выходToolStripMenuItem });
        файлToolStripMenuItem.Name = "файлToolStripMenuItem";
        файлToolStripMenuItem.Size = new Size(59, 24);
        файлToolStripMenuItem.Text = "&Файл";
        // 
        // calculateRootToolStripMenuItem
        // 
        calculateRootToolStripMenuItem.Image = (Image)resources.GetObject("calculateRootToolStripMenuItem.Image");
        calculateRootToolStripMenuItem.Name = "calculateRootToolStripMenuItem";
        calculateRootToolStripMenuItem.Size = new Size(294, 26);
        calculateRootToolStripMenuItem.Text = "Calculate root";
        calculateRootToolStripMenuItem.Click += CalculateRoot;
        // 
        // buildAGraphToolStripMenuItem
        // 
        buildAGraphToolStripMenuItem.Image = (Image)resources.GetObject("buildAGraphToolStripMenuItem.Image");
        buildAGraphToolStripMenuItem.Name = "buildAGraphToolStripMenuItem";
        buildAGraphToolStripMenuItem.Size = new Size(294, 26);
        buildAGraphToolStripMenuItem.Text = "Build graph";
        buildAGraphToolStripMenuItem.Click += BuildPlot;
        // 
        // resetToolStripMenuItem
        // 
        resetToolStripMenuItem.Image = (Image)resources.GetObject("resetToolStripMenuItem.Image");
        resetToolStripMenuItem.Name = "resetToolStripMenuItem";
        resetToolStripMenuItem.Size = new Size(294, 26);
        resetToolStripMenuItem.Text = "Reset";
        resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
        // 
        // создатьToolStripMenuItem
        // 
        создатьToolStripMenuItem.Image = (Image)resources.GetObject("создатьToolStripMenuItem.Image");
        создатьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
        создатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
        создатьToolStripMenuItem.Size = new Size(294, 26);
        создатьToolStripMenuItem.Text = "Со&здать";
        // 
        // открытьToolStripMenuItem
        // 
        открытьToolStripMenuItem.Image = (Image)resources.GetObject("открытьToolStripMenuItem.Image");
        открытьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
        открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
        открытьToolStripMenuItem.Size = new Size(294, 26);
        открытьToolStripMenuItem.Text = "&Открыть";
        // 
        // toolStripSeparator
        // 
        toolStripSeparator.Name = "toolStripSeparator";
        toolStripSeparator.Size = new Size(291, 6);
        // 
        // сохранитьToolStripMenuItem
        // 
        сохранитьToolStripMenuItem.Image = (Image)resources.GetObject("сохранитьToolStripMenuItem.Image");
        сохранитьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
        сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
        сохранитьToolStripMenuItem.Size = new Size(294, 26);
        сохранитьToolStripMenuItem.Text = "Со&хранить";
        // 
        // сохранитькакToolStripMenuItem
        // 
        сохранитькакToolStripMenuItem.Name = "сохранитькакToolStripMenuItem";
        сохранитькакToolStripMenuItem.Size = new Size(294, 26);
        сохранитькакToolStripMenuItem.Text = "Сохранить &как";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(291, 6);
        // 
        // печатьToolStripMenuItem
        // 
        печатьToolStripMenuItem.Image = (Image)resources.GetObject("печатьToolStripMenuItem.Image");
        печатьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
        печатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
        печатьToolStripMenuItem.Size = new Size(294, 26);
        печатьToolStripMenuItem.Text = "&Печать";
        // 
        // предварительныйпросмотрToolStripMenuItem
        // 
        предварительныйпросмотрToolStripMenuItem.Image = (Image)resources.GetObject("предварительныйпросмотрToolStripMenuItem.Image");
        предварительныйпросмотрToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        предварительныйпросмотрToolStripMenuItem.Name = "предварительныйпросмотрToolStripMenuItem";
        предварительныйпросмотрToolStripMenuItem.Size = new Size(294, 26);
        предварительныйпросмотрToolStripMenuItem.Text = "Предварительный прос&мотр";
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(291, 6);
        // 
        // выходToolStripMenuItem
        // 
        выходToolStripMenuItem.Name = "выходToolStripMenuItem";
        выходToolStripMenuItem.Size = new Size(294, 26);
        выходToolStripMenuItem.Text = "Вы&ход";
        // 
        // правкаToolStripMenuItem
        // 
        правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отменадействияToolStripMenuItem, отменадействияToolStripMenuItem1, toolStripSeparator3, вырезатьToolStripMenuItem, копироватьToolStripMenuItem, вставкаToolStripMenuItem, toolStripSeparator4, выделитьвсеToolStripMenuItem });
        правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
        правкаToolStripMenuItem.Size = new Size(74, 24);
        правкаToolStripMenuItem.Text = "&Правка";
        // 
        // отменадействияToolStripMenuItem
        // 
        отменадействияToolStripMenuItem.Name = "отменадействияToolStripMenuItem";
        отменадействияToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
        отменадействияToolStripMenuItem.Size = new Size(263, 26);
        отменадействияToolStripMenuItem.Text = "&Отмена действия";
        // 
        // отменадействияToolStripMenuItem1
        // 
        отменадействияToolStripMenuItem1.Name = "отменадействияToolStripMenuItem1";
        отменадействияToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Y;
        отменадействияToolStripMenuItem1.Size = new Size(263, 26);
        отменадействияToolStripMenuItem1.Text = "&Отмена действия";
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new Size(260, 6);
        // 
        // вырезатьToolStripMenuItem
        // 
        вырезатьToolStripMenuItem.Image = (Image)resources.GetObject("вырезатьToolStripMenuItem.Image");
        вырезатьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
        вырезатьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
        вырезатьToolStripMenuItem.Size = new Size(263, 26);
        вырезатьToolStripMenuItem.Text = "Вырезат&ь";
        // 
        // копироватьToolStripMenuItem
        // 
        копироватьToolStripMenuItem.Image = (Image)resources.GetObject("копироватьToolStripMenuItem.Image");
        копироватьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
        копироватьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
        копироватьToolStripMenuItem.Size = new Size(263, 26);
        копироватьToolStripMenuItem.Text = "&Копировать";
        // 
        // вставкаToolStripMenuItem
        // 
        вставкаToolStripMenuItem.Image = (Image)resources.GetObject("вставкаToolStripMenuItem.Image");
        вставкаToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
        вставкаToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
        вставкаToolStripMenuItem.Size = new Size(263, 26);
        вставкаToolStripMenuItem.Text = "Вст&авка";
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new Size(260, 6);
        // 
        // выделитьвсеToolStripMenuItem
        // 
        выделитьвсеToolStripMenuItem.Name = "выделитьвсеToolStripMenuItem";
        выделитьвсеToolStripMenuItem.Size = new Size(263, 26);
        выделитьвсеToolStripMenuItem.Text = "Выделить &все";
        // 
        // сервисToolStripMenuItem
        // 
        сервисToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { настройкиToolStripMenuItem, параметрыToolStripMenuItem });
        сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
        сервисToolStripMenuItem.Size = new Size(73, 24);
        сервисToolStripMenuItem.Text = "Сер&вис";
        // 
        // настройкиToolStripMenuItem
        // 
        настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
        настройкиToolStripMenuItem.Size = new Size(173, 26);
        настройкиToolStripMenuItem.Text = "&Настройки";
        // 
        // параметрыToolStripMenuItem
        // 
        параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
        параметрыToolStripMenuItem.Size = new Size(173, 26);
        параметрыToolStripMenuItem.Text = "&Параметры";
        // 
        // справкаToolStripMenuItem
        // 
        справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { содержаниеToolStripMenuItem, индексToolStripMenuItem, поискToolStripMenuItem, toolStripSeparator5, опрограммеToolStripMenuItem });
        справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
        справкаToolStripMenuItem.Size = new Size(81, 24);
        справкаToolStripMenuItem.Text = "&Справка";
        // 
        // содержаниеToolStripMenuItem
        // 
        содержаниеToolStripMenuItem.Name = "содержаниеToolStripMenuItem";
        содержаниеToolStripMenuItem.Size = new Size(196, 26);
        содержаниеToolStripMenuItem.Text = "&Содержание";
        // 
        // индексToolStripMenuItem
        // 
        индексToolStripMenuItem.Name = "индексToolStripMenuItem";
        индексToolStripMenuItem.Size = new Size(196, 26);
        индексToolStripMenuItem.Text = "&Индекс";
        // 
        // поискToolStripMenuItem
        // 
        поискToolStripMenuItem.Name = "поискToolStripMenuItem";
        поискToolStripMenuItem.Size = new Size(196, 26);
        поискToolStripMenuItem.Text = "&Поиск";
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new Size(193, 6);
        // 
        // опрограммеToolStripMenuItem
        // 
        опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
        опрограммеToolStripMenuItem.Size = new Size(196, 26);
        опрограммеToolStripMenuItem.Text = "&О программе...";
        // 
        // DichotomyForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(911, 576);
        Controls.Add(tableLayoutPanel2);
        Controls.Add(formulaTextBox);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(rootLabel);
        Controls.Add(plot);
        Controls.Add(allowCustomRange);
        Controls.Add(label4);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "DichotomyForm";
        Tag = "Signed";
        Text = "Dichotomy";
        WindowState = FormWindowState.Maximized;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem buildAGraphToolStripMenuItem;

  private System.Windows.Forms.ToolStripMenuItem calculateRootToolStripMenuItem;

  private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
  private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem сохранитькакToolStripMenuItem;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
  private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
  private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem1;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
  private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem вставкаToolStripMenuItem;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
  private System.Windows.Forms.ToolStripMenuItem выделитьвсеToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem содержаниеToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem индексToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
  private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;

  private System.Windows.Forms.MenuStrip menuStrip1;

  private System.Windows.Forms.Label stepLabel;
  private System.Windows.Forms.TextBox stepTextBox;

  private System.Windows.Forms.Label x2Label;
  private System.Windows.Forms.Label x1Label;
  private System.Windows.Forms.TextBox x1TextBox;
  private System.Windows.Forms.TextBox x2TextBox;

  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

  private System.Windows.Forms.CheckBox allowCustomRange;

  private System.Windows.Forms.TextBox formulaTextBox;
  private System.Windows.Forms.Label label4;

  private System.Windows.Forms.Label eLabel;
  private System.Windows.Forms.TextBox eTextBox;
  private System.Windows.Forms.Label rootLabel;

  private System.Windows.Forms.TextBox bTextBox;

  private System.Windows.Forms.Label bLabel;
  private System.Windows.Forms.TextBox aTextBox;

  private System.Windows.Forms.Label aLabel;

  private System.Windows.Forms.Panel plot;

    #endregion

    private ToolStripMenuItem resetToolStripMenuItem;
}