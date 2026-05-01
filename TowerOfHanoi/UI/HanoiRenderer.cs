using System.Drawing;
using System.Drawing.Drawing2D;
using TowerOfHanoi.Models;

namespace TowerOfHanoi.UI
{
    internal static class HanoiRenderer
    {
        // Vibrant, highly saturated "cartoon" colors
        private static readonly Brush[] diskBrushes = new Brush[]
        {
            new SolidBrush(Color.FromArgb(255, 50, 50)),   // Bright Red
            new SolidBrush(Color.FromArgb(255, 150, 0)),   // Orange
            new SolidBrush(Color.FromArgb(255, 220, 0)),   // Yellow
            new SolidBrush(Color.FromArgb(50, 220, 50)),   // Green
            new SolidBrush(Color.FromArgb(0, 180, 255)),   // Light Blue
            new SolidBrush(Color.FromArgb(180, 50, 255)),  // Purple
            new SolidBrush(Color.FromArgb(255, 100, 200)), // Pink
            new SolidBrush(Color.FromArgb(0, 200, 200))    // Cyan
        };

        // Helper method for bouncy, rounded cartoon shapes
        private static GraphicsPath GetRoundedRect(RectangleF bounds, int radius)
        {
            float d = radius * 2F;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        public static void DrawGame(Graphics g, int canvasWidth, int canvasHeight, Tower a, Tower b, Tower c)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            
            // 1. Cartoon Background (Sky and Grass)
            g.Clear(Color.LightSkyBlue); 
            int groundY = canvasHeight - 40;
            g.FillRectangle(new SolidBrush(Color.LawnGreen), 0, groundY, canvasWidth, 40);
            // Thick ground outline
            g.DrawLine(new Pen(Color.Black, 4), 0, groundY, canvasWidth, groundY); 

            int baseY = groundY;
            int rodWidth = 20; // Thicker, chunkier rods
            int rodHeight = canvasHeight - 120;
            int[] rodX = { canvasWidth / 4, canvasWidth / 2, canvasWidth * 3 / 4 };

            // 2. Draw Cartoon Rods (Wooden look with thick outlines)
            Brush rodBrush = new SolidBrush(Color.Chocolate);
            Pen thickBlackPen = new Pen(Color.Black, 3f); // The signature animation outline

            for (int i = 0; i < 3; i++)
            {
                // Draw Base
                RectangleF baseRect = new RectangleF(rodX[i] - 100, baseY - 15, 200, 15);
                using (GraphicsPath basePath = GetRoundedRect(baseRect, 5))
                {
                    g.FillPath(rodBrush, basePath);
                    g.DrawPath(thickBlackPen, basePath);
                }
                
                // Draw Vertical Pole
                RectangleF poleRect = new RectangleF(rodX[i] - (rodWidth / 2), baseY - rodHeight, rodWidth, rodHeight);
                using (GraphicsPath polePath = GetRoundedRect(poleRect, 8))
                {
                    g.FillPath(rodBrush, polePath);
                    g.DrawPath(thickBlackPen, polePath);
                }
            }

            // 3. Draw Disks
            DrawDisksForTower(g, a, rodX[0], baseY - 15);
            DrawDisksForTower(g, b, rodX[1], baseY - 15);
            DrawDisksForTower(g, c, rodX[2], baseY - 15);
        }

        private static void DrawDisksForTower(Graphics g, Tower tower, int centerX, int baseY)
        {
            object[] disks = tower.GetStack().ToArray();
            int diskHeight = 32; // Taller, chunkier disks
            int yOffset = baseY - diskHeight;

            // Use a fun, chunky font for the numbers
            using (Font diskFont = new Font("Comic Sans MS", 12, FontStyle.Bold))
            using (StringFormat centerFormat = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                for (int i = disks.Length - 1; i >= 0; i--)
                {
                    Disk d = (Disk)disks[i];
                    int diskWidth = 50 + (d.GetSize() * 30); // Wider disks
                    int diskX = centerX - (diskWidth / 2);

                    int colorIndex = (d.GetSize() - 1) % diskBrushes.Length;
                    Brush currentBrush = diskBrushes[colorIndex];

                    RectangleF diskRect = new RectangleF(diskX, yOffset, diskWidth, diskHeight);
                    
                    using (GraphicsPath diskPath = GetRoundedRect(diskRect, 15)) // Extra round!
                    {
                        // A. Main color fill
                        g.FillPath(currentBrush, diskPath);
                        
                        // B. The "Glossy" Cartoon Highlight (A semi-transparent white bubble at the top)
                        RectangleF highlightRect = new RectangleF(diskX + 8, yOffset + 4, diskWidth - 16, diskHeight / 2.5f);
                        using (GraphicsPath highlightPath = GetRoundedRect(highlightRect, 8))
                        {
                            g.FillPath(new SolidBrush(Color.FromArgb(100, 255, 255, 255)), highlightPath);
                        }

                        // C. Thick black animated outline
                        g.DrawPath(new Pen(Color.Black, 3f), diskPath);
                    }

                    // Draw the number inside
                    g.DrawString(d.GetSize().ToString(), diskFont, Brushes.Black, diskRect, centerFormat);

                    yOffset -= diskHeight; 
                }
            }
        }
    }
}