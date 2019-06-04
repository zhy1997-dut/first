/*
* MATLAB Compiler: 6.4 (R2017a)
* Date: Tue Apr 16 19:09:33 2019
* Arguments:
* "-B""macro_default""-W""dotnet:createResult,classifier,4.0,private""-T""link:lib""-d""D:
* \Ð¡ºÚÎÝ\matlabÐ¡ºÚÎÝ\graduation
* project\createResult\for_testing""-v""class{classifier:D:\Ð¡ºÚÎÝ\matlabÐ¡ºÚÎÝ\graduation
* project\createResult.m,D:\Ð¡ºÚÎÝ\matlabÐ¡ºÚÎÝ\graduation project\trainClassifier.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace createResultNative
{

  /// <summary>
  /// The classifier class provides a CLS compliant, Object (native) interface to the
  /// MATLAB functions contained in the files:
  /// <newpara></newpara>
  /// D:\Ð¡ºÚÎÝ\matlabÐ¡ºÚÎÝ\graduation project\createResult.m
  /// <newpara></newpara>
  /// D:\Ð¡ºÚÎÝ\matlabÐ¡ºÚÎÝ\graduation project\trainClassifier.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class classifier : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static classifier()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "createResult.ctf";

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
    /// Constructs a new instance of the classifier class.
    /// </summary>
    public classifier()
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
    ~classifier()
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
    /// Provides a single output, 0-input Objectinterface to the createResult MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object createResult()
    {
      return mcr.EvaluateFunction("createResult", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the createResult MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="classifier">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object createResult(Object classifier)
    {
      return mcr.EvaluateFunction("createResult", classifier);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the createResult MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="classifier">Input argument #1</param>
    /// <param name="input">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object createResult(Object classifier, Object input)
    {
      return mcr.EvaluateFunction("createResult", classifier, input);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the createResult MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createResult(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "createResult", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the createResult MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="classifier">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createResult(int numArgsOut, Object classifier)
    {
      return mcr.EvaluateFunction(numArgsOut, "createResult", classifier);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the createResult MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="classifier">Input argument #1</param>
    /// <param name="input">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createResult(int numArgsOut, Object classifier, Object input)
    {
      return mcr.EvaluateFunction(numArgsOut, "createResult", classifier, input);
    }


    /// <summary>
    /// Provides an interface for the createResult function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("createResult", 2, 1, 0)]
    protected void createResult(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("createResult", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the trainClassifier MATLAB
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object trainClassifier()
    {
      return mcr.EvaluateFunction("trainClassifier", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the trainClassifier MATLAB
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object trainClassifier(Object trainingData)
    {
      return mcr.EvaluateFunction("trainClassifier", trainingData);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the trainClassifier MATLAB
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
    public Object[] trainClassifier(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "trainClassifier", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the trainClassifier MATLAB
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
    public Object[] trainClassifier(int numArgsOut, Object trainingData)
    {
      return mcr.EvaluateFunction(numArgsOut, "trainClassifier", trainingData);
    }


    /// <summary>
    /// Provides an interface for the trainClassifier function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
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
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("trainClassifier", 1, 2, 0)]
    protected void trainClassifier(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("trainClassifier", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
