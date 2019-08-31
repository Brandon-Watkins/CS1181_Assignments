/*
frmBrandonsFirstDrawing.cs
CS 1181
Brandon Watkins 
18 May 2019
Robert Howe
Description: Creates a randomized scenic picture.

WOW: 
_randomized my drawing
    mountain base is at a _random location (within a range)
    mountain peaks and valleys are _random heights, within a range
    mountain color is _random, within a range
    snow line is at a _random height, within a range
    house and roof will be at _random locations, within a range
    house and roof size are _random, within a range
    door location is _random, within a range
    sun will be at a _random location, within a range
    sun has _random color, within a range
    sun has _random size, within a range
    _sky has _random color, within range
    _randomly sized, colored, and placed, blades of grass, individually, within a range
added a button to _randomize the drawing again
added some track bars to scale the individual components in my painting, within a range
When resizing my form, re-randomizes, and repaints the form. 
    Really mostly just covering my butt. Without, the image distorts (similar to when you hide the scale controls)
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BrandonsFirstDrawing_HowCute
{
    public partial class frmBrandonsFirstDrawing : Form
    {
        // Class level variables for scaling:
        private const double _SF = 1;// Size Factor. To make scaling easier...
        private double _mountainsSF = 1 * _SF;//max 2, higher = closer _mountains
        private double _houseSF = 1 * _SF;// higher = larger house
        private double _sunSF = 1 * _SF;// higher = larger sun
        private double _roofSF = 1 * _SF;// higher = larger roof
        private double _grassSF = 0.1 * _SF;//used to make grass "taller". thicker line.
        private double _amountOfSnow = 0.8;// higher = more snow
        private double _snowVariation = 0.2;// higher = more fluctuation in snow levels
        private double _mountainHeight = 0.5;// higher = higher mountain peaks
        private double _mtnHeightInverse = 0.5;// don't touch. reverses the mountain height, which is the one that we actually use.
        private const int _SHADE_SCALE = 50; // how much darker is the side of the house than the front? higher = darker. Max = 50, unless changes are made to the Draw walls Method
        private const int _OVERHANG_AMOUNT = 20; // how much roof overhang there is. higher = more

        // Other misc class level variables
        private Random _random;
        private Graphics _gfx;
        private int _formHeight;
        private int _formWidth;
        private int _groundLevel;
        private int _mountainLevel;
        private int _indexForLastPointOnBottomOf_mountains;
        private int _roofHeight;
        private int _houseWidth;
        private string _houseSide;
        private List<Point> _mountainRidgeLine = new List<Point>();// the line seperating _mountains from the _sky
        private List<Point> _mountains = new List<Point>();
        private Point _mountainBaseLine;// the height-point seperating _mountains from rest of the land
        private List<Point> _sky = new List<Point>();
        private List<Point> _snowLine = new List<Point>();
        private List<Point> _mountainBaseFull = new List<Point>();
        private Point[] _housePoints;

        /// <summary>
        /// initialize form, instantiate(?) random object
        /// </summary>
        public frmBrandonsFirstDrawing()
        {
            InitializeComponent();
            _random = new Random();
        }

        /// <summary>
        /// determines form size, and assigns some class level variables accordingly
        /// </summary>
        /// <param name="e">No idea. Graphic something something.</param>
        private void MiscDrawingStuff(PaintEventArgs e)
        {
            _gfx = e.Graphics;
            _formHeight = this.Size.Height;
            _formWidth = this.Size.Width;
            _groundLevel = (int)(_formHeight - _formHeight * 0.1);
            _mountainLevel = (int)(_formHeight * 0.3 * _mountainsSF);
            _mtnHeightInverse = 1 - _mountainHeight;
        }

        /// <summary>
        /// resets the scaler fields
        /// </summary>
        private void ResetStuff()
        {
            _mountainsSF = 1 * _SF;
            _houseSF = 1 * _SF;
            _sunSF = 1 * _SF;
            _roofSF = 1 * _SF;
            _grassSF = 0.1 * _SF;
        }

        /// <summary>
        /// traces the outline of the mountain range, for use in drawing the mountains, sky, and ground below the mountains.
        /// </summary>
        private void TraceMountains()
        {
            int index = 0;
            int mountainPeak = _random.Next((int)(_mountainLevel * _mtnHeightInverse), (int)(_mountainLevel * _mtnHeightInverse + _mountainLevel * 0.3));
            // change the elevation at _random intervals, by a _random amount, within a range.
            Point firstPoint = new Point(0, _random.Next(mountainPeak, (int)(mountainPeak + _mountainLevel * 0.3)));
            mountainPeak = _random.Next((int)(_mountainLevel * _mtnHeightInverse), (int)(_mountainLevel * _mtnHeightInverse + _mountainLevel * 0.3));
            Point lastPoint = new Point(_formWidth, _random.Next(mountainPeak, (int)(mountainPeak + _mountainLevel * 0.3)));

            _mountainRidgeLine.Add(firstPoint);// the line seperating _mountains from the _sky

            // the height-point seperating _mountains from rest of the land
            _mountainBaseLine = new Point(01, _random.Next((int)(_mountainLevel * 1.45), (int)(_mountainLevel * 1.45 + _mountainLevel * 0.3)));

            _sky.Add(new Point(0, 0));
            _sky.Add(firstPoint);

            _mountains.Add(_mountainBaseLine);
            _mountains.Add(firstPoint);
            int index2 = 0;

            // drawing the top of the _mountains
            for (int i = 0; i < _formWidth; i = _random.Next(index + 10, index + 40))
            {
                index = i;
                mountainPeak = _random.Next((int)(_mountainLevel * _mtnHeightInverse), (int)(_mountainLevel * _mtnHeightInverse + _mountainLevel * 0.3));
                Point tempPoint = new Point(i, ((_random.Next(mountainPeak, (int)(mountainPeak + _mountainLevel * 0.3) )) ) );
                index2++;
                if (tempPoint.X > _formWidth || tempPoint.Y > _formHeight) return;// shouldn't happen, but if it's out of bounds...
                else
                {
                    _mountainRidgeLine.Add(tempPoint);
                    _mountains.Add(tempPoint);
                    _sky.Add(tempPoint);
                }
            }
            _mountainRidgeLine.Add(lastPoint);
            _mountains.Add(lastPoint);
            _indexForLastPointOnBottomOf_mountains = _mountains[_mountains.Count - 1].Y;
            _sky.Add(lastPoint);
            _sky.Add(new Point(_formWidth, 0));

            _mountainBaseFull.Add(lastPoint);

            // drawing the bottom of the _mountains
            index = _formWidth;
            for (int i = _formWidth - 1; i > 0; i = _random.Next(index - 125, index))
            {
                index = i;
                int mountainBase = _random.Next((int)(_mountainBaseLine.Y - 5), (int)(_mountainBaseLine.Y + 5));
                _mountains.Add(new Point(i, mountainBase));
                _mountainBaseFull.Add(new Point(i, mountainBase));
            }
        }
        
        /// <summary>
        /// Draws the mountains.
        /// </summary>
        private void DrawMountains()
        {
            int red = _random.Next(90, 150);
            int green = _random.Next(45, 180);
            int blue = _random.Next(0, 50);
            PointF[] _mountainsArray = new PointF[_mountains.Count];
            for (int i = 0; i < _mountains.Count; i++)
            {
                _mountainsArray[i] = _mountains[i];
            }
            Brush mountainBrush = new SolidBrush(Color.FromArgb(255, red, green, blue));
            _gfx.FillPolygon(mountainBrush, _mountainsArray);
        }

        /// <summary>
        /// Draws the snow caps on the mountains
        /// </summary>
        private void DrawSnowCaps()
        {
            int index = 0;
            _snowLine.Add(new Point(0, 0));
            int mountainPeak = _random.Next((int)(_mountainLevel), (int)(_mountainLevel + _amountOfSnow * _mountainLevel * _snowVariation));
            _snowLine.Add(new Point(0, mountainPeak));
            for (int i = 0; i < _formWidth; i = _random.Next(index + 30, index + 75))
            {
                index = i;
                mountainPeak = _random.Next((int)(_mountainLevel), (int)(_mountainLevel + _amountOfSnow * _mountainLevel * _snowVariation));
                Point tempPoint = new Point(i, mountainPeak);
                if (tempPoint.X > _formWidth || tempPoint.Y > _formHeight) return;// shouldn't happen, but if it's out of bounds...
                else
                {
                    _snowLine.Add(tempPoint);
                }
            }
            _snowLine.Add(new Point(_formWidth, (_random.Next((int)(_mountainLevel), 
                (int)(_mountainLevel + _amountOfSnow * _mountainLevel * _snowVariation)))));
            _snowLine.Add(new Point(_formWidth, 0));

            Point[] _snowLineArray = new Point[_snowLine.Count];
            for (int i = 0; i < _snowLine.Count; i++)
            {
                _snowLineArray[i] = _snowLine[i];
            }

            Brush snowBrush = new SolidBrush(Color.Snow);
            _gfx.FillPolygon(snowBrush, _snowLineArray);
        }

        /// <summary>
        /// Draws the sky
        /// </summary>
        private void DrawSky()
        { 
            // Draw blank _sky
            PointF[] _skyArray = new PointF[_sky.Count];
            for (int i = 0; i < _sky.Count; i++)
            {
                _skyArray[i] = _sky[i];
            }
            int red = _random.Next(0, 100);
            int green = _random.Next(120, 200);
            int blue = _random.Next(150, 255);
            Brush _skyBrush = new SolidBrush(Color.FromArgb(255, red, green, blue));
            _gfx.FillPolygon(_skyBrush, _skyArray);

            // draw sun
            int sunColorGreen = _random.Next(140, 255);
            int sunColorRed = _random.Next(200, 255);
            int sunSize = (int)(_random.Next(40, 100) * _sunSF);
            Brush sunBrush = new SolidBrush(Color.FromArgb(255, sunColorRed, sunColorGreen, 0));
            _gfx.FillEllipse(sunBrush, (int)(_random.Next(0, (_formWidth - 50))), _random.Next(0, (int)(_mountainLevel * 0.3)), sunSize, sunSize);
        }

        /// <summary>
        /// Fills the ground with a base color
        /// </summary>
        private void DrawGroundBase()
        {
            Point[] mountainBase = new Point[_mountainBaseFull.Count + 2];
            mountainBase[0] = new Point(_formWidth, _formHeight);
            mountainBase[mountainBase.Length - 1] = new Point(0, _formHeight);
            mountainBase[mountainBase.Length - 2] = _mountains[0];
           
            for (int i = 1; i < _mountainBaseFull.Count; i++)
            {
                mountainBase[i] = _mountainBaseFull[i];
            }
            Brush groundBrush = new SolidBrush(Color.ForestGreen);
            _gfx.FillPolygon(groundBrush, mountainBase);
        }

        /// <summary>
        /// Draws the finer details on the ground (grass blades, etc)
        /// </summary>
        private void DrawGround()
        {            
            //draw grass
            if (_mountainBaseLine.Y < _formHeight)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int red = _random.Next(0, 110);
                    int green = _random.Next(160, 200);
                    int blue = _random.Next(0, 120);
                    Point pointI = new Point(_random.Next(0, _formWidth), _random.Next(_mountainBaseLine.Y, _formHeight));
                    int bladeLength = _random.Next(1, 10);
                    int bladeDirection = _random.Next(-2, 3);
                    _gfx.DrawLines(new Pen(Color.FromArgb(255, red, green, blue), _random.Next((int)(0.1 * _grassSF), (int)(0.6 * _grassSF))), new Point[] { pointI, new Point(pointI.X + bladeDirection, pointI.Y + bladeLength) });
                }
            }
            
        }

        /// <summary>
        /// Draw the house, including the walls, door, roof.
        /// </summary>
        private void DrawHouse()
        {
            if (_mountainBaseLine.Y >= _formHeight - 250) return;
            /*              /6\
             *             /   \
             *            /     \
             *           /       \
             *         5|\   (9)/7\            
             *          | \    /   \        (#) indicates its hidden by the view
             *          |  \  /      \ 
             *          |   \/_________\
             *          |4  |2     (8)  |3
             *          \   |           |
             *           \  |           |
             *            \ |           |
             *             \|1__________|0
             *             
             *            ^-- House Side = Left
             */
             // Determining which side the house is on. The side of the house that the viewer will see
            _houseSide ="";
            int outsideWallHorizontalCoord = _random.Next(75, _formWidth);
            if (outsideWallHorizontalCoord >= (_formWidth * 4 / 5)) _houseSide = "Left";
            else if (outsideWallHorizontalCoord > (_formWidth  / 2)) _houseSide = "FrontLeft";
            //else if (outsideWallHorizontalCoord > (_formWidth * 2 / 5)) _houseSide = "Front"; // decided not to do this angle
            else if (outsideWallHorizontalCoord > (_formWidth / 5)) _houseSide = "FrontRight";
            else _houseSide = "Right";

            // Determining wall placements
            int insideBackWallHorizontalCoord = -1;
            int insideFrontWallHorizontalCoord = -1;
            if (_houseSide == "Left")
            {
                insideFrontWallHorizontalCoord = outsideWallHorizontalCoord - (int)(_houseSF * _random.Next(100, 300));
                insideBackWallHorizontalCoord = insideFrontWallHorizontalCoord - (int)(_houseSF * _random.Next(100, 300));
            }
            else if (_houseSide == "FrontLeft")
            {
                insideFrontWallHorizontalCoord = outsideWallHorizontalCoord - (int)(_houseSF * _random.Next(100, 300));
                insideBackWallHorizontalCoord = insideFrontWallHorizontalCoord - (int)(_houseSF * _random.Next(50, 150));
            }
            else if (_houseSide == "Front")
            {
                insideBackWallHorizontalCoord = -1;//N/A
                insideFrontWallHorizontalCoord = outsideWallHorizontalCoord - (int)(_houseSF * _random.Next(100, 300));
            }
            else if (_houseSide == "FrontRight")
            {
                insideFrontWallHorizontalCoord = outsideWallHorizontalCoord + (int)(_houseSF * _random.Next(100, 300));
                insideBackWallHorizontalCoord = insideFrontWallHorizontalCoord + (int)(_houseSF * _random.Next(50, 150));
            }
            else if (_houseSide == "Right")
            {
                insideFrontWallHorizontalCoord = outsideWallHorizontalCoord + (int)(_houseSF * _random.Next(100, 300));
                insideBackWallHorizontalCoord = insideFrontWallHorizontalCoord + (int)(_houseSF * _random.Next(100, 300));
            }
            // Determining how far away the house is
            int floorVerticalCoord = _random.Next(_mountainBaseLine.Y + 100, _formHeight - 50);
            int ceilingVerticalCoord = floorVerticalCoord - (int)(_houseSF * _random.Next(75, 150));

            _houseWidth = Math.Abs(insideFrontWallHorizontalCoord - outsideWallHorizontalCoord);
            _roofHeight = Math.Abs(ceilingVerticalCoord - floorVerticalCoord) / 2;

            // house corners coords - mapped onto the house above
            
            Point outsideBottomFront = new Point(outsideWallHorizontalCoord, floorVerticalCoord); // Outside Bottom Front (0)
            Point insideBottomFront = new Point(insideFrontWallHorizontalCoord, outsideBottomFront.Y); // Inside Bottom Front (1)
            Point insideTopFront = new Point(insideFrontWallHorizontalCoord, ceilingVerticalCoord); // Inside Top Front (2)
            Point outsideTopFront = new Point(outsideWallHorizontalCoord, insideTopFront.Y); // Outside Top Front (3)
            Point insideBottomBack = new Point(insideBackWallHorizontalCoord, floorVerticalCoord + (ceilingVerticalCoord - floorVerticalCoord) / 2); // Inside Bottom Back (4)
            Point insideTopBack = new Point(insideBackWallHorizontalCoord, ceilingVerticalCoord + (ceilingVerticalCoord - floorVerticalCoord) / 2); // Inside Top Back (5)
            Point topBackCornerOfRoof;// Top Back Corner of Roof (6)
            Point topFrontCornerOfRoof;// Top Front Corner of Roof (7)
            Point outsideBottomBack; // hidden ground-level corner (8) don't currently need.
            Point outsideTopBack; // semi hidden ceiling corner (9)
            if (_houseSide == "FrontLeft" || _houseSide == "Left" || _houseSide == "Front")
            {
                topFrontCornerOfRoof = new Point(insideBottomFront.X + (_houseWidth / 2), insideTopFront.Y - ((int)(_houseWidth * _roofSF / 4))); 
                topBackCornerOfRoof = new Point(insideTopBack.X + (_houseWidth / 2), insideTopBack.Y - ((int)(_houseWidth * _roofSF / 4)));
                outsideBottomBack = new Point(insideBottomBack.X + _houseWidth, insideBottomBack.Y);
                outsideTopBack = new Point(insideTopBack.X + _houseWidth, insideTopBack.Y);
            }
            else
            {
                topFrontCornerOfRoof = new Point(insideBottomFront.X - (_houseWidth / 2), insideTopFront.Y - ((int)(_houseWidth * _roofSF / 4)));
                topBackCornerOfRoof = new Point(insideTopBack.X - (_houseWidth / 2), insideTopBack.Y - ((int)(_houseWidth * _roofSF / 4)));
                outsideBottomBack = new Point(insideBottomBack.X - _houseWidth, insideBottomBack.Y);
                outsideTopBack = new Point(insideTopBack.X - _houseWidth, insideTopBack.Y);
            }

            _housePoints = new Point[]
            {
                outsideBottomFront,
                insideBottomFront,
                insideTopFront,
                outsideTopFront,
                insideBottomBack,
                insideTopBack,
                topFrontCornerOfRoof,
                topBackCornerOfRoof,
                outsideBottomBack,
                outsideTopBack
            };

            //Build the house
            DrawWalls();
            DrawDoor();
            DrawRoof();
        }

        /// <summary>
        /// Draws the walls for the house
        /// </summary>
        private void DrawWalls()
        {
            Point[] frontOfHouse = { _housePoints[0], _housePoints[1], _housePoints[2], _housePoints[3] };

            // Draw the front wall
            int colorRed = _random.Next(100, 150);
            int colorGreen = _random.Next(80, 130);
            int colorBlue = _random.Next(50, 80);
            Brush houseBrush = new SolidBrush(Color.FromArgb(255, colorRed, colorGreen, colorBlue));
            _gfx.FillPolygon(houseBrush, frontOfHouse);
            
            // draw the side wall
            if (_houseSide != "Front")
            {
                Point[] wall = new Point[] { _housePoints[1], _housePoints[2], _housePoints[5], _housePoints[4] };
                Brush wallBrush = new SolidBrush(Color.FromArgb(255, colorRed - _SHADE_SCALE, colorGreen - _SHADE_SCALE, colorBlue - _SHADE_SCALE));
                _gfx.FillPolygon(wallBrush, wall);
            }
        }

        /// <summary>
        /// Draws a door for the house
        /// </summary>
        private void DrawDoor()
        {
            Point bottomFrontLeftCorner;
            Point bottomFrontRightCorner;
            if (_houseSide == "Left" || _houseSide == "FrontLeft" || _houseSide == "Front")
            {
                bottomFrontLeftCorner = _housePoints[1];
                bottomFrontRightCorner = _housePoints[0];
            }

            else if (_houseSide == "Right" || _houseSide == "FrontRight")
            {
                bottomFrontRightCorner = _housePoints[1];
                bottomFrontLeftCorner = _housePoints[0];
            }
            else
            {
                bottomFrontRightCorner = _housePoints[1];
                bottomFrontLeftCorner = _housePoints[0];
                MessageBox.Show("Error. DrawDoor Method.");
            }

            int bottomLeft = _random.Next(bottomFrontLeftCorner.X, bottomFrontRightCorner.X - 50);
            Point[] door = {new Point(bottomLeft, bottomFrontRightCorner.Y), new Point(bottomLeft + 25, bottomFrontRightCorner.Y),
                new Point(bottomLeft + 25, bottomFrontLeftCorner.Y - 50), new Point(bottomLeft, bottomFrontLeftCorner.Y - 50) };
            Brush doorBrush = new SolidBrush(Color.FromArgb(255, 153, 0, 0));
            _gfx.FillPolygon(doorBrush, door);

            //door knob
            Point doorKnob = new Point(bottomLeft + 12, bottomFrontLeftCorner.Y - 25);
            Brush doorKnobBrush = new SolidBrush(Color.Black);
            _gfx.FillEllipse(doorKnobBrush, doorKnob.X, doorKnob.Y, 6, 6);
        }

        /// <summary>
        /// Draws a roof for the house
        /// </summary>
        private void DrawRoof()
        {
            
            //roof overhang
            Point roofOverhang1;// front left corner of roof
            Point roofOverhang2;// front right corner of roof
            Point roofOverhang3;//back left corner of roof
            Point roofOverhang4;// back right corner of roof
            if (_houseSide == "Left" || _houseSide == "FrontLeft" || _houseSide == "Front")
            {
                roofOverhang1 = new Point((int)(_housePoints[2].X - _OVERHANG_AMOUNT * _roofSF), _housePoints[2].Y);
                roofOverhang2 = new Point((int)(_housePoints[5].X - _OVERHANG_AMOUNT * _roofSF), _housePoints[5].Y);
                roofOverhang3 = new Point((int)(_housePoints[3].X + _OVERHANG_AMOUNT * _roofSF), _housePoints[3].Y);
                roofOverhang4 = new Point((int)(_housePoints[9].X + _OVERHANG_AMOUNT * _roofSF), _housePoints[9].Y);
            }
            else
            {
                roofOverhang1 = new Point((int)(_housePoints[2].X + _OVERHANG_AMOUNT * _roofSF), _housePoints[2].Y);
                roofOverhang2 = new Point((int)(_housePoints[5].X + _OVERHANG_AMOUNT * _roofSF), _housePoints[5].Y);
                roofOverhang3 = new Point((int)(_housePoints[3].X - _OVERHANG_AMOUNT * _roofSF), _housePoints[3].Y);
                roofOverhang4 = new Point((int)(_housePoints[9].X - _OVERHANG_AMOUNT * _roofSF), _housePoints[9].Y);
            }

            int red = _random.Next(120, 140);
            int green = _random.Next(120, 150);
            int blue = _random.Next(140, 170);

            if (_houseSide != "Front")
            {
                // other side of roof
                Point[] roofSide;
                roofSide = new Point[] { roofOverhang3, roofOverhang4, _housePoints[7], _housePoints[6] };
                Brush roofLightBrush = new SolidBrush(Color.FromArgb(255, red, green, blue));
                _gfx.FillPolygon(roofLightBrush, roofSide);

                // main side of roof
                Brush roofDarkBrush = new SolidBrush(Color.FromArgb(255, red - _SHADE_SCALE, green - _SHADE_SCALE, blue - _SHADE_SCALE));

                roofSide = new Point[] { roofOverhang1, roofOverhang2, _housePoints[7], _housePoints[6] };


                _gfx.FillPolygon(roofDarkBrush, roofSide);
            }

            // front of roof
            Point[] roofFront;
            Brush roofMidBrush;
            // front of roof
            roofFront = new Point[] { _housePoints[6], roofOverhang1, roofOverhang3 };
            roofMidBrush = new SolidBrush(Color.FromArgb(255, red - _SHADE_SCALE / 2, green - _SHADE_SCALE / 2, blue - _SHADE_SCALE / 2));
            _gfx.FillPolygon(roofMidBrush, roofFront);
        
            
        }
        
        /// <summary>
        /// Initializes all my painting methods
        /// </summary>
        /// <param name="sender">I got nothing.</param>
        /// <param name="e">Still nope</param>
        private void frmBrandonsFirstDrawing_Paint(object sender, PaintEventArgs e)
        {
            MiscDrawingStuff(e);
            TraceMountains();
            DrawMountains();
            DrawSnowCaps();
            DrawSky();
            DrawGroundBase();
            DrawGround();
            DrawHouse();
        }

        /// <summary>
        /// Tells form to randomize and paint a new picture. Resets some fields
        /// </summary>
        /// <param name="sender">button click</param>
        /// <param name="e">graphic something something</param>
        private void btnNewPainting_Click(object sender, EventArgs e)
        {
            _gfx = null;
            _formHeight = 0;
            _formWidth = 0;
            _groundLevel = 0;
            _mountainLevel = 0;
            _mountainRidgeLine = new List<Point>();// the line seperating _mountains from the _sky
            _mountains = new List<Point>(); // the height-point seperating _mountains from rest of the land
            _mountainBaseLine = new Point(0,0);
            _sky = new List<Point>();
            _snowLine = new List<Point>();
            _mountainBaseFull = new List<Point>();
            _indexForLastPointOnBottomOf_mountains = 0;
            _houseSide = "";
            _housePoints = null;
            Invalidate();
        }

        private void tkbrGrass_Scroll(object sender, EventArgs e)
        {
            _grassSF = tkbrGrass.Value / 20;
        }

        private void tkbrMountains_Scroll(object sender, EventArgs e)
        {
            _mountainHeight = tkbrMountains.Value * 0.6;
        }

        private void tkbrSnow_Scroll(object sender, EventArgs e)
        {
            if (tkbrSnow.Value <= 1) _amountOfSnow = 0.8;
            else _amountOfSnow = tkbrSnow.Value * 2;
        }

        private void tkbrHouse_Scroll(object sender, EventArgs e)
        {
            _houseSF = tkbrHouse.Value * 0.1;
        }

        private void tkbrSun_Scroll(object sender, EventArgs e)
        {
            _sunSF = tkbrSun.Value;
            if (tkbrSun.Value == 0) _sunSF = 0.5;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            gbControls.Hide();
            btnShow.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            gbControls.Show();
            btnShow.Hide();
        }

        /// <summary>
        /// randomizes and draws a new painting, resetting some fields, upoin resizing the window. Otherwise it distorts the image like mad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBrandonsFirstDrawing_ResizeEnd(object sender, EventArgs e)
        {
            _gfx = null;
            _formHeight = 0;
            _formWidth = 0;
            _groundLevel = 0;
            _mountainLevel = 0;
            _mountainRidgeLine = new List<Point>();// the line seperating _mountains from the _sky
            _mountains = new List<Point>(); // the height-point seperating _mountains from rest of the land
            _mountainBaseLine = new Point(0, 0);
            _sky = new List<Point>();
            _snowLine = new List<Point>();
            _mountainBaseFull = new List<Point>();
            _indexForLastPointOnBottomOf_mountains = 0;
            _houseSide = "";
            _housePoints = null;
            Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetStuff();
        }
    }
}
