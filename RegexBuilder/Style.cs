using System;
using System.Drawing;

namespace RegexBuilder {

    /// <summary>
    /// Encapsulates information about a style, which means a BG and FG colors to be used in the
    /// RTF Text box
    /// </summary>
    public class Style {

        private Color _fore;
        private Color _back;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="background">The BG Color</param>
        /// <param name="foreground">The FG Color</param>
        public Style(Color background, Color foreground) {
            this._back = background;
            this._fore = foreground;
        }

        /// <summary>
        /// The foreground color
        /// </summary>
        public Color ForegroundColor {
            get { return this._fore; }
            set { this._fore = value; }
        }

        /// <summary>
        /// The background color
        /// </summary>
        public Color BackgroundColor {
            get { return this._back; }
            set { this._back = value; }
        }
    }
}
