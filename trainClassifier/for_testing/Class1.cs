/*
* MATLAB Compiler: 6.4 (R2017a)
* Date: Mon Apr 15 21:49:10 2019
* Arguments:
* "-B""macro_default""-W""dotnet:trainClassifier,Class1,4.0,private""-T""link:lib""-d""D:\
* Ð¡ºÚÎÝ\matlabÐ¡ºÚÎÝ\graduation
* project\trainClassifier\for_testing""-v""class{Class1:D:\Ð¡ºÚÎÝ\matlabÐ¡ºÚÎÝ\graduation
* project\trainClassifier.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace trainClassifier
{

  /// <summary>
  /// The Class1 class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// D:\Ð¡ºÚÎÝ\matlabÐ¡ºÚÎÝ\graduation project\trainClassifier.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class Class1 : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static Class1()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "trainClassifier.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Class1 class.
    /// </summary>
    public Class1()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Class1()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the trainClassifier MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [trainedClassifier, validationAccuracy] = trainClassifier(trainingData)
    /// returns a trained classifier and its accuracy. This code recreates the
    /// classification model trained in Classification Learner app. Use the
    /// generated code to automate training the same model with new data, or to
    /// learn how to programmatically train models.
    /// Input:
    /// trainingData: a matrix with the same number of columns and data type
    /// as imported into the app.
    /// Output:
    /// trainedClassifier: a struct containing the trained classifier. The
    /// struct contains various fields with information about the trained
    /// classifier.
    /// trainedClassifier.predictFcn: a function to make predictions on new
    /// data.
    /// validationAccuracy: a double containing the accuracy in percent. In
    /// the app, the History list displays this overall accuracy score for
    /// each model.
    /// Use the code to train the model with new data. To retrain your
    /// classifier, call the function from the command line with your original
    /// data or new data as the input argument trainingData.
    /// For example, to retrain a classifier trained with the original data set
    /// T, enter:
    /// [trainedClassifier, validationAccuracy] = trainClassifier(T)
    /// To make predictions with the returned 'trainedClassifier' on new data T2,
    /// use
    /// yfit = trainedClassifier.predictFcn(T2)
    /// T2 must be a matrix containing only the predictor columns used for
    /// training. For details, enter:
    /// trainedClassifier.HowToPredict
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray trainClassifier()
    {
      return mcr.EvaluateFunction("trainClassifier", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the trainClassifier MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [trainedClassifier, validationAccuracy] = trainClassifier(trainingData)
    /// returns a trained classifier and its accuracy. This code recreates the
    /// classification model trained in Classification Learner app. Use the
    /// generated code to automate training the same model with new data, or to
    /// learn how to programmatically train models.
    /// Input:
    /// trainingData: a matrix with the same number of columns and data type
    /// as imported into the app.
    /// Output:
    /// trainedClassifier: a struct containing the trained classifier. The
    /// struct contains various fields with information about the trained
    /// classifier.
    /// trainedClassifier.predictFcn: a function to make predictions on new
    /// data.
    /// validationAccuracy: a double containing the accuracy in percent. In
    /// the app, the History list displays this overall accuracy score for
    /// each model.
    /// Use the code to train the model with new data. To retrain your
    /// classifier, call the function from the command line with your original
    /// data or new data as the input argument trainingData.
    /// For example, to retrain a classifier trained with the original data set
    /// T, enter:
    /// [trainedClassifier, validationAccuracy] = trainClassifier(T)
    /// To make predictions with the returned 'trainedClassifier' on new data T2,
    /// use
    /// yfit = trainedClassifier.predictFcn(T2)
    /// T2 must be a matrix containing only the predictor columns used for
    /// training. For details, enter:
    /// trainedClassifier.HowToPredict
    /// </remarks>
    /// <param name="trainingData">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray trainClassifier(MWArray trainingData)
    {
      return mcr.EvaluateFunction("trainClassifier", trainingData);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the trainClassifier MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [trainedClassifier, validationAccuracy] = trainClassifier(trainingData)
    /// returns a trained classifier and its accuracy. This code recreates the
    /// classification model trained in Classification Learner app. Use the
    /// generated code to automate training the same model with new data, or to
    /// learn how to programmatically train models.
    /// Input:
    /// trainingData: a matrix with the same number of columns and data type
    /// as imported into the app.
    /// Output:
    /// trainedClassifier: a struct containing the trained classifier. The
    /// struct contains various fields with information about the trained
    /// classifier.
    /// trainedClassifier.predictFcn: a function to make predictions on new
    /// data.
    /// validationAccuracy: a double containing the accuracy in percent. In
    /// the app, the History list displays this overall accuracy score for
    /// each model.
    /// Use the code to train the model with new data. To retrain your
    /// classifier, call the function from the command line with your original
    /// data or new data as the input argument trainingData.
    /// For example, to retrain a classifier trained with the original data set
    /// T, enter:
    /// [trainedClassifier, validationAccuracy] = trainClassifier(T)
    /// To make predictions with the returned 'trainedClassifier' on new data T2,
    /// use
    /// yfit = trainedClassifier.predictFcn(T2)
    /// T2 must be a matrix containing only the predictor columns used for
    /// training. For details, enter:
    /// trainedClassifier.HowToPredict
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] trainClassifier(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "trainClassifier", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the trainClassifier MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [trainedClassifier, validationAccuracy] = trainClassifier(trainingData)
    /// returns a trained classifier and its accuracy. This code recreates the
    /// classification model trained in Classification Learner app. Use the
    /// generated code to automate training the same model with new data, or to
    /// learn how to programmatically train models.
    /// Input:
    /// trainingData: a matrix with the same number of columns and data type
    /// as imported into the app.
    /// Output:
    /// trainedClassifier: a struct containing the trained classifier. The
    /// struct contains various fields with information about the trained
    /// classifier.
    /// trainedClassifier.predictFcn: a function to make predictions on new
    /// data.
    /// validationAccuracy: a double containing the accuracy in percent. In
    /// the app, the History list displays this overall accuracy score for
    /// each model.
    /// Use the code to train the model with new data. To retrain your
    /// classifier, call the function from the command line with your original
    /// data or new data as the input argument trainingData.
    /// For example, to retrain a classifier trained with the original data set
    /// T, enter:
    /// [trainedClassifier, validationAccuracy] = trainClassifier(T)
    /// To make predictions with the returned 'trainedClassifier' on new data T2,
    /// use
    /// yfit = trainedClassifier.predictFcn(T2)
    /// T2 must be a matrix containing only the predictor columns used for
    /// training. For details, enter:
    /// trainedClassifier.HowToPredict
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="trainingData">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] trainClassifier(int numArgsOut, MWArray trainingData)
    {
      return mcr.EvaluateFunction(numArgsOut, "trainClassifier", trainingData);
    }


    /// <summary>
    /// Provides an interface for the trainClassifier function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// [trainedClassifier, validationAccuracy] = trainClassifier(trainingData)
    /// returns a trained classifier and its accuracy. This code recreates the
    /// classification model trained in Classification Learner app. Use the
    /// generated code to automate training the same model with new data, or to
    /// learn how to programmatically train models.
    /// Input:
    /// trainingData: a matrix with the same number of columns and data type
    /// as imported into the app.
    /// Output:
    /// trainedClassifier: a struct containing the trained classifier. The
    /// struct contains various fields with information about the trained
    /// classifier.
    /// trainedClassifier.predictFcn: a function to make predictions on new
    /// data.
    /// validationAccuracy: a double containing the accuracy in percent. In
    /// the app, the History list displays this overall accuracy score for
    /// each model.
    /// Use the code to train the model with new data. To retrain your
    /// classifier, call the function from the command line with your original
    /// data or new data as the input argument trainingData.
    /// For example, to retrain a classifier trained with the original data set
    /// T, enter:
    /// [trainedClassifier, validationAccuracy] = trainClassifier(T)
    /// To make predictions with the returned 'trainedClassifier' on new data T2,
    /// use
    /// yfit = trainedClassifier.predictFcn(T2)
    /// T2 must be a matrix containing only the predictor columns used for
    /// training. For details, enter:
    /// trainedClassifier.HowToPredict
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void trainClassifier(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("trainClassifier", numArgsOut, ref argsOut, argsIn);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
