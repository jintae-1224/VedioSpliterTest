
namespace VedioSpliter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_split = new System.Windows.Forms.Button();
            this.endTextBox = new System.Windows.Forms.TextBox();
            this.btn_OpenCsv = new System.Windows.Forms.Button();
            this.btn_savePath = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_path = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_split
            // 
            this.btn_split.Location = new System.Drawing.Point(436, 115);
            this.btn_split.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_split.Name = "btn_split";
            this.btn_split.Size = new System.Drawing.Size(122, 31);
            this.btn_split.TabIndex = 4;
            this.btn_split.Text = "Split";
            this.btn_split.UseVisualStyleBackColor = true;
            this.btn_split.Click += new System.EventHandler(this.btn_split_Click);
            // 
            // endTextBox
            // 
            this.endTextBox.Location = new System.Drawing.Point(282, 119);
            this.endTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(132, 25);
            this.endTextBox.TabIndex = 3;
            this.endTextBox.Text = "2";
            // 
            // btn_OpenCsv
            // 
            this.btn_OpenCsv.Location = new System.Drawing.Point(40, 115);
            this.btn_OpenCsv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_OpenCsv.Name = "btn_OpenCsv";
            this.btn_OpenCsv.Size = new System.Drawing.Size(122, 31);
            this.btn_OpenCsv.TabIndex = 5;
            this.btn_OpenCsv.Text = "OpenCsv";
            this.btn_OpenCsv.UseVisualStyleBackColor = true;
            this.btn_OpenCsv.Click += new System.EventHandler(this.btn_OpenCsv_Click);
            // 
            // btn_savePath
            // 
            this.btn_savePath.Location = new System.Drawing.Point(423, 21);
            this.btn_savePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_savePath.Name = "btn_savePath";
            this.btn_savePath.Size = new System.Drawing.Size(117, 30);
            this.btn_savePath.TabIndex = 6;
            this.btn_savePath.Text = "저장경로";
            this.btn_savePath.UseVisualStyleBackColor = true;
            this.btn_savePath.Click += new System.EventHandler(this.btn_savePath_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(117, 26);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(297, 25);
            this.txt_name.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "파일명 : ";
            // 
            // lab_path
            // 
            this.lab_path.AutoSize = true;
            this.lab_path.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_path.Location = new System.Drawing.Point(37, 68);
            this.lab_path.Name = "lab_path";
            this.lab_path.Size = new System.Drawing.Size(0, 21);
            this.lab_path.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(182, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "저장간격 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 184);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_savePath);
            this.Controls.Add(this.btn_OpenCsv);
            this.Controls.Add(this.btn_split);
            this.Controls.Add(this.endTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_split;
        private System.Windows.Forms.TextBox endTextBox;
        private System.Windows.Forms.Button btn_OpenCsv;
        private System.Windows.Forms.Button btn_savePath;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_path;
        private System.Windows.Forms.Label label3;
    }
}

