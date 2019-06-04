/*
* MATLAB Compiler: 6.4 (R2017a)
* Date: Wed May 29 16:33:52 2019
* Arguments:
* "-B""macro_default""-W""dotnet:MATLib,MATLib,4.0,private""-T""link:lib""-d""D:\小黑屋\ma
* tlab小黑屋\graduation
* project\MATLib\for_testing""-v""class{MATLib:D:\小黑屋\matlab小黑屋\graduation
* project\dtw.m,D:\小黑屋\matlab小黑屋\graduation
* project\ensemble.m,D:\小黑屋\matlab小黑屋\graduation
* project\KNN.m,D:\小黑屋\matlab小黑屋\graduation
* project\KNN_only.m,D:\小黑屋\matlab小黑屋\graduation project\Use_C4_5.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace MATLibNative
{

  /// <summary>
  /// The MATLib class provides a CLS compliant, Object (native) interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// D:\小黑屋\matlab小黑屋\graduation project\dtw.m
  /// <newpara></newpara>
  /// D:\小黑屋\matlab小黑屋\graduation project\ensemble.m
  /// <newpara></newpara>
  /// D:\小黑屋\matlab小黑屋\graduation project\KNN.m
  /// <newpara></newpara>
  /// D:\小黑屋\matlab小黑屋\graduation project\KNN_only.m
  /// <newpara></newpara>
  /// D:\小黑屋\matlab小黑屋\graduation project\Use_C4_5.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class MATLib : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static MATLib()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "MATLib.ctf";

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
    /// Constructs a new instance of the MATLib class.
    /// </summary>
    public MATLib()
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
    ~MATLib()
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
    /// Provides a single output, 0-input Objectinterface to the dtw MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [Dist,D,k,w,rw,tw]=dtw(r,t,pflag)
    /// Dynamic Time Warping Algorithm
    /// Dist is unnormalized distance between t and r
    /// D is the accumulated distance matrix
    /// k is the normalizing factor
    /// w is the optimal path
    /// t is the vector you are testing against
    /// r is the vector you are testing
    /// rw is the warped r vector
    /// tw is the warped t vector
    /// pflag  plot flag: 1 (yes), 0(no)
    /// Version comments:
    /// rw, tw and pflag added by Pau Mic
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object dtw()
    {
      return mcr.EvaluateFunction("dtw", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the dtw MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [Dist,D,k,w,rw,tw]=dtw(r,t,pflag)
    /// Dynamic Time Warping Algorithm
    /// Dist is unnormalized distance between t and r
    /// D is the accumulated distance matrix
    /// k is the normalizing factor
    /// w is the optimal path
    /// t is the vector you are testing against
    /// r is the vector you are testing
    /// rw is the warped r vector
    /// tw is the warped t vector
    /// pflag  plot flag: 1 (yes), 0(no)
    /// Version comments:
    /// rw, tw and pflag added by Pau Mic
    /// </remarks>
    /// <param name="r">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object dtw(Object r)
    {
      return mcr.EvaluateFunction("dtw", r);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the dtw MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [Dist,D,k,w,rw,tw]=dtw(r,t,pflag)
    /// Dynamic Time Warping Algorithm
    /// Dist is unnormalized distance between t and r
    /// D is the accumulated distance matrix
    /// k is the normalizing factor
    /// w is the optimal path
    /// t is the vector you are testing against
    /// r is the vector you are testing
    /// rw is the warped r vector
    /// tw is the warped t vector
    /// pflag  plot flag: 1 (yes), 0(no)
    /// Version comments:
    /// rw, tw and pflag added by Pau Mic
    /// </remarks>
    /// <param name="r">Input argument #1</param>
    /// <param name="t">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object dtw(Object r, Object t)
    {
      return mcr.EvaluateFunction("dtw", r, t);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the dtw MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [Dist,D,k,w,rw,tw]=dtw(r,t,pflag)
    /// Dynamic Time Warping Algorithm
    /// Dist is unnormalized distance between t and r
    /// D is the accumulated distance matrix
    /// k is the normalizing factor
    /// w is the optimal path
    /// t is the vector you are testing against
    /// r is the vector you are testing
    /// rw is the warped r vector
    /// tw is the warped t vector
    /// pflag  plot flag: 1 (yes), 0(no)
    /// Version comments:
    /// rw, tw and pflag added by Pau Mic
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] dtw(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "dtw", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the dtw MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [Dist,D,k,w,rw,tw]=dtw(r,t,pflag)
    /// Dynamic Time Warping Algorithm
    /// Dist is unnormalized distance between t and r
    /// D is the accumulated distance matrix
    /// k is the normalizing factor
    /// w is the optimal path
    /// t is the vector you are testing against
    /// r is the vector you are testing
    /// rw is the warped r vector
    /// tw is the warped t vector
    /// pflag  plot flag: 1 (yes), 0(no)
    /// Version comments:
    /// rw, tw and pflag added by Pau Mic
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="r">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] dtw(int numArgsOut, Object r)
    {
      return mcr.EvaluateFunction(numArgsOut, "dtw", r);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the dtw MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [Dist,D,k,w,rw,tw]=dtw(r,t,pflag)
    /// Dynamic Time Warping Algorithm
    /// Dist is unnormalized distance between t and r
    /// D is the accumulated distance matrix
    /// k is the normalizing factor
    /// w is the optimal path
    /// t is the vector you are testing against
    /// r is the vector you are testing
    /// rw is the warped r vector
    /// tw is the warped t vector
    /// pflag  plot flag: 1 (yes), 0(no)
    /// Version comments:
    /// rw, tw and pflag added by Pau Mic
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="r">Input argument #1</param>
    /// <param name="t">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] dtw(int numArgsOut, Object r, Object t)
    {
      return mcr.EvaluateFunction(numArgsOut, "dtw", r, t);
    }


    /// <summary>
    /// Provides an interface for the dtw function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// [Dist,D,k,w,rw,tw]=dtw(r,t,pflag)
    /// Dynamic Time Warping Algorithm
    /// Dist is unnormalized distance between t and r
    /// D is the accumulated distance matrix
    /// k is the normalizing factor
    /// w is the optimal path
    /// t is the vector you are testing against
    /// r is the vector you are testing
    /// rw is the warped r vector
    /// tw is the warped t vector
    /// pflag  plot flag: 1 (yes), 0(no)
    /// Version comments:
    /// rw, tw and pflag added by Pau Mic
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("dtw", 2, 1, 0)]
    protected void dtw(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("dtw", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the ensemble MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ensemble()
    {
      return mcr.EvaluateFunction("ensemble", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the ensemble MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="y_c">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ensemble(Object y_c)
    {
      return mcr.EvaluateFunction("ensemble", y_c);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the ensemble MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="y_c">Input argument #1</param>
    /// <param name="y_cPAA">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ensemble(Object y_c, Object y_cPAA)
    {
      return mcr.EvaluateFunction("ensemble", y_c, y_cPAA);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the ensemble MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="y_c">Input argument #1</param>
    /// <param name="y_cPAA">Input argument #2</param>
    /// <param name="y_t">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ensemble(Object y_c, Object y_cPAA, Object y_t)
    {
      return mcr.EvaluateFunction("ensemble", y_c, y_cPAA, y_t);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the ensemble MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="y_c">Input argument #1</param>
    /// <param name="y_cPAA">Input argument #2</param>
    /// <param name="y_t">Input argument #3</param>
    /// <param name="sign">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ensemble(Object y_c, Object y_cPAA, Object y_t, Object sign)
    {
      return mcr.EvaluateFunction("ensemble", y_c, y_cPAA, y_t, sign);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the ensemble MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="y_c">Input argument #1</param>
    /// <param name="y_cPAA">Input argument #2</param>
    /// <param name="y_t">Input argument #3</param>
    /// <param name="sign">Input argument #4</param>
    /// <param name="test_Max">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ensemble(Object y_c, Object y_cPAA, Object y_t, Object sign, Object 
                     test_Max)
    {
      return mcr.EvaluateFunction("ensemble", y_c, y_cPAA, y_t, sign, test_Max);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the ensemble MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="y_c">Input argument #1</param>
    /// <param name="y_cPAA">Input argument #2</param>
    /// <param name="y_t">Input argument #3</param>
    /// <param name="sign">Input argument #4</param>
    /// <param name="test_Max">Input argument #5</param>
    /// <param name="test_Min">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ensemble(Object y_c, Object y_cPAA, Object y_t, Object sign, Object 
                     test_Max, Object test_Min)
    {
      return mcr.EvaluateFunction("ensemble", y_c, y_cPAA, y_t, sign, test_Max, test_Min);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the ensemble MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] ensemble(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "ensemble", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the ensemble MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="y_c">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] ensemble(int numArgsOut, Object y_c)
    {
      return mcr.EvaluateFunction(numArgsOut, "ensemble", y_c);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the ensemble MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="y_c">Input argument #1</param>
    /// <param name="y_cPAA">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] ensemble(int numArgsOut, Object y_c, Object y_cPAA)
    {
      return mcr.EvaluateFunction(numArgsOut, "ensemble", y_c, y_cPAA);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the ensemble MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="y_c">Input argument #1</param>
    /// <param name="y_cPAA">Input argument #2</param>
    /// <param name="y_t">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] ensemble(int numArgsOut, Object y_c, Object y_cPAA, Object y_t)
    {
      return mcr.EvaluateFunction(numArgsOut, "ensemble", y_c, y_cPAA, y_t);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the ensemble MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="y_c">Input argument #1</param>
    /// <param name="y_cPAA">Input argument #2</param>
    /// <param name="y_t">Input argument #3</param>
    /// <param name="sign">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] ensemble(int numArgsOut, Object y_c, Object y_cPAA, Object y_t, 
                       Object sign)
    {
      return mcr.EvaluateFunction(numArgsOut, "ensemble", y_c, y_cPAA, y_t, sign);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the ensemble MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="y_c">Input argument #1</param>
    /// <param name="y_cPAA">Input argument #2</param>
    /// <param name="y_t">Input argument #3</param>
    /// <param name="sign">Input argument #4</param>
    /// <param name="test_Max">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] ensemble(int numArgsOut, Object y_c, Object y_cPAA, Object y_t, 
                       Object sign, Object test_Max)
    {
      return mcr.EvaluateFunction(numArgsOut, "ensemble", y_c, y_cPAA, y_t, sign, test_Max);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the ensemble MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="y_c">Input argument #1</param>
    /// <param name="y_cPAA">Input argument #2</param>
    /// <param name="y_t">Input argument #3</param>
    /// <param name="sign">Input argument #4</param>
    /// <param name="test_Max">Input argument #5</param>
    /// <param name="test_Min">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] ensemble(int numArgsOut, Object y_c, Object y_cPAA, Object y_t, 
                       Object sign, Object test_Max, Object test_Min)
    {
      return mcr.EvaluateFunction(numArgsOut, "ensemble", y_c, y_cPAA, y_t, sign, test_Max, test_Min);
    }


    /// <summary>
    /// Provides an interface for the ensemble function in which the input and output
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
    [MATLABSignature("ensemble", 6, 4, 0)]
    protected void ensemble(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("ensemble", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the KNN MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object KNN()
    {
      return mcr.EvaluateFunction("KNN", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the KNN MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="inx">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object KNN(Object inx)
    {
      return mcr.EvaluateFunction("KNN", inx);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the KNN MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="inx">Input argument #1</param>
    /// <param name="data">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object KNN(Object inx, Object data)
    {
      return mcr.EvaluateFunction("KNN", inx, data);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the KNN MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="inx">Input argument #1</param>
    /// <param name="data">Input argument #2</param>
    /// <param name="labels">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object KNN(Object inx, Object data, Object labels)
    {
      return mcr.EvaluateFunction("KNN", inx, data, labels);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the KNN MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="inx">Input argument #1</param>
    /// <param name="data">Input argument #2</param>
    /// <param name="labels">Input argument #3</param>
    /// <param name="k">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object KNN(Object inx, Object data, Object labels, Object k)
    {
      return mcr.EvaluateFunction("KNN", inx, data, labels, k);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the KNN MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] KNN(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "KNN", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the KNN MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="inx">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] KNN(int numArgsOut, Object inx)
    {
      return mcr.EvaluateFunction(numArgsOut, "KNN", inx);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the KNN MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="inx">Input argument #1</param>
    /// <param name="data">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] KNN(int numArgsOut, Object inx, Object data)
    {
      return mcr.EvaluateFunction(numArgsOut, "KNN", inx, data);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the KNN MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="inx">Input argument #1</param>
    /// <param name="data">Input argument #2</param>
    /// <param name="labels">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] KNN(int numArgsOut, Object inx, Object data, Object labels)
    {
      return mcr.EvaluateFunction(numArgsOut, "KNN", inx, data, labels);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the KNN MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="inx">Input argument #1</param>
    /// <param name="data">Input argument #2</param>
    /// <param name="labels">Input argument #3</param>
    /// <param name="k">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] KNN(int numArgsOut, Object inx, Object data, Object labels, Object k)
    {
      return mcr.EvaluateFunction(numArgsOut, "KNN", inx, data, labels, k);
    }


    /// <summary>
    /// Provides an interface for the KNN function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("KNN", 4, 1, 0)]
    protected void KNN(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("KNN", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the KNN_only MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object KNN_only()
    {
      return mcr.EvaluateFunction("KNN_only", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the KNN_only MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="inx">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object KNN_only(Object inx)
    {
      return mcr.EvaluateFunction("KNN_only", inx);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the KNN_only MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="inx">Input argument #1</param>
    /// <param name="data">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object KNN_only(Object inx, Object data)
    {
      return mcr.EvaluateFunction("KNN_only", inx, data);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the KNN_only MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="inx">Input argument #1</param>
    /// <param name="data">Input argument #2</param>
    /// <param name="labels">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object KNN_only(Object inx, Object data, Object labels)
    {
      return mcr.EvaluateFunction("KNN_only", inx, data, labels);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the KNN_only MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="inx">Input argument #1</param>
    /// <param name="data">Input argument #2</param>
    /// <param name="labels">Input argument #3</param>
    /// <param name="k">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object KNN_only(Object inx, Object data, Object labels, Object k)
    {
      return mcr.EvaluateFunction("KNN_only", inx, data, labels, k);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the KNN_only MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] KNN_only(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "KNN_only", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the KNN_only MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="inx">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] KNN_only(int numArgsOut, Object inx)
    {
      return mcr.EvaluateFunction(numArgsOut, "KNN_only", inx);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the KNN_only MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="inx">Input argument #1</param>
    /// <param name="data">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] KNN_only(int numArgsOut, Object inx, Object data)
    {
      return mcr.EvaluateFunction(numArgsOut, "KNN_only", inx, data);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the KNN_only MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="inx">Input argument #1</param>
    /// <param name="data">Input argument #2</param>
    /// <param name="labels">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] KNN_only(int numArgsOut, Object inx, Object data, Object labels)
    {
      return mcr.EvaluateFunction(numArgsOut, "KNN_only", inx, data, labels);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the KNN_only MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="inx">Input argument #1</param>
    /// <param name="data">Input argument #2</param>
    /// <param name="labels">Input argument #3</param>
    /// <param name="k">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] KNN_only(int numArgsOut, Object inx, Object data, Object labels, 
                       Object k)
    {
      return mcr.EvaluateFunction(numArgsOut, "KNN_only", inx, data, labels, k);
    }


    /// <summary>
    /// Provides an interface for the KNN_only function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// inx 为 输入测试数据，data为样本数据，labels为样本标签
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("KNN_only", 4, 1, 0)]
    protected void KNN_only(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("KNN_only", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the Use_C4_5 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Classify using Quinlan's C4.5 algorithm  
    /// Inputs:  
    /// training_patterns   - Train patterns 训练样本  每一列代表一个样本
    /// 每一行代表一个特征
    /// training_targets    - Train targets  1×训练样本个数 每个训练样本对应的判别值
    /// test_patterns       - Test  patterns 测试样本，每一列代表一个样本  
    /// inc_node            - Percentage of incorrectly assigned samples at a node 
    /// 一个节点上未正确分配的样本的百分比
    /// inc_node为防止过拟合，表示样本数小于一定阈值结束递归，可设置为5-10
    /// 注意inc_node设置太大的话会导致分类准确率下降，太小的话可能会导致过拟合  
    /// Nu is to determine whether the variable is discrete or continuous (the value is
    /// always set to 10)  
    /// Nu用于确定变量是离散还是连续（该值始终设置为10）
    /// 这里用10作为一个阈值，如果某个特征的无重复的特征值的数目比这个阈值还小，就认为这个
    /// 特征是离散的
    /// Outputs  
    /// test_targets        - Predicted targets 1×测试样本个数
    /// 得到每个测试样本对应的判别值
    /// 也就是输出所有测试样本最终的判别情况
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Use_C4_5()
    {
      return mcr.EvaluateFunction("Use_C4_5", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the Use_C4_5 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Classify using Quinlan's C4.5 algorithm  
    /// Inputs:  
    /// training_patterns   - Train patterns 训练样本  每一列代表一个样本
    /// 每一行代表一个特征
    /// training_targets    - Train targets  1×训练样本个数 每个训练样本对应的判别值
    /// test_patterns       - Test  patterns 测试样本，每一列代表一个样本  
    /// inc_node            - Percentage of incorrectly assigned samples at a node 
    /// 一个节点上未正确分配的样本的百分比
    /// inc_node为防止过拟合，表示样本数小于一定阈值结束递归，可设置为5-10
    /// 注意inc_node设置太大的话会导致分类准确率下降，太小的话可能会导致过拟合  
    /// Nu is to determine whether the variable is discrete or continuous (the value is
    /// always set to 10)  
    /// Nu用于确定变量是离散还是连续（该值始终设置为10）
    /// 这里用10作为一个阈值，如果某个特征的无重复的特征值的数目比这个阈值还小，就认为这个
    /// 特征是离散的
    /// Outputs  
    /// test_targets        - Predicted targets 1×测试样本个数
    /// 得到每个测试样本对应的判别值
    /// 也就是输出所有测试样本最终的判别情况
    /// </remarks>
    /// <param name="train_patterns">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Use_C4_5(Object train_patterns)
    {
      return mcr.EvaluateFunction("Use_C4_5", train_patterns);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the Use_C4_5 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Classify using Quinlan's C4.5 algorithm  
    /// Inputs:  
    /// training_patterns   - Train patterns 训练样本  每一列代表一个样本
    /// 每一行代表一个特征
    /// training_targets    - Train targets  1×训练样本个数 每个训练样本对应的判别值
    /// test_patterns       - Test  patterns 测试样本，每一列代表一个样本  
    /// inc_node            - Percentage of incorrectly assigned samples at a node 
    /// 一个节点上未正确分配的样本的百分比
    /// inc_node为防止过拟合，表示样本数小于一定阈值结束递归，可设置为5-10
    /// 注意inc_node设置太大的话会导致分类准确率下降，太小的话可能会导致过拟合  
    /// Nu is to determine whether the variable is discrete or continuous (the value is
    /// always set to 10)  
    /// Nu用于确定变量是离散还是连续（该值始终设置为10）
    /// 这里用10作为一个阈值，如果某个特征的无重复的特征值的数目比这个阈值还小，就认为这个
    /// 特征是离散的
    /// Outputs  
    /// test_targets        - Predicted targets 1×测试样本个数
    /// 得到每个测试样本对应的判别值
    /// 也就是输出所有测试样本最终的判别情况
    /// </remarks>
    /// <param name="train_patterns">Input argument #1</param>
    /// <param name="train_targets">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Use_C4_5(Object train_patterns, Object train_targets)
    {
      return mcr.EvaluateFunction("Use_C4_5", train_patterns, train_targets);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the Use_C4_5 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Classify using Quinlan's C4.5 algorithm  
    /// Inputs:  
    /// training_patterns   - Train patterns 训练样本  每一列代表一个样本
    /// 每一行代表一个特征
    /// training_targets    - Train targets  1×训练样本个数 每个训练样本对应的判别值
    /// test_patterns       - Test  patterns 测试样本，每一列代表一个样本  
    /// inc_node            - Percentage of incorrectly assigned samples at a node 
    /// 一个节点上未正确分配的样本的百分比
    /// inc_node为防止过拟合，表示样本数小于一定阈值结束递归，可设置为5-10
    /// 注意inc_node设置太大的话会导致分类准确率下降，太小的话可能会导致过拟合  
    /// Nu is to determine whether the variable is discrete or continuous (the value is
    /// always set to 10)  
    /// Nu用于确定变量是离散还是连续（该值始终设置为10）
    /// 这里用10作为一个阈值，如果某个特征的无重复的特征值的数目比这个阈值还小，就认为这个
    /// 特征是离散的
    /// Outputs  
    /// test_targets        - Predicted targets 1×测试样本个数
    /// 得到每个测试样本对应的判别值
    /// 也就是输出所有测试样本最终的判别情况
    /// </remarks>
    /// <param name="train_patterns">Input argument #1</param>
    /// <param name="train_targets">Input argument #2</param>
    /// <param name="test_patterns">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Use_C4_5(Object train_patterns, Object train_targets, Object 
                     test_patterns)
    {
      return mcr.EvaluateFunction("Use_C4_5", train_patterns, train_targets, test_patterns);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the Use_C4_5 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Classify using Quinlan's C4.5 algorithm  
    /// Inputs:  
    /// training_patterns   - Train patterns 训练样本  每一列代表一个样本
    /// 每一行代表一个特征
    /// training_targets    - Train targets  1×训练样本个数 每个训练样本对应的判别值
    /// test_patterns       - Test  patterns 测试样本，每一列代表一个样本  
    /// inc_node            - Percentage of incorrectly assigned samples at a node 
    /// 一个节点上未正确分配的样本的百分比
    /// inc_node为防止过拟合，表示样本数小于一定阈值结束递归，可设置为5-10
    /// 注意inc_node设置太大的话会导致分类准确率下降，太小的话可能会导致过拟合  
    /// Nu is to determine whether the variable is discrete or continuous (the value is
    /// always set to 10)  
    /// Nu用于确定变量是离散还是连续（该值始终设置为10）
    /// 这里用10作为一个阈值，如果某个特征的无重复的特征值的数目比这个阈值还小，就认为这个
    /// 特征是离散的
    /// Outputs  
    /// test_targets        - Predicted targets 1×测试样本个数
    /// 得到每个测试样本对应的判别值
    /// 也就是输出所有测试样本最终的判别情况
    /// </remarks>
    /// <param name="train_patterns">Input argument #1</param>
    /// <param name="train_targets">Input argument #2</param>
    /// <param name="test_patterns">Input argument #3</param>
    /// <param name="inc_node">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Use_C4_5(Object train_patterns, Object train_targets, Object 
                     test_patterns, Object inc_node)
    {
      return mcr.EvaluateFunction("Use_C4_5", train_patterns, train_targets, test_patterns, inc_node);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the Use_C4_5 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Classify using Quinlan's C4.5 algorithm  
    /// Inputs:  
    /// training_patterns   - Train patterns 训练样本  每一列代表一个样本
    /// 每一行代表一个特征
    /// training_targets    - Train targets  1×训练样本个数 每个训练样本对应的判别值
    /// test_patterns       - Test  patterns 测试样本，每一列代表一个样本  
    /// inc_node            - Percentage of incorrectly assigned samples at a node 
    /// 一个节点上未正确分配的样本的百分比
    /// inc_node为防止过拟合，表示样本数小于一定阈值结束递归，可设置为5-10
    /// 注意inc_node设置太大的话会导致分类准确率下降，太小的话可能会导致过拟合  
    /// Nu is to determine whether the variable is discrete or continuous (the value is
    /// always set to 10)  
    /// Nu用于确定变量是离散还是连续（该值始终设置为10）
    /// 这里用10作为一个阈值，如果某个特征的无重复的特征值的数目比这个阈值还小，就认为这个
    /// 特征是离散的
    /// Outputs  
    /// test_targets        - Predicted targets 1×测试样本个数
    /// 得到每个测试样本对应的判别值
    /// 也就是输出所有测试样本最终的判别情况
    /// </remarks>
    /// <param name="train_patterns">Input argument #1</param>
    /// <param name="train_targets">Input argument #2</param>
    /// <param name="test_patterns">Input argument #3</param>
    /// <param name="inc_node">Input argument #4</param>
    /// <param name="Nu">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Use_C4_5(Object train_patterns, Object train_targets, Object 
                     test_patterns, Object inc_node, Object Nu)
    {
      return mcr.EvaluateFunction("Use_C4_5", train_patterns, train_targets, test_patterns, inc_node, Nu);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the Use_C4_5 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Classify using Quinlan's C4.5 algorithm  
    /// Inputs:  
    /// training_patterns   - Train patterns 训练样本  每一列代表一个样本
    /// 每一行代表一个特征
    /// training_targets    - Train targets  1×训练样本个数 每个训练样本对应的判别值
    /// test_patterns       - Test  patterns 测试样本，每一列代表一个样本  
    /// inc_node            - Percentage of incorrectly assigned samples at a node 
    /// 一个节点上未正确分配的样本的百分比
    /// inc_node为防止过拟合，表示样本数小于一定阈值结束递归，可设置为5-10
    /// 注意inc_node设置太大的话会导致分类准确率下降，太小的话可能会导致过拟合  
    /// Nu is to determine whether the variable is discrete or continuous (the value is
    /// always set to 10)  
    /// Nu用于确定变量是离散还是连续（该值始终设置为10）
    /// 这里用10作为一个阈值，如果某个特征的无重复的特征值的数目比这个阈值还小，就认为这个
    /// 特征是离散的
    /// Outputs  
    /// test_targets        - Predicted targets 1×测试样本个数
    /// 得到每个测试样本对应的判别值
    /// 也就是输出所有测试样本最终的判别情况
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Use_C4_5(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "Use_C4_5", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the Use_C4_5 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Classify using Quinlan's C4.5 algorithm  
    /// Inputs:  
    /// training_patterns   - Train patterns 训练样本  每一列代表一个样本
    /// 每一行代表一个特征
    /// training_targets    - Train targets  1×训练样本个数 每个训练样本对应的判别值
    /// test_patterns       - Test  patterns 测试样本，每一列代表一个样本  
    /// inc_node            - Percentage of incorrectly assigned samples at a node 
    /// 一个节点上未正确分配的样本的百分比
    /// inc_node为防止过拟合，表示样本数小于一定阈值结束递归，可设置为5-10
    /// 注意inc_node设置太大的话会导致分类准确率下降，太小的话可能会导致过拟合  
    /// Nu is to determine whether the variable is discrete or continuous (the value is
    /// always set to 10)  
    /// Nu用于确定变量是离散还是连续（该值始终设置为10）
    /// 这里用10作为一个阈值，如果某个特征的无重复的特征值的数目比这个阈值还小，就认为这个
    /// 特征是离散的
    /// Outputs  
    /// test_targets        - Predicted targets 1×测试样本个数
    /// 得到每个测试样本对应的判别值
    /// 也就是输出所有测试样本最终的判别情况
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="train_patterns">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Use_C4_5(int numArgsOut, Object train_patterns)
    {
      return mcr.EvaluateFunction(numArgsOut, "Use_C4_5", train_patterns);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the Use_C4_5 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Classify using Quinlan's C4.5 algorithm  
    /// Inputs:  
    /// training_patterns   - Train patterns 训练样本  每一列代表一个样本
    /// 每一行代表一个特征
    /// training_targets    - Train targets  1×训练样本个数 每个训练样本对应的判别值
    /// test_patterns       - Test  patterns 测试样本，每一列代表一个样本  
    /// inc_node            - Percentage of incorrectly assigned samples at a node 
    /// 一个节点上未正确分配的样本的百分比
    /// inc_node为防止过拟合，表示样本数小于一定阈值结束递归，可设置为5-10
    /// 注意inc_node设置太大的话会导致分类准确率下降，太小的话可能会导致过拟合  
    /// Nu is to determine whether the variable is discrete or continuous (the value is
    /// always set to 10)  
    /// Nu用于确定变量是离散还是连续（该值始终设置为10）
    /// 这里用10作为一个阈值，如果某个特征的无重复的特征值的数目比这个阈值还小，就认为这个
    /// 特征是离散的
    /// Outputs  
    /// test_targets        - Predicted targets 1×测试样本个数
    /// 得到每个测试样本对应的判别值
    /// 也就是输出所有测试样本最终的判别情况
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="train_patterns">Input argument #1</param>
    /// <param name="train_targets">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Use_C4_5(int numArgsOut, Object train_patterns, Object train_targets)
    {
      return mcr.EvaluateFunction(numArgsOut, "Use_C4_5", train_patterns, train_targets);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the Use_C4_5 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Classify using Quinlan's C4.5 algorithm  
    /// Inputs:  
    /// training_patterns   - Train patterns 训练样本  每一列代表一个样本
    /// 每一行代表一个特征
    /// training_targets    - Train targets  1×训练样本个数 每个训练样本对应的判别值
    /// test_patterns       - Test  patterns 测试样本，每一列代表一个样本  
    /// inc_node            - Percentage of incorrectly assigned samples at a node 
    /// 一个节点上未正确分配的样本的百分比
    /// inc_node为防止过拟合，表示样本数小于一定阈值结束递归，可设置为5-10
    /// 注意inc_node设置太大的话会导致分类准确率下降，太小的话可能会导致过拟合  
    /// Nu is to determine whether the variable is discrete or continuous (the value is
    /// always set to 10)  
    /// Nu用于确定变量是离散还是连续（该值始终设置为10）
    /// 这里用10作为一个阈值，如果某个特征的无重复的特征值的数目比这个阈值还小，就认为这个
    /// 特征是离散的
    /// Outputs  
    /// test_targets        - Predicted targets 1×测试样本个数
    /// 得到每个测试样本对应的判别值
    /// 也就是输出所有测试样本最终的判别情况
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="train_patterns">Input argument #1</param>
    /// <param name="train_targets">Input argument #2</param>
    /// <param name="test_patterns">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Use_C4_5(int numArgsOut, Object train_patterns, Object train_targets, 
                       Object test_patterns)
    {
      return mcr.EvaluateFunction(numArgsOut, "Use_C4_5", train_patterns, train_targets, test_patterns);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the Use_C4_5 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Classify using Quinlan's C4.5 algorithm  
    /// Inputs:  
    /// training_patterns   - Train patterns 训练样本  每一列代表一个样本
    /// 每一行代表一个特征
    /// training_targets    - Train targets  1×训练样本个数 每个训练样本对应的判别值
    /// test_patterns       - Test  patterns 测试样本，每一列代表一个样本  
    /// inc_node            - Percentage of incorrectly assigned samples at a node 
    /// 一个节点上未正确分配的样本的百分比
    /// inc_node为防止过拟合，表示样本数小于一定阈值结束递归，可设置为5-10
    /// 注意inc_node设置太大的话会导致分类准确率下降，太小的话可能会导致过拟合  
    /// Nu is to determine whether the variable is discrete or continuous (the value is
    /// always set to 10)  
    /// Nu用于确定变量是离散还是连续（该值始终设置为10）
    /// 这里用10作为一个阈值，如果某个特征的无重复的特征值的数目比这个阈值还小，就认为这个
    /// 特征是离散的
    /// Outputs  
    /// test_targets        - Predicted targets 1×测试样本个数
    /// 得到每个测试样本对应的判别值
    /// 也就是输出所有测试样本最终的判别情况
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="train_patterns">Input argument #1</param>
    /// <param name="train_targets">Input argument #2</param>
    /// <param name="test_patterns">Input argument #3</param>
    /// <param name="inc_node">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Use_C4_5(int numArgsOut, Object train_patterns, Object train_targets, 
                       Object test_patterns, Object inc_node)
    {
      return mcr.EvaluateFunction(numArgsOut, "Use_C4_5", train_patterns, train_targets, test_patterns, inc_node);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the Use_C4_5 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Classify using Quinlan's C4.5 algorithm  
    /// Inputs:  
    /// training_patterns   - Train patterns 训练样本  每一列代表一个样本
    /// 每一行代表一个特征
    /// training_targets    - Train targets  1×训练样本个数 每个训练样本对应的判别值
    /// test_patterns       - Test  patterns 测试样本，每一列代表一个样本  
    /// inc_node            - Percentage of incorrectly assigned samples at a node 
    /// 一个节点上未正确分配的样本的百分比
    /// inc_node为防止过拟合，表示样本数小于一定阈值结束递归，可设置为5-10
    /// 注意inc_node设置太大的话会导致分类准确率下降，太小的话可能会导致过拟合  
    /// Nu is to determine whether the variable is discrete or continuous (the value is
    /// always set to 10)  
    /// Nu用于确定变量是离散还是连续（该值始终设置为10）
    /// 这里用10作为一个阈值，如果某个特征的无重复的特征值的数目比这个阈值还小，就认为这个
    /// 特征是离散的
    /// Outputs  
    /// test_targets        - Predicted targets 1×测试样本个数
    /// 得到每个测试样本对应的判别值
    /// 也就是输出所有测试样本最终的判别情况
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="train_patterns">Input argument #1</param>
    /// <param name="train_targets">Input argument #2</param>
    /// <param name="test_patterns">Input argument #3</param>
    /// <param name="inc_node">Input argument #4</param>
    /// <param name="Nu">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Use_C4_5(int numArgsOut, Object train_patterns, Object train_targets, 
                       Object test_patterns, Object inc_node, Object Nu)
    {
      return mcr.EvaluateFunction(numArgsOut, "Use_C4_5", train_patterns, train_targets, test_patterns, inc_node, Nu);
    }


    /// <summary>
    /// Provides an interface for the Use_C4_5 function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Classify using Quinlan's C4.5 algorithm  
    /// Inputs:  
    /// training_patterns   - Train patterns 训练样本  每一列代表一个样本
    /// 每一行代表一个特征
    /// training_targets    - Train targets  1×训练样本个数 每个训练样本对应的判别值
    /// test_patterns       - Test  patterns 测试样本，每一列代表一个样本  
    /// inc_node            - Percentage of incorrectly assigned samples at a node 
    /// 一个节点上未正确分配的样本的百分比
    /// inc_node为防止过拟合，表示样本数小于一定阈值结束递归，可设置为5-10
    /// 注意inc_node设置太大的话会导致分类准确率下降，太小的话可能会导致过拟合  
    /// Nu is to determine whether the variable is discrete or continuous (the value is
    /// always set to 10)  
    /// Nu用于确定变量是离散还是连续（该值始终设置为10）
    /// 这里用10作为一个阈值，如果某个特征的无重复的特征值的数目比这个阈值还小，就认为这个
    /// 特征是离散的
    /// Outputs  
    /// test_targets        - Predicted targets 1×测试样本个数
    /// 得到每个测试样本对应的判别值
    /// 也就是输出所有测试样本最终的判别情况
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("Use_C4_5", 5, 1, 0)]
    protected void Use_C4_5(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("Use_C4_5", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
