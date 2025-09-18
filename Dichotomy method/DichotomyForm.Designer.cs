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
  private void InitializeComponent() {
    plot = new System.Windows.Forms.Panel();
    aLabel = new System.Windows.Forms.Label();
    bLabel = new System.Windows.Forms.Label();
    aTextBox = new System.Windows.Forms.TextBox();
    bTextBox = new System.Windows.Forms.TextBox();
    eLabel = new System.Windows.Forms.Label();
    eTextBox = new System.Windows.Forms.TextBox();
    root = new System.Windows.Forms.Label();
    formulaTextBox = new System.Windows.Forms.TextBox();
    label4 = new System.Windows.Forms.Label();
    allowCustomRange = new System.Windows.Forms.CheckBox();
    calculateButton = new System.Windows.Forms.Button();
    tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
    tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
    stepTextBox = new System.Windows.Forms.TextBox();
    stepLabel = new System.Windows.Forms.Label();
    x2TextBox = new System.Windows.Forms.TextBox();
    x1TextBox = new System.Windows.Forms.TextBox();
    x2Label = new System.Windows.Forms.Label();
    x1Label = new System.Windows.Forms.Label();
    tableLayoutPanel1.SuspendLayout();
    tableLayoutPanel2.SuspendLayout();
    SuspendLayout();
    // 
    // plot
    // 
    plot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
    plot.Location = new System.Drawing.Point(419, 85);
    plot.Name = "plot";
    plot.Size = new System.Drawing.Size(422, 337);
    plot.TabIndex = 0;
    // 
    // aLabel
    // 
    aLabel.Location = new System.Drawing.Point(3, 0);
    aLabel.Name = "aLabel";
    aLabel.Size = new System.Drawing.Size(40, 34);
    aLabel.TabIndex = 1;
    aLabel.Text = "A =";
    aLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // bLabel
    // 
    bLabel.Location = new System.Drawing.Point(3, 40);
    bLabel.Name = "bLabel";
    bLabel.Size = new System.Drawing.Size(40, 28);
    bLabel.TabIndex = 2;
    bLabel.Text = "B =";
    bLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // aTextBox
    // 
    aTextBox.Location = new System.Drawing.Point(55, 3);
    aTextBox.Multiline = true;
    aTextBox.Name = "aTextBox";
    aTextBox.Size = new System.Drawing.Size(98, 34);
    aTextBox.TabIndex = 3;
    aTextBox.Tag = "Signed";
    aTextBox.KeyPress += ApplyInputRestrictionByTag;
    // 
    // bTextBox
    // 
    bTextBox.Location = new System.Drawing.Point(55, 43);
    bTextBox.Multiline = true;
    bTextBox.Name = "bTextBox";
    bTextBox.Size = new System.Drawing.Size(98, 34);
    bTextBox.TabIndex = 4;
    bTextBox.Tag = "Signed";
    bTextBox.KeyPress += ApplyInputRestrictionByTag;
    // 
    // eLabel
    // 
    eLabel.Location = new System.Drawing.Point(3, 80);
    eLabel.Name = "eLabel";
    eLabel.Size = new System.Drawing.Size(40, 37);
    eLabel.TabIndex = 5;
    eLabel.Text = "E =";
    eLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // eTextBox
    // 
    eTextBox.Location = new System.Drawing.Point(55, 83);
    eTextBox.Multiline = true;
    eTextBox.Name = "eTextBox";
    eTextBox.Size = new System.Drawing.Size(98, 34);
    eTextBox.TabIndex = 6;
    eTextBox.Tag = "Unsigned";
    eTextBox.KeyPress += ApplyInputRestrictionByTag;
    // 
    // root
    // 
    root.Location = new System.Drawing.Point(63, 470);
    root.Name = "root";
    root.Size = new System.Drawing.Size(181, 31);
    root.TabIndex = 7;
    root.Text = "root";
    root.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // formulaTextBox
    // 
    formulaTextBox.Location = new System.Drawing.Point(95, 24);
    formulaTextBox.Multiline = true;
    formulaTextBox.Name = "formulaTextBox";
    formulaTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
    formulaTextBox.Size = new System.Drawing.Size(192, 52);
    formulaTextBox.TabIndex = 9;
    formulaTextBox.Text = "x^2";
    // 
    // label4
    // 
    label4.Location = new System.Drawing.Point(38, 24);
    label4.Name = "label4";
    label4.Size = new System.Drawing.Size(45, 52);
    label4.TabIndex = 8;
    label4.Text = "f(x) =";
    label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // allowCustomRange
    // 
    allowCustomRange.Location = new System.Drawing.Point(35, 264);
    allowCustomRange.Name = "allowCustomRange";
    allowCustomRange.Size = new System.Drawing.Size(156, 27);
    allowCustomRange.TabIndex = 10;
    allowCustomRange.Text = "Use cutstom range";
    allowCustomRange.UseVisualStyleBackColor = true;
    // 
    // calculateButton
    // 
    calculateButton.Location = new System.Drawing.Point(55, 123);
    calculateButton.Name = "calculateButton";
    calculateButton.Size = new System.Drawing.Size(98, 34);
    calculateButton.TabIndex = 11;
    calculateButton.Text = "Calculate";
    calculateButton.UseVisualStyleBackColor = true;
    calculateButton.Click += CalculateButton_Click;
    // 
    // tableLayoutPanel1
    // 
    tableLayoutPanel1.ColumnCount = 2;
    tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.42619F));
    tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.573814F));
    tableLayoutPanel1.Controls.Add(aTextBox, 1, 0);
    tableLayoutPanel1.Controls.Add(bTextBox, 1, 1);
    tableLayoutPanel1.Controls.Add(eTextBox, 1, 2);
    tableLayoutPanel1.Controls.Add(calculateButton, 1, 3);
    tableLayoutPanel1.Controls.Add(aLabel, 0, 0);
    tableLayoutPanel1.Controls.Add(bLabel, 0, 1);
    tableLayoutPanel1.Controls.Add(eLabel, 0, 2);
    tableLayoutPanel1.Location = new System.Drawing.Point(35, 82);
    tableLayoutPanel1.Name = "tableLayoutPanel1";
    tableLayoutPanel1.RowCount = 4;
    tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
    tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
    tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
    tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
    tableLayoutPanel1.Size = new System.Drawing.Size(156, 160);
    tableLayoutPanel1.TabIndex = 12;
    // 
    // tableLayoutPanel2
    // 
    tableLayoutPanel2.ColumnCount = 2;
    tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.05128F));
    tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.948715F));
    tableLayoutPanel2.Controls.Add(stepTextBox, 1, 2);
    tableLayoutPanel2.Controls.Add(stepLabel, 0, 2);
    tableLayoutPanel2.Controls.Add(x2TextBox, 1, 1);
    tableLayoutPanel2.Controls.Add(x1TextBox, 1, 0);
    tableLayoutPanel2.Controls.Add(x2Label, 0, 1);
    tableLayoutPanel2.Controls.Add(x1Label, 0, 0);
    tableLayoutPanel2.Location = new System.Drawing.Point(35, 297);
    tableLayoutPanel2.Name = "tableLayoutPanel2";
    tableLayoutPanel2.RowCount = 3;
    tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.00971F));
    tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.097088F));
    tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.893204F));
    tableLayoutPanel2.Size = new System.Drawing.Size(156, 103);
    tableLayoutPanel2.TabIndex = 13;
    // 
    // stepTextBox
    // 
    stepTextBox.Location = new System.Drawing.Point(53, 68);
    stepTextBox.Name = "stepTextBox";
    stepTextBox.Size = new System.Drawing.Size(100, 27);
    stepTextBox.TabIndex = 16;
    stepTextBox.Tag = "Usigned";
    stepTextBox.KeyPress += ApplyInputRestrictionByTag;
    // 
    // stepLabel
    // 
    stepLabel.Location = new System.Drawing.Point(3, 65);
    stepLabel.Name = "stepLabel";
    stepLabel.Size = new System.Drawing.Size(44, 23);
    stepLabel.TabIndex = 14;
    stepLabel.Text = "Step";
    stepLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
    // 
    // x2TextBox
    // 
    x2TextBox.Location = new System.Drawing.Point(53, 37);
    x2TextBox.Name = "x2TextBox";
    x2TextBox.Size = new System.Drawing.Size(100, 27);
    x2TextBox.TabIndex = 15;
    x2TextBox.Tag = "Signed";
    x2TextBox.KeyPress += ApplyInputRestrictionByTag;
    // 
    // x1TextBox
    // 
    x1TextBox.Location = new System.Drawing.Point(53, 3);
    x1TextBox.Name = "x1TextBox";
    x1TextBox.Size = new System.Drawing.Size(100, 27);
    x1TextBox.TabIndex = 14;
    x1TextBox.Tag = "Signed";
    x1TextBox.KeyPress += ApplyInputRestrictionByTag;
    // 
    // x2Label
    // 
    x2Label.Location = new System.Drawing.Point(3, 34);
    x2Label.Name = "x2Label";
    x2Label.Size = new System.Drawing.Size(38, 23);
    x2Label.TabIndex = 14;
    x2Label.Text = "x2 =";
    x2Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
    // 
    // x1Label
    // 
    x1Label.Location = new System.Drawing.Point(3, 0);
    x1Label.Name = "x1Label";
    x1Label.Size = new System.Drawing.Size(38, 23);
    x1Label.TabIndex = 15;
    x1Label.Text = "x1 =";
    x1Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
    // 
    // DichotomyForm
    // 
    AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    ClientSize = new System.Drawing.Size(911, 576);
    Controls.Add(tableLayoutPanel2);
    Controls.Add(formulaTextBox);
    Controls.Add(tableLayoutPanel1);
    Controls.Add(root);
    Controls.Add(plot);
    Controls.Add(allowCustomRange);
    Controls.Add(label4);
    Tag = "Signed";
    Text = "Dichotomy";
    WindowState = System.Windows.Forms.FormWindowState.Maximized;
    tableLayoutPanel1.ResumeLayout(false);
    tableLayoutPanel1.PerformLayout();
    tableLayoutPanel2.ResumeLayout(false);
    tableLayoutPanel2.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }

  private System.Windows.Forms.Label stepLabel;
  private System.Windows.Forms.TextBox stepTextBox;

  private System.Windows.Forms.Label x2Label;
  private System.Windows.Forms.Label x1Label;
  private System.Windows.Forms.TextBox x1TextBox;
  private System.Windows.Forms.TextBox x2TextBox;

  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

  private System.Windows.Forms.Button calculateButton;

  private System.Windows.Forms.CheckBox allowCustomRange;

  private System.Windows.Forms.TextBox formulaTextBox;
  private System.Windows.Forms.Label label4;

  private System.Windows.Forms.Label eLabel;
  private System.Windows.Forms.TextBox eTextBox;
  private System.Windows.Forms.Label root;

  private System.Windows.Forms.TextBox bTextBox;

  private System.Windows.Forms.Label bLabel;
  private System.Windows.Forms.TextBox aTextBox;

  private System.Windows.Forms.Label aLabel;

  private System.Windows.Forms.Panel plot;

  #endregion
}