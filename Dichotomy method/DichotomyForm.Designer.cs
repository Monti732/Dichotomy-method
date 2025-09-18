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
    label1 = new System.Windows.Forms.Label();
    label2 = new System.Windows.Forms.Label();
    aValue = new System.Windows.Forms.TextBox();
    bValue = new System.Windows.Forms.TextBox();
    label3 = new System.Windows.Forms.Label();
    eValue = new System.Windows.Forms.TextBox();
    root = new System.Windows.Forms.Label();
    formulaTextBox = new System.Windows.Forms.TextBox();
    label4 = new System.Windows.Forms.Label();
    allowCustomRange = new System.Windows.Forms.CheckBox();
    calculateButton = new System.Windows.Forms.Button();
    tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
    menuStrip1 = new System.Windows.Forms.MenuStrip();
    toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
    tableLayoutPanel1.SuspendLayout();
    SuspendLayout();
    // 
    // plot
    // 
    plot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
    plot.Location = new System.Drawing.Point(328, 24);
    plot.Name = "plot";
    plot.Size = new System.Drawing.Size(532, 466);
    plot.TabIndex = 0;
    // 
    // label1
    // 
    label1.Location = new System.Drawing.Point(3, 0);
    label1.Name = "label1";
    label1.Size = new System.Drawing.Size(40, 31);
    label1.TabIndex = 1;
    label1.Text = "A =";
    label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // label2
    // 
    label2.Location = new System.Drawing.Point(3, 40);
    label2.Name = "label2";
    label2.Size = new System.Drawing.Size(40, 31);
    label2.TabIndex = 2;
    label2.Text = "B =";
    label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // aValue
    // 
    aValue.Location = new System.Drawing.Point(55, 3);
    aValue.Multiline = true;
    aValue.Name = "aValue";
    aValue.Size = new System.Drawing.Size(98, 34);
    aValue.TabIndex = 3;
    // 
    // bValue
    // 
    bValue.Location = new System.Drawing.Point(55, 43);
    bValue.Multiline = true;
    bValue.Name = "bValue";
    bValue.Size = new System.Drawing.Size(98, 34);
    bValue.TabIndex = 4;
    // 
    // label3
    // 
    label3.Location = new System.Drawing.Point(3, 80);
    label3.Name = "label3";
    label3.Size = new System.Drawing.Size(40, 31);
    label3.TabIndex = 5;
    label3.Text = "E =";
    label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // eValue
    // 
    eValue.Location = new System.Drawing.Point(55, 83);
    eValue.Multiline = true;
    eValue.Name = "eValue";
    eValue.Size = new System.Drawing.Size(98, 34);
    eValue.TabIndex = 6;
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
    allowCustomRange.Size = new System.Drawing.Size(161, 27);
    allowCustomRange.TabIndex = 10;
    allowCustomRange.Text = "Use cutstom range";
    allowCustomRange.UseVisualStyleBackColor = true;
    allowCustomRange.CheckedChanged += allowCustomRange_CheckedChanged;
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
    tableLayoutPanel1.Controls.Add(aValue, 1, 0);
    tableLayoutPanel1.Controls.Add(bValue, 1, 1);
    tableLayoutPanel1.Controls.Add(eValue, 1, 2);
    tableLayoutPanel1.Controls.Add(calculateButton, 1, 3);
    tableLayoutPanel1.Controls.Add(label1, 0, 0);
    tableLayoutPanel1.Controls.Add(label2, 0, 1);
    tableLayoutPanel1.Controls.Add(label3, 0, 2);
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
    // DichotomyForm
    // 
    AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    ClientSize = new System.Drawing.Size(911, 576);
    Controls.Add(formulaTextBox);
    Controls.Add(tableLayoutPanel1);
    Controls.Add(root);
    Controls.Add(plot);
    Controls.Add(allowCustomRange);
    Controls.Add(label4);
    Controls.Add(menuStrip1);
    MainMenuStrip = menuStrip1;
    Text = "Dichotomy";
    WindowState = System.Windows.Forms.FormWindowState.Maximized;
    tableLayoutPanel1.ResumeLayout(false);
    tableLayoutPanel1.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }
  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

  private System.Windows.Forms.Button calculateButton;

  private System.Windows.Forms.CheckBox allowCustomRange;

  private System.Windows.Forms.TextBox formulaTextBox;
  private System.Windows.Forms.Label label4;

  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox eValue;
  private System.Windows.Forms.Label root;

  private System.Windows.Forms.TextBox bValue;

  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox aValue;

  private System.Windows.Forms.Label label1;

  private System.Windows.Forms.Panel plot;

  #endregion
}