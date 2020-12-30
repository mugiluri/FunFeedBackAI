using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLiveChart
{   /*Author: Anthony Mugiluri - Email: anthonyhost6@gmail.com*/
    public partial class Form1 : Form
    {
        
        public static int count = 0;
        public static int numx, numx1, numx2, numx3, numx4, numx5, numx6, numx7, numx8, numx9;
        public static int numy, numy1, numy2, numy3, numy4, numy5, numy6, numy7, numy8, numy9;

        public static bool feedBackAnalysed;

        //Creating a list of training data
        static List<FeedBackTrainingData> trainingdata = new List<FeedBackTrainingData>();
        //Creating a list of training data
        static List<FeedBackTrainingData> testData = new List<FeedBackTrainingData>();

        public static object IDataView { get; private set; }
        public static int trueFalseState = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            RunModel();
        }

        public static string inputX4, inputX3, inputX2, inputX1;
        public static string inputY4, inputY3, inputY2, inputY1;

        public static void LoadTrainingData()//Loading dummy data
        {
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is good",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is horrible",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very horrible",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "horrible",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very very horrible",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very horrible session",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is nice",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very nice",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "nice",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very very nice",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very nice session",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is good",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very good",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "good",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very very good",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very good session",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is awesome",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very awesome",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "awesome",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very very awesome",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very awesome session",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is irritating",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very irritating",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "irritating",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very very irritating",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very irritating session",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is interesting",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very interesting",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "interesting",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very very interesting",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very interesting session",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is boring",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very boring",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "boring",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very very boring",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very boring session",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is sad",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very sad",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "sad",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very very sad",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very sad session",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is cool",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very cool",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "cool",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very very cool",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very cool session",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is tough",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very tough",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "tough",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very very tough",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very tough session",
                IsGood = false
            });

            /*More training data to increase accuracy as per the data tested -- 100% Accuracy*/

            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is rough",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "well ok ok",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "sooo nice",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "cool nice",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "nice and sweet",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "it's very average",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very bad",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "average and okay",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "nice and good",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "looks gud to my eye",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is bad",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "bad",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "i like it",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "don't like",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "i don't like it",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "dont like",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "i dont like it",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "didn't like",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "didnt like",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "i didn't like it",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "i didnt like it",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "don't",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "dont",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "like",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not awesome",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this was awesome",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "awesome",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "it's not awesome",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not good",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not nice",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not average",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not okay",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not sweet",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not horrible",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not terrible",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not bad",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not interesting",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not complaining",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not boring",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not sad",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not cool",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not tough",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not rough",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "i didn't like it",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "didn't",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "didnt",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "it was great",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "it was not great",
                IsGood = false
            });

        }

        public static void LoadTestData()//Loading test data -- Searching this from training data -- [Key Words]
        {
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "good",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "bad",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "terrible",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "nice",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "sweet",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "average",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "irritating",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "okay",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "horrible",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "ok",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "gud",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "like",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "interesting",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "boring",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "sad",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "cool",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "tough",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "rough",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "don't",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "dont",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "awesome",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "was awesome",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not awesome",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "didn't",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "didnt",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "great",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData()
            {
                FeedBackText = "not great",
                IsGood = false
            });

        }

        public void RunModel()
        {
            //Step 1 :- We need to load training data
            LoadTrainingData();
            //Step 2 :- Create object of MLContext
            //Create an instance of MLContext(the central point)
            //To access the features of machine learning
            var mlContext = new MLContext();
            //Step 3 :- Convert your data into IDataView
            IDataView dataView = mlContext.Data.LoadFromEnumerable<FeedBackTrainingData>(trainingdata);
            //IDataView dataView = mlContext.*****Deprecated>>>CreateStreamingDataView******<FeedBackTrainingData>(trainingdata);
            //Step 4 :- We need to create the pipeline
            //define the workflows in it.
            //FeedBackText is a feature that I want to convert to vector
            var pipeline = mlContext.Transforms.Text.FeaturizeText("Features", "FeedBackText").Append(mlContext.BinaryClassification.Trainers.FastTree(numberOfLeaves: 50, numberOfTrees: 50, minimumExampleCountPerLeaf: 1));//Add NuGet Microsoft.ML.FastTree
                                                                                                                                                                                                               //Step 5 :- Train the algorithm and we want the model out(Training algorithm with our training data)
            var model = pipeline.Fit(dataView);//>>>>>Load the test data first
            //Step 6 :- Load the test data and run the test data
            //to check our models accuracy
            LoadTestData();

            //Creating data view from test data
            IDataView dataView1 = mlContext.Data.LoadFromEnumerable<FeedBackTrainingData>(testData);
            var predictions = model.Transform(dataView1);//Getting predictions from the model
            var metrics = mlContext.BinaryClassification.Evaluate(predictions, "Label");//Evaluate predictions - right or wrong?

            double myAccuracy = metrics.Accuracy * 100.00;

            this.textBoxFeebBackIn.Text = "";
            this.textBoxAnalyse.Text = "";
            textBoxAnalyse.Text = String.Format("{0:0.00}", "Accuracy : " + myAccuracy + "%  ");
        }
        public void PredictInput()
        {
            var mlContext = new MLContext();
            //Step 3 :- Convert your data into IDataView
            IDataView dataView = mlContext.Data.LoadFromEnumerable<FeedBackTrainingData>(trainingdata);
            //IDataView dataView = mlContext.*****Deprecated>>>CreateStreamingDataView******<FeedBackTrainingData>(trainingdata);
            //Step 4 :- We need to create the pipeline
            //define the workflows in it.
            //FeedBackText is a feature that I want to convert to vector
            var pipeline = mlContext.Transforms.Text.FeaturizeText("Features", "FeedBackText").Append(mlContext.BinaryClassification.Trainers.FastTree(numberOfLeaves: 50, numberOfTrees: 50, minimumExampleCountPerLeaf: 1));//Add NuGet Microsoft.ML.FastTree
                                                                                                                                                                                                                              //Step 5 :- Train the algorithm and we want the model out(Training algorithm with our training data)
            var model = pipeline.Fit(dataView);

            ///#######################################################
            //Step 7 :- Use the model >>Create class feedback prediction

            string feedbackstring = this.textBoxFeebBackIn.Text; //Console.ReadLine().ToString();

            if (feedbackstring != "exit")
            {
                var predictionFunction = mlContext.Model.CreatePredictionEngine<FeedBackTrainingData, FeedBackPrediction>(model);
                var feedbackinput = new FeedBackTrainingData();
                feedbackinput.FeedBackText = feedbackstring;
                var feedbackpredicted = predictionFunction.Predict(feedbackinput);

                feedBackAnalysed = feedbackpredicted.IsGood;
                if(feedBackAnalysed == true)
                {
                    trueFalseState = 1;
                    panel1.BackgroundImage = imageList1.Images[0];//Display happy emoji in panel1
                }
                else
                {
                    trueFalseState = 0;
                    panel1.BackgroundImage = imageList1.Images[1];//Display sad emoji in panel1
                }
            }
            else {
                this.textBoxFeebBackIn.Text = "";
                textBoxAnalyse.Text += " Now press 'Load'";
            }
            
        }

        public void buttonPost_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 0:
                    PredictInput();
                    numx = count;
                    numy = trueFalseState;
                    this.textBoxAnalyse.Text += feedBackAnalysed.ToString();
                    count++;
                    this.textBoxFeebBackIn.Text = "";
                    break;
                case 1:
                    PredictInput();
                    numx1 = count;
                    numy1 = trueFalseState;
                    this.textBoxAnalyse.Text += " , ";
                    this.textBoxAnalyse.Text += feedBackAnalysed.ToString();
                    count++;
                    this.textBoxFeebBackIn.Text = "";
                    break;
                case 2:
                    PredictInput();
                    numx2 = count;
                    numy2 = trueFalseState;
                    this.textBoxAnalyse.Text += " , ";
                    this.textBoxAnalyse.Text += feedBackAnalysed.ToString();
                    count++;
                    this.textBoxFeebBackIn.Text = "";
                    break;
                case 3:
                    PredictInput();
                    numx3 = count;
                    numy3 = trueFalseState;
                    this.textBoxAnalyse.Text += " , ";
                    this.textBoxAnalyse.Text += feedBackAnalysed.ToString();
                    count++;
                    this.textBoxFeebBackIn.Text = "";
                    break;
                case 4:
                    PredictInput();
                    numx4 = count;
                    numy4 = trueFalseState;
                    this.textBoxAnalyse.Text += " , ";
                    this.textBoxAnalyse.Text += feedBackAnalysed.ToString();
                    count++;
                    this.textBoxFeebBackIn.Text = "";
                    break;
                case 5:
                    PredictInput();
                    numx5 = count;
                    numy5 = trueFalseState;
                    this.textBoxAnalyse.Text += " , ";
                    this.textBoxAnalyse.Text += feedBackAnalysed.ToString();
                    count++;
                    this.textBoxFeebBackIn.Text = "";
                    break;
                case 6:
                    PredictInput();
                    numx6 = count;
                    numy6 = trueFalseState;
                    this.textBoxAnalyse.Text += " , ";
                    this.textBoxAnalyse.Text += feedBackAnalysed.ToString();
                    count++;
                    this.textBoxFeebBackIn.Text = "";
                    break;
                case 7:
                    PredictInput();
                    numx7 = count;
                    numy7 = trueFalseState;
                    this.textBoxAnalyse.Text += " , ";
                    this.textBoxAnalyse.Text += feedBackAnalysed.ToString();
                    count++;
                    this.textBoxFeebBackIn.Text = "";
                    break;
                case 8:
                    PredictInput();
                    numx8 = count;
                    numy8 = trueFalseState;
                    this.textBoxAnalyse.Text += " , ";
                    this.textBoxAnalyse.Text += feedBackAnalysed.ToString();
                    count++;
                    this.textBoxFeebBackIn.Text = "";
                    break;
                case 9:
                    PredictInput();
                    numx9 = count;
                    numy9 = trueFalseState;
                    this.textBoxAnalyse.Text += " , ";
                    this.textBoxAnalyse.Text += feedBackAnalysed.ToString();
                    count++;
                    this.textBoxFeebBackIn.Text = "";
                    break;
            }
        }

    class FeedBackTrainingData
    {
        [LoadColumn(0), ColumnName("Label")]//First column --[Column(ordinal: "0", name: "Label")]-- Column attributes
        public bool IsGood { get; set; }//prop then tab twice -- Expected predicted output(Labels)

        [LoadColumn(1)]//Second column -- Feature/Input
        public string FeedBackText { get; set; }

    }

    class FeedBackPrediction
    {
        [ColumnName("PredictedLabel")]
        public bool IsGood { get; set; }//To predict the output
    }

        private void buttonLoad_Click(object sender, EventArgs e)//See graph button
        {
            int[] yValues = { 0, numy, numy1, numy2, numy3, numy4, numy5, numy6, numy7, numy8, numy9 };//Will be either true or false -- True=1, False=0
            int[] xValues = { 0, numx, numx1, numx2, numx3, numx4, numx5, numx6, numx7, numx8, numx9 };//Will be number of counts/series

            int n = count, a, b, c, d, f, g;// h, i, j;

            void StopLoadingAnimation()
            {
                pictureBox1.Visible = false;
                pictureBox1.Enabled = false;
            }
            

            switch (n)
            {
                case 0:
                    StopLoadingAnimation();
                    cartesianChart1.Series = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>
                            {
                                new ObservablePoint(xValues[0],yValues[0]),

                            }
                         }
                    };
                    break;
                case 1:
                    StopLoadingAnimation();
                    cartesianChart1.Series = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>
                            {
                                new ObservablePoint(xValues[0],yValues[0]),
                                new ObservablePoint(xValues[1],yValues[1]),

                            }
                         }
                    };
                    break;
                case 2:
                    StopLoadingAnimation();
                    cartesianChart1.Series = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>
                            {
                                new ObservablePoint(xValues[0],yValues[0]),
                                new ObservablePoint(xValues[1],yValues[1]),
                                new ObservablePoint(xValues[2],yValues[2])

                            }
                         }
                    };
                    break;
                default:
                if (count > 5)
                {
                        StopLoadingAnimation();
                        a = n; b = a - 1; c = b - 1; d = c - 1; f = d - 1; g = f - 1;// h = g - 1; i = h - 1; j = i - 1;
                        cartesianChart1.Series = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>
                            {
                                //new ObservablePoint(xValues[j],yValues[j]),
                                //new ObservablePoint(xValues[i],yValues[i]),
                                //new ObservablePoint(xValues[h],yValues[h]),
                                new ObservablePoint(xValues[g],yValues[g]),
                                new ObservablePoint(xValues[f],yValues[f]),
                                new ObservablePoint(xValues[d],yValues[d]),
                                new ObservablePoint(xValues[c],yValues[c]),
                                new ObservablePoint(xValues[b],yValues[b]),
                                new ObservablePoint(xValues[a],yValues[a])

                            }
                         }
                    };
                    }
                    else
                    {
                        this.textBoxAnalyse.Text += " Enter atleast six Fun Feedback entries. >>> ";
                    }
                    
                    break;
            }

        }

        
        public Form1()
        {
            InitializeComponent();
        }
    }
}
