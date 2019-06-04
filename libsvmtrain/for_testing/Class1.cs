/*
* MATLAB Compiler: 6.4 (R2017a)
* Date: Tue Apr 30 15:04:44 2019
* Arguments:
* "-B""macro_default""-W""dotnet:libsvmtrain,Class1,4.0,private""-T""link:lib""-d""D:\С��
* ��\matlabС����\graduation
* project\libsvmtrain\for_testing""-v""class{Class1:D:\С����\matlabС����\graduation
* project\libsvmpredict.mexw64,D:\С����\matlabС����\graduation
* project\libsvmtrain.mexw64}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace libsvmtrain
{

  /// <summary>
  /// The Class1 class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// D:\С����\matlabС����\graduation project\libsvmpredict.mexw64
  /// <newpara></newpara>
  /// D:\С����\matlabС����\graduation project\libsvmtrain.mexw64
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

          string ctfFileName = "libsvmtrain.ctf";

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
    /// Provides a void output, 0-input MWArrayinterface to the libsvmpredict MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void libsvmpredict()
    {
      mcr.EvaluateFunction(0, "libsvmpredict", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the libsvmpredict MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="varargin">Array of MWArrays representing the input arguments 1
    /// through varargin.length</param>
    ///
    public void libsvmpredict(params MWArray[] varargin)
    {
      mcr.EvaluateFunction(0, "libsvmpredict", varargin);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the libsvmpredict MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] libsvmpredict(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "libsvmpredict", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the libsvmpredict MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="varargin">Array of MWArrays representing the input arguments 1
    /// through varargin.length</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] libsvmpredict(int numArgsOut, params MWArray[] varargin)
    {
      return mcr.EvaluateFunction(numArgsOut, "libsvmpredict", varargin);
    }


    /// <summary>
    /// Provides an interface for the libsvmpredict function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void libsvmpredict(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("libsvmpredict", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the libsvmtrain MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void libsvmtrain()
    {
      mcr.EvaluateFunction(0, "libsvmtrain", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the libsvmtrain MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="varargin">Array of MWArrays representing the input arguments 1
    /// through varargin.length</param>
    ///
    public void libsvmtrain(params MWArray[] varargin)
    {
      mcr.EvaluateFunction(0, "libsvmtrain", varargin);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the libsvmtrain MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] libsvmtrain(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "libsvmtrain", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the libsvmtrain MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="varargin">Array of MWArrays representing the input arguments 1
    /// through varargin.length</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] libsvmtrain(int numArgsOut, params MWArray[] varargin)
    {
      return mcr.EvaluateFunction(numArgsOut, "libsvmtrain", varargin);
    }


    /// <summary>
    /// Provides an interface for the libsvmtrain function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void libsvmtrain(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("libsvmtrain", numArgsOut, ref argsOut, argsIn);
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
