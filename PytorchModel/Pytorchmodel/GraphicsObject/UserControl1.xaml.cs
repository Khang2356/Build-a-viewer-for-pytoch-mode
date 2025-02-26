﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pytorchmodel.RenderControl;

namespace Pytorchmodel.GraphicsObject
{
    /// <summary>
    /// Interaction logic for GraphicsNode_UsrCtrl.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private double maxLength;
        public AnchorPoint AnchorPoint;
        public string NodeType;

        public bool isHighlighted;
        public string CurrentTitleColor;
        public string CurrentAttributeColor;

        public string LayerName;

        public UserControl1()
        {
            InitializeComponent();
            this.NodeType = "";
            this.CurrentTitleColor = "#30302F";
            this.CurrentAttributeColor = "#2D2D2D";
            this.maxLength = txtblockPropety.Width;
            this.isHighlighted = false;
            ApplyColor();
        }

        public UserControl1(string _type)
        {
            InitializeComponent();
            this.NodeType = _type;
            this.CurrentTitleColor = "#30302F";
            this.CurrentAttributeColor = "#2D2D2D";
            this.maxLength = txtblockPropety.Width;
            this.isHighlighted = false;
            ApplyColor();
        }

        public void ApplyColor()
        {
            BrushConverter bc = new BrushConverter();
            TitleZone.Background = (Brush)bc.ConvertFrom(CurrentTitleColor);
            AttributesZone.Background = (Brush)bc.ConvertFrom(CurrentAttributeColor);
        }

        public String txtPropety
        {
            get { return this.txtblockPropety.Text; }
            set { this.txtblockPropety.Text = string.Format(value); }
        }

        public String txtTitle
        {
            get { return this.txtblockTitle.Text; }
            set { this.txtblockTitle.Text = string.Format(value); }
        }

        public void SetAsInputNode()
        {
            this.Height = 25;
        }

        [Obsolete]
        public void txtPropety_AddLine(string lineInput)
        {
            if (txtblockPropety.Text == "")
            {
                txtblockPropety.Text += lineInput;
                this.Height -= 28;
            }
            else
                txtblockPropety.Text += System.Environment.NewLine + lineInput;


            FormattedText formattedText = new FormattedText(
            lineInput,
            new System.Globalization.CultureInfo("en-us", false),
            FlowDirection.LeftToRight,
            new Typeface("Segoe UI"),
            18,
            Brushes.Black);

            if (maxLength < formattedText.MinWidth)
            {
                this.Width = formattedText.MinWidth + 24;
                maxLength = lineInput.Length;
            }

            this.Height += 28;
        }

        public void Transform2SingleLine()
        {
            AttributeGrid.Visibility = System.Windows.Visibility.Hidden;
            this.Height = 29;
            TitleZone.CornerRadius = new CornerRadius(10, 10, 10, 10);
        }

        public void CalcAnchorPoint()
        {
            AnchorPoint = new AnchorPoint(this.Height, this.Width, Canvas.GetTop(this), Canvas.GetLeft(this));
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            TitleZone.Background = new SolidColorBrush(Colors.Gray);
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            ApplyColor();
        }

        public void NodeByType(string _type)
        {
            switch (_type)
            {
                case "Conv2d":
                    txtTitle = "Conv2d";
                    CurrentTitleColor = "#385073";
                    ApplyColor();
                    break;
                case "InputLayer":
                    txtTitle = "Input";
                    CurrentTitleColor = "#414141";
                    ApplyColor();
                    Transform2SingleLine();
                    break;
                case "AvgPool2d":
                    txtTitle = "AvgPool2d";
                    CurrentTitleColor = "#385037";
                    ApplyColor();
                    break;
                case "MaxPool2d":
                    txtTitle = "MaxPool2d";
                    CurrentTitleColor = "#385037";
                    ApplyColor();
                    break;
                case "BatchNorm2d":
                    txtTitle = "BatchNorm2d";
                    CurrentTitleColor = "#385037";
                    ApplyColor();
                    break;
                case "Linear":
                    txtTitle = "Linear";
                    CurrentTitleColor = "#385037";
                    ApplyColor();
                    break;
                case "Dropout":
                    txtTitle = "Dropout";
                    CurrentTitleColor = "#385037";
                    ApplyColor();
                    break;
                case "Softmax":
                    txtTitle = "Softmax";
                    CurrentTitleColor = "#385037";
                    ApplyColor();
                    break;
                default:
                    break;
            }
        }

        private void MainGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SlidePanel_Control.SlidePanel_Show(this.LayerName, SlidePanel_Mode.LayerPropeties);
        }

        public void Highlight()
        {
            this.AlertBox.Visibility = System.Windows.Visibility.Visible;
            Storyboard sb = Resources["MarchingAnts"] as Storyboard;
            sb.RepeatBehavior = RepeatBehavior.Forever;
            sb.Begin(this.AlertBox);
            this.isHighlighted = true;
        }

        public void DeHighlight()
        {
            this.AlertBox.Visibility = System.Windows.Visibility.Hidden;
            Storyboard sb = Resources["MarchingAnts"] as Storyboard;
            sb.RepeatBehavior = new RepeatBehavior(0);
            sb.Begin(this.AlertBox);
            this.isHighlighted = false;
        }
    }
}
