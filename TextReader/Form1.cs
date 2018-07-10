
namespace TextReader
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : System.Windows.Forms.Form
    {
        #region Fields

        // The status of the reading.
        private StatusTypes _currentStatus = StatusTypes.Stopped;

        // The path to the sound files.
        private const string _path = @"..\..\Resources\Letters\";

        // The sound player.
        private System.Media.SoundPlayer _soundPlayer = new System.Media.SoundPlayer();

        // The position of the cursor.
        private System.Drawing.Point _currentPosition = new System.Drawing.Point(0, 0);

        // The time between to letter is read.
        private const int _timerSpace = 80;

        // Read with sound.
        private bool _hasSound = false;

        /// <summary>
        /// The types of reading status.
        /// </summary>
        public enum StatusTypes
        {
            /// <summary>
            /// The reading is in progress.
            /// </summary>
            Playing,
            /// <summary>
            /// The reading is not in progress.
            /// </summary>
            Stopped,
            /// <summary>
            /// The reading is paused.
            /// </summary>
            Paused
        }

        #endregion Fields

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Plays the sound of the alphabet.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/>.</param>
        private void ReadText(object sender, System.EventArgs e)
        {
            try
            {
                switch (GetCharacterFromRichtextbox(_currentPosition))
                {
                    case 'a':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'a')
                        {
                            SendResponse("aa");
                        }
                        else
                        {
                            SendResponse("a");
                        }
                        break;
                    case 'á':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'á')
                        {
                            SendResponse("áá");
                        }
                        else
                        {
                            SendResponse("á");
                        }
                        break;
                    case 'b':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'b')
                        {
                            SendResponse("bb");
                        }
                        else
                        {
                            SendResponse("b");
                        }
                        break;
                    case 'c':
                        if ((GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'c') &&
                            (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 2, _currentPosition.Y)) == 's'))
                        {
                            SendResponse("ccs");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 's')
                        {
                            SendResponse("cs");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'c')
                        {
                            SendResponse("cc");
                        }
                        else
                        {
                            SendResponse("c");
                        }
                        break;
                    case 'd':
                        if ((GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'z') &&
                            (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 2, _currentPosition.Y)) == 's'))
                        {
                            SendResponse("dzs");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'z')
                        {
                            SendResponse("dz");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'd')
                        {
                            SendResponse("dd");
                        }
                        else
                        {
                            SendResponse("d");
                        }
                        break;
                    case 'e':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'e')
                        {
                            SendResponse("ee");
                        }
                        else
                        {
                            SendResponse("e");
                        }
                        break;
                    case 'é':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'é')
                        {
                            SendResponse("éé");
                        }
                        else
                        {
                            SendResponse("é");
                        }
                        break;
                    case 'f':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'f')
                        {
                            SendResponse("ff");
                        }
                        else
                        {
                            SendResponse("f");
                        }
                        break;
                    case 'g':
                        if ((GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'g') &&
                            (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 2, _currentPosition.Y)) == 'y'))
                        {
                            SendResponse("ggy");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'y')
                        {
                            SendResponse("gy");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'g')
                        {
                            SendResponse("gg");
                        }
                        else
                        {
                            SendResponse("g");
                        }
                        break;
                    case 'h':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'h')
                        {
                            SendResponse("hh");
                        }
                        else
                        {
                            SendResponse("h");
                        }
                        break;
                    case 'i':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'i')
                        {
                            SendResponse("ii");
                        }
                        else
                        {
                            SendResponse("i");
                        }
                        break;
                    case 'í':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'í')
                        {
                            SendResponse("íí");
                        }
                        else
                        {
                            SendResponse("í");
                        }
                        break;
                    case 'j':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'j')
                        {
                            SendResponse("jj");
                        }
                        else
                        {
                            SendResponse("j");
                        }
                        break;
                    case 'k':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'k')
                        {
                            SendResponse("kk");
                        }
                        else
                        {
                            SendResponse("k");
                        }
                        break;
                    case 'l':
                        if ((GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'l') &&
                            (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 2, _currentPosition.Y)) == 'y'))
                        {
                            SendResponse("lly");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'y')
                        {
                            SendResponse("ly");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'l')
                        {
                            SendResponse("ll");
                        }
                        else
                        {
                            SendResponse("l");
                        }
                        break;
                    case 'm':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'm')
                        {
                            SendResponse("mm");
                        }
                        else
                        {
                            SendResponse("m");
                        }
                        break;
                    case 'n':
                        if ((GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'n') &&
                            (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 2, _currentPosition.Y)) == 'y'))
                        {
                            SendResponse("nny");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'y')
                        {
                            SendResponse("ny");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'n')
                        {
                            SendResponse("nn");
                        }
                        else
                        {
                            SendResponse("n");
                        }
                        break;
                    case 'o':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'o')
                        {
                            SendResponse("oo");
                        }
                        else
                        {
                            SendResponse("o");
                        }
                        break;
                    case 'ó':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'ó')
                        {
                            SendResponse("óó");
                        }
                        else
                        {
                            SendResponse("ó");
                        }
                        break;
                    case 'ö':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'ö')
                        {
                            SendResponse("öö");
                        }
                        else
                        {
                            SendResponse("ö");
                        }
                        break;
                    case 'ő':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'ő')
                        {
                            SendResponse("őő");
                        }
                        else
                        {
                            SendResponse("ő");
                        }
                        break;
                    case 'p':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'p')
                        {
                            SendResponse("pp");
                        }
                        else
                        {
                            SendResponse("p");
                        }
                        break;
                    case 'q':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'q')
                        {
                            SendResponse("qq");
                        }
                        else
                        {
                            SendResponse("q");
                        }
                        break;
                    case 'r':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'r')
                        {
                            SendResponse("rr");
                        }
                        else
                        {
                            SendResponse("r");
                        }
                        break;
                    case 's':
                        if ((GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 's') &&
                            (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 2, _currentPosition.Y)) == 'z'))
                        {
                            SendResponse("ssz");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'z')
                        {
                            SendResponse("sz");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 's')
                        {
                            SendResponse("ss");
                        }
                        else
                        {
                            SendResponse("s");
                        }
                        break;
                    case 't':
                        if ((GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 't') &&
                            (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 2, _currentPosition.Y)) == 'y'))
                        {
                            SendResponse("tty");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'y')
                        {
                            SendResponse("ty");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 't')
                        {
                            SendResponse("tt");
                        }
                        else
                        {
                            SendResponse("t");
                        }
                        break;
                    case 'u':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'u')
                        {
                            SendResponse("uu");
                        }
                        else
                        {
                            SendResponse("u");
                        }
                        break;
                    case 'ú':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'ú')
                        {
                            SendResponse("úú");
                        }
                        else
                        {
                            SendResponse("ú");
                        }
                        break;
                    case 'ü':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'ü')
                        {
                            SendResponse("üü");
                        }
                        else
                        {
                            SendResponse("ü");
                        }
                        break;
                    case 'ű':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'ű')
                        {
                            SendResponse("űű");
                        }
                        else
                        {
                            SendResponse("ű");
                        }
                        break;
                    case 'v':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'v')
                        {
                            SendResponse("vv");
                        }
                        else
                        {
                            SendResponse("v");
                        }
                        break;
                    case 'w':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'w')
                        {
                            SendResponse("ww");
                        }
                        else
                        {
                            SendResponse("w");
                        }
                        break;
                    case 'x':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'x')
                        {
                            SendResponse("xx");
                        }
                        else
                        {
                            SendResponse("x");
                        }
                        break;
                    case 'y':
                        if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'y')
                        {
                            SendResponse("yy");
                        }
                        else
                        {
                            SendResponse("y");
                        }
                        break;
                    case 'z':
                        if ((GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'z') &&
                            (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 2, _currentPosition.Y)) == 's'))
                        {
                            SendResponse("zzs");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 's')
                        {
                            SendResponse("zs");
                        }
                        else if (GetCharacterFromRichtextbox(new System.Drawing.Point(_currentPosition.X + 1, _currentPosition.Y)) == 'z')
                        {
                            SendResponse("zz");
                        }
                        else
                        {
                            SendResponse("z");
                        }
                        break;
                    case ' ':
                    case ',':
                    case ':':
                    case ';':
                    case '-':
                    case '_':
                    case '"':
                    case '˝':
                    case '§':
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '+':
                    case '*':
                    case '/':
                    case '\\':
                    case '\'':
                    case '%':
                    case '=':
                    case '(':
                    case ')':
                    case '€':
                    case '<':
                    case '>':
                    case '{':
                    case '}':
                    case '&':
                    case '@':
                    case '#':
                    case '[':
                    case ']':
                    case '|':
                    case '–':
                        if (!_hasSound)
                        {
                            System.Diagnostics.Debug.WriteLine(" ");
                        }

                        System.Threading.Thread.Sleep(_timerSpace);
                        IncreaseCurrentPosition(1);
                        break;
                    case '.':
                    case '?':
                    case '!':
                        System.Threading.Thread.Sleep(2 * _timerSpace);
                        IncreaseCurrentPosition(1);
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                if (_hasSound)
                {
                    System.Diagnostics.Debug.WriteLine("error");
                }

                IncreaseCurrentPosition(1);
            }
        }

        /// <summary>
        /// Plays the given sound.
        /// </summary>
        /// <param name="text">The sound to play.</param>
        private void SendResponse(string text)
        {
            try
            {
                if (_hasSound)
                {
                    _soundPlayer.SoundLocation = _path + text + ".mp3";
                    _soundPlayer.Play();
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(text);
                }

                IncreaseCurrentPosition(text.Length);
            }
            catch
            { }
        }

        /// <summary>
        /// Gets the character of the text at the given position.
        /// </summary>
        /// <param name="point">The character's position.</param>
        /// <returns>The character.</returns>
        private char GetCharacterFromRichtextbox(System.Drawing.Point point)
        {
            try
            {
                return richTextBox1.Lines[point.Y][point.X].ToString().ToLower()[0];
            }
            catch
            {
                return ' ';
            }
        }

        /// <summary>
        /// Increases the cursor's position.
        /// </summary>
        /// <param name="value">The value to increase the cursor's position.</param>
        private void IncreaseCurrentPosition(int value)
        {
            try
            {
                if (_currentPosition.X + value >= richTextBox1.Lines[_currentPosition.Y].Length)
                {
                    _currentPosition.Y += 1;
                    _currentPosition.X = 0;
                }
                else
                {
                    _currentPosition.X += value;
                }

                if (_currentPosition.Y > richTextBox1.Lines.Length - 1)
                {
                    timer1.Stop();
                    button2.Text = "Play";
                    button3.Enabled = false;
                    _currentStatus = StatusTypes.Stopped;
                    _currentPosition = new System.Drawing.Point(0, 0);
                }
            }
            catch
            { }
        }

        /// <summary>
        /// Jumps to the previus page of the text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/>.</param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            _currentStatus = StatusTypes.Stopped;
            _currentPosition = new System.Drawing.Point(0, 0);
            timer1.Stop();
            button2.Text = "Play";
        }

        /// <summary>
        /// Starts or pauses the reading.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/>.</param>
        private void button2_Click(object sender, System.EventArgs e)
        {
            if (_currentStatus == StatusTypes.Stopped)
            {
                _currentStatus = StatusTypes.Playing;
                timer1.Start();
                button2.Text = "Pause";
            }
            else if (_currentStatus == StatusTypes.Paused)
            {
                _currentStatus = StatusTypes.Playing;
                timer1.Start();
                button2.Text = "Paused";
            }
            else if (_currentStatus == StatusTypes.Playing)
            {
                _currentStatus = StatusTypes.Paused;
                timer1.Stop();
                button2.Text = "Continue";
            }

            button3.Enabled = true;
        }

        /// <summary>
        /// Stops the reading.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/>.</param>
        private void button3_Click(object sender, System.EventArgs e)
        {
            _currentStatus = StatusTypes.Stopped;
            _currentPosition = new System.Drawing.Point(0, 0);
            timer1.Stop();
            button2.Text = "Play";
            button2.Enabled = true;
            button3.Enabled = false;
        }

        /// <summary>
        /// Jumps to the next page of the text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/>.</param>
        private void button4_Click(object sender, System.EventArgs e)
        {
            _currentStatus = StatusTypes.Stopped;
            _currentPosition = new System.Drawing.Point(0, 0);
            timer1.Stop();
            button2.Text = "Play";
        }

        /// <summary>
        /// Sets the volume acording to the trackbar.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/>.</param>
        private void trackBar1_Scroll(object sender, System.EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        /// <summary>
        /// Sets the default values for the elements after the form is loaded.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/>.</param>
        private void Form1_Load(object sender, System.EventArgs e)
        {
            button1.Text = "Back";
            button2.Text = "Play";
            button3.Text = "Stop";
            button4.Text = "Next";

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            richTextBox1.Text = "";
            trackBar1.Value = 50;
            label1.Text = trackBar1.Value.ToString();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = _timerSpace;
            timer1.Tick += ReadText;

            _soundPlayer.SoundLocation = "";
            _soundPlayer.Stop();

            _currentStatus = StatusTypes.Stopped;
            _currentPosition = new System.Drawing.Point(0, 0);
        }

        /// <summary>
        /// Shows information about the application.
        /// </summary>
        /// <param name="sender">THe sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/>.</param>
        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (Form2 about = new Form2())
            {
                about.ShowDialog();
            }
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/>.</param>
        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _currentStatus = StatusTypes.Stopped;
            _currentPosition = new System.Drawing.Point(0, 0);
            timer1.Stop();
            Close();
        }

        /// <summary>
        /// Clears the textbox.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/>.</param>
        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _currentStatus = StatusTypes.Stopped;
            _currentPosition = new System.Drawing.Point(0, 0);
            timer1.Stop();
            richTextBox1.Text = "";
            button2.Enabled = false;
        }

        /// <summary>
        /// Opens a text file and reads it's content.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/>.</param>
        private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            richTextBox1.Text = "";

            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|Documents (.doc)|*.doc|Word Documents (.docx)|*.docx|PDF Files (.pdf)|*.pdf|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                switch (openFileDialog1.FileName.Split('.')[openFileDialog1.FileName.Split('.').Length - 1].ToLower())
                {
                    case "txt":
                        System.Text.Encoding enc = GetFileEncoding(openFileDialog1.FileName);

                        using (System.IO.FileStream fileStream = System.IO.File.Open(openFileDialog1.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        {
                            using (System.IO.StreamReader streamReader = new System.IO.StreamReader(fileStream, enc))
                            {
                                richTextBox1.Text = streamReader.ReadToEnd();
                            }
                        }
                        break;
                    case "doc":
                    case "docx":
                        Microsoft.Office.Interop.Word.Application app2 = new Microsoft.Office.Interop.Word.Application();
                        {
                            Microsoft.Office.Interop.Word.Document doc = app2.Documents.Open(openFileDialog1.FileName);
                            {
                                foreach (Microsoft.Office.Interop.Word.Paragraph objParagraph in doc.Paragraphs)
                                {
                                    richTextBox1.Text += objParagraph.Range.Text;
                                }

                                doc.Close();
                            }

                            app2.Quit();
                        }
                        break;
                    case "pdf":
                        using (iTextSharp.text.pdf.PdfReader pdfReader = new iTextSharp.text.pdf.PdfReader(openFileDialog1.FileName))
                        {
                            for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                            {
                                richTextBox1.Text += iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(pdfReader, page, new iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy());
                            }
                        }
                        break;
                }
            }

            button2.Enabled = !string.IsNullOrEmpty(richTextBox1.Text.Trim());
            _currentStatus = StatusTypes.Stopped;
            _currentPosition = new System.Drawing.Point(0, 0);
            timer1.Stop();
        }

        /// <summary>
        /// Detects the byte order mark of a file and returns an appropriate encoding for the file.
        /// </summary>
        /// <param name="srcFile">The path to the file.</param>
        /// <returns>The encoding.</returns>
        private System.Text.Encoding GetFileEncoding(string srcFile)
        {
            // Use Default of Encoding.Default (Ansi CodePage)
            System.Text.Encoding enc = System.Text.Encoding.Default;

            // Detect byte order mark if any - otherwise assume default
            byte[] buffer = new byte[5];

            using (System.IO.FileStream file = new System.IO.FileStream(srcFile, System.IO.FileMode.Open))
            {
                file.Read(buffer, 0, 5);
                file.Close();
            }

            if (buffer[0] == 0xef && buffer[1] == 0xbb && buffer[2] == 0xbf)
            {
                enc = System.Text.Encoding.UTF8;
            }
            else if (buffer[0] == 0xfe && buffer[1] == 0xff)
            {
                enc = System.Text.Encoding.Unicode;
            }
            else if (buffer[0] == 0 && buffer[1] == 0 && buffer[2] == 0xfe && buffer[3] == 0xff)
            {
                enc = System.Text.Encoding.UTF32;
            }
            else if (buffer[0] == 0x2b && buffer[1] == 0x2f && buffer[2] == 0x76)
            {
                enc = System.Text.Encoding.UTF7;
            }

            return enc;
        }

        /// <summary>
        /// Resets the status to default.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/>.</param>
        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            button1.Text = "Back";
            button2.Text = "Play";
            button3.Text = "Stop";
            button4.Text = "Next";

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            richTextBox1.Text = "";
            trackBar1.Value = 50;
            label1.Text = trackBar1.Value.ToString();
            timer1.Stop();

            _soundPlayer.SoundLocation = "";
            _soundPlayer.Stop();

            _currentStatus = StatusTypes.Stopped;
            _currentPosition = new System.Drawing.Point(0, 0);
        }

        #endregion Methods
    }
}
