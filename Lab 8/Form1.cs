using System.Drawing.Drawing2D;
namespace Lab_8 {
    public partial class Form1 : Form
    {
        //Header members //Drawing a string
        string Header;
        int HeaderSize;
        string Fnt;
        Font HeaderFont;
        Color HeaderColor;
        Brush HeaderBrush;
        RectangleF HeaderRect;

        //Underline members for header //Drawing a Line
        Pen underLine;
        Point startLine;
        Point endLine;

        //Subtitle members //Drawing a string
        string Header2;
        Font HeaderFont2;
        Brush HeaderBrush2;
        RectangleF HeaderRect2;

        //Underline members for sub-title //Drawing a Line
        Pen underLine2;
        Point startLine2;
        Point endLine2;

        //Table
        Pen TablePen;

        //Table Headers //Drawing a String
        string head;
        Font headFont;
        Brush headBrush;
        RectangleF headRect;

        //Table Headers2 //Drawing a String
        string head2;
        Font headFont2;
        Brush headBrush2;
        RectangleF headRect2;

        //Table years //Drawing Rectangles
        int Years;
        Font YearsFont;
        Brush YearsBrush;
        RectangleF YearsRect;

        //Array of revenue
        int[] revenue;
        Font revenueFont;
        Brush revenueBrush;

        //X-axis
        Pen XaxisLine;
        Point XaxisStart;
        Point XaxisEnd;

        //Y-axis
        Pen YaxisLine;
        Point YaxisStart;
        Point YaxisEnd;

        //Drawing 4 lines for the arrows

             //Arrow for X-axis
        //Line 1
        Pen XaxisArrow;
        Point XaxisArrowStart;
        Point XaxisArrowEnd;

        //Line 2
        Pen XaxisArrow2;
        Point XaxisArrowStart2;
        Point XaxisArrowEnd2;

             //Arrow for Y-axis
        //Line 1 
        Pen YaxisArrow;
        Point YaxisArrowStart;
        Point YaxisArrowEnd;

        //Line 2
        Pen YaxisArrow2;
        Point YaxisArrowStart2;
        Point YaxisArrowEnd2;

        //Axis members //Drawing a string
        //Y-axis Header
        string YaxisName;
        Font YaxisNameFont;
        Brush YaxisNameBrush;
        RectangleF YaxisNameRect;

        //X-axis Header
        string XaxisName;
        Font XaxisNameFont;
        Brush XaxisNameBrush;
        RectangleF XaxisNameRect;

        //Draw dashes for X-axis //Drawing a line(s)
        Pen XaxisLinesPen;
        Point XaxisDashStart;
        Point XaxisDashEnd;
        int xPosition;

        //Draw dashes for Y-axis //Drawing a line(s)
        Pen YaxisLinesPen;
        Point YaxisDashStart;
        Point YaxisDashEnd;
        int yPosition;

        //Draw years for X-axis //Drawing Strings
        int YearsX;
        Font YearsFontX;
        Brush YearsBrushX;
        RectangleF YearsRectX;

        //Draw Revenue for Y-axis //Drawing Strings
        int RevenueY;
        Font RevenueFontY;
        Brush RevenueBrushY;
        RectangleF RevenueRectY;

        //Drawing Line Chart //Drawing Lines
        Pen LineChartPen;

        //Drawing Bar Chart //DrawingRectangles
        Pen BarChartPen;
        HatchBrush BarChartHatchBrush;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------//
        public Form1()
        {
            InitializeComponent();
            //Header
            Header = "ABC Company";
            HeaderSize = 20;
            Fnt = "Times New Roman";
            HeaderFont = new Font(Fnt, HeaderSize);
            HeaderColor = Color.Black;
            HeaderBrush = new SolidBrush(HeaderColor);
            HeaderRect = new RectangleF(300, 50,250, 80); //x,y,width,height

            //Header underline
            underLine = new Pen(Color.Black);
            startLine = new Point(300, 85);
            endLine = new Point(485, 85);

            //Subtitle
            Header2 = "Annual Revenue";
            HeaderFont2 = new Font("TimesNewRoman", 15);
            HeaderBrush2 = new SolidBrush(Color.Black);
            HeaderRect2 = new RectangleF(320, 90, 200, 20); //x,y,width,height

            //Subtitle underline
            underLine2 = new Pen(Color.Black);
            startLine2 = new Point(320, 115);
            endLine2 = new Point(470, 115);

            //Table
            TablePen = new Pen(Color.Black, 3);

            //Table Headers
            head = "Year";
            headFont = new Font("Arial", 15);
            headBrush = new SolidBrush(Color.Black);
            headRect = new RectangleF(605, 145, 100, 30); //x,y,width,height

            //Table Headers2
            head2 = "Revenue";
            headFont2 = new Font("Arial", 15);
            headBrush2 = new SolidBrush(Color.Black);
            headRect2 = new RectangleF(690, 145, 100, 30); //x,y,width,height

            //Table years
            Years = 1988;
            YearsFont = new Font("Arial", 15);
            YearsBrush = new SolidBrush(Color.Black);
            YearsRect = new RectangleF(605, 195, 100, 30); //x,y,width,height

            //Table Revenue
            revenue = [150, 170, 180, 175, 200, 250, 210, 240, 280, 140];
            revenueFont = new Font("Arial", 15);
            revenueBrush = new SolidBrush(Color.Black);

            //X-axis
            XaxisLine = new Pen(Color.Black, 2);
            XaxisStart = new Point(50, 650);
            XaxisEnd = new Point(500, 650);

            //Y-axis
            YaxisLine = new Pen(Color.Black, 2);
            YaxisStart = new Point(50, 650);
            YaxisEnd = new Point(50, 200);

            //Drawing 4 lines for the arrows

            //Arrow for X-axis
            //Line 1
            XaxisArrow = new Pen(Color.Black, 2);
            XaxisArrowStart = new Point(480, 630);
            XaxisArrowEnd = new Point(500, 650);

            //Line 2
            XaxisArrow2 = new Pen(Color.Black, 2);
            XaxisArrowStart2 = new Point(480, 670);
            XaxisArrowEnd2 = new Point(500, 650);

            //Arrow for Y-axis
            //Line 1 (Left)
            YaxisArrow = new Pen(Color.Black, 2);
            YaxisArrowStart = new Point(30, 220);
            YaxisArrowEnd = new Point(50, 200);

            //Line 2 (Right)
            YaxisArrow2 = new Pen(Color.Black, 2);
            YaxisArrowStart2 = new Point(70, 220);
            YaxisArrowEnd2 = new Point(50, 200);

            //Y-axis Header
            YaxisName = "Revenue";
            YaxisNameFont = new Font("Arial", 15);
            YaxisNameBrush = new SolidBrush(Color.Black);
            YaxisNameRect = new RectangleF(7, 150, 90, 50); //x,y,width,height

            //X-axis Header
            XaxisName = "Years";
            XaxisNameFont = new Font("Arial", 15);
            XaxisNameBrush = new SolidBrush(Color.Black);
            XaxisNameRect = new RectangleF(490, 670, 90, 50); //x,y,width,height

            //X-axis Dashes
            XaxisLinesPen = new Pen(Color.Black, 2);
            XaxisDashStart = new Point(50, 640);
            XaxisDashEnd = new Point(50, 660);
            xPosition = 0;

            //Y-axis Dashes
            YaxisLinesPen = new Pen(Color.Black, 2);
            YaxisDashStart = new Point(40, 650);
            YaxisDashEnd = new Point(60, 630);
            yPosition = 0;


            //Draw years for X-axis 
            YearsX = 1988;
            YearsFontX = new Font("Arial", 12);
            YearsBrushX = new SolidBrush(Color.Black);
            YearsRectX = new Rectangle(); //x,y,width,height

            //Draw Revenue for Y-axis
            RevenueY = 300;
            RevenueFontY = new Font("Arial", 12);
            RevenueBrushY = new SolidBrush(Color.Black);
            RevenueRectY = new Rectangle(); //x,y,width,height

            //Draw Line Chart //Drawing Lines
            LineChartPen = new Pen(Color.Blue, 2);

            //Draw Bar Chart //Drawing Rectangles
            BarChartPen = new Pen(Color.Black, 2);
            Color hatchColor = Color.Black;
            BarChartHatchBrush = new HatchBrush(HatchStyle.BackwardDiagonal, hatchColor, Color.Red);

                                             //INITIALIZING THE CHECKER FOR BOTH TOOLBAR & CONTEXT MENU WHEN THE PROGRAM IS RUNNED FOR THE FIRST TIME

            // Initialize checked state for line chart color in toolbar
            blueToolStripMenuItem.Checked = true;
            greenToolStripMenuItem.Checked = false;

            // Initialize checked state for bar chart color in toolbar
            redToolStripMenuItem1.Checked = true;

            // Initialize checked state for bar chart style in toolbar and context menu (backward diagonal)
            leftToolStripMenuItem.Checked = true;
            leftToolStripMenuItem1.Checked = true;

            // Initialize checked state for line chart style in toolbar and context menu (solid)
            solidToolStripMenuItem.Checked = true;
            solidToolStripMenuItem1.Checked = true;

            // This line changes the checked state for the "Blue" color option in the context menu
            blueToolStripMenuItem3.Checked = true;
        }
         

        void DrawHeader(Graphics g) { g.DrawString(Header, HeaderFont, HeaderBrush, HeaderRect); }
        void DrawHeader2(Graphics g) { g.DrawString(Header2, HeaderFont2, HeaderBrush2, HeaderRect2); }
        void DrawUnderLine(Graphics g) { g.DrawLine(underLine, startLine, endLine); }
        void DrawUnderLine2(Graphics g) { g.DrawLine(underLine2, startLine2, endLine2); }
        void DrawTable(Graphics g)
        {
            RectangleF[] rects = new RectangleF[22];

            // First Column
            for (int i = 0; i < 11; i++) { rects[i] = new RectangleF(580, 130 + (50 * i), 100, 50); }

            // Second Column
            for (int k = 0; k < 11; k++) { rects[11 + k] = new RectangleF(680, 130 + (50 * k), 100, 50); }

            g.DrawRectangles(TablePen, rects);

            for (int j = 0; j < 10; j++)
            {
                int currentYear = 1988 + j;
                int currentRev = revenue[j];

                RectangleF currentYearRect = new RectangleF(605, 195 + (j * 50), 100, 30);
                g.DrawString(currentYear.ToString(), YearsFont, YearsBrush, currentYearRect);

                RectangleF revn = new RectangleF(710, 195 + (j * 50), 100, 30); //x,y,width,height
                g.DrawString(currentRev.ToString(), revenueFont, revenueBrush, revn);
            }
        }
        void DrawHead(Graphics g) { g.DrawString(head, headFont, headBrush, headRect); }
        void DrawHead2(Graphics g) { g.DrawString(head2, headFont2, headBrush2, headRect2); }
        void DrawXaxis(Graphics g) { g.DrawLine(XaxisLine, XaxisStart, XaxisEnd); }
        void DrawYaxis(Graphics g) { g.DrawLine(YaxisLine, YaxisStart, YaxisEnd); }
        void DrawXaxisArrow1(Graphics g) { g.DrawLine(XaxisArrow, XaxisArrowStart, XaxisArrowEnd); }
        void DrawXaxisArrow2(Graphics g) { g.DrawLine(XaxisArrow2, XaxisArrowStart2, XaxisArrowEnd2); }
        void DrawYaxisArrow1(Graphics g) { g.DrawLine(YaxisArrow, YaxisArrowStart, YaxisArrowEnd); }
        void DrawYaxisArrow2(Graphics g) { g.DrawLine(YaxisArrow2, YaxisArrowStart2, YaxisArrowEnd2); }
        void DrawYaxisName(Graphics g) { g.DrawString(YaxisName, YaxisNameFont, YaxisNameBrush, YaxisNameRect); }
        void DrawXaxisName(Graphics g) { g.DrawString(XaxisName, XaxisNameFont, XaxisNameBrush, XaxisNameRect); }

        void DrawLinesXandY(Graphics g)
        {
            for (int i = 0; i < 10; i++)
            {
                xPosition = 100 + (40 * i);
                XaxisDashStart.X = xPosition; // Update the x-coordinate of the start point
                XaxisDashEnd.X = xPosition;   // Update the x-coordinate of the end point
                g.DrawLine(XaxisLinesPen, XaxisDashStart, XaxisDashEnd);
            }
            for (int i = 0; i < 20; i++)
            {
                yPosition = 250 + (20 * i);
                YaxisDashStart.Y = yPosition; // Update the x-coordinate of the start point
                YaxisDashEnd.Y = yPosition;   // Update the x-coordinate of the end point
                g.DrawLine(YaxisLinesPen, YaxisDashStart, YaxisDashEnd);
            }
        }

        void DrawYearsAndRevenue(Graphics g)
        {
            YearsX = 1988;
            for (int i = 0; i < 10; i++)
            {
                int xDraw = 80 + (40 * i);
                YearsRect.X = xDraw;
                YearsRect.Y = 660;
                g.DrawString(YearsX.ToString(), YearsFontX, YearsBrushX, YearsRect); //string,Font,Brush,Rect
                YearsX++;
            }

            RevenueY = 300;
            for (int i = 0; i < 20; i++)
            {
                int yDraw = 240 + (20 * i);
                RevenueRectY.X = 5;
                RevenueRectY.Y = yDraw;
                g.DrawString(RevenueY.ToString(), RevenueFontY, RevenueBrushY, RevenueRectY); //string,Font,Brush,Rect
                RevenueY -= 10;
            }
        }
        void DrawLinesPoint(Graphics g)
        {
            //Step on X-axis is 40, same as dashes
            //Step on Y-axis is 20,same as dashes.
            Point[] points = {
                 new Point(100,550),
                 new Point(140,510),
                 new Point(180,490),
                 new Point(220,500),
                 new Point(260,450),
                 new Point(300,350),
                 new Point(340,430),
                 new Point(380,370),
                 new Point(420,290),
                 new Point(460,570)
             };

            g.DrawLines(LineChartPen, points);
        }

        void DrawBarChart(Graphics g)
        {
            int[] heights = { 100, 140, 160, 150, 200, 300, 220, 280, 360, 80 };
            int[] yPositions = { 550, 510, 490, 500, 450, 350, 430, 370, 290, 570 };

            RectangleF[] BarRects = new RectangleF[heights.Length];

            for (int i = 0; i < heights.Length; i++)
            { BarRects[i] = new RectangleF(90 + i * 40, yPositions[i], 20, heights[i]); }

            g.DrawRectangles(BarChartPen, BarRects);
            g.FillRectangles(BarChartHatchBrush, BarRects);
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Title
            DrawHeader(g);
            DrawUnderLine(g);

            //Subtitle
            DrawHeader2(g);
            DrawUnderLine2(g);

            //Table
            DrawTable(g);
            DrawHead(g);
            DrawHead2(g);

            //Axis
            DrawXaxis(g);
            DrawYaxis(g);

            //Arrows
            //X-axis
            DrawXaxisArrow1(g);
            DrawXaxisArrow2(g);
            //Y-axis
            DrawYaxisArrow1(g);
            DrawYaxisArrow2(g);

            //Header names
            DrawYaxisName(g);
            DrawXaxisName(g);

            //Drawing the numbers
            DrawYearsAndRevenue(g);

            //Drawing BarChart
            DrawBarChart(g);

            //Drawing the Chart
            DrawLinesPoint(g);

            //Dashes for Axis
            DrawLinesXandY(g);
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                case 2: //Ctrl + B
                    LineChartPen.Color = Color.Blue;
                    break;
                case 7: //Ctrl + G
                    LineChartPen.Color = Color.Green;
                    break;
                case 18:    //Ctrl + R
                    LineChartPen.Color = Color.Red;
                    break;
            }

            Invalidate();
        }

        //----------------------------------------------------------------------------------------
        private void RedLine()
        {
            LineChartPen.Color = Color.Red;
            redToolStripMenuItem.Checked = true;
            greenToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            Invalidate();
        }
        private void GreenLine()
        {
            LineChartPen.Color = Color.Green;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;
            Invalidate();
        }
        private void BlueLine()
        {
            LineChartPen.Color = Color.Blue;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = true;
            Invalidate();
        }
        //-------------------------------------------------------
        private void SolidLine()
        {
            LineChartPen.DashStyle = DashStyle.Solid;
            solidToolStripMenuItem.Checked = true;
            dottedToolStripMenuItem.Checked = false;
            dashToolStripMenuItem.Checked = false;
            Invalidate();
        }
        private void DashedLine()
        {
            LineChartPen.DashStyle = DashStyle.Dash;
            solidToolStripMenuItem.Checked = false;
            dottedToolStripMenuItem.Checked = false;
            dashToolStripMenuItem.Checked = true;
            Invalidate();
        }
        private void DottedLine()
        {
            LineChartPen.DashStyle = DashStyle.Dot;
            solidToolStripMenuItem.Checked = false;
            dottedToolStripMenuItem.Checked = true;
            dashToolStripMenuItem.Checked = false;
            Invalidate();
        }
        //-------------------------------------------------------
        private void RedBar()
        {
            Color hatchColor = ((HatchBrush)BarChartHatchBrush).ForegroundColor;
            BarChartHatchBrush = new HatchBrush(HatchStyle.BackwardDiagonal, hatchColor, Color.Red);
            redToolStripMenuItem1.Checked = true;
            greenToolStripMenuItem1.Checked = false;
            blueToolStripMenuItem1.Checked = false;
            Invalidate();
        }
        private void GreenBar()
        {
            Color hatchColor = ((HatchBrush)BarChartHatchBrush).ForegroundColor;
            BarChartHatchBrush = new HatchBrush(HatchStyle.BackwardDiagonal, hatchColor, Color.Green);
            redToolStripMenuItem1.Checked = false;
            greenToolStripMenuItem1.Checked = true;
            blueToolStripMenuItem1.Checked = false;
            Invalidate();
        }
        private void BlueBar()
        {
            Color hatchColor = ((HatchBrush)BarChartHatchBrush).ForegroundColor;
            BarChartHatchBrush = new HatchBrush(HatchStyle.BackwardDiagonal, hatchColor, Color.Blue);
            redToolStripMenuItem1.Checked = false;
            greenToolStripMenuItem1.Checked = false;
            blueToolStripMenuItem1.Checked = true;
            Invalidate();
        }
        //-------------------------------------------------------
        private void RightBar()
        {
            Color hatchColor = ((HatchBrush)BarChartHatchBrush).ForegroundColor;
            Color barColor = ((HatchBrush)BarChartHatchBrush).BackgroundColor;
            BarChartHatchBrush = new HatchBrush(HatchStyle.ForwardDiagonal, hatchColor, barColor);
            leftToolStripMenuItem.Checked = false;
            rightToolStripMenuItem.Checked = true;
            crossToolStripMenuItem.Checked = false;

            leftToolStripMenuItem1.Checked = false;
            rightToolStripMenuItem1.Checked = true;
            crossToolStripMenuItem1.Checked = false;
            Invalidate();
        }
        private void LeftBar()
        {
            Color hatchColor = ((HatchBrush)BarChartHatchBrush).ForegroundColor;
            Color barColor = ((HatchBrush)BarChartHatchBrush).BackgroundColor;
            BarChartHatchBrush = new HatchBrush(HatchStyle.BackwardDiagonal, hatchColor, barColor);
            leftToolStripMenuItem.Checked = true;
            rightToolStripMenuItem.Checked = false;
            crossToolStripMenuItem.Checked = false;
            leftToolStripMenuItem1.Checked = true;
            rightToolStripMenuItem1.Checked = false;
            crossToolStripMenuItem1.Checked = false;
            Invalidate();
        }
        private void CrossBar()
        {
            Color hatchColor = ((HatchBrush)BarChartHatchBrush).ForegroundColor;
            Color barColor = ((HatchBrush)BarChartHatchBrush).BackgroundColor;
            BarChartHatchBrush = new HatchBrush(HatchStyle.DiagonalCross, hatchColor, barColor);
            leftToolStripMenuItem.Checked = false;
            rightToolStripMenuItem.Checked = false;
            crossToolStripMenuItem.Checked = true;
            leftToolStripMenuItem1.Checked = false;
            rightToolStripMenuItem1.Checked = false;
            crossToolStripMenuItem1.Checked = true;
            Invalidate();
        }
        //-------------------------------------------------------
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedLine();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GreenLine();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlueLine();
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolidLine();
        }

        private void dashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashedLine();
        }

        private void dottedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DottedLine();
        }

        private void barToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RedBar();
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GreenBar();
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BlueBar();
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RightBar();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeftBar();
        }

        private void crossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrossBar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RedLine();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            GreenLine();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            BlueLine();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SolidLine();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DashedLine();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DottedLine();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            RedBar();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            GreenBar();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            BlueBar();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            RightBar();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            LeftBar();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            CrossBar();
        }

       

        private void redToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RedBar();
            redToolStripMenuItem2.Checked = true;
            greenToolStripMenuItem2.Checked = false;
            blueToolStripMenuItem2.Checked = false;
        }

        private void greenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GreenBar();
            redToolStripMenuItem2.Checked = false;
            greenToolStripMenuItem2.Checked = true;
            blueToolStripMenuItem2.Checked = false;
        }

        private void blueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BlueBar();
            redToolStripMenuItem2.Checked = false;
            greenToolStripMenuItem2.Checked = false;
            blueToolStripMenuItem2.Checked = true;
        }

        private void rightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RightBar();
        }

        private void leftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LeftBar();
        }

        private void crossToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrossBar();
        }

        private void redToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RedLine();
            redToolStripMenuItem3.Checked = true;
            greenToolStripMenuItem3.Checked = false;
            blueToolStripMenuItem3.Checked = false;
        }

        private void greenToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GreenLine();
            redToolStripMenuItem3.Checked = false;
            greenToolStripMenuItem3.Checked = true;
            blueToolStripMenuItem3.Checked = false;
        }

        private void blueToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BlueLine();
            redToolStripMenuItem3.Checked = false;
            greenToolStripMenuItem3.Checked = false;
            blueToolStripMenuItem3.Checked = true;
        }

        private void solidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SolidLine();
            solidToolStripMenuItem1.Checked = true;
            dottedToolStripMenuItem1.Checked = false;
            dashedToolStripMenuItem.Checked = false;
        }

        private void dashedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashedLine();
            solidToolStripMenuItem1.Checked = false;
            dottedToolStripMenuItem1.Checked = false;
            dashedToolStripMenuItem.Checked = true;
        }

        private void dottedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DottedLine();
            solidToolStripMenuItem1.Checked = false;
            dottedToolStripMenuItem1.Checked = true;
            dashedToolStripMenuItem.Checked = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > 50 && e.X < 500 && e.Y > 200 && e.Y < 650)
            {
                ContextMenuStrip = contextMenuStrip1;
                float rev = 100 + ((650 - e.Y) / 20) * 10;
                float yrs = 1987 + ((e.X - 50) / 40);
                toolStripStatusLabel1.Text = $"Year:{yrs} Revenue:{rev}";
            }

            else { ContextMenuStrip = contextMenuStrip2; }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X >= 50 && e.X <= 500 && e.Y >= 200 && e.Y <= 650)
            {
                // My X-axis starts at 50, ends at 500. (Length=450)
                // My Y-axis starts at 200, ends at 650. (Length=450)

                // My X-axis dash space is 40px for 1 year
                // My Y-axis dash space is 20px for 10 revenue
                float rev = 100 + ( (650 - e.Y) / 20 ) * 10;
                float yrs = 1987 + ( (e.X - 50) / 40 );

                // Set a title for the MessageBox
                string title = "Year & Revenue Information";

                // Display the MessageBox with a title
                MessageBox.Show($" Year: {yrs} \n Revenue: {rev}", title);   
            }
        }

        private void companyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            PrepareDialogBox(form2);
            form2.TextBoxes = Header;

            if (form2.ShowDialog() == DialogResult.OK)
            {
                Header=form2.TextBoxes;
                HeaderColor = form2.TextClr;
                HeaderSize = form2.TextSize;
                Fnt = form2.TextFont;
                HeaderFont = new Font(Fnt, HeaderSize);
                HeaderBrush = new SolidBrush(form2.TextClr);
                Invalidate();

            }
        }
        private void PrepareDialogBox(Form2 form2)
        {
            if (Fnt == "Times New Roman") {form2.Times = true; }
            else if (Fnt == "Arial") { form2.Arial = true; }
            else if (Fnt == "Courier New") { form2.Courier = true; }

            if (HeaderSize == 16) { form2.Size16 = true; }
            else if (HeaderSize == 20) { form2.Size20 = true; }
            else if (HeaderSize == 24) { form2.Size24 = true; }
        
        }

    }
}