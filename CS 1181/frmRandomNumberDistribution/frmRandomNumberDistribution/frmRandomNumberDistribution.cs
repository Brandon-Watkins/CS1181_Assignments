/*

frmRandomNumberDistribution
CS 1181
Brandon Watkins 
26 February 2019
Robert Howe
Description: Generate random numbers, and determine distributions

WOW:
Added a makeshift error displaybox, to display errors without halting the program to display a message box. 
    originally tried using tooltips, but couldn't get it to work how I wanted.
If invalid data is entered, the invalid control is reset, and an error message is displayed.
if nothing (or previously cleared erroneous data) is entered into the seed textbox, the program runs without seed adjustments.
textboxes auto clear upon entering, to make editing them easier.
    textboxes refill with default values if invalid input was entered.
    textboxes refill with previously entered (valid) data, if left blank.
added a button to give additional statistics like mean, median, min, max, and displays them in a seperate form, 
    which calls the methods from its parent form to populate the form.
added a button to save all results to a .txt file.
    added the ability to choose the save name and location
added a reset button
added an exit button
added Thread.Sleep to my save button to help ensure save files were written before moving on(hopefully)
made my trackbar only display ticks if it's generating 100 or less numbers, to reduce drawing time. No point in having a million tick marks

I'm aware I have some unnecesary methods and arrays, I'm just trying to use as many as possible to learn them well.

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
using System.Timers;
using System.IO;
using System.Threading;

namespace frmRandomNumberDistribution
{
    public partial class frmRandomNumberDistribution : Form
    {

        // **************************** Global Variables ************************* //
        public int intVal = -1;
        public double dblVal = -1;
        public bool readyToDisplayIndex = false;
        public int[] randomValuesGenerated; // unaltered list of random numbers, within specified range, queantity, and seed value.
        public int[] sortedRNG; // randomValuesGenerated, sorted from least to greatest.
        public int[] numberDistribution; // shows how many times each number within the specified range was randomly chosen. // NOTE: This array does not utilize the first (0) index. Use 1-10 (for 10 numbers).
        public string[] meanArray; 
        public string[] medianArray;
        public string[] minimumArray;
        public string[] maximumArray;
        public string temporaryHolder;
        public string[] statsTable;

        public frmRandomNumberDistribution()
        {
            InitializeComponent();
        }

        // ************************ Custom Methods ****************************//


        /// <summary>
        /// Reset all controls
        /// </summary>
        private void Reset()
        {
            txtGenerateNumbersBetween_Input.Text = "10";
            txtNumberOfValuesToGenerate_Input.Text = "10";
            txtSeedNumber_Input.Text = "";
            tkbrValueAtIndex.Value = 0;
            lblIndexPosition_Output.Text = "Value at index " + tkbrValueAtIndex.Value.ToString() + ":";
            lblValueAtIndex_Output.BackColor = Control.DefaultBackColor;
            lblValueAtIndex_Output.Location = new Point(368, 232);
            lblValueAtIndex_Output.Text = "";
            lbNumberDistribution_Output.Text = "";
            lbNumbersGenerated_Output.Text = "";
            readyToDisplayIndex = false;
            lbNumberDistribution_Output.Items.Clear();
            lbNumbersGenerated_Output.Items.Clear();
            lblValueAtIndex_Output.BackColor = Control.DefaultBackColor;
            lblValueAtIndex_Output.Location = new Point(216, 146);
            lblValueAtIndex_Output.Text = "";
        }
        
        
        /// <summary>
        /// Checks control inputs, verifying they are positive integers, or resetting values and displaying errors
        /// </summary>
        /// <param name="valueToCheck">control to check (Control)</param>
        /// <param name="intVal">value to check (int)</param>
        /// <param name="dblVal">value to check (double)</param>
        /// <returns>true if valid input was entered (bool)</returns>
        private bool CheckInputs(Control valueToCheck, ref int intVal, ref double dblVal)
        {
            if (valueToCheck.Text == "")
            {
                return false;
            }
            else if(valueToCheck.Text != "")
            {
                try // verifying they are numerical inputs
                {
                    intVal = int.Parse(valueToCheck.Text);
                    dblVal = double.Parse(valueToCheck.Text);

                    if (int.Parse(valueToCheck.Text) <= 0)
                    {
                        InputCorrection(valueToCheck);
                        return false;
                    }
                    else if (intVal == dblVal) // the only scenario in which we use the seed value for calculations
                    {
                        lblError.Visible = false;
                        return true;
                    }
                }
                catch
                {
                    InputCorrection(valueToCheck);
                    return false;
                }
            }
            MessageBox.Show("Something Broke.");
            InputCorrection(valueToCheck);
            return false;
        }


        /// <summary>
        /// resets invalid inputs, and gives an error
        /// </summary>
        /// <param name="valueToCheck">Control</param>
        private void InputCorrection(Control valueToCheck)
        {
            lblError.Text = "Invalid Input Entered:  " + valueToCheck.Text + "." + Environment.NewLine + "Please enter a positive integer value.";
            string text = valueToCheck.Text.Substring(0, valueToCheck.Text.Length - 1);
            valueToCheck.Text = text;
            lblError.Visible = true;
        }


        /// <summary>
        /// Creates a random object, based on whether or not a valid seed was entered
        /// </summary>
        /// <param name="CheckInputs_Seed">check seed input (Control)</param>
        /// <returns>a random object utilizing seed input if input was valid (Random)</returns>
        private Random CreateRandom(bool CheckInputs_Seed)
        {
            Random random = null;

            // determine which random object to use
            if (CheckInputs_Seed == true)
            {
                random = new Random(int.Parse(txtSeedNumber_Input.Text));
            }
            else if (CheckInputs_Seed == false)
            {
                random = new Random();
            }
            return random;
        }


        /// <summary>
        /// Generates random numbers and puts in array
        /// </summary>
        /// <param name="random">the random object to use (Random)</param>
        /// <param name="randomValuesGenerated">the array created (int[])</param>
        private void GenerateRandomNumbers(Random random/*CreateRandom Method*/, out int[] randomValuesGenerated)
        {
            // create array to store randoms
            int numberOfValuesToGenerate = int.Parse(txtNumberOfValuesToGenerate_Input.Text);
            randomValuesGenerated = new int[numberOfValuesToGenerate];
            int rangeOfValuesToGenerate = int.Parse(txtGenerateNumbersBetween_Input.Text);

            // run RNG
            for (int i = 0; i < numberOfValuesToGenerate; i++)
            {
                randomValuesGenerated[i] = random.Next(rangeOfValuesToGenerate) + 1;
                lbNumbersGenerated_Output.Items.Add(randomValuesGenerated[i].ToString());
            }
        }


        /// <summary>
        /// Stores an array to a .txt file
        /// </summary>
        /// <param name="arrayToStore">which array to store in the file (int[])</param>
        private void StoreData(string[] arrayToStore)
        {
            try
            {
                saveFile.DefaultExt = ".txt";
                saveFile.FileName = "Random_Number_Distribution.txt";
                
                DialogResult result = saveFile.ShowDialog();
                if (result == DialogResult.OK)
                {
                    StreamWriter outputFile;
                    outputFile = File.CreateText(saveFile.FileName);

                    int length = arrayToStore.Length;

                    for (int i = 0; i < length - 1; i++)
                    {
                        outputFile.WriteLine(arrayToStore[i]);
                    }
                    Thread.Sleep(500);
                    outputFile.Close();
                    Thread.Sleep(200);
                }
            }
            catch
            {
                MessageBox.Show("Error writing results to .txt file.");
            }
        }


        /// <summary>
        /// Creates an array, storing the number of times each number was generated
        /// </summary>
        /// <param name="numberDistribution">the array this method creates (int[])</param>
        /// <param name="randomValuesGenerated">the array containing the original random values (int[])</param>
        /// <param name="sortedRNG">the array containing the sorted random numbers (int[])</param>
        private void NumberDistribution(out int[] numberDistribution, int[] randomValuesGenerated, int[] sortedRNG)
        {
            // determine the number distribution array size
            numberDistribution = new int[int.Parse(txtGenerateNumbersBetween_Input.Text) + 1]; // index 0 will remain empty, 0, to keep things straight in my head

            int lengthSR = sortedRNG.Length;
            int lengthNum = numberDistribution.Length;

            // create array
            int position = 0;
            numberDistribution[0] = 0;
            for (int outerI = 1; outerI < lengthNum; outerI++)// counting numberDistribution indexes
            {
                int total = 0;
                for (int p = position; p < lengthSR; p++) // counting sortedRNG indexes
                {
                    if (sortedRNG[p] == outerI)
                    {
                        total++;
                        position = p;
                    }
                }
                numberDistribution[outerI] = total;
            }

            // display results

            for (int i = 1; i < lengthNum; i++)
            {
                string message = "There ";
                if (numberDistribution[i] == 1)
                {
                    message += "is 1 " + i;
                }
                else
                {
                    message += "are " + numberDistribution[i] + " " + i + "'s";
                }
                lbNumberDistribution_Output.Items.Add(message);
            }
        }

        
        /// <summary>
        /// Tells the other methods to do their jobs in calculating and displaying the randoms
        /// </summary>
        private void Calculate()
        {
            GenerateRandomNumbers(CreateRandom(CheckInputs(txtSeedNumber_Input, ref intVal, ref dblVal)), out randomValuesGenerated);
            
            SortRandomNumbers(randomValuesGenerated, out sortedRNG);
            
            NumberDistribution(out numberDistribution, randomValuesGenerated, sortedRNG);
        }
        
        
        /// <summary>
        /// creates a new array to organize the random array from least to greatest
        /// </summary>
        /// <param name="randomValuesGenerated">iooriginal random array (int[])</param>
        /// <param name="sortedRNG">the new array created, out, (int[])</param>
        private void SortRandomNumbers(int[] randomValuesGenerated, out int[] sortedRNG)
        {
            int minIndex; // location of smallest value
            int minValue; // smallest value
            int length1 = randomValuesGenerated.Length;
            // create a seperate array, for saving purposes:
            sortedRNG = new int[length1];

            for (int i = 0; i < length1; i++)
            {
                sortedRNG[i] = randomValuesGenerated[i];
            }

            //sort sortedRNG
            int length2 = sortedRNG.Length;
            for (int i = 0; i < length2 - 1; i++)
            {
                minIndex = i;
                int minIndexJ = i;
                minValue = sortedRNG[i];

                for(int j = (i + 1); j < length2; j++)
                {
                    if (sortedRNG[j] < minValue)
                    {
                        minValue = sortedRNG[j];
                        minIndexJ = j;
                    }
                }
               Swap(ref sortedRNG[minIndex], ref sortedRNG[minIndexJ]);

            }
        }


        /// <summary>
        /// swaps two ints
        /// </summary>
        /// <param name="firstIntToSwap">Int</param>
        /// <param name="secondIntToSwap">Int</param>
        private void Swap(ref int firstIntToSwap, ref int secondIntToSwap)
        {
            int temporaryHolder = firstIntToSwap;
            firstIntToSwap = secondIntToSwap;
            secondIntToSwap = temporaryHolder;
        }


        /// <summary>
        /// Swap a Control's string for an empty string, saving original as temporaryHolder
        /// </summary>
        /// <param name="stringToSwap">Control string to replace(Control)</param>
        /// <param name="temporaryHolder">copy of string to replace (string)</param>
        /// <param name="nullString">empty string (string)</param>
        private void Swap(Control stringToSwap, out string temporaryHolder, string nullString = "")
        {   temporaryHolder = stringToSwap.Text;
            stringToSwap.Text = nullString;
        }


        /// <summary>
        /// Swaps temp holder back into Control's string, resets temp holder.
        /// </summary>
        /// <param name="stringToSwap">Control's string to bring back (Control)</param>
        /// <param name="temporaryHolder">variable holding the previous string (string)</param>
        private void Swap(Control stringToSwap, ref string temporaryHolder)
        {
            stringToSwap.Text = temporaryHolder;
            temporaryHolder = "";
        }


        /// <summary>
        /// gathers and calculates additional stats: mean, median, min, max, most common
        /// </summary>
        public void ExtraCalculations()
        {
            if (readyToDisplayIndex)
            {
                //added a button to give additional statistics like mean, median, min, max, and most common numbers, and displays them.
                FindMean(out meanArray);
                FindMedian(out medianArray);
                FindMinimum(out minimumArray);
                FindMaximum(out maximumArray);
                //FindMostCommon(out mostCommonArray); // couldn't get this to work for some reason. Will look into more later.
            }
        }


        /// <summary>
        /// finds highest value in the random numbers
        /// </summary>
        /// <param name="maximumArray">string[]</param>
        private void FindMaximum(out string[] maximumArray)
        {
            maximumArray = new string[2];
            maximumArray[0] = "Max Value:";
            maximumArray[1] = sortedRNG[sortedRNG.Length - 1].ToString();
        }


        /// <summary>
        /// finds lowest value in the random numbers
        /// </summary>
        /// <param name="minimumArray">string[]</param>
        private void FindMinimum(out string[] minimumArray)
        {
            minimumArray = new string[2];
            minimumArray[0] = "Min Value:";
            minimumArray[1] = sortedRNG[0].ToString();
        }


        /// <summary>
        /// finds and/or calculates median value from random numbers
        /// </summary>
        /// <param name="medianArray">string[]</param>
        private void FindMedian(out string[] medianArray)
        {
            medianArray = new string[2];
            medianArray[0] = "Median:";
            int length = sortedRNG.Length;

            if (length % 2 == 0)
            {
                double med1 = sortedRNG[(length - 1) / 2];
                double med2 = sortedRNG[(length + 1) / 2];
                if ((med1 + med2) % 2 == 0)
                {
                    medianArray[1] = ((med1 + med2) / 2).ToString("n0");
                }
                else
                {
                    medianArray[1] = ((med1 + med2) / 2).ToString("n2");
                }
            }

            else
            {
                medianArray[1] = sortedRNG[(length / 2)].ToString("n0");
            }
        
        }


        /// <summary>
        /// calculates the average for the random numbers
        /// </summary>
        /// <param name="meanArray">string[]</param>
        private void FindMean(out string[] meanArray)
        {
            int length = randomValuesGenerated.Length;
            bool error = false;
            double sum = 0.0;
            meanArray = new string[2];
            meanArray[0] = "Mean:";

            for (int i = 0; i < length; i++)
            {
                sum += randomValuesGenerated[i];
                if (sum < 0)
                {
                    error = true;
                }
            }
            double mean = sum / length;
            if (error)
            {
                MessageBox.Show("Mean value couldn't be computed:\r\nData overflow.");
                meanArray[1] = "N/A";
            }
            else if (error == false)
            {
                if ((sum / length) % 2 == 0)
                {
                    meanArray[1] = mean.ToString("n0");
                }
                else
                {
                    meanArray[1] = mean.ToString("n2");
                }
            }
        }


        /// <summary>
        /// Creates a new stats table form, opens it, and hides this form
        /// </summary>
        private void CreateStatsTableForm()
        {
            this.Hide();
            Form StatsTable = new frmStatsTable(this); // sends variables over to stats form
            StatsTable.Owner = this; // sets the current form as the owner, allowing me to switch back to this afterwards.
            StatsTable.Show();
        }


        /// <summary>
        /// Creates an array of total stats
        /// </summary>
        /// <param name="statsTable">outputs the array (string[])</param>
        public void CreateStatsTable(out string[] statsTable)// transfer over to new form
        {
            int lengthRV = randomValuesGenerated.Length;
            int lengthND = numberDistribution.Length;
            statsTable = null;
            const int PAD = 15;// change padding between columns

            // create table with columns:
            // Random #s | Sorted #s | # Distribution | min | max | Mean | Median | Most Common 

            if (lengthRV >= lengthND)// seems to be working
            {
                statsTable = new string[lengthRV + 1];

                statsTable[0] = (((((((("Random Values:".PadRight(PAD)) +
                    "| " + "Sorted Randoms:".PadRight(PAD)).PadLeft(PAD) +
                    "| " + "Distribution:".PadRight(PAD)).PadLeft(2 * PAD) +
                    "| " + minimumArray[0].PadRight(PAD)).PadLeft(3 * PAD) +
                    "| " + maximumArray[0].PadRight(PAD)).PadLeft(4 * PAD) +
                    "| " + meanArray[0].PadRight(PAD)).PadLeft(5 * PAD) +
                    "| " + medianArray[0].PadRight(PAD)).PadLeft(6 * PAD));

                statsTable[1] = ((((((((randomValuesGenerated[0].ToString().PadRight(PAD)) +
                    "| " + sortedRNG[0].ToString().PadRight(PAD)).PadLeft(PAD) +
                    "| " + ("1's: " + numberDistribution[1].ToString()).PadRight(PAD)).PadLeft(2 * PAD) +
                    "| " + minimumArray[1].PadRight(PAD)).PadLeft(3 * PAD) +
                    "| " + maximumArray[1].PadRight(PAD)).PadLeft(4 * PAD) +
                    "| " + meanArray[1].PadRight(PAD)).PadLeft(5 * PAD) +
                    "| " + medianArray[1].PadRight(PAD)).PadLeft(6 * PAD));

                for (int i = 2; i < (lengthND); i++)
                {
                    statsTable[i] = ((randomValuesGenerated[i - 1].ToString().PadRight(PAD) +
                        "| " + sortedRNG[i - 1].ToString().PadRight(PAD)).PadLeft(PAD) +
                        "| " + ((i).ToString() + "'s: " + numberDistribution[i].ToString()).PadRight(PAD)).PadLeft(2 * PAD);
                }

                for (int i = (lengthND); i < lengthRV + 1; i++)
                {
                    statsTable[i] = randomValuesGenerated[i - 1].ToString().PadRight(PAD) +
                        "| " + sortedRNG[i - 1].ToString().PadRight(PAD).PadLeft(PAD);
                }
            }
            else if (lengthRV < lengthND)
            {
                statsTable = new string[lengthND];

                statsTable[0] = (((((((("Random Values:".PadRight(PAD)) +
                    "| " + "Sorted Randoms:".PadRight(PAD)).PadLeft(PAD) +
                    "| " + "Distribution:".PadRight(PAD)).PadLeft(2 * PAD) +
                    "| " + minimumArray[0].PadRight(PAD)).PadLeft(3 * PAD) +
                    "| " + maximumArray[0].PadRight(PAD)).PadLeft(4 * PAD) +
                    "| " + meanArray[0].PadRight(PAD)).PadLeft(5 * PAD) +
                    "| " + medianArray[0].PadRight(PAD)).PadLeft(6 * PAD));

                statsTable[1] = ((((((((randomValuesGenerated[0].ToString().PadRight(PAD)) +
                    "| " + sortedRNG[0].ToString().PadRight(PAD)).PadLeft(PAD) +
                    "| " + ("1's: " + numberDistribution[1].ToString()).PadRight(PAD)).PadLeft(2 * PAD) +
                    "| " + minimumArray[1].PadRight(PAD)).PadLeft(3 * PAD) +
                    "| " + maximumArray[1].PadRight(PAD)).PadLeft(4 * PAD) +
                    "| " + meanArray[1].PadRight(PAD)).PadLeft(5 * PAD) +
                    "| " + medianArray[1].PadRight(PAD)).PadLeft(6 * PAD));

                for (int i = 2; i < (lengthRV + 1); i++)
                {
                    statsTable[i] = ((randomValuesGenerated[i - 1].ToString().PadRight(PAD) +
                        "| " + sortedRNG[i - 1].ToString().PadRight(PAD)).PadLeft(PAD) +
                        "| " + ((i).ToString() + "'s: " + numberDistribution[i].ToString()).PadRight(PAD)).PadLeft(2 * PAD);
                }

                for (int i = (lengthRV + 1); i < lengthND; i++)
                {
                    statsTable[i] = "".PadRight(PAD) +
                        "    " + ("".PadRight(PAD)).PadLeft(PAD) +
                        ((i).ToString() + "'s: " + numberDistribution[i].ToString()).PadRight(PAD).PadLeft(PAD);
                }
            }
        }


        /// <summary>
        /// displays the overall stats using a listbox
        /// </summary>
        /// <param name="whereToDisplayTable">(ListBox)</param>
        public void DisplayStatsTable(ListBox whereToDisplay, string[] statsTable)
        {
            int lengthRV = randomValuesGenerated.Length;
            int lengthND = numberDistribution.Length;

            whereToDisplay.Items.Clear();
            if (lengthRV >= lengthND)
            {
                for (int i = 0; i <= lengthRV; i++)
                {
                    whereToDisplay.Items.Add(statsTable[i]);
                }
            }

            else if (lengthRV < lengthND)
            {
                for (int i = 0; i < lengthND; i++)
                {
                    whereToDisplay.Items.Add(statsTable[i]);
                }
            }
        }


        /// <summary>
        /// Calculates the other, additional, stats.
        /// </summary>
        public void OtherStats()
        {
            statsTable = null;

            if (readyToDisplayIndex)
            {
                ExtraCalculations();
                CreateStatsTable(out statsTable);
            }
            else
            {
                lblError.Text = "Error: Must generate random numbers before\r\nyou can access their results.";
                lblError.Show();
            }
        }


        /// <summary>
        /// determines whether or not to turn off trackbar tick marks
        /// </summary>
        /// <returns>true if need to show tick marks (bool)</returns>
        private bool UseTrackBarTickMarks()
        {
            if (int.Parse(txtNumberOfValuesToGenerate_Input.Text) < 101)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Saves results
        /// </summary>
        public void SaveResults()
        {
            if (readyToDisplayIndex)
            {
                StoreData(statsTable);
            }
            else
            {
                lblError.Text = "Error: Must generate random numbers before\r\nyou can access their results.";
                lblError.Show();
            }
        }


        // *************************** End of Custom Methods *****************************//

        
        private void frmRandomNumberDistribution_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnGenerateRandomNumbers_Click(object sender, EventArgs e)
        {
            lbNumberDistribution_Output.Items.Clear();
            lbNumbersGenerated_Output.Items.Clear();
            if (CheckInputs(txtGenerateNumbersBetween_Input, ref intVal, ref dblVal) && CheckInputs(txtNumberOfValuesToGenerate_Input, ref intVal, ref dblVal))
            {
                Calculate();

                lblIndexPosition_Output.Text = "Value at index " + tkbrValueAtIndex.Value.ToString() + ":";
                lblValueAtIndex_Output.BackColor = Control.DefaultBackColor;
                lblValueAtIndex_Output.Location = new Point(368, 232);
                lblValueAtIndex_Output.Text = randomValuesGenerated[tkbrValueAtIndex.Value].ToString();

                readyToDisplayIndex = true;
                OtherStats();
            }
            else
            {
                MessageBox.Show("Something broke.");
            }
            
        }

        private void btnOtherStats_Click(object sender, EventArgs e)
        {
            CreateStatsTableForm();
        }

        private void btnSaveResults_Click(object sender, EventArgs e)// intentionally does not display the overall data with this button click.
        {
            SaveResults();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSeedNumber_Input_Leave(object sender, EventArgs e)
        {
            if (CheckInputs(txtSeedNumber_Input, ref intVal, ref dblVal) == false)
            {
                txtSeedNumber_Input.Text = "";
            }
        }

        private void txtSeedNumber_Input_Enter(object sender, EventArgs e) // intentionally did not use swap on these, swap had issues letting user reset this to not using a seed value (short of resetting entire form)
        {
            txtSeedNumber_Input.Text = "";
        }

        private void txtNumberOfValuesToGenerate_Input_Enter(object sender, EventArgs e)
        {
            Swap(txtNumberOfValuesToGenerate_Input, out temporaryHolder);
        }

        private void txtNumberOfValuesToGenerate_Input_Leave(object sender, EventArgs e)
        {
            CheckInputs(txtNumberOfValuesToGenerate_Input, ref intVal, ref dblVal);
            if (txtNumberOfValuesToGenerate_Input.Text == "")
            {
                Swap(txtNumberOfValuesToGenerate_Input, ref temporaryHolder);
            }
        }

        private void txtGenerateNumbersBetween_Input_Enter(object sender, EventArgs e)
        {
            Swap(txtGenerateNumbersBetween_Input, out temporaryHolder);
        }

        private void txtGenerateNumbersBetween_Input_Leave(object sender, EventArgs e)
        {
            CheckInputs(txtGenerateNumbersBetween_Input, ref intVal, ref dblVal);
            if (txtGenerateNumbersBetween_Input.Text == "")
            {
                Swap(txtGenerateNumbersBetween_Input, ref temporaryHolder);
            }
        }

        private void txtNumberOfValuesToGenerate_Input_TextChanged(object sender, EventArgs e) 
        {
            try
            {
                if (UseTrackBarTickMarks()) tkbrValueAtIndex.TickStyle = TickStyle.BottomRight;
                else tkbrValueAtIndex.TickStyle = TickStyle.None;

                tkbrValueAtIndex.Maximum = int.Parse(txtNumberOfValuesToGenerate_Input.Text) - 1;
            }
            catch
            {
                // nada
            }
            try
            {
                CheckInputs(txtNumberOfValuesToGenerate_Input, ref intVal, ref dblVal);
            }
            catch
            {
                lblError.Text = "Invalid Input Entered:  " + txtNumberOfValuesToGenerate_Input.Text + "." + Environment.NewLine + "Please enter a positive integer value.";
                lblError.Visible = true;
            }
        }

        private void tkbrValueAtIndex_Scroll(object sender, EventArgs e)
        {
            if (CheckInputs(txtGenerateNumbersBetween_Input, ref intVal, ref dblVal) && CheckInputs(txtNumberOfValuesToGenerate_Input, ref intVal, ref dblVal))
            {
                lblIndexPosition_Output.Text = "Value at index " + tkbrValueAtIndex.Value.ToString() + ":";
                lblError.Visible = false;
            }
            else
            {
                tkbrValueAtIndex.Value = 0;
                lblError.Text = "Error: You must enter valid data in the textboxes, prior to searching the index." + Environment.NewLine + "Enter positive integers in the above fields, and try again.";
                lblError.Visible = true;
            }
            if (readyToDisplayIndex)
            {
                lblValueAtIndex_Output.BackColor = Control.DefaultBackColor;
                lblValueAtIndex_Output.Location = new Point(368, 232);
                lblValueAtIndex_Output.Text = randomValuesGenerated[tkbrValueAtIndex.Value].ToString();
            }
            else if (!readyToDisplayIndex)
            {
                lblValueAtIndex_Output.Text = "Error: Must generate random numbers before\r\ndisplaying the value at the specified index.";
                lblValueAtIndex_Output.BackColor = Color.FromArgb(255, 192, 192);
                lblValueAtIndex_Output.Location = new Point(252, 236);
            }
        }

        private void txtGenerateNumbersBetween_Input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CheckInputs(txtGenerateNumbersBetween_Input, ref intVal, ref dblVal);
            }
            catch
            {
                lblError.Text = "Invalid Input Entered:  " + txtGenerateNumbersBetween_Input.Text + "." + Environment.NewLine + "Please enter a positive integer value.";
                lblError.Visible = true;
            }
            readyToDisplayIndex = false;
        }

        private void txtSeedNumber_Input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CheckInputs(txtSeedNumber_Input, ref intVal, ref dblVal);
            }
            catch
            {
                lblError.Text = "Invalid Input Entered:  " + txtSeedNumber_Input.Text + "." + Environment.NewLine + "Please enter a positive integer value.";
                lblError.Visible = true;
            }
            readyToDisplayIndex = false;
        }
    }
}
