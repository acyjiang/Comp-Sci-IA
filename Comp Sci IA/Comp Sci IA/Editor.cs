using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp_Sci_IA
{
    internal class Editor
    {
        Stack<Image> undo;
        Stack<Image> redo;
        Image _image;
        int _width;
        int _height;
        int _wBound;
        int _hBound;
        int _cX;
        int _cY;
        double _scaleFactor;

        public Editor(Image image, int wBound, int hBound, int cX, int cY)
        {
            _image = image;
            _cX = cX;
            _cY = cY;
            _wBound = wBound;
            _hBound = hBound;
            set_dims();
            this.undo = new Stack<Image>();
            this.redo = new Stack<Image>();
            this.undo.Push(image);
        }

        public void setImage(Image image)
        {
            this._image = image;
            set_dims();
            this.undo.Push((Image)image.Clone());
            this.redo.Clear();

            foreach (Image i in undo)
            {
                Console.WriteLine(i.Height + " " + i.Width);
            }
        }

        public void set_dims()
        {
            _scaleFactor = Math.Min((double)_wBound / _image.Width, (double)_hBound / _image.Height);
            _width = (int)(_image.Width * _scaleFactor);
            _height = (int)(_image.Height * _scaleFactor);
            Console.WriteLine(_width + " " + _height + " " + _cX + " " + _cY);
        }

        public int leftBound()
        {
            return _cX - _width / 2;
        }
        public int rightBound()
        {
            return _cX + _width / 2;
        }
        public int upperBound()
        {
            return _cY - _height / 2;
        }
        public int lowerBound()
        {
            return _cY + _height / 2;
        }

        public int getWidth() { return _width; }

        public int getHeight() { return _height; }

        public double getScale() { return 1/_scaleFactor; }

        public Image getImage() { return _image; }

        public void undoHistory()
        {
            redo.Push((Image)undo.Pop().Clone());
            this._image = (Image)undo.Peek().Clone();
            set_dims();
            Console.WriteLine(undo.Count + " " + redo.Count);
        }

        public void redoHistory()
        {
            undo.Push(redo.Peek());
            this._image = redo.Pop();
            set_dims();
        }
    }
}
