namespace DrawingApp
{
    partial class DrawingForm1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DrawingForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "DrawingForm1";
            this.Text = "Drawing Application";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingForm1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingForm1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingForm1_MouseUp);
            this.ResumeLayout(false);
        }
    }
}
