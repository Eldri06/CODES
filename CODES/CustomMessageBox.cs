using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODES
{
    public partial class CustomMessageBox : Form
    {
        private Label lblMessage;
        private Button btnOK;
        private PictureBox pbIcon;
        private Panel panelTop;
        private Panel panelBottom;

        public enum MessageBoxType
        {
            Success,
            Error,
            Warning,
            Info
        }

        private CustomMessageBox(string message, string title, MessageBoxType type)
        {
            InitializeComponents(message, title, type);
        }

        private void InitializeComponents(string message, string title, MessageBoxType type)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(400, 200);
            this.BackColor = Color.White;

            panelTop = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = GetColorForType(type)
            };

            pbIcon = new PictureBox
            {
                Size = new Size(40, 40),
                Location = new Point(20, 10),
                SizeMode = PictureBoxSizeMode.CenterImage,
                BackColor = Color.Transparent
            };
            SetIconForType(pbIcon, type);

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(300, 40),
                Location = new Point(70, 10),
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.Transparent
            };

            panelTop.Controls.Add(pbIcon);
            panelTop.Controls.Add(lblTitle);

            lblMessage = new Label
            {
                Text = message,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(64, 64, 64),
                AutoSize = false,
                Size = new Size(360, 80),
                Location = new Point(20, 80),
                TextAlign = ContentAlignment.MiddleLeft
            };

            panelBottom = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                BackColor = Color.FromArgb(245, 245, 245)
            };

            btnOK = new Button
            {
                Text = "OK",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Size = new Size(100, 35),
                Location = new Point(280, 12),
                FlatStyle = FlatStyle.Flat,
                BackColor = GetColorForType(type),
                ForeColor = Color.White,
                Cursor = Cursors.Hand
            };
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.Click += (s, e) => this.Close();

            panelBottom.Controls.Add(btnOK);

            this.Controls.Add(panelTop);
            this.Controls.Add(lblMessage);
            this.Controls.Add(panelBottom);

            this.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                    Color.FromArgb(200, 200, 200), ButtonBorderStyle.Solid);
            };
        }

        private Color GetColorForType(MessageBoxType type)
        {
            switch (type)
            {
                case MessageBoxType.Success:
                    return Color.FromArgb(40, 167, 69);
                case MessageBoxType.Error:
                    return Color.FromArgb(220, 53, 69);
                case MessageBoxType.Warning:
                    return Color.FromArgb(255, 193, 7);
                case MessageBoxType.Info:
                    return Color.FromArgb(0, 123, 255);
                default:
                    return Color.FromArgb(0, 51, 102);
            }
        }

        private void SetIconForType(PictureBox pb, MessageBoxType type)
        {
            pb.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                switch (type)
                {
                    case MessageBoxType.Success:
                        DrawCheckMark(g, pb.ClientRectangle);
                        break;
                    case MessageBoxType.Error:
                        DrawXMark(g, pb.ClientRectangle);
                        break;
                    case MessageBoxType.Warning:
                        DrawExclamationMark(g, pb.ClientRectangle);
                        break;
                    case MessageBoxType.Info:
                        DrawInfoMark(g, pb.ClientRectangle);
                        break;
                }
            };
        }

        private void DrawCheckMark(Graphics g, Rectangle rect)
        {
            using (Pen pen = new Pen(Color.White, 4))
            {
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                g.DrawLine(pen, rect.Width / 4, rect.Height / 2, rect.Width / 2 - 2, rect.Height * 3 / 4);
                g.DrawLine(pen, rect.Width / 2 - 2, rect.Height * 3 / 4, rect.Width * 3 / 4, rect.Height / 4);
            }
        }

        private void DrawXMark(Graphics g, Rectangle rect)
        {
            using (Pen pen = new Pen(Color.White, 4))
            {
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                int margin = 10;
                g.DrawLine(pen, margin, margin, rect.Width - margin, rect.Height - margin);
                g.DrawLine(pen, rect.Width - margin, margin, margin, rect.Height - margin);
            }
        }

        private void DrawExclamationMark(Graphics g, Rectangle rect)
        {
            using (Pen pen = new Pen(Color.White, 4))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                g.DrawLine(pen, rect.Width / 2, rect.Height / 4, rect.Width / 2, rect.Height / 2);
                g.FillEllipse(brush, rect.Width / 2 - 3, rect.Height * 2 / 3, 6, 6);
            }
        }

        private void DrawInfoMark(Graphics g, Rectangle rect)
        {
            using (Font font = new Font("Segoe UI", 18, FontStyle.Bold))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString("i", font, brush, rect, sf);
            }
        }

        public static void Show(string message, string title, MessageBoxType type)
        {
            using (CustomMessageBox msgBox = new CustomMessageBox(message, title, type))
            {
                msgBox.ShowDialog();
            }
        }
    }
}
