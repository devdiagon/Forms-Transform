namespace TareaFigurasTranslate.figure_views
{
    partial class FrmTrapecio
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
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtInputSide = new System.Windows.Forms.TextBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.txtInputB = new System.Windows.Forms.TextBox();
            this.txtInputA = new System.Windows.Forms.TextBox();
            this.lblInputB = new System.Windows.Forms.Label();
            this.lblInputA = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.bgrProcess = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbrOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.gbrRotate = new System.Windows.Forms.GroupBox();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.gbrScale = new System.Windows.Forms.GroupBox();
            this.lblScaleValue = new System.Windows.Forms.Label();
            this.trbScale = new System.Windows.Forms.TrackBar();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grbInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.bgrProcess.SuspendLayout();
            this.gbrOutputs.SuspendLayout();
            this.gbrRotate.SuspendLayout();
            this.gbrScale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbScale)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtInputSide);
            this.grbInputs.Controls.Add(this.lblSide);
            this.grbInputs.Controls.Add(this.txtInputB);
            this.grbInputs.Controls.Add(this.txtInputA);
            this.grbInputs.Controls.Add(this.lblInputB);
            this.grbInputs.Controls.Add(this.lblInputA);
            this.grbInputs.Font = new System.Drawing.Font("Roboto Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(12, 12);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(452, 163);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtInputSide
            // 
            this.txtInputSide.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSide.Location = new System.Drawing.Point(175, 117);
            this.txtInputSide.Name = "txtInputSide";
            this.txtInputSide.Size = new System.Drawing.Size(199, 28);
            this.txtInputSide.TabIndex = 5;
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSide.Location = new System.Drawing.Point(28, 122);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(130, 18);
            this.lblSide.TabIndex = 4;
            this.lblSide.Text = "Lados oblicuos (l):";
            // 
            // txtInputB
            // 
            this.txtInputB.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputB.Location = new System.Drawing.Point(175, 74);
            this.txtInputB.Name = "txtInputB";
            this.txtInputB.Size = new System.Drawing.Size(199, 28);
            this.txtInputB.TabIndex = 3;
            // 
            // txtInputA
            // 
            this.txtInputA.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputA.Location = new System.Drawing.Point(175, 33);
            this.txtInputA.Name = "txtInputA";
            this.txtInputA.Size = new System.Drawing.Size(199, 28);
            this.txtInputA.TabIndex = 2;
            // 
            // lblInputB
            // 
            this.lblInputB.AutoSize = true;
            this.lblInputB.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputB.Location = new System.Drawing.Point(44, 79);
            this.lblInputB.Name = "lblInputB";
            this.lblInputB.Size = new System.Drawing.Size(114, 18);
            this.lblInputB.TabIndex = 1;
            this.lblInputB.Text = "Base menor (b):";
            // 
            // lblInputA
            // 
            this.lblInputA.AutoSize = true;
            this.lblInputA.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputA.Location = new System.Drawing.Point(42, 38);
            this.lblInputA.Name = "lblInputA";
            this.lblInputA.Size = new System.Drawing.Size(116, 18);
            this.lblInputA.TabIndex = 0;
            this.lblInputA.Text = "Base mayor (B):";
            // 
            // picCanvas
            // 
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Location = new System.Drawing.Point(481, 65);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(643, 493);
            this.picCanvas.TabIndex = 3;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            this.picCanvas.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pic_keyDown);
            // 
            // bgrProcess
            // 
            this.bgrProcess.Controls.Add(this.btnClose);
            this.bgrProcess.Controls.Add(this.btnReset);
            this.bgrProcess.Controls.Add(this.btnCalculate);
            this.bgrProcess.Font = new System.Drawing.Font("Roboto Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgrProcess.Location = new System.Drawing.Point(12, 190);
            this.bgrProcess.Name = "bgrProcess";
            this.bgrProcess.Size = new System.Drawing.Size(452, 94);
            this.bgrProcess.TabIndex = 1;
            this.bgrProcess.TabStop = false;
            this.bgrProcess.Text = "Proceso";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(314, 38);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(175, 38);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 30);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(31, 38);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 30);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // gbrOutputs
            // 
            this.gbrOutputs.Controls.Add(this.txtArea);
            this.gbrOutputs.Controls.Add(this.txtPerimeter);
            this.gbrOutputs.Controls.Add(this.lblArea);
            this.gbrOutputs.Controls.Add(this.lblPerimeter);
            this.gbrOutputs.Font = new System.Drawing.Font("Roboto Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrOutputs.Location = new System.Drawing.Point(12, 304);
            this.gbrOutputs.Name = "gbrOutputs";
            this.gbrOutputs.Size = new System.Drawing.Size(452, 119);
            this.gbrOutputs.TabIndex = 2;
            this.gbrOutputs.TabStop = false;
            this.gbrOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtArea.Location = new System.Drawing.Point(112, 75);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(199, 28);
            this.txtArea.TabIndex = 5;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPerimeter.Location = new System.Drawing.Point(112, 34);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(199, 28);
            this.txtPerimeter.TabIndex = 4;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(63, 80);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(43, 18);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "Área:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(28, 39);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(78, 18);
            this.lblPerimeter.TabIndex = 2;
            this.lblPerimeter.Text = "Perímetro:";
            // 
            // gbrRotate
            // 
            this.gbrRotate.Controls.Add(this.btnRotateRight);
            this.gbrRotate.Controls.Add(this.btnRotateLeft);
            this.gbrRotate.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrRotate.Location = new System.Drawing.Point(12, 439);
            this.gbrRotate.Name = "gbrRotate";
            this.gbrRotate.Size = new System.Drawing.Size(175, 119);
            this.gbrRotate.TabIndex = 3;
            this.gbrRotate.TabStop = false;
            this.gbrRotate.Text = "Rotar";
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateRight.Location = new System.Drawing.Point(92, 27);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(75, 85);
            this.btnRotateRight.TabIndex = 1;
            this.btnRotateRight.Text = "Rotar 5° ===>";
            this.btnRotateRight.UseVisualStyleBackColor = true;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateLeft.Location = new System.Drawing.Point(6, 27);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(75, 85);
            this.btnRotateLeft.TabIndex = 0;
            this.btnRotateLeft.Text = "Rotar 5° <===";
            this.btnRotateLeft.UseVisualStyleBackColor = true;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // gbrScale
            // 
            this.gbrScale.Controls.Add(this.lblScaleValue);
            this.gbrScale.Controls.Add(this.trbScale);
            this.gbrScale.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrScale.Location = new System.Drawing.Point(211, 439);
            this.gbrScale.Name = "gbrScale";
            this.gbrScale.Size = new System.Drawing.Size(253, 119);
            this.gbrScale.TabIndex = 4;
            this.gbrScale.TabStop = false;
            this.gbrScale.Text = "Escala";
            // 
            // lblScaleValue
            // 
            this.lblScaleValue.AutoSize = true;
            this.lblScaleValue.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScaleValue.Location = new System.Drawing.Point(90, 76);
            this.lblScaleValue.Name = "lblScaleValue";
            this.lblScaleValue.Size = new System.Drawing.Size(43, 20);
            this.lblScaleValue.TabIndex = 1;
            this.lblScaleValue.Text = "1.00";
            // 
            // trbScale
            // 
            this.trbScale.Location = new System.Drawing.Point(16, 27);
            this.trbScale.Minimum = 1;
            this.trbScale.Name = "trbScale";
            this.trbScale.Size = new System.Drawing.Size(231, 56);
            this.trbScale.TabIndex = 0;
            this.trbScale.Value = 1;
            this.trbScale.Scroll += new System.EventHandler(this.scaleScroll);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInfo.Location = new System.Drawing.Point(511, 32);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(559, 18);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Presione en el recuadro para mover la figura con las flechas del teclado";
            // 
            // FrmTrapecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1136, 576);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gbrScale);
            this.Controls.Add(this.gbrRotate);
            this.Controls.Add(this.gbrOutputs);
            this.Controls.Add(this.bgrProcess);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.grbInputs);
            this.Name = "FrmTrapecio";
            this.Text = "FrmRombo";
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.bgrProcess.ResumeLayout(false);
            this.gbrOutputs.ResumeLayout(false);
            this.gbrOutputs.PerformLayout();
            this.gbrRotate.ResumeLayout(false);
            this.gbrScale.ResumeLayout(false);
            this.gbrScale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox bgrProcess;
        private System.Windows.Forms.GroupBox gbrOutputs;
        private System.Windows.Forms.Label lblInputB;
        private System.Windows.Forms.Label lblInputA;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.GroupBox gbrRotate;
        private System.Windows.Forms.TextBox txtInputB;
        private System.Windows.Forms.TextBox txtInputA;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.GroupBox gbrScale;
        private System.Windows.Forms.TrackBar trbScale;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.Button btnRotateLeft;
        private System.Windows.Forms.Label lblScaleValue;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtInputSide;
        private System.Windows.Forms.Label lblSide;
    }
}